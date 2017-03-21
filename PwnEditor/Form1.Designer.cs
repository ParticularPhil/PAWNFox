namespace PwnEditor
{
    partial class Form1
    {
        #pragma warning disable 618
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.codeEditor = new ScintillaNET.Scintilla();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamemodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flagsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCompleteBracesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.compilingLabel = new System.Windows.Forms.Label();
            this.compilingThread = new System.ComponentModel.BackgroundWorker();
            this.errorLB = new System.Windows.Forms.ListBox();
            this.includeView = new System.Windows.Forms.TreeView();
            this.unfoldingButton = new System.Windows.Forms.Button();
            this.RestoreFolding = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.creditLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fillStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.foldingButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vehicleTab = new System.Windows.Forms.TabPage();
            this.vehicleGV = new System.Windows.Forms.DataGridView();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickupTab = new System.Windows.Forms.TabPage();
            this.ptypeGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickupMTab = new System.Windows.Forms.TabPage();
            this.pmodelGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.weaponTab = new System.Windows.Forms.TabPage();
            this.weaponGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyncedTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialActionTab = new System.Windows.Forms.TabPage();
            this.sactionGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerKeysTab = new System.Windows.Forms.TabPage();
            this.pkeyGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapIconTab = new System.Windows.Forms.TabPage();
            this.mapIconGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuningTab = new System.Windows.Forms.TabPage();
            this.tuningGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitsTab = new System.Windows.Forms.TabPage();
            this.limitsGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherTab = new System.Windows.Forms.TabPage();
            this.otherGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionAnalyzeTimer = new System.Windows.Forms.Timer(this.components);
            this.filterBox = new System.Windows.Forms.TextBox();
            this.resetIncludeViewButton = new System.Windows.Forms.Button();
            this.functionViewTabControl = new System.Windows.Forms.TabControl();
            this.fTabIncludeView = new System.Windows.Forms.TabPage();
            this.fTabStockView = new System.Windows.Forms.TabPage();
            this.stockView = new System.Windows.Forms.TreeView();
            this.fTabEnumView = new System.Windows.Forms.TabPage();
            this.enumView = new System.Windows.Forms.TreeView();
            this.fTabDefineView = new System.Windows.Forms.TabPage();
            this.defineView = new System.Windows.Forms.TreeView();
            this.fTabPVarView = new System.Windows.Forms.TabPage();
            this.pvarView = new System.Windows.Forms.TreeView();
            this.analyzeThread = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateThread = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ownNotes = new System.Windows.Forms.RichTextBox();
            this.includeThread = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.codeEditor)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.vehicleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGV)).BeginInit();
            this.pickupTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptypeGV)).BeginInit();
            this.pickupMTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmodelGV)).BeginInit();
            this.colorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.weaponTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaponGV)).BeginInit();
            this.specialActionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sactionGV)).BeginInit();
            this.playerKeysTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkeyGV)).BeginInit();
            this.mapIconTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapIconGV)).BeginInit();
            this.tuningTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuningGV)).BeginInit();
            this.limitsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitsGV)).BeginInit();
            this.otherTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherGV)).BeginInit();
            this.functionViewTabControl.SuspendLayout();
            this.fTabIncludeView.SuspendLayout();
            this.fTabStockView.SuspendLayout();
            this.fTabEnumView.SuspendLayout();
            this.fTabDefineView.SuspendLayout();
            this.fTabPVarView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeEditor
            // 
            this.codeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeEditor.AutoComplete.DropRestOfWord = true;
            this.codeEditor.AutoComplete.ListString = "";
            this.codeEditor.AutoComplete.MaxHeight = 10;
            this.codeEditor.AutoComplete.StopCharacters = " ";
            this.codeEditor.Folding.Flags = ((ScintillaNET.FoldFlag)((ScintillaNET.FoldFlag.Box | ScintillaNET.FoldFlag.LineAfterContracted)));
            this.codeEditor.Folding.MarkerScheme = ScintillaNET.FoldMarkerScheme.CirclePlusMinus;
            this.codeEditor.Folding.UseCompactFolding = true;
            this.codeEditor.Lexing.LineCommentPrefix = "";
            this.codeEditor.Lexing.StreamCommentPrefix = "";
            this.codeEditor.Lexing.StreamCommentSufix = "";
            this.codeEditor.Lexing.WordChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_öÖäÄüÜß";
            this.codeEditor.Location = new System.Drawing.Point(11, 5);
            this.codeEditor.Margins.Margin0.Width = 60;
            this.codeEditor.Margins.Margin2.Width = 20;
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Size = new System.Drawing.Size(958, 522);
            this.codeEditor.TabIndex = 8;
            this.codeEditor.AutoCompleteAccepted += new System.EventHandler<ScintillaNET.AutoCompleteAcceptedEventArgs>(this.codeEditor_AutoCompleteAccepted);
            this.codeEditor.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.codeEditor_CharAdded);
            this.codeEditor.SelectionChanged += new System.EventHandler(this.codeEditor_SelectionChanged);
            this.codeEditor.TextDeleted += new System.EventHandler<ScintillaNET.TextModifiedEventArgs>(this.codeEditor_TextDeleted);
            this.codeEditor.TextInserted += new System.EventHandler<ScintillaNET.TextModifiedEventArgs>(this.codeEditor_TextInserted);
            this.codeEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeEditor_KeyDown);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editingToolStripMenuItem,
            this.compileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.uPDATESToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1192, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamemodeToolStripMenuItem,
            this.filterscriptToolStripMenuItem,
            this.blankToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // gamemodeToolStripMenuItem
            // 
            this.gamemodeToolStripMenuItem.Name = "gamemodeToolStripMenuItem";
            this.gamemodeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.gamemodeToolStripMenuItem.Text = "Gamemode";
            this.gamemodeToolStripMenuItem.Click += new System.EventHandler(this.gamemodeToolStripMenuItem_Click);
            // 
            // filterscriptToolStripMenuItem
            // 
            this.filterscriptToolStripMenuItem.Name = "filterscriptToolStripMenuItem";
            this.filterscriptToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.filterscriptToolStripMenuItem.Text = "Filterscript";
            this.filterscriptToolStripMenuItem.Click += new System.EventHandler(this.filterscriptToolStripMenuItem_Click);
            // 
            // blankToolStripMenuItem
            // 
            this.blankToolStripMenuItem.Name = "blankToolStripMenuItem";
            this.blankToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.blankToolStripMenuItem.Text = "Blank";
            this.blankToolStripMenuItem.Click += new System.EventHandler(this.blankToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadToolStripMenuItem.Text = "Open";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editingToolStripMenuItem
            // 
            this.editingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findReplaceToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editingToolStripMenuItem.Name = "editingToolStripMenuItem";
            this.editingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editingToolStripMenuItem.Text = "Editing";
            // 
            // findReplaceToolStripMenuItem
            // 
            this.findReplaceToolStripMenuItem.Name = "findReplaceToolStripMenuItem";
            this.findReplaceToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.findReplaceToolStripMenuItem.Text = "Find/Replace";
            this.findReplaceToolStripMenuItem.Click += new System.EventHandler(this.findReplaceToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem1,
            this.flagsToolStripMenuItem});
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.compileToolStripMenuItem.Text = "Compile";
            // 
            // compileToolStripMenuItem1
            // 
            this.compileToolStripMenuItem1.Name = "compileToolStripMenuItem1";
            this.compileToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.compileToolStripMenuItem1.Text = "Compile";
            this.compileToolStripMenuItem1.Click += new System.EventHandler(this.compileToolStripMenuItem1_Click);
            // 
            // flagsToolStripMenuItem
            // 
            this.flagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flagsTextBox});
            this.flagsToolStripMenuItem.Name = "flagsToolStripMenuItem";
            this.flagsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.flagsToolStripMenuItem.Text = "Flags";
            // 
            // flagsTextBox
            // 
            this.flagsTextBox.Name = "flagsTextBox";
            this.flagsTextBox.Size = new System.Drawing.Size(100, 23);
            this.flagsTextBox.TextChanged += new System.EventHandler(this.flagsTextBox_TextChanged);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "License";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoCompleteBracesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // autoCompleteBracesToolStripMenuItem
            // 
            this.autoCompleteBracesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateToolStripMenuItem,
            this.deactivateToolStripMenuItem});
            this.autoCompleteBracesToolStripMenuItem.Name = "autoCompleteBracesToolStripMenuItem";
            this.autoCompleteBracesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.autoCompleteBracesToolStripMenuItem.Text = "Auto-Complete braces";
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.activateToolStripMenuItem.Text = "Activate";
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // deactivateToolStripMenuItem
            // 
            this.deactivateToolStripMenuItem.Name = "deactivateToolStripMenuItem";
            this.deactivateToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deactivateToolStripMenuItem.Text = "Deactivate";
            this.deactivateToolStripMenuItem.Click += new System.EventHandler(this.deactivateToolStripMenuItem_Click);
            // 
            // uPDATESToolStripMenuItem
            // 
            this.uPDATESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.uPDATESToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.uPDATESToolStripMenuItem.Name = "uPDATESToolStripMenuItem";
            this.uPDATESToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.uPDATESToolStripMenuItem.Text = "UPDATES";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "Pawn Source file|*.pwn|Include Files|*inc|Text file|*txt";
            this.saveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDialog_FileOk);
            // 
            // openDialog
            // 
            this.openDialog.Filter = "Pawn Source file|*.pwn|Include Files|*inc|Text file|*txt";
            this.openDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDialog_FileOk);
            // 
            // compilingLabel
            // 
            this.compilingLabel.AutoSize = true;
            this.compilingLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compilingLabel.ForeColor = System.Drawing.Color.Red;
            this.compilingLabel.Location = new System.Drawing.Point(7, 10);
            this.compilingLabel.Name = "compilingLabel";
            this.compilingLabel.Size = new System.Drawing.Size(152, 27);
            this.compilingLabel.TabIndex = 2;
            this.compilingLabel.Text = "COMPILING...";
            this.compilingLabel.Visible = false;
            // 
            // compilingThread
            // 
            this.compilingThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.compilingThread_DoWork);
            this.compilingThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.compilingThread_RunWorkerCompleted);
            // 
            // errorLB
            // 
            this.errorLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLB.FormattingEnabled = true;
            this.errorLB.HorizontalScrollbar = true;
            this.errorLB.Location = new System.Drawing.Point(3, 3);
            this.errorLB.Name = "errorLB";
            this.errorLB.Size = new System.Drawing.Size(166, 17);
            this.errorLB.TabIndex = 3;
            this.errorLB.SelectedIndexChanged += new System.EventHandler(this.errorLB_SelectedIndexChanged);
            // 
            // includeView
            // 
            this.includeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.includeView.Location = new System.Drawing.Point(6, 3);
            this.includeView.Name = "includeView";
            this.includeView.Size = new System.Drawing.Size(157, 86);
            this.includeView.TabIndex = 4;
            this.includeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.includeView_NodeMouseClick);
            this.includeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.includeView_NodeMouseDoubleClick);
            // 
            // unfoldingButton
            // 
            this.unfoldingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unfoldingButton.Location = new System.Drawing.Point(-10, 53);
            this.unfoldingButton.Name = "unfoldingButton";
            this.unfoldingButton.Size = new System.Drawing.Size(73, 23);
            this.unfoldingButton.TabIndex = 5;
            this.unfoldingButton.Text = "Unfold All";
            this.unfoldingButton.UseVisualStyleBackColor = true;
            this.unfoldingButton.Click += new System.EventHandler(this.unfoldingButton_Click);
            // 
            // RestoreFolding
            // 
            this.RestoreFolding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreFolding.Location = new System.Drawing.Point(69, 53);
            this.RestoreFolding.Name = "RestoreFolding";
            this.RestoreFolding.Size = new System.Drawing.Size(119, 23);
            this.RestoreFolding.TabIndex = 6;
            this.RestoreFolding.Text = "Restore Folding";
            this.RestoreFolding.UseVisualStyleBackColor = true;
            this.RestoreFolding.Click += new System.EventHandler(this.RestoreFolding_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.creditLabel,
            this.fillStatusLabel,
            this.textStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 560);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1192, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TextChanged += new System.EventHandler(this.statusLabel_TextChanged);
            // 
            // creditLabel
            // 
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(186, 17);
            this.creditLabel.Text = "      || Pawnfox 1.3.1 by Anthrax//IV";
            // 
            // fillStatusLabel
            // 
            this.fillStatusLabel.Name = "fillStatusLabel";
            this.fillStatusLabel.Size = new System.Drawing.Size(865, 17);
            this.fillStatusLabel.Spring = true;
            // 
            // textStatusLabel
            // 
            this.textStatusLabel.Name = "textStatusLabel";
            this.textStatusLabel.Size = new System.Drawing.Size(95, 17);
            this.textStatusLabel.Text = "Text Status Label";
            // 
            // foldingButton
            // 
            this.foldingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.foldingButton.Location = new System.Drawing.Point(-98, 53);
            this.foldingButton.Name = "foldingButton";
            this.foldingButton.Size = new System.Drawing.Size(82, 23);
            this.foldingButton.TabIndex = 8;
            this.foldingButton.Text = "Fold all";
            this.foldingButton.UseVisualStyleBackColor = true;
            this.foldingButton.Click += new System.EventHandler(this.foldingButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.vehicleTab);
            this.tabControl1.Controls.Add(this.pickupTab);
            this.tabControl1.Controls.Add(this.pickupMTab);
            this.tabControl1.Controls.Add(this.colorTab);
            this.tabControl1.Controls.Add(this.weaponTab);
            this.tabControl1.Controls.Add(this.specialActionTab);
            this.tabControl1.Controls.Add(this.playerKeysTab);
            this.tabControl1.Controls.Add(this.mapIconTab);
            this.tabControl1.Controls.Add(this.tuningTab);
            this.tabControl1.Controls.Add(this.limitsTab);
            this.tabControl1.Controls.Add(this.otherTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(184, 233);
            this.tabControl1.TabIndex = 9;
            // 
            // vehicleTab
            // 
            this.vehicleTab.Controls.Add(this.vehicleGV);
            this.vehicleTab.Location = new System.Drawing.Point(4, 112);
            this.vehicleTab.Name = "vehicleTab";
            this.vehicleTab.Padding = new System.Windows.Forms.Padding(3);
            this.vehicleTab.Size = new System.Drawing.Size(176, 117);
            this.vehicleTab.TabIndex = 0;
            this.vehicleTab.Text = "Vehicles";
            this.vehicleTab.UseVisualStyleBackColor = true;
            // 
            // vehicleGV
            // 
            this.vehicleGV.AllowUserToAddRows = false;
            this.vehicleGV.AllowUserToDeleteRows = false;
            this.vehicleGV.AllowUserToResizeRows = false;
            this.vehicleGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameC,
            this.ValueC});
            this.vehicleGV.Location = new System.Drawing.Point(6, 6);
            this.vehicleGV.Name = "vehicleGV";
            this.vehicleGV.ReadOnly = true;
            this.vehicleGV.Size = new System.Drawing.Size(162, 105);
            this.vehicleGV.TabIndex = 0;
            this.vehicleGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleGV_CellContentDoubleClick);
            this.vehicleGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vehicleGV_KeyDown);
            // 
            // NameC
            // 
            this.NameC.Frozen = true;
            this.NameC.HeaderText = "Name";
            this.NameC.Name = "NameC";
            this.NameC.ReadOnly = true;
            // 
            // ValueC
            // 
            this.ValueC.Frozen = true;
            this.ValueC.HeaderText = "Value";
            this.ValueC.Name = "ValueC";
            this.ValueC.ReadOnly = true;
            // 
            // pickupTab
            // 
            this.pickupTab.Controls.Add(this.ptypeGV);
            this.pickupTab.Location = new System.Drawing.Point(4, 112);
            this.pickupTab.Name = "pickupTab";
            this.pickupTab.Padding = new System.Windows.Forms.Padding(3);
            this.pickupTab.Size = new System.Drawing.Size(176, 117);
            this.pickupTab.TabIndex = 1;
            this.pickupTab.Text = "Pickup Types";
            this.pickupTab.UseVisualStyleBackColor = true;
            // 
            // ptypeGV
            // 
            this.ptypeGV.AllowUserToAddRows = false;
            this.ptypeGV.AllowUserToDeleteRows = false;
            this.ptypeGV.AllowUserToResizeRows = false;
            this.ptypeGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptypeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ptypeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ptypeGV.Location = new System.Drawing.Point(6, 5);
            this.ptypeGV.Name = "ptypeGV";
            this.ptypeGV.ReadOnly = true;
            this.ptypeGV.Size = new System.Drawing.Size(164, 109);
            this.ptypeGV.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pickupMTab
            // 
            this.pickupMTab.Controls.Add(this.pmodelGV);
            this.pickupMTab.Location = new System.Drawing.Point(4, 112);
            this.pickupMTab.Name = "pickupMTab";
            this.pickupMTab.Padding = new System.Windows.Forms.Padding(3);
            this.pickupMTab.Size = new System.Drawing.Size(176, 117);
            this.pickupMTab.TabIndex = 2;
            this.pickupMTab.Text = "Pickup Models";
            this.pickupMTab.UseVisualStyleBackColor = true;
            // 
            // pmodelGV
            // 
            this.pmodelGV.AllowUserToAddRows = false;
            this.pmodelGV.AllowUserToDeleteRows = false;
            this.pmodelGV.AllowUserToResizeRows = false;
            this.pmodelGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pmodelGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pmodelGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pmodelGV.Location = new System.Drawing.Point(6, 5);
            this.pmodelGV.Name = "pmodelGV";
            this.pmodelGV.ReadOnly = true;
            this.pmodelGV.Size = new System.Drawing.Size(164, 106);
            this.pmodelGV.TabIndex = 2;
            this.pmodelGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pmodelGV_KeyDown);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // colorTab
            // 
            this.colorTab.Controls.Add(this.pictureBox1);
            this.colorTab.Location = new System.Drawing.Point(4, 112);
            this.colorTab.Name = "colorTab";
            this.colorTab.Padding = new System.Windows.Forms.Padding(3);
            this.colorTab.Size = new System.Drawing.Size(176, 117);
            this.colorTab.TabIndex = 3;
            this.colorTab.Text = "Colors";
            this.colorTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PwnEditor.Properties.Resources.color;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // weaponTab
            // 
            this.weaponTab.Controls.Add(this.weaponGV);
            this.weaponTab.Location = new System.Drawing.Point(4, 112);
            this.weaponTab.Name = "weaponTab";
            this.weaponTab.Padding = new System.Windows.Forms.Padding(3);
            this.weaponTab.Size = new System.Drawing.Size(176, 117);
            this.weaponTab.TabIndex = 4;
            this.weaponTab.Text = "Weapons";
            this.weaponTab.UseVisualStyleBackColor = true;
            // 
            // weaponGV
            // 
            this.weaponGV.AllowUserToAddRows = false;
            this.weaponGV.AllowUserToDeleteRows = false;
            this.weaponGV.AllowUserToResizeRows = false;
            this.weaponGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weaponGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weaponGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.NameTab,
            this.SyncedTab,
            this.SlotTab,
            this.CategoryTab});
            this.weaponGV.Location = new System.Drawing.Point(6, 5);
            this.weaponGV.Name = "weaponGV";
            this.weaponGV.ReadOnly = true;
            this.weaponGV.Size = new System.Drawing.Size(164, 106);
            this.weaponGV.TabIndex = 3;
            this.weaponGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weaponGV_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Model ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // NameTab
            // 
            this.NameTab.HeaderText = "Name";
            this.NameTab.Name = "NameTab";
            this.NameTab.ReadOnly = true;
            // 
            // SyncedTab
            // 
            this.SyncedTab.HeaderText = "Synced";
            this.SyncedTab.Name = "SyncedTab";
            this.SyncedTab.ReadOnly = true;
            // 
            // SlotTab
            // 
            this.SlotTab.HeaderText = "Slot";
            this.SlotTab.Name = "SlotTab";
            this.SlotTab.ReadOnly = true;
            // 
            // CategoryTab
            // 
            this.CategoryTab.HeaderText = "Category";
            this.CategoryTab.Name = "CategoryTab";
            this.CategoryTab.ReadOnly = true;
            // 
            // specialActionTab
            // 
            this.specialActionTab.Controls.Add(this.sactionGV);
            this.specialActionTab.Location = new System.Drawing.Point(4, 112);
            this.specialActionTab.Name = "specialActionTab";
            this.specialActionTab.Padding = new System.Windows.Forms.Padding(3);
            this.specialActionTab.Size = new System.Drawing.Size(176, 117);
            this.specialActionTab.TabIndex = 5;
            this.specialActionTab.Text = "Special Actions";
            this.specialActionTab.UseVisualStyleBackColor = true;
            // 
            // sactionGV
            // 
            this.sactionGV.AllowUserToAddRows = false;
            this.sactionGV.AllowUserToDeleteRows = false;
            this.sactionGV.AllowUserToResizeRows = false;
            this.sactionGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sactionGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sactionGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sactionGV.Location = new System.Drawing.Point(6, 5);
            this.sactionGV.Name = "sactionGV";
            this.sactionGV.ReadOnly = true;
            this.sactionGV.Size = new System.Drawing.Size(164, 109);
            this.sactionGV.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Value";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // playerKeysTab
            // 
            this.playerKeysTab.Controls.Add(this.pkeyGV);
            this.playerKeysTab.Location = new System.Drawing.Point(4, 112);
            this.playerKeysTab.Name = "playerKeysTab";
            this.playerKeysTab.Padding = new System.Windows.Forms.Padding(3);
            this.playerKeysTab.Size = new System.Drawing.Size(176, 117);
            this.playerKeysTab.TabIndex = 6;
            this.playerKeysTab.Text = "Player Keys";
            this.playerKeysTab.UseVisualStyleBackColor = true;
            // 
            // pkeyGV
            // 
            this.pkeyGV.AllowUserToAddRows = false;
            this.pkeyGV.AllowUserToDeleteRows = false;
            this.pkeyGV.AllowUserToResizeRows = false;
            this.pkeyGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkeyGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkeyGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Column1,
            this.Column2,
            this.Column3});
            this.pkeyGV.Location = new System.Drawing.Point(6, 5);
            this.pkeyGV.Name = "pkeyGV";
            this.pkeyGV.ReadOnly = true;
            this.pkeyGV.Size = new System.Drawing.Size(164, 109);
            this.pkeyGV.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Definition";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Value";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "GT Vehicle";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Def Foot";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Def Vehicle";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // mapIconTab
            // 
            this.mapIconTab.Controls.Add(this.mapIconGV);
            this.mapIconTab.Location = new System.Drawing.Point(4, 112);
            this.mapIconTab.Name = "mapIconTab";
            this.mapIconTab.Size = new System.Drawing.Size(176, 117);
            this.mapIconTab.TabIndex = 7;
            this.mapIconTab.Text = "Map Icons";
            this.mapIconTab.UseVisualStyleBackColor = true;
            // 
            // mapIconGV
            // 
            this.mapIconGV.AllowUserToAddRows = false;
            this.mapIconGV.AllowUserToDeleteRows = false;
            this.mapIconGV.AllowUserToResizeRows = false;
            this.mapIconGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapIconGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mapIconGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.mapIconGV.Location = new System.Drawing.Point(6, 5);
            this.mapIconGV.Name = "mapIconGV";
            this.mapIconGV.ReadOnly = true;
            this.mapIconGV.Size = new System.Drawing.Size(167, 109);
            this.mapIconGV.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "Value";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // tuningTab
            // 
            this.tuningTab.Controls.Add(this.tuningGV);
            this.tuningTab.Location = new System.Drawing.Point(4, 112);
            this.tuningTab.Name = "tuningTab";
            this.tuningTab.Size = new System.Drawing.Size(176, 117);
            this.tuningTab.TabIndex = 8;
            this.tuningTab.Text = "Tuning Components";
            this.tuningTab.UseVisualStyleBackColor = true;
            // 
            // tuningGV
            // 
            this.tuningGV.AllowUserToAddRows = false;
            this.tuningGV.AllowUserToDeleteRows = false;
            this.tuningGV.AllowUserToResizeRows = false;
            this.tuningGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tuningGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tuningGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.tuningGV.Location = new System.Drawing.Point(6, 6);
            this.tuningGV.Name = "tuningGV";
            this.tuningGV.ReadOnly = true;
            this.tuningGV.Size = new System.Drawing.Size(173, 108);
            this.tuningGV.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.Frozen = true;
            this.dataGridViewTextBoxColumn13.HeaderText = "Name";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.Frozen = true;
            this.dataGridViewTextBoxColumn14.HeaderText = "Value";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // limitsTab
            // 
            this.limitsTab.Controls.Add(this.limitsGV);
            this.limitsTab.Location = new System.Drawing.Point(4, 112);
            this.limitsTab.Name = "limitsTab";
            this.limitsTab.Size = new System.Drawing.Size(176, 117);
            this.limitsTab.TabIndex = 9;
            this.limitsTab.Text = "SA:MP Limits";
            this.limitsTab.UseVisualStyleBackColor = true;
            // 
            // limitsGV
            // 
            this.limitsGV.AllowUserToAddRows = false;
            this.limitsGV.AllowUserToDeleteRows = false;
            this.limitsGV.AllowUserToResizeRows = false;
            this.limitsGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.limitsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.limitsGV.Location = new System.Drawing.Point(6, 6);
            this.limitsGV.Name = "limitsGV";
            this.limitsGV.ReadOnly = true;
            this.limitsGV.Size = new System.Drawing.Size(173, 108);
            this.limitsGV.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.Frozen = true;
            this.dataGridViewTextBoxColumn15.HeaderText = "Name";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.Frozen = true;
            this.dataGridViewTextBoxColumn16.HeaderText = "Value";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // otherTab
            // 
            this.otherTab.Controls.Add(this.otherGV);
            this.otherTab.Location = new System.Drawing.Point(4, 112);
            this.otherTab.Name = "otherTab";
            this.otherTab.Size = new System.Drawing.Size(176, 117);
            this.otherTab.TabIndex = 10;
            this.otherTab.Text = "Other";
            this.otherTab.UseVisualStyleBackColor = true;
            // 
            // otherGV
            // 
            this.otherGV.AllowUserToAddRows = false;
            this.otherGV.AllowUserToDeleteRows = false;
            this.otherGV.AllowUserToResizeRows = false;
            this.otherGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otherGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.otherGV.Location = new System.Drawing.Point(6, 3);
            this.otherGV.Name = "otherGV";
            this.otherGV.ReadOnly = true;
            this.otherGV.Size = new System.Drawing.Size(173, 129);
            this.otherGV.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.Frozen = true;
            this.dataGridViewTextBoxColumn17.HeaderText = "Name";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.Frozen = true;
            this.dataGridViewTextBoxColumn18.HeaderText = "Value";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // functionAnalyzeTimer
            // 
            this.functionAnalyzeTimer.Enabled = true;
            this.functionAnalyzeTimer.Interval = 60000;
            this.functionAnalyzeTimer.Tick += new System.EventHandler(this.functionAnalyzeTimer_Tick);
            // 
            // filterBox
            // 
            this.filterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBox.Location = new System.Drawing.Point(7, 25);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(151, 20);
            this.filterBox.TabIndex = 10;
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // resetIncludeViewButton
            // 
            this.resetIncludeViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetIncludeViewButton.Location = new System.Drawing.Point(164, 23);
            this.resetIncludeViewButton.Name = "resetIncludeViewButton";
            this.resetIncludeViewButton.Size = new System.Drawing.Size(24, 23);
            this.resetIncludeViewButton.TabIndex = 11;
            this.resetIncludeViewButton.Text = "X";
            this.resetIncludeViewButton.UseVisualStyleBackColor = true;
            this.resetIncludeViewButton.Click += new System.EventHandler(this.resetIncludeViewButton_Click);
            // 
            // functionViewTabControl
            // 
            this.functionViewTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionViewTabControl.Controls.Add(this.fTabIncludeView);
            this.functionViewTabControl.Controls.Add(this.fTabStockView);
            this.functionViewTabControl.Controls.Add(this.fTabEnumView);
            this.functionViewTabControl.Controls.Add(this.fTabDefineView);
            this.functionViewTabControl.Controls.Add(this.fTabPVarView);
            this.functionViewTabControl.Location = new System.Drawing.Point(8, 51);
            this.functionViewTabControl.Multiline = true;
            this.functionViewTabControl.Name = "functionViewTabControl";
            this.functionViewTabControl.SelectedIndex = 0;
            this.functionViewTabControl.Size = new System.Drawing.Size(177, 139);
            this.functionViewTabControl.TabIndex = 12;
            // 
            // fTabIncludeView
            // 
            this.fTabIncludeView.Controls.Add(this.includeView);
            this.fTabIncludeView.Location = new System.Drawing.Point(4, 40);
            this.fTabIncludeView.Name = "fTabIncludeView";
            this.fTabIncludeView.Padding = new System.Windows.Forms.Padding(3);
            this.fTabIncludeView.Size = new System.Drawing.Size(169, 95);
            this.fTabIncludeView.TabIndex = 0;
            this.fTabIncludeView.Text = "Native/Include";
            this.fTabIncludeView.UseVisualStyleBackColor = true;
            // 
            // fTabStockView
            // 
            this.fTabStockView.Controls.Add(this.stockView);
            this.fTabStockView.Location = new System.Drawing.Point(4, 40);
            this.fTabStockView.Name = "fTabStockView";
            this.fTabStockView.Padding = new System.Windows.Forms.Padding(3);
            this.fTabStockView.Size = new System.Drawing.Size(169, 95);
            this.fTabStockView.TabIndex = 1;
            this.fTabStockView.Text = "Own functions";
            this.fTabStockView.UseVisualStyleBackColor = true;
            // 
            // stockView
            // 
            this.stockView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockView.Location = new System.Drawing.Point(6, 6);
            this.stockView.Name = "stockView";
            this.stockView.Size = new System.Drawing.Size(157, 83);
            this.stockView.TabIndex = 13;
            this.stockView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stockView_NodeMouseClick);
            this.stockView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.stockView_NodeMouseDoubleClick);
            // 
            // fTabEnumView
            // 
            this.fTabEnumView.Controls.Add(this.enumView);
            this.fTabEnumView.Location = new System.Drawing.Point(4, 40);
            this.fTabEnumView.Name = "fTabEnumView";
            this.fTabEnumView.Padding = new System.Windows.Forms.Padding(3);
            this.fTabEnumView.Size = new System.Drawing.Size(169, 95);
            this.fTabEnumView.TabIndex = 2;
            this.fTabEnumView.Text = "Enums";
            this.fTabEnumView.UseVisualStyleBackColor = true;
            // 
            // enumView
            // 
            this.enumView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumView.Location = new System.Drawing.Point(6, 6);
            this.enumView.Name = "enumView";
            this.enumView.Size = new System.Drawing.Size(160, 83);
            this.enumView.TabIndex = 13;
            // 
            // fTabDefineView
            // 
            this.fTabDefineView.Controls.Add(this.defineView);
            this.fTabDefineView.Location = new System.Drawing.Point(4, 40);
            this.fTabDefineView.Name = "fTabDefineView";
            this.fTabDefineView.Padding = new System.Windows.Forms.Padding(3);
            this.fTabDefineView.Size = new System.Drawing.Size(169, 95);
            this.fTabDefineView.TabIndex = 3;
            this.fTabDefineView.Text = "Defines";
            this.fTabDefineView.UseVisualStyleBackColor = true;
            // 
            // defineView
            // 
            this.defineView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defineView.Location = new System.Drawing.Point(6, 6);
            this.defineView.Name = "defineView";
            this.defineView.Size = new System.Drawing.Size(157, 83);
            this.defineView.TabIndex = 13;
            this.defineView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.defineView_NodeMouseDoubleClick);
            // 
            // fTabPVarView
            // 
            this.fTabPVarView.Controls.Add(this.pvarView);
            this.fTabPVarView.Location = new System.Drawing.Point(4, 40);
            this.fTabPVarView.Name = "fTabPVarView";
            this.fTabPVarView.Size = new System.Drawing.Size(169, 95);
            this.fTabPVarView.TabIndex = 4;
            this.fTabPVarView.Text = "PVars";
            this.fTabPVarView.UseVisualStyleBackColor = true;
            // 
            // pvarView
            // 
            this.pvarView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvarView.Location = new System.Drawing.Point(3, 4);
            this.pvarView.Name = "pvarView";
            this.pvarView.Size = new System.Drawing.Size(160, 86);
            this.pvarView.TabIndex = 5;
            // 
            // analyzeThread
            // 
            this.analyzeThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.analyzeThread_DoWork);
            this.analyzeThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.analyzeThread_RunWorkerCompleted);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::PwnEditor.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(854, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // updateThread
            // 
            this.updateThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateThread_DoWork);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.compilingLabel);
            this.splitContainer1.Panel1.Controls.Add(this.codeEditor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1180, 532);
            this.splitContainer1.SplitterDistance = 975;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Location = new System.Drawing.Point(6, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.resetIncludeViewButton);
            this.splitContainer2.Panel1.Controls.Add(this.filterBox);
            this.splitContainer2.Panel1.Controls.Add(this.functionViewTabControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(193, 522);
            this.splitContainer2.SplitterDistance = 192;
            this.splitContainer2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hide own functions (split with ;):";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer3.Panel2.Controls.Add(this.unfoldingButton);
            this.splitContainer3.Panel2.Controls.Add(this.foldingButton);
            this.splitContainer3.Panel2.Controls.Add(this.RestoreFolding);
            this.splitContainer3.Size = new System.Drawing.Size(193, 326);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(180, 45);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorLB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(172, 19);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compiler output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ownNotes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(172, 19);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Own notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ownNotes
            // 
            this.ownNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownNotes.Location = new System.Drawing.Point(3, 1);
            this.ownNotes.Name = "ownNotes";
            this.ownNotes.Size = new System.Drawing.Size(165, 15);
            this.ownNotes.TabIndex = 9;
            this.ownNotes.Text = "";
            // 
            // includeThread
            // 
            this.includeThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.includeThread_DoWork);
            this.includeThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.includeThread_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 582);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Pawnfox - New file";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeEditor)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.vehicleTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGV)).EndInit();
            this.pickupTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptypeGV)).EndInit();
            this.pickupMTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pmodelGV)).EndInit();
            this.colorTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.weaponTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weaponGV)).EndInit();
            this.specialActionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sactionGV)).EndInit();
            this.playerKeysTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pkeyGV)).EndInit();
            this.mapIconTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapIconGV)).EndInit();
            this.tuningTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tuningGV)).EndInit();
            this.limitsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.limitsGV)).EndInit();
            this.otherTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otherGV)).EndInit();
            this.functionViewTabControl.ResumeLayout(false);
            this.fTabIncludeView.ResumeLayout(false);
            this.fTabStockView.ResumeLayout(false);
            this.fTabEnumView.ResumeLayout(false);
            this.fTabDefineView.ResumeLayout(false);
            this.fTabPVarView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla codeEditor;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem1;
        private System.Windows.Forms.Label compilingLabel;
        private System.ComponentModel.BackgroundWorker compilingThread;
        private System.Windows.Forms.ListBox errorLB;
        private System.Windows.Forms.TreeView includeView;
        private System.Windows.Forms.Button unfoldingButton;
        private System.Windows.Forms.Button RestoreFolding;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button foldingButton;
        private System.Windows.Forms.ToolStripStatusLabel creditLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage vehicleTab;
        private System.Windows.Forms.TabPage pickupTab;
        private System.Windows.Forms.DataGridView vehicleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueC;
        private System.Windows.Forms.DataGridView ptypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage pickupMTab;
        private System.Windows.Forms.DataGridView pmodelGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage colorTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage weaponTab;
        private System.Windows.Forms.DataGridView weaponGV;
        private System.Windows.Forms.TabPage specialActionTab;
        private System.Windows.Forms.DataGridView sactionGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabPage playerKeysTab;
        private System.Windows.Forms.DataGridView pkeyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer functionAnalyzeTimer;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Button resetIncludeViewButton;
        private System.Windows.Forms.TabControl functionViewTabControl;
        private System.Windows.Forms.TabPage fTabIncludeView;
        private System.Windows.Forms.TabPage fTabStockView;
        private System.Windows.Forms.TreeView stockView;
        private System.Windows.Forms.TabPage fTabEnumView;
        private System.Windows.Forms.TreeView enumView;
        private System.Windows.Forms.TabPage fTabDefineView;
        private System.Windows.Forms.TreeView defineView;
        private System.Windows.Forms.TabPage mapIconTab;
        private System.Windows.Forms.DataGridView mapIconGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyncedTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryTab;
        private System.Windows.Forms.TabPage tuningTab;
        private System.Windows.Forms.TabPage limitsTab;
        private System.Windows.Forms.TabPage otherTab;
        private System.Windows.Forms.DataGridView tuningGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridView limitsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridView otherGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker analyzeThread;
        private System.Windows.Forms.ToolStripMenuItem editingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox flagsTextBox;
        private System.Windows.Forms.TabPage fTabPVarView;
        private System.Windows.Forms.TreeView pvarView;
        private System.Windows.Forms.ToolStripMenuItem uPDATESToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker updateThread;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStripMenuItem gamemodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterscriptToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox ownNotes;
        private System.Windows.Forms.ToolStripStatusLabel fillStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel textStatusLabel;
        private System.ComponentModel.BackgroundWorker includeThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem blankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoCompleteBracesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateToolStripMenuItem;
    }
}

