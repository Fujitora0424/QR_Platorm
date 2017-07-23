namespace QR_Tool_Winform
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListenButton = new MetroFramework.Controls.MetroButton();
            this.ErrorText = new System.Windows.Forms.RichTextBox();
            this.ErrorClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ErrorCleanUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProject = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseProject = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新案例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新案例描述ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorPannel = new MetroFramework.Controls.MetroPanel();
            this.ControlPannel = new MetroFramework.Controls.MetroPanel();
            this.ConnetControlPage = new MetroFramework.Controls.MetroTabControl();
            this.ControlTab = new MetroFramework.Controls.MetroTabPage();
            this.gpbApp = new System.Windows.Forms.GroupBox();
            this.lbAppPort = new MetroFramework.Controls.MetroLabel();
            this.PhoneIP = new MetroFramework.Controls.MetroTextBox();
            this.phoneToggle = new MetroFramework.Controls.MetroToggle();
            this.gpbPlaform = new System.Windows.Forms.GroupBox();
            this.lbPCPort = new MetroFramework.Controls.MetroLabel();
            this.txbPCPort = new MetroFramework.Controls.MetroTextBox();
            this.StopListenButton = new MetroFramework.Controls.MetroButton();
            this.ResponseTab = new MetroFramework.Controls.MetroTabPage();
            this.ResponseOrNotGroup = new System.Windows.Forms.GroupBox();
            this.lbResponseStatus = new MetroFramework.Controls.MetroLabel();
            this.tgResponse = new MetroFramework.Controls.MetroToggle();
            this.ARCset = new MetroFramework.Controls.MetroTextBox();
            this.lbARC = new MetroFramework.Controls.MetroLabel();
            this.TestcaseClikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PassMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FailMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.查看日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.FindProject = new System.Windows.Forms.FolderBrowserDialog();
            this.connectStateLabel = new System.Windows.Forms.StatusStrip();
            this.connectStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.projectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.SendText = new MetroFramework.Controls.MetroTabControl();
            this.ReceiveText = new MetroFramework.Controls.MetroTabControl();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnShowLog = new MetroFramework.Controls.MetroButton();
            this.btnUpdateLog = new MetroFramework.Controls.MetroButton();
            this.btnDelectLog = new MetroFramework.Controls.MetroButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbDataBase = new MetroFramework.Controls.MetroComboBox();
            this.testTabPagesplitContainer = new System.Windows.Forms.SplitContainer();
            this.CaseAndControlPanel = new MetroFramework.Controls.MetroPanel();
            this.TestCasePanel = new MetroFramework.Controls.MetroPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvTestCase = new System.Windows.Forms.TreeView();
            this.gbTestCaseContent = new System.Windows.Forms.GroupBox();
            this.rtbTestCaseContent = new System.Windows.Forms.RichTextBox();
            this.gbTestcasecontrol = new System.Windows.Forms.GroupBox();
            this.txbQRCount = new System.Windows.Forms.TextBox();
            this.btnControl = new MetroFramework.Controls.MetroButton();
            this.btnTestCase = new MetroFramework.Controls.MetroButton();
            this.ALLMessagesplitContainer = new System.Windows.Forms.SplitContainer();
            this.SendandRecievesplitContainer = new System.Windows.Forms.SplitContainer();
            this.RemetroPanel = new MetroFramework.Controls.MetroPanel();
            this.SemetroPanel = new MetroFramework.Controls.MetroPanel();
            this.funTabControl = new MetroFramework.Controls.MetroTabControl();
            this.testTabPage = new MetroFramework.Controls.MetroTabPage();
            this.databaseTabPage = new MetroFramework.Controls.MetroTabPage();
            this.databaseTabPagesplitContainer = new System.Windows.Forms.SplitContainer();
            this.logGrid = new MetroFramework.Controls.MetroGrid();
            this.traceTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.ErrorClickMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.ErrorPannel.SuspendLayout();
            this.ControlPannel.SuspendLayout();
            this.ConnetControlPage.SuspendLayout();
            this.ControlTab.SuspendLayout();
            this.gpbApp.SuspendLayout();
            this.gpbPlaform.SuspendLayout();
            this.ResponseTab.SuspendLayout();
            this.ResponseOrNotGroup.SuspendLayout();
            this.TestcaseClikMenu.SuspendLayout();
            this.MessageClickMenu.SuspendLayout();
            this.connectStateLabel.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testTabPagesplitContainer)).BeginInit();
            this.testTabPagesplitContainer.Panel1.SuspendLayout();
            this.testTabPagesplitContainer.Panel2.SuspendLayout();
            this.testTabPagesplitContainer.SuspendLayout();
            this.CaseAndControlPanel.SuspendLayout();
            this.TestCasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbTestCaseContent.SuspendLayout();
            this.gbTestcasecontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALLMessagesplitContainer)).BeginInit();
            this.ALLMessagesplitContainer.Panel1.SuspendLayout();
            this.ALLMessagesplitContainer.Panel2.SuspendLayout();
            this.ALLMessagesplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendandRecievesplitContainer)).BeginInit();
            this.SendandRecievesplitContainer.Panel1.SuspendLayout();
            this.SendandRecievesplitContainer.Panel2.SuspendLayout();
            this.SendandRecievesplitContainer.SuspendLayout();
            this.RemetroPanel.SuspendLayout();
            this.SemetroPanel.SuspendLayout();
            this.funTabControl.SuspendLayout();
            this.testTabPage.SuspendLayout();
            this.databaseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTabPagesplitContainer)).BeginInit();
            this.databaseTabPagesplitContainer.Panel1.SuspendLayout();
            this.databaseTabPagesplitContainer.Panel2.SuspendLayout();
            this.databaseTabPagesplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListenButton
            // 
            this.ListenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListenButton.Location = new System.Drawing.Point(22, 111);
            this.ListenButton.Margin = new System.Windows.Forms.Padding(6);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(80, 36);
            this.ListenButton.TabIndex = 0;
            this.ListenButton.Text = "监听";
            this.ListenButton.UseSelectable = true;
            this.ListenButton.Click += new System.EventHandler(this.Listen);
            // 
            // ErrorText
            // 
            this.ErrorText.BackColor = System.Drawing.Color.White;
            this.ErrorText.ContextMenuStrip = this.ErrorClickMenu;
            this.ErrorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorText.ForeColor = System.Drawing.Color.Black;
            this.ErrorText.HideSelection = false;
            this.ErrorText.Location = new System.Drawing.Point(0, 0);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(6);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(1127, 160);
            this.ErrorText.TabIndex = 1;
            this.ErrorText.Text = "";
            this.ErrorText.TextChanged += new System.EventHandler(this.ErrorText_TextChanged);
            // 
            // ErrorClickMenu
            // 
            this.ErrorClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ErrorClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ErrorCleanUp});
            this.ErrorClickMenu.Name = "ErrorClickMenu";
            this.ErrorClickMenu.Size = new System.Drawing.Size(117, 32);
            // 
            // ErrorCleanUp
            // 
            this.ErrorCleanUp.Name = "ErrorCleanUp";
            this.ErrorCleanUp.Size = new System.Drawing.Size(116, 28);
            this.ErrorCleanUp.Text = "清空";
            this.ErrorCleanUp.Click += new System.EventHandler(this.ErrorCleanUp_Click);
            // 
            // menuStrip
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.menuStrip, true);
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("宋体", 9F);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(21, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1396, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProject,
            this.OpenProject,
            this.CloseProject});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("宋体", 9F);
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.文件ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.文件ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.文件ToolStripMenuItem.Text = "工程";
            this.文件ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // CreateProject
            // 
            this.CreateProject.Name = "CreateProject";
            this.CreateProject.Size = new System.Drawing.Size(160, 30);
            this.CreateProject.Text = "新建工程";
            this.CreateProject.Click += new System.EventHandler(this.CreateProject_Click);
            // 
            // OpenProject
            // 
            this.OpenProject.Name = "OpenProject";
            this.OpenProject.Size = new System.Drawing.Size(160, 30);
            this.OpenProject.Text = "打开工程";
            this.OpenProject.Click += new System.EventHandler(this.OpenProject_Click);
            // 
            // CloseProject
            // 
            this.CloseProject.Name = "CloseProject";
            this.CloseProject.Size = new System.Drawing.Size(160, 30);
            this.CloseProject.Text = "关闭工程";
            this.CloseProject.Click += new System.EventHandler(this.CloseProject_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新案例ToolStripMenuItem,
            this.更新案例描述ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 更新案例ToolStripMenuItem
            // 
            this.更新案例ToolStripMenuItem.Name = "更新案例ToolStripMenuItem";
            this.更新案例ToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.更新案例ToolStripMenuItem.Text = "更新案例列表";
            this.更新案例ToolStripMenuItem.Click += new System.EventHandler(this.更新案例ToolStripMenuItem_Click);
            // 
            // 更新案例描述ToolStripMenuItem
            // 
            this.更新案例描述ToolStripMenuItem.Name = "更新案例描述ToolStripMenuItem";
            this.更新案例描述ToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.更新案例描述ToolStripMenuItem.Text = "更新案例描述";
            this.更新案例描述ToolStripMenuItem.Click += new System.EventHandler(this.更新案例描述ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ErrorPannel
            // 
            this.ErrorPannel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ErrorPannel.BackColor = System.Drawing.Color.White;
            this.ErrorPannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ErrorPannel.Controls.Add(this.ErrorText);
            this.ErrorPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorPannel.HorizontalScrollbarBarColor = true;
            this.ErrorPannel.HorizontalScrollbarHighlightOnWheel = false;
            this.ErrorPannel.HorizontalScrollbarSize = 22;
            this.ErrorPannel.Location = new System.Drawing.Point(0, 0);
            this.ErrorPannel.Margin = new System.Windows.Forms.Padding(6);
            this.ErrorPannel.Name = "ErrorPannel";
            this.ErrorPannel.Size = new System.Drawing.Size(1131, 164);
            this.ErrorPannel.TabIndex = 4;
            this.ErrorPannel.VerticalScrollbarBarColor = true;
            this.ErrorPannel.VerticalScrollbarHighlightOnWheel = false;
            this.ErrorPannel.VerticalScrollbarSize = 21;
            // 
            // ControlPannel
            // 
            this.ControlPannel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ControlPannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlPannel.Controls.Add(this.ConnetControlPage);
            this.ControlPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPannel.HorizontalScrollbarBarColor = true;
            this.ControlPannel.HorizontalScrollbarHighlightOnWheel = false;
            this.ControlPannel.HorizontalScrollbarSize = 22;
            this.ControlPannel.Location = new System.Drawing.Point(0, 102);
            this.ControlPannel.Margin = new System.Windows.Forms.Padding(6);
            this.ControlPannel.Name = "ControlPannel";
            this.ControlPannel.Size = new System.Drawing.Size(250, 676);
            this.ControlPannel.TabIndex = 5;
            this.ControlPannel.VerticalScrollbarBarColor = true;
            this.ControlPannel.VerticalScrollbarHighlightOnWheel = false;
            this.ControlPannel.VerticalScrollbarSize = 21;
            // 
            // ConnetControlPage
            // 
            this.ConnetControlPage.Controls.Add(this.ControlTab);
            this.ConnetControlPage.Controls.Add(this.ResponseTab);
            this.ConnetControlPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnetControlPage.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.ConnetControlPage.ItemSize = new System.Drawing.Size(90, 34);
            this.ConnetControlPage.Location = new System.Drawing.Point(0, 0);
            this.ConnetControlPage.Margin = new System.Windows.Forms.Padding(6);
            this.ConnetControlPage.Name = "ConnetControlPage";
            this.ConnetControlPage.SelectedIndex = 0;
            this.ConnetControlPage.Size = new System.Drawing.Size(246, 672);
            this.ConnetControlPage.Style = MetroFramework.MetroColorStyle.Orange;
            this.ConnetControlPage.TabIndex = 0;
            this.ConnetControlPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConnetControlPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConnetControlPage.UseCustomForeColor = true;
            this.ConnetControlPage.UseSelectable = true;
            // 
            // ControlTab
            // 
            this.ControlTab.Controls.Add(this.gpbApp);
            this.ControlTab.Controls.Add(this.gpbPlaform);
            this.ControlTab.HorizontalScrollbarBarColor = true;
            this.ControlTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ControlTab.HorizontalScrollbarSize = 22;
            this.ControlTab.Location = new System.Drawing.Point(4, 38);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.ControlTab.Size = new System.Drawing.Size(238, 630);
            this.ControlTab.TabIndex = 0;
            this.ControlTab.Text = "通讯设置";
            this.ControlTab.UseVisualStyleBackColor = true;
            this.ControlTab.VerticalScrollbarBarColor = true;
            this.ControlTab.VerticalScrollbarHighlightOnWheel = false;
            this.ControlTab.VerticalScrollbarSize = 21;
            this.ControlTab.Click += new System.EventHandler(this.ControlTab_Click);
            // 
            // gpbApp
            // 
            this.gpbApp.Controls.Add(this.lbAppPort);
            this.gpbApp.Controls.Add(this.PhoneIP);
            this.gpbApp.Controls.Add(this.phoneToggle);
            this.gpbApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbApp.Location = new System.Drawing.Point(3, 170);
            this.gpbApp.Margin = new System.Windows.Forms.Padding(6);
            this.gpbApp.Name = "gpbApp";
            this.gpbApp.Padding = new System.Windows.Forms.Padding(6);
            this.gpbApp.Size = new System.Drawing.Size(232, 158);
            this.gpbApp.TabIndex = 16;
            this.gpbApp.TabStop = false;
            this.gpbApp.Text = "二维码APP";
            // 
            // lbAppPort
            // 
            this.lbAppPort.AutoSize = true;
            this.lbAppPort.Location = new System.Drawing.Point(24, 39);
            this.lbAppPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAppPort.Name = "lbAppPort";
            this.lbAppPort.Size = new System.Drawing.Size(62, 19);
            this.lbAppPort.TabIndex = 13;
            this.lbAppPort.Text = "手机IP：";
            this.lbAppPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAppPort.Click += new System.EventHandler(this.lbAppPort_Click);
            // 
            // PhoneIP
            // 
            this.PhoneIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneIP.Lines = new string[] {
        "172.16.3.30"};
            this.PhoneIP.Location = new System.Drawing.Point(87, 33);
            this.PhoneIP.Margin = new System.Windows.Forms.Padding(6);
            this.PhoneIP.MaxLength = 32767;
            this.PhoneIP.Name = "PhoneIP";
            this.PhoneIP.PasswordChar = '\0';
            this.PhoneIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneIP.SelectedText = "";
            this.PhoneIP.Size = new System.Drawing.Size(129, 48);
            this.PhoneIP.TabIndex = 12;
            this.PhoneIP.Text = "172.16.3.30";
            this.PhoneIP.UseSelectable = true;
            this.PhoneIP.TextChanged += new System.EventHandler(this.PhoneIP_TextChanged);
            // 
            // phoneToggle
            // 
            this.phoneToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.phoneToggle.AutoSize = true;
            this.phoneToggle.Location = new System.Drawing.Point(22, 104);
            this.phoneToggle.Margin = new System.Windows.Forms.Padding(6);
            this.phoneToggle.Name = "phoneToggle";
            this.phoneToggle.Size = new System.Drawing.Size(80, 22);
            this.phoneToggle.TabIndex = 14;
            this.phoneToggle.Text = "Off";
            this.phoneToggle.UseSelectable = true;
            this.phoneToggle.CheckedChanged += new System.EventHandler(this.phoneToggle_CheckedChanged);
            // 
            // gpbPlaform
            // 
            this.gpbPlaform.Controls.Add(this.lbPCPort);
            this.gpbPlaform.Controls.Add(this.ListenButton);
            this.gpbPlaform.Controls.Add(this.txbPCPort);
            this.gpbPlaform.Controls.Add(this.StopListenButton);
            this.gpbPlaform.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbPlaform.Location = new System.Drawing.Point(3, 3);
            this.gpbPlaform.Margin = new System.Windows.Forms.Padding(6);
            this.gpbPlaform.Name = "gpbPlaform";
            this.gpbPlaform.Padding = new System.Windows.Forms.Padding(6);
            this.gpbPlaform.Size = new System.Drawing.Size(232, 167);
            this.gpbPlaform.TabIndex = 15;
            this.gpbPlaform.TabStop = false;
            this.gpbPlaform.Text = "二维码平台";
            // 
            // lbPCPort
            // 
            this.lbPCPort.AutoSize = true;
            this.lbPCPort.Location = new System.Drawing.Point(24, 45);
            this.lbPCPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPCPort.Name = "lbPCPort";
            this.lbPCPort.Size = new System.Drawing.Size(79, 19);
            this.lbPCPort.TabIndex = 2;
            this.lbPCPort.Text = "本机端口：";
            this.lbPCPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPCPort.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbPCPort
            // 
            this.txbPCPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPCPort.Lines = new string[] {
        "6667"};
            this.txbPCPort.Location = new System.Drawing.Point(84, 33);
            this.txbPCPort.Margin = new System.Windows.Forms.Padding(6);
            this.txbPCPort.MaxLength = 32767;
            this.txbPCPort.Name = "txbPCPort";
            this.txbPCPort.PasswordChar = '\0';
            this.txbPCPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPCPort.SelectedText = "";
            this.txbPCPort.Size = new System.Drawing.Size(130, 48);
            this.txbPCPort.TabIndex = 1;
            this.txbPCPort.Text = "6667";
            this.txbPCPort.UseSelectable = true;
            // 
            // StopListenButton
            // 
            this.StopListenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopListenButton.Enabled = false;
            this.StopListenButton.Location = new System.Drawing.Point(144, 111);
            this.StopListenButton.Margin = new System.Windows.Forms.Padding(6);
            this.StopListenButton.Name = "StopListenButton";
            this.StopListenButton.Size = new System.Drawing.Size(70, 36);
            this.StopListenButton.TabIndex = 3;
            this.StopListenButton.Text = "停止监听";
            this.StopListenButton.UseSelectable = true;
            this.StopListenButton.Click += new System.EventHandler(this.StopListenButton_Click);
            // 
            // ResponseTab
            // 
            this.ResponseTab.Controls.Add(this.ResponseOrNotGroup);
            this.ResponseTab.HorizontalScrollbarBarColor = true;
            this.ResponseTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ResponseTab.HorizontalScrollbarSize = 22;
            this.ResponseTab.Location = new System.Drawing.Point(4, 38);
            this.ResponseTab.Margin = new System.Windows.Forms.Padding(9);
            this.ResponseTab.Name = "ResponseTab";
            this.ResponseTab.Size = new System.Drawing.Size(238, 630);
            this.ResponseTab.TabIndex = 1;
            this.ResponseTab.Text = "应答参数";
            this.ResponseTab.VerticalScrollbarBarColor = true;
            this.ResponseTab.VerticalScrollbarHighlightOnWheel = false;
            this.ResponseTab.VerticalScrollbarSize = 22;
            // 
            // ResponseOrNotGroup
            // 
            this.ResponseOrNotGroup.BackColor = System.Drawing.Color.White;
            this.ResponseOrNotGroup.Controls.Add(this.lbResponseStatus);
            this.ResponseOrNotGroup.Controls.Add(this.tgResponse);
            this.ResponseOrNotGroup.Controls.Add(this.ARCset);
            this.ResponseOrNotGroup.Controls.Add(this.lbARC);
            this.ResponseOrNotGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResponseOrNotGroup.Location = new System.Drawing.Point(0, 0);
            this.ResponseOrNotGroup.Margin = new System.Windows.Forms.Padding(6);
            this.ResponseOrNotGroup.Name = "ResponseOrNotGroup";
            this.ResponseOrNotGroup.Padding = new System.Windows.Forms.Padding(6);
            this.ResponseOrNotGroup.Size = new System.Drawing.Size(238, 228);
            this.ResponseOrNotGroup.TabIndex = 4;
            this.ResponseOrNotGroup.TabStop = false;
            this.ResponseOrNotGroup.Text = "响应报文";
            this.ResponseOrNotGroup.Enter += new System.EventHandler(this.ResponseOrNotGroup_Enter);
            // 
            // lbResponseStatus
            // 
            this.lbResponseStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResponseStatus.AutoSize = true;
            this.lbResponseStatus.Location = new System.Drawing.Point(12, 142);
            this.lbResponseStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbResponseStatus.Name = "lbResponseStatus";
            this.lbResponseStatus.Size = new System.Drawing.Size(79, 19);
            this.lbResponseStatus.TabIndex = 11;
            this.lbResponseStatus.Text = "响应状态：";
            // 
            // tgResponse
            // 
            this.tgResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tgResponse.AutoSize = true;
            this.tgResponse.Checked = true;
            this.tgResponse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgResponse.Location = new System.Drawing.Point(123, 139);
            this.tgResponse.Name = "tgResponse";
            this.tgResponse.Size = new System.Drawing.Size(80, 22);
            this.tgResponse.TabIndex = 10;
            this.tgResponse.Text = "On";
            this.tgResponse.UseSelectable = true;
            this.tgResponse.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // ARCset
            // 
            this.ARCset.Lines = new string[] {
        "00"};
            this.ARCset.Location = new System.Drawing.Point(122, 45);
            this.ARCset.Margin = new System.Windows.Forms.Padding(6);
            this.ARCset.MaxLength = 2;
            this.ARCset.Name = "ARCset";
            this.ARCset.PasswordChar = '\0';
            this.ARCset.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ARCset.SelectedText = "";
            this.ARCset.Size = new System.Drawing.Size(81, 48);
            this.ARCset.TabIndex = 8;
            this.ARCset.Text = "00";
            this.ARCset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ARCset.UseSelectable = true;
            this.ARCset.Click += new System.EventHandler(this.ARCset_Click);
            this.ARCset.Leave += new System.EventHandler(this.ARCset_TextChanged);
            // 
            // lbARC
            // 
            this.lbARC.AutoSize = true;
            this.lbARC.Location = new System.Drawing.Point(12, 45);
            this.lbARC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbARC.Name = "lbARC";
            this.lbARC.Size = new System.Drawing.Size(65, 19);
            this.lbARC.TabIndex = 9;
            this.lbARC.Text = "响应码：";
            // 
            // TestcaseClikMenu
            // 
            this.TestcaseClikMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TestcaseClikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PassMenu,
            this.FailMenu,
            this.查看日志ToolStripMenuItem});
            this.TestcaseClikMenu.Name = "TestcaseClikMenu";
            this.TestcaseClikMenu.Size = new System.Drawing.Size(153, 88);
            // 
            // PassMenu
            // 
            this.PassMenu.Name = "PassMenu";
            this.PassMenu.Size = new System.Drawing.Size(152, 28);
            this.PassMenu.Text = "打开案例";
            this.PassMenu.Click += new System.EventHandler(this.PassMenu_Click);
            // 
            // FailMenu
            // 
            this.FailMenu.Name = "FailMenu";
            this.FailMenu.Size = new System.Drawing.Size(152, 28);
            this.FailMenu.Text = "合并案例";
            this.FailMenu.Click += new System.EventHandler(this.FailMenu_Click);
            // 
            // 查看日志ToolStripMenuItem
            // 
            this.查看日志ToolStripMenuItem.Name = "查看日志ToolStripMenuItem";
            this.查看日志ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.查看日志ToolStripMenuItem.Text = "查看日志";
            this.查看日志ToolStripMenuItem.Click += new System.EventHandler(this.查看日志ToolStripMenuItem_Click);
            // 
            // MessageClickMenu
            // 
            this.MessageClickMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MessageClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearMessage});
            this.MessageClickMenu.Name = "contextMenuStrip1";
            this.MessageClickMenu.Size = new System.Drawing.Size(153, 32);
            // 
            // ClearMessage
            // 
            this.ClearMessage.Name = "ClearMessage";
            this.ClearMessage.Size = new System.Drawing.Size(152, 28);
            this.ClearMessage.Text = "清除报文";
            this.ClearMessage.Click += new System.EventHandler(this.ClearMessage_Click);
            // 
            // connectStateLabel
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.connectStateLabel, true);
            this.connectStateLabel.BackColor = System.Drawing.Color.White;
            this.connectStateLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.connectStateLabel.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.connectStateLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectStatusLabel,
            this.connectStatus,
            this.projectStatusLabel,
            this.projectStatus});
            this.connectStateLabel.Location = new System.Drawing.Point(21, 911);
            this.connectStateLabel.Margin = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.connectStateLabel.Name = "connectStateLabel";
            this.connectStateLabel.Padding = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.connectStateLabel.Size = new System.Drawing.Size(1396, 27);
            this.connectStateLabel.TabIndex = 7;
            this.connectStateLabel.Text = "工程名称";
            // 
            // connectStatusLabel
            // 
            this.connectStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.connectStatusLabel.Name = "connectStatusLabel";
            this.connectStatusLabel.Size = new System.Drawing.Size(93, 22);
            this.connectStatusLabel.Text = "监听状态:";
            this.connectStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // connectStatus
            // 
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(62, 22);
            this.connectStatus.Text = "未监听";
            // 
            // projectStatusLabel
            // 
            this.projectStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.projectStatusLabel.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.projectStatusLabel.Name = "projectStatusLabel";
            this.projectStatusLabel.Size = new System.Drawing.Size(93, 22);
            this.projectStatusLabel.Text = "工程名称:";
            // 
            // projectStatus
            // 
            this.projectStatus.Name = "projectStatus";
            this.projectStatus.Size = new System.Drawing.Size(62, 22);
            this.projectStatus.Text = "未加载";
            // 
            // SendText
            // 
            this.SendText.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.SendText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendText.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.SendText.Location = new System.Drawing.Point(0, 0);
            this.SendText.Margin = new System.Windows.Forms.Padding(6);
            this.SendText.Multiline = true;
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(557, 605);
            this.SendText.TabIndex = 7;
            this.SendText.UseSelectable = true;
            // 
            // ReceiveText
            // 
            this.ReceiveText.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ReceiveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiveText.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.ReceiveText.Location = new System.Drawing.Point(0, 0);
            this.ReceiveText.Margin = new System.Windows.Forms.Padding(6);
            this.ReceiveText.Multiline = true;
            this.ReceiveText.Name = "ReceiveText";
            this.ReceiveText.Size = new System.Drawing.Size(565, 605);
            this.ReceiveText.TabIndex = 6;
            this.ReceiveText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ReceiveText.UseSelectable = true;
            // 
            // logGroupBox
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.logGroupBox, true);
            this.logGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logGroupBox.Controls.Add(this.splitContainer2);
            this.logGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logGroupBox.Location = new System.Drawing.Point(0, 0);
            this.logGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.logGroupBox.Size = new System.Drawing.Size(1385, 140);
            this.logGroupBox.TabIndex = 3;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "数据库控制";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(6, 27);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnShowLog);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpdateLog);
            this.splitContainer2.Panel1.Controls.Add(this.btnDelectLog);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1373, 107);
            this.splitContainer2.SplitterDistance = 1115;
            this.splitContainer2.SplitterWidth = 9;
            this.splitContainer2.TabIndex = 6;
            // 
            // btnShowLog
            // 
            this.btnShowLog.DisplayFocus = true;
            this.btnShowLog.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowLog.Highlight = true;
            this.btnShowLog.Location = new System.Drawing.Point(69, 6);
            this.btnShowLog.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(195, 87);
            this.btnShowLog.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnShowLog.TabIndex = 5;
            this.btnShowLog.Text = "显示数据";
            this.btnShowLog.UseSelectable = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // btnUpdateLog
            // 
            this.btnUpdateLog.DisplayFocus = true;
            this.btnUpdateLog.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateLog.Highlight = true;
            this.btnUpdateLog.Location = new System.Drawing.Point(360, 12);
            this.btnUpdateLog.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateLog.Name = "btnUpdateLog";
            this.btnUpdateLog.Size = new System.Drawing.Size(195, 87);
            this.btnUpdateLog.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnUpdateLog.TabIndex = 4;
            this.btnUpdateLog.Text = "更新数据";
            this.btnUpdateLog.UseSelectable = true;
            this.btnUpdateLog.Click += new System.EventHandler(this.btnUpdateLog_Click);
            // 
            // btnDelectLog
            // 
            this.btnDelectLog.DisplayFocus = true;
            this.btnDelectLog.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDelectLog.Highlight = true;
            this.btnDelectLog.Location = new System.Drawing.Point(672, 12);
            this.btnDelectLog.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelectLog.Name = "btnDelectLog";
            this.btnDelectLog.Size = new System.Drawing.Size(195, 87);
            this.btnDelectLog.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnDelectLog.TabIndex = 3;
            this.btnDelectLog.Text = "删除数据";
            this.btnDelectLog.UseSelectable = true;
            this.btnDelectLog.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cbDataBase);
            this.splitContainer3.Size = new System.Drawing.Size(249, 107);
            this.splitContainer3.SplitterDistance = 51;
            this.splitContainer3.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "选择数据库";
            // 
            // cbDataBase
            // 
            this.cbDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDataBase.FormattingEnabled = true;
            this.cbDataBase.ItemHeight = 23;
            this.cbDataBase.Items.AddRange(new object[] {
            "TransLog",
            "StableLog"});
            this.cbDataBase.Location = new System.Drawing.Point(0, 0);
            this.cbDataBase.Margin = new System.Windows.Forms.Padding(6);
            this.cbDataBase.Name = "cbDataBase";
            this.cbDataBase.Size = new System.Drawing.Size(249, 29);
            this.cbDataBase.TabIndex = 0;
            this.cbDataBase.UseCustomBackColor = true;
            this.cbDataBase.UseCustomForeColor = true;
            this.cbDataBase.UseSelectable = true;
            // 
            // testTabPagesplitContainer
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.testTabPagesplitContainer, true);
            this.testTabPagesplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testTabPagesplitContainer.Location = new System.Drawing.Point(3, 3);
            this.testTabPagesplitContainer.Name = "testTabPagesplitContainer";
            // 
            // testTabPagesplitContainer.Panel1
            // 
            this.testTabPagesplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.testTabPagesplitContainer.Panel1.Controls.Add(this.CaseAndControlPanel);
            // 
            // testTabPagesplitContainer.Panel2
            // 
            this.testTabPagesplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.testTabPagesplitContainer.Panel2.Controls.Add(this.ALLMessagesplitContainer);
            this.testTabPagesplitContainer.Size = new System.Drawing.Size(1385, 778);
            this.testTabPagesplitContainer.SplitterDistance = 250;
            this.testTabPagesplitContainer.TabIndex = 7;
            // 
            // CaseAndControlPanel
            // 
            this.CaseAndControlPanel.AutoScroll = true;
            this.CaseAndControlPanel.Controls.Add(this.ControlPannel);
            this.CaseAndControlPanel.Controls.Add(this.TestCasePanel);
            this.CaseAndControlPanel.Controls.Add(this.btnControl);
            this.CaseAndControlPanel.Controls.Add(this.btnTestCase);
            this.CaseAndControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaseAndControlPanel.HorizontalScrollbar = true;
            this.CaseAndControlPanel.HorizontalScrollbarBarColor = true;
            this.CaseAndControlPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.CaseAndControlPanel.HorizontalScrollbarSize = 22;
            this.CaseAndControlPanel.Location = new System.Drawing.Point(0, 0);
            this.CaseAndControlPanel.Margin = new System.Windows.Forms.Padding(6);
            this.CaseAndControlPanel.Name = "CaseAndControlPanel";
            this.CaseAndControlPanel.Size = new System.Drawing.Size(250, 778);
            this.CaseAndControlPanel.TabIndex = 6;
            this.CaseAndControlPanel.VerticalScrollbar = true;
            this.CaseAndControlPanel.VerticalScrollbarBarColor = true;
            this.CaseAndControlPanel.VerticalScrollbarHighlightOnWheel = false;
            this.CaseAndControlPanel.VerticalScrollbarSize = 22;
            // 
            // TestCasePanel
            // 
            this.TestCasePanel.Controls.Add(this.splitContainer1);
            this.TestCasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestCasePanel.HorizontalScrollbarBarColor = true;
            this.TestCasePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TestCasePanel.HorizontalScrollbarSize = 22;
            this.TestCasePanel.Location = new System.Drawing.Point(0, 102);
            this.TestCasePanel.Margin = new System.Windows.Forms.Padding(6);
            this.TestCasePanel.Name = "TestCasePanel";
            this.TestCasePanel.Size = new System.Drawing.Size(250, 676);
            this.TestCasePanel.TabIndex = 17;
            this.TestCasePanel.VerticalScrollbarBarColor = true;
            this.TestCasePanel.VerticalScrollbarHighlightOnWheel = false;
            this.TestCasePanel.VerticalScrollbarSize = 22;
            this.TestCasePanel.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvTestCase);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbTestCaseContent);
            this.splitContainer1.Size = new System.Drawing.Size(250, 676);
            this.splitContainer1.SplitterDistance = 332;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 17;
            // 
            // tvTestCase
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.tvTestCase, true);
            this.tvTestCase.ContextMenuStrip = this.TestcaseClikMenu;
            this.tvTestCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTestCase.Location = new System.Drawing.Point(0, 0);
            this.tvTestCase.Margin = new System.Windows.Forms.Padding(6);
            this.tvTestCase.Name = "tvTestCase";
            this.tvTestCase.Size = new System.Drawing.Size(250, 332);
            this.tvTestCase.TabIndex = 17;
            this.tvTestCase.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CaseText_AfterSelect);
            // 
            // gbTestCaseContent
            // 
            this.gbTestCaseContent.Controls.Add(this.rtbTestCaseContent);
            this.gbTestCaseContent.Controls.Add(this.gbTestcasecontrol);
            this.gbTestCaseContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTestCaseContent.Font = new System.Drawing.Font("宋体", 9F);
            this.gbTestCaseContent.Location = new System.Drawing.Point(0, 0);
            this.gbTestCaseContent.Margin = new System.Windows.Forms.Padding(6);
            this.gbTestCaseContent.Name = "gbTestCaseContent";
            this.gbTestCaseContent.Padding = new System.Windows.Forms.Padding(6);
            this.gbTestCaseContent.Size = new System.Drawing.Size(250, 335);
            this.gbTestCaseContent.TabIndex = 17;
            this.gbTestCaseContent.TabStop = false;
            this.gbTestCaseContent.Text = "案例描述";
            // 
            // rtbTestCaseContent
            // 
            this.rtbTestCaseContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTestCaseContent.Location = new System.Drawing.Point(6, 27);
            this.rtbTestCaseContent.Margin = new System.Windows.Forms.Padding(6);
            this.rtbTestCaseContent.Name = "rtbTestCaseContent";
            this.rtbTestCaseContent.Size = new System.Drawing.Size(238, 77);
            this.rtbTestCaseContent.TabIndex = 17;
            this.rtbTestCaseContent.Text = "";
            // 
            // gbTestcasecontrol
            // 
            this.gbTestcasecontrol.Controls.Add(this.txbQRCount);
            this.gbTestcasecontrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbTestcasecontrol.Location = new System.Drawing.Point(6, 104);
            this.gbTestcasecontrol.Margin = new System.Windows.Forms.Padding(6);
            this.gbTestcasecontrol.Name = "gbTestcasecontrol";
            this.gbTestcasecontrol.Padding = new System.Windows.Forms.Padding(6);
            this.gbTestcasecontrol.Size = new System.Drawing.Size(238, 225);
            this.gbTestcasecontrol.TabIndex = 17;
            this.gbTestcasecontrol.TabStop = false;
            this.gbTestcasecontrol.Text = "控制器";
            this.gbTestcasecontrol.Visible = false;
            // 
            // txbQRCount
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.txbQRCount, true);
            this.txbQRCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbQRCount.Location = new System.Drawing.Point(6, 27);
            this.txbQRCount.Margin = new System.Windows.Forms.Padding(6);
            this.txbQRCount.Multiline = true;
            this.txbQRCount.Name = "txbQRCount";
            this.txbQRCount.Size = new System.Drawing.Size(226, 192);
            this.txbQRCount.TabIndex = 17;
            // 
            // btnControl
            // 
            this.btnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControl.Highlight = true;
            this.btnControl.Location = new System.Drawing.Point(0, 51);
            this.btnControl.Margin = new System.Windows.Forms.Padding(6);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(250, 51);
            this.btnControl.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "设置";
            this.btnControl.UseSelectable = true;
            this.btnControl.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnTestCase
            // 
            this.btnTestCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestCase.Highlight = true;
            this.btnTestCase.Location = new System.Drawing.Point(0, 0);
            this.btnTestCase.Margin = new System.Windows.Forms.Padding(6);
            this.btnTestCase.Name = "btnTestCase";
            this.btnTestCase.Size = new System.Drawing.Size(250, 51);
            this.btnTestCase.TabIndex = 4;
            this.btnTestCase.Text = "测试案例";
            this.btnTestCase.UseSelectable = true;
            this.btnTestCase.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ALLMessagesplitContainer
            // 
            this.ALLMessagesplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ALLMessagesplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ALLMessagesplitContainer.Margin = new System.Windows.Forms.Padding(6);
            this.ALLMessagesplitContainer.Name = "ALLMessagesplitContainer";
            this.ALLMessagesplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ALLMessagesplitContainer.Panel1
            // 
            this.ALLMessagesplitContainer.Panel1.AutoScroll = true;
            this.ALLMessagesplitContainer.Panel1.Controls.Add(this.SendandRecievesplitContainer);
            // 
            // ALLMessagesplitContainer.Panel2
            // 
            this.ALLMessagesplitContainer.Panel2.AutoScroll = true;
            this.ALLMessagesplitContainer.Panel2.Controls.Add(this.ErrorPannel);
            this.ALLMessagesplitContainer.Size = new System.Drawing.Size(1131, 778);
            this.ALLMessagesplitContainer.SplitterDistance = 605;
            this.ALLMessagesplitContainer.SplitterWidth = 9;
            this.ALLMessagesplitContainer.TabIndex = 0;
            // 
            // SendandRecievesplitContainer
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.SendandRecievesplitContainer, true);
            this.SendandRecievesplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendandRecievesplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SendandRecievesplitContainer.Margin = new System.Windows.Forms.Padding(6);
            this.SendandRecievesplitContainer.Name = "SendandRecievesplitContainer";
            // 
            // SendandRecievesplitContainer.Panel1
            // 
            this.SendandRecievesplitContainer.Panel1.AutoScroll = true;
            this.SendandRecievesplitContainer.Panel1.Controls.Add(this.RemetroPanel);
            // 
            // SendandRecievesplitContainer.Panel2
            // 
            this.SendandRecievesplitContainer.Panel2.AutoScroll = true;
            this.SendandRecievesplitContainer.Panel2.Controls.Add(this.SemetroPanel);
            this.SendandRecievesplitContainer.Size = new System.Drawing.Size(1131, 605);
            this.SendandRecievesplitContainer.SplitterDistance = 565;
            this.SendandRecievesplitContainer.SplitterWidth = 9;
            this.SendandRecievesplitContainer.TabIndex = 0;
            // 
            // RemetroPanel
            // 
            this.RemetroPanel.AutoScroll = true;
            this.RemetroPanel.Controls.Add(this.ReceiveText);
            this.RemetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemetroPanel.HorizontalScrollbar = true;
            this.RemetroPanel.HorizontalScrollbarBarColor = true;
            this.RemetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.RemetroPanel.HorizontalScrollbarSize = 22;
            this.RemetroPanel.Location = new System.Drawing.Point(0, 0);
            this.RemetroPanel.Margin = new System.Windows.Forms.Padding(6);
            this.RemetroPanel.Name = "RemetroPanel";
            this.RemetroPanel.Size = new System.Drawing.Size(565, 605);
            this.RemetroPanel.TabIndex = 0;
            this.RemetroPanel.VerticalScrollbar = true;
            this.RemetroPanel.VerticalScrollbarBarColor = true;
            this.RemetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.RemetroPanel.VerticalScrollbarSize = 22;
            // 
            // SemetroPanel
            // 
            this.SemetroPanel.AutoScroll = true;
            this.SemetroPanel.Controls.Add(this.SendText);
            this.SemetroPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SemetroPanel.HorizontalScrollbar = true;
            this.SemetroPanel.HorizontalScrollbarBarColor = true;
            this.SemetroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SemetroPanel.HorizontalScrollbarSize = 22;
            this.SemetroPanel.Location = new System.Drawing.Point(0, 0);
            this.SemetroPanel.Margin = new System.Windows.Forms.Padding(6);
            this.SemetroPanel.Name = "SemetroPanel";
            this.SemetroPanel.Size = new System.Drawing.Size(557, 605);
            this.SemetroPanel.TabIndex = 0;
            this.SemetroPanel.VerticalScrollbar = true;
            this.SemetroPanel.VerticalScrollbarBarColor = true;
            this.SemetroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SemetroPanel.VerticalScrollbarSize = 22;
            // 
            // funTabControl
            // 
            this.funTabControl.ContextMenuStrip = this.MessageClickMenu;
            this.funTabControl.Controls.Add(this.testTabPage);
            this.funTabControl.Controls.Add(this.databaseTabPage);
            this.funTabControl.Controls.Add(this.traceTabPage);
            this.funTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.funTabControl.Location = new System.Drawing.Point(21, 88);
            this.funTabControl.Name = "funTabControl";
            this.funTabControl.SelectedIndex = 0;
            this.funTabControl.Size = new System.Drawing.Size(1396, 823);
            this.funTabControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.funTabControl.TabIndex = 8;
            this.funTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.funTabControl.UseSelectable = true;
            this.funTabControl.UseStyleColors = true;
            // 
            // testTabPage
            // 
            this.testTabPage.BackColor = System.Drawing.Color.White;
            this.testTabPage.Controls.Add(this.testTabPagesplitContainer);
            this.testTabPage.HorizontalScrollbarBarColor = true;
            this.testTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.testTabPage.HorizontalScrollbarSize = 22;
            this.testTabPage.Location = new System.Drawing.Point(4, 38);
            this.testTabPage.Name = "testTabPage";
            this.testTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.testTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.testTabPage.Size = new System.Drawing.Size(1388, 781);
            this.testTabPage.TabIndex = 0;
            this.testTabPage.Text = "案例测试";
            this.testTabPage.VerticalScrollbarBarColor = true;
            this.testTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.testTabPage.VerticalScrollbarSize = 21;
            // 
            // databaseTabPage
            // 
            this.databaseTabPage.Controls.Add(this.databaseTabPagesplitContainer);
            this.databaseTabPage.HorizontalScrollbarBarColor = true;
            this.databaseTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.databaseTabPage.HorizontalScrollbarSize = 22;
            this.databaseTabPage.Location = new System.Drawing.Point(4, 38);
            this.databaseTabPage.Name = "databaseTabPage";
            this.databaseTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.databaseTabPage.Size = new System.Drawing.Size(1388, 781);
            this.databaseTabPage.TabIndex = 1;
            this.databaseTabPage.Text = "数据库";
            this.databaseTabPage.VerticalScrollbarBarColor = true;
            this.databaseTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.databaseTabPage.VerticalScrollbarSize = 21;
            this.databaseTabPage.Click += new System.EventHandler(this.databaseTabPage_Click);
            // 
            // databaseTabPagesplitContainer
            // 
            this.databaseTabPagesplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseTabPagesplitContainer.Location = new System.Drawing.Point(3, 3);
            this.databaseTabPagesplitContainer.Name = "databaseTabPagesplitContainer";
            this.databaseTabPagesplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // databaseTabPagesplitContainer.Panel1
            // 
            this.databaseTabPagesplitContainer.Panel1.Controls.Add(this.logGrid);
            this.databaseTabPagesplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 0);
            // 
            // databaseTabPagesplitContainer.Panel2
            // 
            this.databaseTabPagesplitContainer.Panel2.Controls.Add(this.logGroupBox);
            this.databaseTabPagesplitContainer.Size = new System.Drawing.Size(1385, 778);
            this.databaseTabPagesplitContainer.SplitterDistance = 634;
            this.databaseTabPagesplitContainer.TabIndex = 4;
            // 
            // logGrid
            // 
            this.logGrid.AllowUserToOrderColumns = true;
            this.logGrid.AllowUserToResizeRows = false;
            this.logGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.logGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.logGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.logGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.logGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logGrid.EnableHeadersVisualStyles = false;
            this.logGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.logGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logGrid.Location = new System.Drawing.Point(6, 6);
            this.logGrid.Margin = new System.Windows.Forms.Padding(6);
            this.logGrid.Name = "logGrid";
            this.logGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.logGrid.RowHeadersVisible = false;
            this.logGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.logGrid.RowTemplate.Height = 23;
            this.logGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logGrid.Size = new System.Drawing.Size(1379, 628);
            this.logGrid.TabIndex = 2;
            this.logGrid.UseCustomForeColor = true;
            this.logGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logGrid_CellContentClick);
            // 
            // traceTabPage
            // 
            this.traceTabPage.HorizontalScrollbarBarColor = true;
            this.traceTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.traceTabPage.HorizontalScrollbarSize = 15;
            this.traceTabPage.Location = new System.Drawing.Point(4, 38);
            this.traceTabPage.Name = "traceTabPage";
            this.traceTabPage.Size = new System.Drawing.Size(1388, 781);
            this.traceTabPage.TabIndex = 2;
            this.traceTabPage.Text = "报告";
            this.traceTabPage.VerticalScrollbarBarColor = true;
            this.traceTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.traceTabPage.VerticalScrollbarSize = 15;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::QR_Tool_Winform.Properties.Resources.logo;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1438, 958);
            this.Controls.Add(this.funTabControl);
            this.Controls.Add(this.connectStateLabel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(935, 626);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(21, 60, 21, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "二维码设备检测平台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ErrorClickMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ErrorPannel.ResumeLayout(false);
            this.ControlPannel.ResumeLayout(false);
            this.ConnetControlPage.ResumeLayout(false);
            this.ControlTab.ResumeLayout(false);
            this.gpbApp.ResumeLayout(false);
            this.gpbApp.PerformLayout();
            this.gpbPlaform.ResumeLayout(false);
            this.gpbPlaform.PerformLayout();
            this.ResponseTab.ResumeLayout(false);
            this.ResponseOrNotGroup.ResumeLayout(false);
            this.ResponseOrNotGroup.PerformLayout();
            this.TestcaseClikMenu.ResumeLayout(false);
            this.MessageClickMenu.ResumeLayout(false);
            this.connectStateLabel.ResumeLayout(false);
            this.connectStateLabel.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.testTabPagesplitContainer.Panel1.ResumeLayout(false);
            this.testTabPagesplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testTabPagesplitContainer)).EndInit();
            this.testTabPagesplitContainer.ResumeLayout(false);
            this.CaseAndControlPanel.ResumeLayout(false);
            this.TestCasePanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbTestCaseContent.ResumeLayout(false);
            this.gbTestcasecontrol.ResumeLayout(false);
            this.gbTestcasecontrol.PerformLayout();
            this.ALLMessagesplitContainer.Panel1.ResumeLayout(false);
            this.ALLMessagesplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ALLMessagesplitContainer)).EndInit();
            this.ALLMessagesplitContainer.ResumeLayout(false);
            this.SendandRecievesplitContainer.Panel1.ResumeLayout(false);
            this.SendandRecievesplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SendandRecievesplitContainer)).EndInit();
            this.SendandRecievesplitContainer.ResumeLayout(false);
            this.RemetroPanel.ResumeLayout(false);
            this.SemetroPanel.ResumeLayout(false);
            this.funTabControl.ResumeLayout(false);
            this.testTabPage.ResumeLayout(false);
            this.databaseTabPage.ResumeLayout(false);
            this.databaseTabPagesplitContainer.Panel1.ResumeLayout(false);
            this.databaseTabPagesplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseTabPagesplitContainer)).EndInit();
            this.databaseTabPagesplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroButton ListenButton;
        public System.Windows.Forms.RichTextBox ErrorText;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        public MetroFramework.Controls.MetroPanel ErrorPannel;
        public MetroFramework.Controls.MetroPanel ControlPannel;
        public MetroFramework.Controls.MetroTabControl ConnetControlPage;
        public MetroFramework.Controls.MetroTabPage ControlTab;
        public MetroFramework.Controls.MetroLabel lbPCPort;
        public MetroFramework.Controls.MetroTextBox txbPCPort;
        public MetroFramework.Controls.MetroButton StopListenButton;
        public System.Windows.Forms.ContextMenuStrip MessageClickMenu;
        public System.Windows.Forms.GroupBox ResponseOrNotGroup;
        public System.Windows.Forms.ToolStripMenuItem ClearMessage;
        public System.Windows.Forms.ContextMenuStrip ErrorClickMenu;
        public System.Windows.Forms.ToolStripMenuItem ErrorCleanUp;
        public System.Windows.Forms.ToolStripMenuItem CreateProject;
        public System.Windows.Forms.ToolStripMenuItem OpenProject;
        public System.Windows.Forms.FolderBrowserDialog FindProject;
        public MetroFramework.Controls.MetroLabel lbARC;
        public MetroFramework.Controls.MetroTextBox ARCset;
        public System.Windows.Forms.ToolStripMenuItem CloseProject;
        public System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip TestcaseClikMenu;
        public System.Windows.Forms.ToolStripMenuItem PassMenu;
        private System.Windows.Forms.ToolStripMenuItem FailMenu;
        private System.Windows.Forms.StatusStrip connectStateLabel;
        private System.Windows.Forms.ToolStripStatusLabel connectStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel connectStatus;
        public MetroFramework.Controls.MetroLabel lbAppPort;
        public MetroFramework.Controls.MetroTextBox PhoneIP;
        public MetroFramework.Controls.MetroTabControl SendText;
        public MetroFramework.Controls.MetroTabControl ReceiveText;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        public System.Windows.Forms.ToolStripStatusLabel projectStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel projectStatus;
        private MetroFramework.Controls.MetroTabControl funTabControl;
        private MetroFramework.Controls.MetroTabPage testTabPage;
        private MetroFramework.Controls.MetroTabPage databaseTabPage;
        private MetroFramework.Controls.MetroGrid logGrid;
        private System.Windows.Forms.GroupBox logGroupBox;
        private MetroFramework.Controls.MetroTabPage traceTabPage;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.SplitContainer testTabPagesplitContainer;
        private System.Windows.Forms.SplitContainer ALLMessagesplitContainer;
        private MetroFramework.Controls.MetroPanel CaseAndControlPanel;
        private MetroFramework.Controls.MetroButton btnTestCase;
        private MetroFramework.Controls.MetroButton btnControl;
        private MetroFramework.Controls.MetroTabPage ResponseTab;
        private System.Windows.Forms.GroupBox gpbApp;
        private MetroFramework.Controls.MetroToggle phoneToggle;
        private System.Windows.Forms.GroupBox gpbPlaform;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SendandRecievesplitContainer;
        private MetroFramework.Controls.MetroPanel RemetroPanel;
        private MetroFramework.Controls.MetroPanel SemetroPanel;
        private MetroFramework.Controls.MetroButton btnDelectLog;
        private MetroFramework.Controls.MetroButton btnUpdateLog;
        private MetroFramework.Controls.MetroButton btnShowLog;
        private System.Windows.Forms.SplitContainer databaseTabPagesplitContainer;
        public System.Windows.Forms.TreeView tvTestCase;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新案例ToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel TestCasePanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbTestCaseContent;
        private System.Windows.Forms.RichTextBox rtbTestCaseContent;
        private System.Windows.Forms.GroupBox gbTestcasecontrol;
        private System.Windows.Forms.TextBox txbQRCount;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbDataBase;
        private System.Windows.Forms.ToolStripMenuItem 更新案例描述ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看日志ToolStripMenuItem;
        public MetroFramework.Controls.MetroLabel lbResponseStatus;
        private MetroFramework.Controls.MetroToggle tgResponse;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}

