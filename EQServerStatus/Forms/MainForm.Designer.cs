namespace EQServerStatus
{
    partial class MainForm
    {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bertoxxulous", 5, 5);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bristlebane", 5, 5);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cazic Thule", 5, 5);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Drinal", 5, 5);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Erollisi Marr", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Luclin", 5, 5);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Povar", 5, 5);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("The Rathe", 5, 5);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Trakanon", 5, 5);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tunare", 5, 5);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Xegony", 5, 5);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Regular Servers", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Agnarr (PoP-LP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Antonius Bayle (EU)", 5, 5);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Brekt (Free Trade)", 5, 5);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Coirnav (TLP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Fippy Darkpaw (TLP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Firiona Vie (RP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Lockjaw (TLP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Phinigel (TLP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Ragefire (TLP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Vox (New Player)", 5, 5);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Zek (PvP)", 5, 5);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Special Servers", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Beta", 5, 5);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Test", 5, 5);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Testing Servers", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ServerTreeView = new System.Windows.Forms.TreeView();
            this.ServerStatusImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRefreshTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQResourcecomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.logTab = new System.Windows.Forms.TabPage();
            this.ErrorLogGroupBox = new System.Windows.Forms.GroupBox();
            this.ErrorLogListBox = new System.Windows.Forms.ListBox();
            this.GeneralLogGroupBox = new System.Windows.Forms.GroupBox();
            this.GeneralLogListBox = new System.Windows.Forms.ListBox();
            this.triggersTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.triggersListView = new System.Windows.Forms.ListView();
            this.columnServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatusFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatusTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlertOnce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.triggerRemoveSelectedTriggerButton = new System.Windows.Forms.Button();
            this.triggerCreationCreateButton = new System.Windows.Forms.Button();
            this.triggerCreationAlertOnceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.triggerCreationStatusToComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.triggerCreationStatusFromComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.triggerCreationServerSelectComboBox = new System.Windows.Forms.ComboBox();
            this.serverDataTab = new System.Windows.Forms.TabPage();
            this.serverHistoryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serverLastUpdatedLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.programNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nextUpdateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.logTab.SuspendLayout();
            this.ErrorLogGroupBox.SuspendLayout();
            this.GeneralLogGroupBox.SuspendLayout();
            this.triggersTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.serverDataTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerTreeView
            // 
            this.ServerTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServerTreeView.ImageIndex = 0;
            this.ServerTreeView.ImageList = this.ServerStatusImageList;
            this.ServerTreeView.Location = new System.Drawing.Point(10, 25);
            this.ServerTreeView.Name = "ServerTreeView";
            treeNode1.ImageIndex = 5;
            treeNode1.Name = "BertoxxulousNode";
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Tag = "Bertoxxulous";
            treeNode1.Text = "Bertoxxulous";
            treeNode1.ToolTipText = "Bertoxxulous";
            treeNode2.ImageIndex = 5;
            treeNode2.Name = "BristlebaneNode";
            treeNode2.SelectedImageIndex = 5;
            treeNode2.Tag = "Bristlebane";
            treeNode2.Text = "Bristlebane";
            treeNode2.ToolTipText = "Bristlebane";
            treeNode3.ImageIndex = 5;
            treeNode3.Name = "CazicThuleNode";
            treeNode3.SelectedImageIndex = 5;
            treeNode3.Tag = "Cazic Thule";
            treeNode3.Text = "Cazic Thule";
            treeNode3.ToolTipText = "Cazic Thule";
            treeNode4.ImageIndex = 5;
            treeNode4.Name = "DrinalNode";
            treeNode4.SelectedImageIndex = 5;
            treeNode4.Tag = "Drinal";
            treeNode4.Text = "Drinal";
            treeNode4.ToolTipText = "Drinal";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "ErollisiMarrNode";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Tag = "Erollisi Marr";
            treeNode5.Text = "Erollisi Marr";
            treeNode5.ToolTipText = "Erollisi Marr";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "LuclinNode";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Tag = "Luclin";
            treeNode6.Text = "Luclin";
            treeNode6.ToolTipText = "Luclin";
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "PovarNode";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Tag = "Povar";
            treeNode7.Text = "Povar";
            treeNode7.ToolTipText = "Povar";
            treeNode8.ImageIndex = 5;
            treeNode8.Name = "TheRatheNode";
            treeNode8.SelectedImageIndex = 5;
            treeNode8.Tag = "The Rathe";
            treeNode8.Text = "The Rathe";
            treeNode8.ToolTipText = "The Rathe";
            treeNode9.ImageIndex = 5;
            treeNode9.Name = "TrakanonNode";
            treeNode9.SelectedImageIndex = 5;
            treeNode9.Tag = "Trakanon";
            treeNode9.Text = "Trakanon";
            treeNode9.ToolTipText = "Trakanon";
            treeNode10.ImageIndex = 5;
            treeNode10.Name = "TunareNode";
            treeNode10.SelectedImageIndex = 5;
            treeNode10.Tag = "Tunare";
            treeNode10.Text = "Tunare";
            treeNode10.ToolTipText = "Tunare";
            treeNode11.ImageIndex = 5;
            treeNode11.Name = "XegonyNode";
            treeNode11.SelectedImageIndex = 5;
            treeNode11.Tag = "Xegony";
            treeNode11.Text = "Xegony";
            treeNode11.ToolTipText = "Xegony";
            treeNode12.Checked = true;
            treeNode12.Name = "RegularServersNode";
            treeNode12.Text = "Regular Servers";
            treeNode12.ToolTipText = "Regular (Live) Servers";
            treeNode13.ImageIndex = 5;
            treeNode13.Name = "AgnarrNode";
            treeNode13.SelectedImageIndex = 5;
            treeNode13.Tag = "Agnarr";
            treeNode13.Text = "Agnarr (PoP-LP)";
            treeNode13.ToolTipText = "Agnarr (Planes of Power Locked Progression)";
            treeNode14.ImageIndex = 5;
            treeNode14.Name = "AntoniusBayleNode";
            treeNode14.SelectedImageIndex = 5;
            treeNode14.Tag = "Antonius Bayle (EU)";
            treeNode14.Text = "Antonius Bayle (EU)";
            treeNode14.ToolTipText = "Antonius Bayle (EU)";
            treeNode15.ImageIndex = 5;
            treeNode15.Name = "BrektNode";
            treeNode15.SelectedImageIndex = 5;
            treeNode15.Tag = "Brekt";
            treeNode15.Text = "Brekt (Free Trade)";
            treeNode15.ToolTipText = "Brekt (Free Trade)";
            treeNode16.ImageIndex = 5;
            treeNode16.Name = "CoirnavNode";
            treeNode16.SelectedImageIndex = 5;
            treeNode16.Tag = "Coirnav";
            treeNode16.Text = "Coirnav (TLP)";
            treeNode16.ToolTipText = "Coirnav (TLP)";
            treeNode17.ImageIndex = 5;
            treeNode17.Name = "FippyDarkpawNode";
            treeNode17.SelectedImageIndex = 5;
            treeNode17.Tag = "Fippy Darkpaw (TLP)";
            treeNode17.Text = "Fippy Darkpaw (TLP)";
            treeNode17.ToolTipText = "Fippy Darkpaw (TLP)";
            treeNode18.ImageIndex = 5;
            treeNode18.Name = "FirionaVieNode";
            treeNode18.SelectedImageIndex = 5;
            treeNode18.Tag = "Firiona Vie (RP)";
            treeNode18.Text = "Firiona Vie (RP)";
            treeNode18.ToolTipText = "Firiona Vie (RP)";
            treeNode19.ImageIndex = 5;
            treeNode19.Name = "LockjawNode";
            treeNode19.SelectedImageIndex = 5;
            treeNode19.Tag = "Lockjaw";
            treeNode19.Text = "Lockjaw (TLP)";
            treeNode19.ToolTipText = "Lockjaw (TLP)";
            treeNode20.ImageIndex = 5;
            treeNode20.Name = "PhinigelNode";
            treeNode20.SelectedImageIndex = 5;
            treeNode20.Tag = "Phinigel";
            treeNode20.Text = "Phinigel (TLP)";
            treeNode20.ToolTipText = "Phinigel (TLP)";
            treeNode21.ImageIndex = 5;
            treeNode21.Name = "RagefireNode";
            treeNode21.SelectedImageIndex = 5;
            treeNode21.Tag = "Ragefire";
            treeNode21.Text = "Ragefire (TLP)";
            treeNode21.ToolTipText = "Ragefire (TLP)";
            treeNode22.ImageIndex = 5;
            treeNode22.Name = "VoxNode";
            treeNode22.SelectedImageIndex = 5;
            treeNode22.Tag = "Vox";
            treeNode22.Text = "Vox (New Player)";
            treeNode22.ToolTipText = "Vox (New Player)";
            treeNode23.ImageIndex = 5;
            treeNode23.Name = "ZekNode";
            treeNode23.SelectedImageIndex = 5;
            treeNode23.Tag = "Zek";
            treeNode23.Text = "Zek (PvP)";
            treeNode23.ToolTipText = "Zek (PvP)";
            treeNode24.Name = "SpecialServersNode";
            treeNode24.Text = "Special Servers";
            treeNode24.ToolTipText = "TLP\'s, Special Ruleset Servers";
            treeNode25.ImageIndex = 5;
            treeNode25.Name = "BetaNode";
            treeNode25.SelectedImageIndex = 5;
            treeNode25.Tag = "Beta";
            treeNode25.Text = "Beta";
            treeNode25.ToolTipText = "Beta";
            treeNode26.ImageIndex = 5;
            treeNode26.Name = "TestNode";
            treeNode26.SelectedImageIndex = 5;
            treeNode26.Tag = "Test";
            treeNode26.Text = "Test";
            treeNode26.ToolTipText = "Test";
            treeNode27.Name = "TestingServersNode";
            treeNode27.Text = "Testing Servers";
            treeNode27.ToolTipText = "Testing Servers";
            this.ServerTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode24,
            treeNode27});
            this.ServerTreeView.SelectedImageIndex = 0;
            this.ServerTreeView.ShowNodeToolTips = true;
            this.ServerTreeView.Size = new System.Drawing.Size(195, 544);
            this.ServerTreeView.TabIndex = 0;
            this.ServerTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.serverTreeViewNodeClick);
            // 
            // ServerStatusImageList
            // 
            this.ServerStatusImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ServerStatusImageList.ImageStream")));
            this.ServerStatusImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ServerStatusImageList.Images.SetKeyName(0, "ServerIcon");
            this.ServerStatusImageList.Images.SetKeyName(1, "green.png");
            this.ServerStatusImageList.Images.SetKeyName(2, "yellow.png");
            this.ServerStatusImageList.Images.SetKeyName(3, "orange.png");
            this.ServerStatusImageList.Images.SetKeyName(4, "Locked");
            this.ServerStatusImageList.Images.SetKeyName(5, "question mark.png");
            this.ServerStatusImageList.Images.SetKeyName(6, "down.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshDataToolStripMenuItem,
            this.setRefreshTimerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolsToolStripMenuItem.Text = "&Options";
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.refreshDataToolStripMenuItem.Text = "&Refresh Data";
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.RefreshDataToolStripMenuItem_Click);
            // 
            // setRefreshTimerToolStripMenuItem
            // 
            this.setRefreshTimerToolStripMenuItem.Name = "setRefreshTimerToolStripMenuItem";
            this.setRefreshTimerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.setRefreshTimerToolStripMenuItem.Text = "&Settings";
            this.setRefreshTimerToolStripMenuItem.Click += new System.EventHandler(this.setRefreshTimerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.eQResourcecomToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.userGuideToolStripMenuItem.Text = "&About";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // eQResourcecomToolStripMenuItem
            // 
            this.eQResourcecomToolStripMenuItem.Name = "eQResourcecomToolStripMenuItem";
            this.eQResourcecomToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eQResourcecomToolStripMenuItem.Text = "&EQResource.com";
            this.eQResourcecomToolStripMenuItem.Click += new System.EventHandler(this.eQResourcecomToolStripMenuItem_Click);
            // 
            // serverRefreshTimer
            // 
            this.serverRefreshTimer.Interval = 10000;
            this.serverRefreshTimer.Tick += new System.EventHandler(this.ServerRefreshTimer_Tick);
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.ErrorLogGroupBox);
            this.logTab.Controls.Add(this.GeneralLogGroupBox);
            this.logTab.Location = new System.Drawing.Point(4, 22);
            this.logTab.Margin = new System.Windows.Forms.Padding(2);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(2);
            this.logTab.Size = new System.Drawing.Size(608, 518);
            this.logTab.TabIndex = 1;
            this.logTab.Text = "Logs";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // ErrorLogGroupBox
            // 
            this.ErrorLogGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLogGroupBox.Controls.Add(this.ErrorLogListBox);
            this.ErrorLogGroupBox.Location = new System.Drawing.Point(9, 257);
            this.ErrorLogGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ErrorLogGroupBox.Name = "ErrorLogGroupBox";
            this.ErrorLogGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ErrorLogGroupBox.Size = new System.Drawing.Size(592, 259);
            this.ErrorLogGroupBox.TabIndex = 3;
            this.ErrorLogGroupBox.TabStop = false;
            this.ErrorLogGroupBox.Text = "Error Logs";
            // 
            // ErrorLogListBox
            // 
            this.ErrorLogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLogListBox.FormattingEnabled = true;
            this.ErrorLogListBox.Location = new System.Drawing.Point(4, 26);
            this.ErrorLogListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ErrorLogListBox.Name = "ErrorLogListBox";
            this.ErrorLogListBox.Size = new System.Drawing.Size(584, 225);
            this.ErrorLogListBox.TabIndex = 1;
            // 
            // GeneralLogGroupBox
            // 
            this.GeneralLogGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralLogGroupBox.Controls.Add(this.GeneralLogListBox);
            this.GeneralLogGroupBox.Location = new System.Drawing.Point(4, 5);
            this.GeneralLogGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GeneralLogGroupBox.Name = "GeneralLogGroupBox";
            this.GeneralLogGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GeneralLogGroupBox.Size = new System.Drawing.Size(602, 247);
            this.GeneralLogGroupBox.TabIndex = 2;
            this.GeneralLogGroupBox.TabStop = false;
            this.GeneralLogGroupBox.Text = "General Logs";
            // 
            // GeneralLogListBox
            // 
            this.GeneralLogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralLogListBox.FormattingEnabled = true;
            this.GeneralLogListBox.Location = new System.Drawing.Point(4, 25);
            this.GeneralLogListBox.Margin = new System.Windows.Forms.Padding(2);
            this.GeneralLogListBox.Name = "GeneralLogListBox";
            this.GeneralLogListBox.Size = new System.Drawing.Size(594, 212);
            this.GeneralLogListBox.TabIndex = 0;
            // 
            // triggersTab
            // 
            this.triggersTab.Controls.Add(this.groupBox2);
            this.triggersTab.Controls.Add(this.groupBox1);
            this.triggersTab.Location = new System.Drawing.Point(4, 22);
            this.triggersTab.Name = "triggersTab";
            this.triggersTab.Padding = new System.Windows.Forms.Padding(3);
            this.triggersTab.Size = new System.Drawing.Size(608, 518);
            this.triggersTab.TabIndex = 2;
            this.triggersTab.Text = "Triggers";
            this.triggersTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.triggersListView);
            this.groupBox2.Location = new System.Drawing.Point(6, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(598, 310);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Triggers";
            // 
            // triggersListView
            // 
            this.triggersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnServer,
            this.columnStatusFrom,
            this.columnStatusTo,
            this.columnAlertOnce});
            this.triggersListView.FullRowSelect = true;
            this.triggersListView.Location = new System.Drawing.Point(5, 18);
            this.triggersListView.MultiSelect = false;
            this.triggersListView.Name = "triggersListView";
            this.triggersListView.Size = new System.Drawing.Size(589, 288);
            this.triggersListView.TabIndex = 0;
            this.triggersListView.UseCompatibleStateImageBehavior = false;
            this.triggersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnServer
            // 
            this.columnServer.Text = "Server";
            this.columnServer.Width = 225;
            // 
            // columnStatusFrom
            // 
            this.columnStatusFrom.Text = "Status From";
            this.columnStatusFrom.Width = 150;
            // 
            // columnStatusTo
            // 
            this.columnStatusTo.Text = "Status To";
            this.columnStatusTo.Width = 150;
            // 
            // columnAlertOnce
            // 
            this.columnAlertOnce.Text = "Repeating";
            this.columnAlertOnce.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triggerRemoveSelectedTriggerButton);
            this.groupBox1.Controls.Add(this.triggerCreationCreateButton);
            this.groupBox1.Controls.Add(this.triggerCreationAlertOnceComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.triggerCreationStatusToComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.triggerCreationStatusFromComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.triggerCreationServerSelectComboBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(598, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Trigger";
            // 
            // triggerRemoveSelectedTriggerButton
            // 
            this.triggerRemoveSelectedTriggerButton.Location = new System.Drawing.Point(333, 114);
            this.triggerRemoveSelectedTriggerButton.Margin = new System.Windows.Forms.Padding(2);
            this.triggerRemoveSelectedTriggerButton.Name = "triggerRemoveSelectedTriggerButton";
            this.triggerRemoveSelectedTriggerButton.Size = new System.Drawing.Size(213, 48);
            this.triggerRemoveSelectedTriggerButton.TabIndex = 12;
            this.triggerRemoveSelectedTriggerButton.Text = "Remove Selected Trigger";
            this.triggerRemoveSelectedTriggerButton.UseVisualStyleBackColor = true;
            this.triggerRemoveSelectedTriggerButton.Click += new System.EventHandler(this.triggerRemoveSelectedTriggerButton_Click);
            // 
            // triggerCreationCreateButton
            // 
            this.triggerCreationCreateButton.Location = new System.Drawing.Point(333, 26);
            this.triggerCreationCreateButton.Margin = new System.Windows.Forms.Padding(2);
            this.triggerCreationCreateButton.Name = "triggerCreationCreateButton";
            this.triggerCreationCreateButton.Size = new System.Drawing.Size(213, 45);
            this.triggerCreationCreateButton.TabIndex = 11;
            this.triggerCreationCreateButton.Text = "Create Trigger";
            this.triggerCreationCreateButton.UseVisualStyleBackColor = true;
            this.triggerCreationCreateButton.Click += new System.EventHandler(this.triggerCreationCreateButton_Click);
            // 
            // triggerCreationAlertOnceComboBox
            // 
            this.triggerCreationAlertOnceComboBox.FormattingEnabled = true;
            this.triggerCreationAlertOnceComboBox.Items.AddRange(new object[] {
            "One Time",
            "Always"});
            this.triggerCreationAlertOnceComboBox.Location = new System.Drawing.Point(104, 136);
            this.triggerCreationAlertOnceComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.triggerCreationAlertOnceComboBox.Name = "triggerCreationAlertOnceComboBox";
            this.triggerCreationAlertOnceComboBox.Size = new System.Drawing.Size(156, 21);
            this.triggerCreationAlertOnceComboBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alert Me When:";
            // 
            // triggerCreationStatusToComboBox
            // 
            this.triggerCreationStatusToComboBox.FormattingEnabled = true;
            this.triggerCreationStatusToComboBox.Items.AddRange(new object[] {
            "low",
            "medium",
            "high",
            "locked",
            "down"});
            this.triggerCreationStatusToComboBox.Location = new System.Drawing.Point(104, 99);
            this.triggerCreationStatusToComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.triggerCreationStatusToComboBox.Name = "triggerCreationStatusToComboBox";
            this.triggerCreationStatusToComboBox.Size = new System.Drawing.Size(156, 21);
            this.triggerCreationStatusToComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status To:";
            // 
            // triggerCreationStatusFromComboBox
            // 
            this.triggerCreationStatusFromComboBox.FormattingEnabled = true;
            this.triggerCreationStatusFromComboBox.Items.AddRange(new object[] {
            "low",
            "medium",
            "high",
            "locked",
            "down"});
            this.triggerCreationStatusFromComboBox.Location = new System.Drawing.Point(104, 63);
            this.triggerCreationStatusFromComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.triggerCreationStatusFromComboBox.Name = "triggerCreationStatusFromComboBox";
            this.triggerCreationStatusFromComboBox.Size = new System.Drawing.Size(156, 21);
            this.triggerCreationStatusFromComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status From:";
            // 
            // triggerCreationServerSelectComboBox
            // 
            this.triggerCreationServerSelectComboBox.FormattingEnabled = true;
            this.triggerCreationServerSelectComboBox.Items.AddRange(new object[] {
            "Agnarr",
            "Antonius Bayle",
            "Beta",
            "Bertoxxulous",
            "Brekt",
            "Bristlebane",
            "Cazic Thule",
            "Corinav",
            "Erollisi Marr",
            "Fippy Darkpaw",
            "Firiona Vie",
            "Lockjaw",
            "Luclin",
            "Phinigel",
            "Povar",
            "Ragefire",
            "Test",
            "The Rathe",
            "Trakanaon",
            "Tunare",
            "Vox",
            "Xegony",
            "Zek"});
            this.triggerCreationServerSelectComboBox.Location = new System.Drawing.Point(104, 26);
            this.triggerCreationServerSelectComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.triggerCreationServerSelectComboBox.Name = "triggerCreationServerSelectComboBox";
            this.triggerCreationServerSelectComboBox.Size = new System.Drawing.Size(156, 21);
            this.triggerCreationServerSelectComboBox.TabIndex = 1;
            // 
            // serverDataTab
            // 
            this.serverDataTab.Controls.Add(this.serverHistoryListView);
            this.serverDataTab.Controls.Add(this.serverLastUpdatedLabel);
            this.serverDataTab.Controls.Add(this.serverNameLabel);
            this.serverDataTab.Location = new System.Drawing.Point(4, 22);
            this.serverDataTab.Margin = new System.Windows.Forms.Padding(2);
            this.serverDataTab.Name = "serverDataTab";
            this.serverDataTab.Padding = new System.Windows.Forms.Padding(2);
            this.serverDataTab.Size = new System.Drawing.Size(608, 518);
            this.serverDataTab.TabIndex = 0;
            this.serverDataTab.Text = "Server Data";
            this.serverDataTab.UseVisualStyleBackColor = true;
            // 
            // serverHistoryListView
            // 
            this.serverHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.serverHistoryListView.Location = new System.Drawing.Point(19, 116);
            this.serverHistoryListView.Margin = new System.Windows.Forms.Padding(2);
            this.serverHistoryListView.Name = "serverHistoryListView";
            this.serverHistoryListView.Size = new System.Drawing.Size(574, 379);
            this.serverHistoryListView.TabIndex = 3;
            this.serverHistoryListView.UseCompatibleStateImageBehavior = false;
            this.serverHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Server Status";
            this.columnHeader2.Width = 400;
            // 
            // serverLastUpdatedLabel
            // 
            this.serverLastUpdatedLabel.AutoSize = true;
            this.serverLastUpdatedLabel.Location = new System.Drawing.Point(16, 68);
            this.serverLastUpdatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverLastUpdatedLabel.Name = "serverLastUpdatedLabel";
            this.serverLastUpdatedLabel.Size = new System.Drawing.Size(126, 13);
            this.serverLastUpdatedLabel.TabIndex = 2;
            this.serverLastUpdatedLabel.Text = "Select a server for details";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameLabel.Location = new System.Drawing.Point(4, 12);
            this.serverNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(601, 27);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "Select a server for details";
            this.serverNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.serverDataTab);
            this.tabControl1.Controls.Add(this.triggersTab);
            this.tabControl1.Controls.Add(this.logTab);
            this.tabControl1.Location = new System.Drawing.Point(208, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 544);
            this.tabControl1.TabIndex = 3;
            // 
            // programNotifyIcon
            // 
            this.programNotifyIcon.ContextMenuStrip = this.notifyIconContextMenuStrip;
            this.programNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("programNotifyIcon.Icon")));
            this.programNotifyIcon.Text = "EQServerStatus: Active";
            this.programNotifyIcon.DoubleClick += new System.EventHandler(this.showProgramFromTray);
            this.programNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TriggerNotifyIcon_MouseDoubleClick);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.refreshServersToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(141, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // refreshServersToolStripMenuItem
            // 
            this.refreshServersToolStripMenuItem.Name = "refreshServersToolStripMenuItem";
            this.refreshServersToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.refreshServersToolStripMenuItem.Text = "Refresh Data";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.mainStatusLabel,
            this.toolStripStatusLabel2,
            this.nextUpdateStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "Current Status:";
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.AutoSize = false;
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(200, 17);
            this.mainStatusLabel.Text = "Initializing...";
            this.mainStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel2.Text = "Next Update In:";
            // 
            // nextUpdateStatusLabel
            // 
            this.nextUpdateStatusLabel.Name = "nextUpdateStatusLabel";
            this.nextUpdateStatusLabel.Size = new System.Drawing.Size(70, 17);
            this.nextUpdateStatusLabel.Text = "Initializing...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 592);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ServerTreeView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EverQuest Server Status by EQResource";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.logTab.ResumeLayout(false);
            this.ErrorLogGroupBox.ResumeLayout(false);
            this.GeneralLogGroupBox.ResumeLayout(false);
            this.triggersTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serverDataTab.ResumeLayout(false);
            this.serverDataTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ServerTreeView;
        internal System.Windows.Forms.ImageList ServerStatusImageList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer serverRefreshTimer;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.GroupBox ErrorLogGroupBox;
        private System.Windows.Forms.ListBox ErrorLogListBox;
        private System.Windows.Forms.GroupBox GeneralLogGroupBox;
        private System.Windows.Forms.ListBox GeneralLogListBox;
        private System.Windows.Forms.TabPage triggersTab;
        private System.Windows.Forms.TabPage serverDataTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem setRefreshTimerToolStripMenuItem;
        private System.Windows.Forms.ListView triggersListView;
        private System.Windows.Forms.ColumnHeader columnServer;
        private System.Windows.Forms.ColumnHeader columnStatusFrom;
        private System.Windows.Forms.ColumnHeader columnStatusTo;
        private System.Windows.Forms.ColumnHeader columnAlertOnce;
        private System.Windows.Forms.ComboBox triggerCreationServerSelectComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox triggerCreationStatusToComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox triggerCreationStatusFromComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox triggerCreationAlertOnceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button triggerCreationCreateButton;
        private System.Windows.Forms.Button triggerRemoveSelectedTriggerButton;
        private System.Windows.Forms.NotifyIcon programNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label serverLastUpdatedLabel;
        private System.Windows.Forms.ListView serverHistoryListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel nextUpdateStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem eQResourcecomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

