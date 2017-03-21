using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PwnEditor
{
    public partial class Form1 : Form
    {
        //Pathes:
        string currentFilePath = "";    //Path of the currently loaded file (with filename and extension)
        string currentFileName = "";    //Name of the currrently loaded file (without extension)
        string appPath = "";            //Path of the application
        string pwnPath = "";            //Path to the PawnStuff directory
        //Global vars:
        bool fileSaved = false;         //File has been saved at least once
        bool noChanges = true;          //No changes made since last saving/loading
        string versionString = "1.3.1";
        List<int> linesNotExpanded=null;//Holds the lines whih had been folded when Unfold All was used the last time
        //Strings:
        string compilingText = "";      //Text to be handed over to the compiler
        string errorText = "";          //Text the compiler returned as errors
        string[] parameters = null;     //Parameters that the application was started with
        //Autocomplete:
        List<lexer.functionData> userFunctionList = null;
        List<lexer.functionData> includeFunctionList = null;
        enum ac_states
        {
            none,pvar
        };
        int ac_line = 0;
        ac_states ac_state = 0;
        //Temporary variables:
        TreeNode tempDefineContent = null;      
        TreeNode tempEnumContent = null;
        TreeNode tempPVarContent = null;
        TreeNode tempIncludeFunctionContent = null;
        TreeNode tempUserFunctionContent = null;
        List<lexer.functionData> tempUserFunctionList = null;
        List<lexer.functionData> tempIncludeFunctionList = null;
        //Settings:
        bool autoCompleteBraces = true;

        public Form1(string[] args)
        {
            InitializeComponent();
            parameters = args;
        }

        //
        //  --- INIT:
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the application pathes:
            appPath = Application.StartupPath;
            pwnPath = appPath + "\\PawnStuff";

            //Set the Scintilla Language to pawn:
            codeEditor.Lexing.LexerLanguageMap["pawn"] = "cpp";
            codeEditor.ConfigurationManager.CustomLocation = Application.StartupPath;
            codeEditor.ConfigurationManager.Language = "pawn";

            //Load compiler flags for menu:
            if (File.Exists(pwnPath + "\\settings.ini"))
            {
                StreamReader file = new StreamReader(pwnPath + "\\settings.ini");
                string content = file.ReadToEnd();  //Important, crashes if not done!
                file.Close();
                flagsTextBox.Text = content;
            }

            //Autocomplete:
            userFunctionList=new List<lexer.functionData>();
            includeFunctionList=new List<lexer.functionData>();
            //Settings:
            codeEditor.AutoComplete.SingleLineAccept = false;

            //Text status label:
            textStatusLabel.Text = "";

            //Read include files:
            //Collect all include files:
            IEnumerable<string> includeFiles = Directory.EnumerateFiles(pwnPath + "\\include");
            IEnumerable<string> directories = Directory.EnumerateDirectories(pwnPath + "\\include");
            foreach (string i in directories)
            {
                IEnumerable<string> files = Directory.EnumerateFiles(pwnPath + "\\include\\" + i);
                includeFiles.Union(files);
            }
            //Add include files to the tree view
            includeView.Nodes.Add("Loading...");
            includeThread.RunWorkerAsync(includeFiles);

            //Updates:
            uPDATESToolStripMenuItem.Visible = false;
            updateThread.RunWorkerAsync();

            //Maximize:
            this.WindowState = FormWindowState.Maximized;

            //Read Scripting Helper files:
            //Vehicles:
            fillHelperData(vehicleGV,"\\resc\\vehicles.data");
            //Pickup types:
            fillHelperData(ptypeGV, "\\resc\\ptypes.data");
            //Pickup models:
            fillHelperData(pmodelGV, "\\resc\\pmodels.data");
            //WeaponIDs models:
            fillHelperData(weaponGV, "\\resc\\weapons.data", 6);
            //Special Actions:
            fillHelperData(sactionGV, "\\resc\\spactions.data");
            //Map Iconss:
            fillHelperData(mapIconGV, "\\resc\\mapicons.data");
            //Player keys:
            fillHelperData(pkeyGV, "\\resc\\pkeys.data", 5);
            //Tuning components:
            fillHelperData(tuningGV, "\\resc\\tuning.data");
            //Limits:
            fillHelperData(limitsGV, "\\resc\\limits.data",2,false);
            //Other:
            fillHelperData(otherGV, "\\resc\\other.data");

            //Open script when needed:
            if (parameters.Length > 0)
            {
                //Open the file:
                openFile(parameters[0]);
            }
            else
            {
                //Open last opened file:
                if(File.Exists(appPath+"\\PawnStuff\\last_opened.data"))
                {
                    StreamReader recentlyFile=new StreamReader(appPath+"\\PawnStuff\\last_opened.data");
                    string path=recentlyFile.ReadToEnd();
                    recentlyFile.Close();
                    openFile(path);
                }
            }
        }

        void fillHelperData(DataGridView dgv, string path, int dataCount=2,bool invert=true)
        {
            //Open file, split each line at "%" and fill the results into the list.
            StreamReader file = new StreamReader(appPath + path);
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                string[] tokens = line.Split('%');
                int row = dgv.Rows.Add();
                if (dataCount != 2)
                {
                    for (int i = 0; i != dataCount; i++)
                    {
                        dgv.Rows[row].Cells[i].Value = tokens[i];
                    }
                }
                else
                {
                    dgv.Rows[row].Cells[0].Value = tokens[invert ? 1 : 0];
                    dgv.Rows[row].Cells[1].Value = tokens[invert ? 0 : 1];
                }
            }
            file.Close();
        }

        void ParseIncludeFiles(IEnumerable<string> includeFiles)
        {
            tempIncludeFunctionContent = new TreeNode();
            tempIncludeFunctionList = new List<lexer.functionData>();
            foreach (string includeFile in includeFiles)
            {
                //Open the include file:
                StreamReader file = new StreamReader(includeFile);
                string text = file.ReadToEnd();
                file.Close();
                //Get path length:
                int pathLength = (pwnPath + "\\include").Length + 1;  //Length is required to omit path from string
                //Create the node:
                TreeNode node = tempIncludeFunctionContent.Nodes.Add(includeFile.Remove(0, pathLength));
                //Analyse the code:
                lexer lex = new lexer();
                List<lexer.functionData> functionList = new List<lexer.functionData>();
                lex.includeAnalysis(text, ref functionList);
                foreach (lexer.functionData function in functionList)
                {
                    node.Nodes.Add(function.fullIdentiferDataTypes).Nodes.Add("Add to code (double click)");
                }
                //Add function list to previous list:
                tempIncludeFunctionList.AddRange(functionList);
            }
        }

        private void includeThread_DoWork(object sender, DoWorkEventArgs e)
        {
            ParseIncludeFiles((IEnumerable<string>)e.Argument);
        }

        private void includeThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            includeView.Nodes.Clear();
            foreach (TreeNode node in tempIncludeFunctionContent.Nodes)
                includeView.Nodes.Add(node);
            includeFunctionList = tempIncludeFunctionList;
        }

        //
        //  --- LOADING:
        //
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!noChanges && codeEditor.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are you sure you don't want to save your changes first?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                    saveDialog.ShowDialog();
            }
            openDialog.ShowDialog();
        }

        void openFile(string path)
        {
            //Open the file:
            StreamReader file = new StreamReader(path, Encoding.Default);
            string text = file.ReadToEnd();
            codeEditor.Text = text;
            file.Close();

            fileSaved = true;

            //Set the current file path:
            currentFilePath = path;
            //Set the current file name:
            string[] tokens = currentFilePath.Split('\\');
            currentFileName = tokens[tokens.Length - 1];
            //Remove extension:
            tokens = currentFileName.Split('.');
            currentFileName = tokens[0];
            //Just loaded the new file - co changes possible:
            noChanges = true;

            //Lexer:
            List<lexer.defineData> userDefineList = null;
            List<lexer.functionData> userFunctionList = null;
            lexer lex = new lexer();
            lex.codeAnalysis(text, ref userDefineList, ref userFunctionList, false);

            //Autocomplete list:
            ScanDocumentThreaded(true);

            //Recently opened:
            StreamWriter recentlyFile = new StreamWriter(appPath + "\\PawnStuff\\last_opened.data", false);
            recentlyFile.Write(path);
            recentlyFile.Close();

            //Update caption:
            this.Text = "Pawnfox - " + currentFileName;
        }

        private void openDialog_FileOk(object sender, CancelEventArgs e)
        {
            openFile(openDialog.FileName);
        }

        //
        //  --- SAVING:
        //
        private void saveCurrentFile()
        {
            //If file has never been saved before, open save as dialog:
            if (fileSaved)
            {
                //Save under the current file name:
                StreamWriter file = new StreamWriter(currentFilePath, false, Encoding.Default);
                file.Write(codeEditor.Text);
                file.Close();
                //We saved the file - no changes made since then:
                noChanges = true;
                //Update status label:
                statusLabel.Text = "File sucessfully saved.";
            }
            else
            {
                saveDialog.ShowDialog();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveCurrentFile();
        }

        private void saveDialog_FileOk(object sender, CancelEventArgs e)
        {
            //Open a stream and write the content of the codeEditor to the file:
            StreamWriter file = new StreamWriter(saveDialog.FileName,false,Encoding.Default);
            file.Write(codeEditor.Text);
            file.Close();
            //Update vars:
            //Set the current file path:
            currentFilePath = saveDialog.FileName;
            //Set the current file name:
            string[] tokens = currentFilePath.Split('\\');
            currentFileName = tokens[tokens.Length - 1];
            //Remove extension:
            tokens = currentFileName.Split('.');
            currentFileName = tokens[0];
            //Update caption and status label:
            this.Text = "Pawnfox - " + currentFileName;
            statusLabel.Text = "File sucessfully saved.";
            //We saved the file - no changes made since then:
            noChanges = true;
            fileSaved = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the saving dialog:
            saveDialog.ShowDialog();
        }

        //
        //  --- COMPILING:
        //
        private void compileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fileSaved)
            {
                //Start compiling. Hide code editor and start compiling thread.
                statusLabel.Text = "";
                codeEditor.Visible = false;
                compilingLabel.Visible = true;
                compilingText = codeEditor.Text;
                compilingThread.RunWorkerAsync();
                codeEditor.NativeInterface.MarkerDeleteAll(0);
                //Clear compiler output:
                errorLB.Items.Clear();
            }
            else
            {
                //File has to be saved first:
                saveDialog.ShowDialog();
            }
        }

        private void codeEditor_KeyDown(object sender, KeyEventArgs e)
        {
            //Compile on F5
            if (e.KeyCode == Keys.F5)
            {
                if (fileSaved)
                {
                    //Start compiling. Hide code editor and start compiling thread.
                    statusLabel.Text = "";
                    codeEditor.Visible = false;
                    compilingLabel.Visible = true;
                    compilingText = codeEditor.Text;
                    compilingThread.RunWorkerAsync();
                    codeEditor.NativeInterface.MarkerDeleteAll(0);
                    //Clear compiler output:
                    errorLB.Items.Clear();
                }
                else
                {
                    //File has to be saved first:
                    saveDialog.ShowDialog();
                }
            }
            //Open find dialog on F9:
            else if (e.KeyCode == Keys.F9)
            {
                unfoldAll();
                codeEditor.FindReplace.ShowFind();
            }
            //Open Replace dialog on F10:
            else if (e.KeyCode == Keys.F10)
            {
                unfoldAll();
                codeEditor.FindReplace.ShowReplace();
            }
            //Save after CTRL+S:
            else if (e.KeyCode == Keys.S && e.Control)
            {
                saveCurrentFile();
            }
            //Open after CTRL+O:
            else if (e.KeyCode == Keys.O && e.Control)
            {
                if (!noChanges && codeEditor.Text.Length > 0)
                {
                    DialogResult answer = MessageBox.Show("Are you sure you don't want to save your changes first?", "Unsaved changes", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.No)
                        saveDialog.ShowDialog();
                }
                openDialog.ShowDialog();
            }
        }

        private void compilingThread_DoWork(object sender, DoWorkEventArgs e)
        {
            //Destination path:
            string destPath = "" ;
            string[] tokens=currentFilePath.Split('.');
            if (tokens.Length > 2)
            {
                for (int i = 0; i != tokens.Length - 2; i++)
                    destPath += tokens[i];
            }
            else destPath = tokens[0];
            //Save file to be compiled:
            string tbcPath = pwnPath + "\\"+currentFileName+".p";
            StreamWriter file = new StreamWriter(tbcPath,false,Encoding.Default);
            file.Write(compilingText);
            file.Close();
            //Read flags:
            string flags = "";
            if (File.Exists(pwnPath + "\\settings.ini"))
            {
                StreamReader settingsFile = new StreamReader(pwnPath + "\\settings.ini");
                flags = settingsFile.ReadToEnd();
                flags = flags.Replace("\n", "");
                settingsFile.Close();
            }
            //Launch compiler:
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WorkingDirectory=pwnPath;
            p.StartInfo.FileName = "pawncc.exe";
            p.StartInfo.Arguments = currentFileName + " -e\"errors\" -o\"" + destPath + "\" -; -( "+flags;
            p.Start();
            //Wait for compiling to finish
            while (!p.HasExited)
            {
                //Wait
            }
            //Check for errors
            string errorPath=pwnPath+"\\errors";
            if (File.Exists(errorPath))
            {
                StreamReader errorFile = new StreamReader(errorPath);
                errorText = errorFile.ReadToEnd();
                errorFile.Close();
                File.Delete(errorPath);
            }
            else
                errorText = "None";
            //Delete compilation file
            File.Delete(tbcPath);
        }

        private void compilingThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Compiling finished. Show editor again.
            compilingLabel.Visible = false;
            codeEditor.Visible = true;
            //Show error list (if errors occured):
            errorLB.Items.Clear();
            if (errorText != "None")
            {
                string[] lines = errorText.Split('\n');
                foreach (string line in lines)
                    errorLB.Items.Add(line);
            }
            else
                errorLB.Items.Add("Compiling completed without errors! YES!");
            //Save:
            StreamWriter file = new StreamWriter(currentFilePath,false,Encoding.Default);
            file.Write(codeEditor.Text);
            file.Close();
            //Because we saved the file, the user can exit without being promted on whether he wants to save it
            noChanges = true;
        }

        private void flagsTextBox_TextChanged(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(pwnPath + "\\settings.ini", false);
            file.Write(flagsTextBox.Text);
            file.Close();
        }

        //
        //  --- ERROR HANDLING:
        //
        private void errorLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (errorText != "None" && errorLB.SelectedItem.ToString().Length > 0)
            {
                //Get line from string:
                string error = errorLB.SelectedItem.ToString();
                string[] tokens = error.Split('(', ')');
                int line = 0;
                int.TryParse(tokens[1], out line);
                if(line>0)
                    line--;
                codeEditor.Lines[line].Select();
                codeEditor.NativeInterface.MarkerAdd(codeEditor.Lines[line].Number, 0);
                error=error.Replace('\r', ' '); //Prevent status label from becoming double-lined
                statusLabel.Text = error;
            }
        }

        //
        //  ---  INCLUDE HANDLING:
        //
        private void resetIncludeViewButton_Click(object sender, EventArgs e)
        {
            if (functionViewTabControl.SelectedTab == fTabIncludeView)  //Include view selected
                includeView.CollapseAll();
            filterBox.Text = "";
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            string[] filters = null;
            if (filterBox.Text.Contains(';'))
            {
                filters = filterBox.Text.Split(';');
            }
            else
            {
                filters = new string[1];
                filters[0] = filterBox.Text;
            }

            stockView.Nodes.Clear();
            foreach(lexer.functionData function in userFunctionList)
            {
                if (filters.Length == 1 && filters[0] == "")
                {
                    TreeNode tempNode = stockView.Nodes.Add(function.fullIdentifer);
                    TreeNode callNode = tempNode.Nodes.Add("Calls");
                    //Call stuff:
                    foreach (int call in function.occurences)
                    {
                        callNode.Nodes.Add((call + 1).ToString());
                    }
                }
                else
                {
                    bool notFiltered = true;
                    foreach (string s in filters)
                    {
                        if (function.identifer.Contains(s))
                        {
                            notFiltered = false;
                            break;
                        }
                    }
                    if (notFiltered)
                    {
                        TreeNode tempNode = stockView.Nodes.Add(function.fullIdentifer);
                        TreeNode callNode = tempNode.Nodes.Add("Calls");
                        //Call stuff:
                        foreach (int call in function.occurences)
                        {
                            callNode.Nodes.Add((call + 1).ToString());
                        }
                    }
                }
            }
        }

        private void includeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Update the status label:
            statusLabel.Text = e.Node.Text;
        }

        private void includeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Add to code (double click)")
            {
                lexer.functionData foundFunction=includeFunctionList.Find(item => e.Node.Parent.Text == item.fullIdentiferDataTypes);
                if (foundFunction != null)
                {
                    codeEditor.InsertText(foundFunction.identifer + "(");
                    statusLabel.Text = foundFunction.fullIdentiferDataTypes;
                }
            }
        }

        private void stockView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Update the status label:
                statusLabel.Text = e.Node.Text;
            }
            else
            {
                //On right click, select the appropriate line in the script:
                if (userFunctionList.Exists(item => item.fullIdentifer.Equals(e.Node.Text)))
                {
                    lexer.functionData foundFunction = userFunctionList.Find(item => item.fullIdentifer.Equals(e.Node.Text));
                    codeEditor.Lines[foundFunction.implementation].Select();
                    stockView.SelectedNode = e.Node;
                }
            }
        }

        private void stockView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int lineNumber = 0;
                if (int.TryParse(e.Node.Text, out lineNumber))
                {
                    codeEditor.Lines[lineNumber-1].Select();
                }
                else if (e.Node.Text == "Add to code (double click)")
                {
                    lexer.functionData foundFunction = userFunctionList.Find(item => e.Node.Parent.Text == item.fullIdentiferDataTypes);
                    if (foundFunction != null)
                    {
                        codeEditor.InsertText(userFunctionList.Find(item => e.Node.Parent.Text == item.fullIdentiferDataTypes).identifer + "(");
                        statusLabel.Text = foundFunction.fullIdentiferDataTypes;
                    }
                } 
            }
        }

        private void defineView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //When clicking a define, go to the line in the script:
            foreach (ScintillaNET.Line line in codeEditor.Lines)
            {
                if (line.Text.Contains(e.Node.Text))
                {
                    line.Select();
                    break;
                }
            }
        }

        //Kill possible newline chars:
        private void statusLabel_TextChanged(object sender, EventArgs e)
        {
            if (statusLabel.Text.Contains("\r\n"))
            {
                statusLabel.Text = statusLabel.Text.Replace("\r\n", "");
            }
        }

        //
        //  ---  FOLDING:
        //
        void foldAll()
        {
            //Toggle all unfolded lines:
            //int currentPos = codeEditor.CurrentPos;
            codeEditor.CurrentPos = codeEditor.TextLength;
            foreach (ScintillaNET.Line line in codeEditor.Lines)
            {
                if (line.IsFoldPoint && line.FoldExpanded)
                    codeEditor.NativeInterface.ToggleFold(line.Number);
                    //line.ToggleFoldExpanded();
            }
        }
        void unfoldAll()
        {
            linesNotExpanded=new List<int>();
            //Toggle all folded lines and add them to the list:
            foreach (ScintillaNET.Line line in codeEditor.Lines)
            {
                if (!line.FoldExpanded)
                {
                    line.ToggleFoldExpanded();
                    linesNotExpanded.Add(line.Number);
                }
            }
        }
        void restoreFolding() //Restore the previous folding after using unfold all
        {
            if (linesNotExpanded != null)
            {
                //Unfold all previously folded lines:
                foreach (int lineNumber in linesNotExpanded)
                {
                    codeEditor.Lines[lineNumber].ToggleFoldExpanded();
                }
                //Get rid of the array:
                linesNotExpanded = null;
            }
            else
                MessageBox.Show("You did not previously unfold all lines.", "Error");
        }
        private void foldingButton_Click(object sender, EventArgs e)
        {
            foldAll();
        }
        private void unfoldingButton_Click(object sender, EventArgs e)
        {
            unfoldAll();
        }
        private void RestoreFolding_Click(object sender, EventArgs e)
        {
            restoreFolding();
        }

        //
        //  ---  NEW FILES:
        //
        private void newToolStripMenuItem_Click(object sender, EventArgs e){}

        private void gamemodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!noChanges && codeEditor.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are you sure you don't want to save your changes first?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                    saveDialog.ShowDialog();
            }

            //Open and display the new.pwn file:
            StreamReader file = new StreamReader(pwnPath + "\\new_gm.pwn");
            string text = file.ReadToEnd();
            codeEditor.Text = text;
            linesNotExpanded = null;
            //Current file path:
            currentFilePath = "";
            currentFileName = "";
            //No changes:
            noChanges = false;
            fileSaved = false;
            //Caption:
            this.Text = "Pawnfox - New file";
        }

        private void filterscriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!noChanges && codeEditor.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are you sure you don't want to save your changes first?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                    saveDialog.ShowDialog();
            }

            //Open and display the new.pwn file:
            StreamReader file = new StreamReader(pwnPath + "\\new_fs.pwn");
            string text = file.ReadToEnd();
            codeEditor.Text = text;
            linesNotExpanded = null;
            //Current file path:
            currentFilePath = "";
            currentFileName = "";
            //No changes:
            noChanges = false;
            fileSaved = false;
            //Caption:
            this.Text = "Pawnfox - New file";
        }

        private void blankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!noChanges && codeEditor.Text.Length > 0)
            {
                DialogResult answer = MessageBox.Show("Are you sure you don't want to save your changes first?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                    saveDialog.ShowDialog();
            }

            //Open and display the new.pwn file:
            StreamReader file = new StreamReader(pwnPath + "\\new_blank.pwn");
            string text = file.ReadToEnd();
            codeEditor.Text = text;
            linesNotExpanded = null;
            //Current file path:
            currentFilePath = "";
            currentFileName = "";
            //No changes:
            noChanges = false;
            fileSaved = false;
            //Caption:
            this.Text = "Pawnfox - New file";
        }

        //
        //  ---  EDITING:
        //
        //Capture changes of the text:
        private void codeEditor_TextDeleted(object sender, ScintillaNET.TextModifiedEventArgs e)
        {
            if (statusLabel.Text == "File sucessfully saved.")
                statusLabel.Text = "";
            noChanges = false;
        }
        private void codeEditor_TextInserted(object sender, ScintillaNET.TextModifiedEventArgs e)
        {
            if (statusLabel.Text == "File sucessfully saved.")
                statusLabel.Text = "";
            noChanges = false;
        }
        //Capture closure of the form:
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!noChanges&&codeEditor.Text.Length>0)
            {
                DialogResult answer = MessageBox.Show("Are you sure you don't want to save your changes first?", "Unsaved changes", MessageBoxButtons.YesNo);
                if(answer==DialogResult.No)
                    saveDialog.ShowDialog();
            }
        }


        //
        //  --- ScriptHelper:
        //
        //Automatic sorting after key strokes:
        private void vehicleGV_KeyDown(object sender, KeyEventArgs e)
        {
            bool s = false;
            KeysConverter conv = new KeysConverter();
            string keyChar = conv.ConvertToString(e.KeyCode);
            foreach (DataGridViewRow row in vehicleGV.Rows)
            {
                row.Selected = false;
                if (row.Cells[0].Value.ToString().StartsWith(keyChar)&&!s)
                {
                    row.Selected = true;
                    vehicleGV.FirstDisplayedScrollingRowIndex = row.Index;
                    s = true;
                }
            }
        }
        private void pmodelGV_KeyDown(object sender, KeyEventArgs e)
        {
            bool s = false;
            KeysConverter conv = new KeysConverter();
            string keyChar = conv.ConvertToString(e.KeyCode);
            foreach (DataGridViewRow row in pmodelGV.Rows)
            {
                row.Selected = false;
                if (row.Cells[0].Value.ToString().StartsWith(keyChar) && !s)
                {
                    row.Selected = true;
                    pmodelGV.FirstDisplayedScrollingRowIndex = row.Index;
                    s = true;
                }
            }
        }

        //Go to wiki:
        private void vehicleGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start("http://wiki.sa-mp.com/wiki/Vehicles:All");
        }
        private void weaponGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Process.Start("http://wiki.sa-mp.com/wiki/Weapons");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wiki.sa-mp.com/wiki/Colors_List");
        }
        //Go to sareallife.org:
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sareallife.org");
        }

        //
        //  --- Exiting:
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //  --- Autocomplete:
        //
        private void codeEditor_CharAdded(object sender, ScintillaNET.CharAddedEventArgs e)
        {
            if (e.Ch == '{'&&autoCompleteBraces)
            {
                string text = codeEditor.Lines.Current.Text;
                int count=0;
                foreach (char c in text.ToCharArray())
                {
                    if(c=='\t')
                        count++;
                    else break;
                }
                codeEditor.InsertText("\n");
                for (int i = 0; i != count+1; i++)
                    codeEditor.InsertText("\t");
                int pos = codeEditor.CurrentPos;
                codeEditor.InsertText("\n");
                for (int i = 0; i != count; i++)
                    codeEditor.InsertText("\t");
                codeEditor.InsertText("}");
                codeEditor.CurrentPos = pos;
                
            }

            if(e.Ch==' ')
                return;
            //Get word written until now:
            string word=codeEditor.GetWordFromPosition(codeEditor.NativeInterface.GetCurrentPos());

            if(word=="")
                return;

            //Compile a list with possible functions:
            List<string> possibleWords=null;
            possibleWords = new List<string>();
            if (word == "for")  //Enable for loop
                possibleWords.Add("for");
            foreach (lexer.functionData i in (userFunctionList.FindAll(item => item.identifer.StartsWith(word, StringComparison.OrdinalIgnoreCase))))
                possibleWords.Add(i.identifer);
            foreach (lexer.functionData i in (includeFunctionList.FindAll(item => item.identifer.StartsWith(word, StringComparison.OrdinalIgnoreCase))))
                possibleWords.Add(i.identifer);
            //Add defines to the list:
            foreach (TreeNode node in defineView.Nodes)
                foreach (TreeNode i in node.Nodes)
                    if (i.Text.StartsWith(word, StringComparison.OrdinalIgnoreCase))
                        possibleWords.Add((i.Text.Split(' '))[0]);

            //Add PVars to the list:
            string pword = word.ToLower();
            if (pword.Contains("getpvar") || pword.Contains("setpvar") || ac_state == ac_states.pvar)
            {
                if (ac_state == ac_states.none)
                {
                    ac_state = ac_states.pvar;
                    ac_line = codeEditor.Lines.Current.Number;
                }
                foreach (TreeNode node in pvarView.Nodes)
                    if (node.Text.StartsWith(pword, StringComparison.OrdinalIgnoreCase))
                        possibleWords.Add(node.Text);
            }
            if(ac_state==ac_states.pvar)
            {
                if(ac_line!=codeEditor.Lines.Current.Number)
                    ac_state=ac_states.none;
            }
            
            if (possibleWords.Count > 0)
            {
                //Show the options:
                codeEditor.AutoComplete.List.Clear();
                codeEditor.AutoComplete.List = possibleWords;
                codeEditor.AutoComplete.Show();
            }
        }

        private void codeEditor_AutoCompleteAccepted(object sender, ScintillaNET.AutoCompleteAcceptedEventArgs e)
        {
            //Find and display the parameters in the status bar:
            //If the word is not part of the native function list, search the user function list:+
            if (includeFunctionList.Exists(item => item.identifer.Equals(e.Text)))
            {
                lexer.functionData foundFunction = includeFunctionList.Find(item => item.identifer.Equals(e.Text));
                statusLabel.Text = foundFunction.fullIdentifer;
            }
            else if (userFunctionList.Exists(item => item.Equals(e.Text)))
            {
                lexer.functionData foundFunction = userFunctionList.Find(item => item.identifer.Equals(e.Text));
                statusLabel.Text = foundFunction.fullIdentifer;
            }
        }

        private void ScanDocumentThreaded(bool forceNew=false)
        {
            if (codeEditor.Lines.Count > 0
                &&((pvarView.Nodes.Count==0&&defineView.Nodes.Count==0&&enumView.Nodes.Count==0&&stockView.Nodes.Count==0)||forceNew))
            {
                stockView.Nodes.Clear();
                stockView.Nodes.Add("Loading...");
                enumView.Nodes.Clear();
                enumView.Nodes.Add("Loading...");
                defineView.Nodes.Clear();
                defineView.Nodes.Add("Loading...");
                pvarView.Nodes.Clear();
                pvarView.Nodes.Add("Loading...");
                analyzeThread.RunWorkerAsync(codeEditor.Text);
                statusLabel.Text = "Analyzing code...";
            }
        }



        private void analyzeThread_DoWork(object sender, DoWorkEventArgs e)
        {
            //Variables:
            string[] lines = (e.Argument.ToString()).Split('\n');
            //Define variables:
            tempDefineContent = new TreeNode();
            TreeNode maxNode = tempDefineContent.Nodes.Add("MAX");
            TreeNode dialogNode = tempDefineContent.Nodes.Add("DIALOG");
            TreeNode colorNode = tempDefineContent.Nodes.Add("COLORS");
            TreeNode otherNode = tempDefineContent.Nodes.Add("Other");
            //User function variables:
            tempUserFunctionContent = new TreeNode();
            //Enum variables:
            TreeNode tempNode = null;
            tempEnumContent = new TreeNode();
            int stage = 0;
            //PVar variables:
            tempPVarContent = new TreeNode();

            //Analyse:
            tempUserFunctionList = null;
            List<lexer.defineData> defineList = null;
            lexer lex = new lexer();
            lex.codeAnalysis(e.Argument.ToString(), ref defineList, ref tempUserFunctionList, false);
            foreach (lexer.defineData define in defineList)
            {
                if (define.identifer.ToLower().Contains("max"))
                    maxNode.Nodes.Add(define.identifer + " " + define.value);
                else if (define.identifer.ToLower().Contains("dialog"))
                    dialogNode.Nodes.Add(define.identifer + " " + define.value);
                else if (define.identifer.ToLower().Contains("color"))
                    colorNode.Nodes.Add(define.identifer + " " + define.value);
                else
                    otherNode.Nodes.Add(define.identifer + " " + define.value);
            }
            foreach (lexer.functionData function in tempUserFunctionList)
            {
                tempNode = tempUserFunctionContent.Nodes.Add(function.fullIdentiferDataTypes);
                TreeNode callNode=tempNode.Nodes.Add("Calls");
                tempNode.Nodes.Add("Add to code (double click)");
                //Call stuff:
                foreach (int call in function.occurences)
                {
                    callNode.Nodes.Add((call+1).ToString());
                }
            }

            foreach (string line in lines)
            {
                //PVars:
                if (line.ToLower().Contains("setpvar") || line.ToLower().Contains("getpvar"))
                {
                    string[] tokens = line.Split('\"');
                    if (tokens.Length >= 3)
                    {
                        string varName = "\""+tokens[1]+"\"";
                        varName = varName.Replace("\"", "");
                        if (!varName.Contains('%'))
                        {
                            bool exists = false;
                            foreach (TreeNode node in tempPVarContent.Nodes)
                            {
                                if (node.Text == varName)
                                {
                                    exists = true;
                                    break;
                                }
                            }
                            if (!exists)
                                tempPVarContent.Nodes.Add(varName);
                        }
                    }
                }
                if(line.Contains("enum")||stage!=0)
                {
                    if (line.Contains("enum"))
                    {
                        tempNode=new TreeNode(line);
                        stage = 1;
                    }
                    else
                    {
                        if (line.Contains('{') && !line.Contains('}'))
                        {
                            //Skip line (continue would be dangerous)
                        }
                        else if (line.Contains('}') && !line.Contains('{'))
                        {
                            tempEnumContent.Nodes.Add(tempNode);
                            stage = 0;
                        }
                        else
                        {
                            tempNode.Nodes.Add(line);
                        }
                    }
                }
            }
        }
        private void analyzeThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Define view:
            defineView.Nodes.Clear();
            foreach (TreeNode node in tempDefineContent.Nodes)
                defineView.Nodes.Add(node);
            defineView.Sort();
            //Stock view:
            stockView.Nodes.Clear();
            foreach (TreeNode node in tempUserFunctionContent.Nodes)
                stockView.Nodes.Add(node);
            stockView.Sort();
            //Enum view:
            enumView.Nodes.Clear();
            foreach (TreeNode node in tempEnumContent.Nodes)
                enumView.Nodes.Add(node);
            //PVar view:
            pvarView.Nodes.Clear();
            foreach (TreeNode node in tempPVarContent.Nodes)
                pvarView.Nodes.Add(node);
            pvarView.Sort();
            //Lists:
            userFunctionList = tempUserFunctionList;
            //Status label:
            statusLabel.Text="Finished.";
        }
      
        //Rescan for functions every minute
        private void functionAnalyzeTimer_Tick(object sender, EventArgs e)
        {
            ScanDocumentThreaded();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pawnfox 1.3.1\n\n\nDeveloped by Anthrax\\IV.\nSpecial thanks to Bloody for ideas and testing.\n\nVisit sareallife.org for more information.\nContact: pawnfox@sareallife.org.", "Credits");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pawnfox uses a creative commons license.\n\nClick help to view the license.", 
                "License",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,0,"http://creativecommons.org/licenses/by-nc-nd/3.0","keyword");
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pawnfox 1.3.1 - Changelog:\n\n\n1.0:\n- Initial release\n1.1:\n- Changed default compiler flags\n- Handling of large files improved\n- User can now edit compiling flags"
                +"\n- Autocorrect is not case sensitive anymore\n- Several small improvements"
                +"\n 1.2:\n- Added defines to Autocorrect lists\n- PVars added to Autocorrect and function view\n- Bugfixes\n- Addes search function for *all* function view tabs\n- Resizing possible"
                +"\n 1.3:\n- Fully rewrote lexical analysis - faster, less likely to crash and now also finding simple plain functions Search bar now hides certain functions´Pawnfox can now"
                +" reopen the last opened file.\n- Many small improvments\n- Better auto completion (supports braces)"
                +"\n 1.3.1:\n- Several important bugfixes concerning the saving of files\n- Updated logo and application information\n- Update to auto-update function","Changelog");
        }

        //
        //  --- Editing:
        //
        private void findReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeEditor.FindReplace.ShowFind();
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeEditor.UndoRedo.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeEditor.UndoRedo.Redo();
        }
        private void codeEditor_SelectionChanged(object sender, EventArgs e)
        {
            textStatusLabel.Text = "Line: " + (codeEditor.Lines.Current.Number+1).ToString() + " / Character: " + (codeEditor.CurrentPos - codeEditor.Lines.Current.StartPosition).ToString()
                + " / Overall Position: " + codeEditor.CurrentPos+" / Currently selected: "+codeEditor.Selection.Length+" characters";
        }

        //
        //  --- Updates:
        //
        private void updateThread_DoWork(object sender, DoWorkEventArgs e)
        {
            string s = new System.Net.WebClient().DownloadString("http://sareallife.org/pawnfox/ca");
            if (s.Length > 0)
            {
                if (versionString != s)
                {
                    uPDATESToolStripMenuItem.Text = "New update available! (Update: "+s+", Current: "+versionString+")";
                    uPDATESToolStripMenuItem.Visible = true;
                }
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sareallife.org/pawnfox/index.html");
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoCompleteBraces = true;
        }

        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoCompleteBraces = false;
        }

        

        
    }
}
