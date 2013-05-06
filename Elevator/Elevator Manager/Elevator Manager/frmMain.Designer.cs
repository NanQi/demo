namespace Elevator_Manager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("新增员工" , 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("所有员工" , 1);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmiLift = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLiftAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLiftAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiError = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContract = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParts = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.tsbService = new System.Windows.Forms.ToolStripButton();
            this.tsbErrorList = new System.Windows.Forms.ToolStripButton();
            this.tsbSQL = new System.Windows.Forms.ToolStripButton();
            this.tsbLogin = new System.Windows.Forms.ToolStripButton();
            this.tsbExitPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbErrorListSelect = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwMenu = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnParts = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnLift = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwPrint = new System.Windows.Forms.ListView();
            this.gbxMiddle = new System.Windows.Forms.GroupBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.cmsDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxDown = new System.Windows.Forms.GroupBox();
            this.toolsDown = new System.Windows.Forms.ToolStrip();
            this.tsbLeftEnd = new System.Windows.Forms.ToolStripButton();
            this.tsbLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbRight = new System.Windows.Forms.ToolStripButton();
            this.tsbRightEnd = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.gbxUp = new System.Windows.Forms.GroupBox();
            this.toolsUp = new System.Windows.Forms.ToolStrip();
            this.tsbAll = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lblColorLightYellow = new System.Windows.Forms.Label();
            this.pbxColorLightYellow = new System.Windows.Forms.PictureBox();
            this.lblColorOrange = new System.Windows.Forms.Label();
            this.pbxColorOrange = new System.Windows.Forms.PictureBox();
            this.lblColorRed = new System.Windows.Forms.Label();
            this.pbxColorRed = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.chbxNow = new System.Windows.Forms.CheckBox();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxOperator = new System.Windows.Forms.ComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.cbxColumnName = new System.Windows.Forms.ComboBox();
            this.lblColumnName = new System.Windows.Forms.Label();
            this.gbxNumber = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtErrorListSelect = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menu.SuspendLayout();
            this.tools.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbxMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.cmsDataGridView.SuspendLayout();
            this.gbxDown.SuspendLayout();
            this.toolsDown.SuspendLayout();
            this.gbxUp.SuspendLayout();
            this.toolsUp.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.gbxSelect.SuspendLayout();
            this.pnlColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorLightYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorRed)).BeginInit();
            this.gbxNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLift,
            this.tsmiError,
            this.tsmiPlan,
            this.tsmiSQL,
            this.tsmiEmployee,
            this.tsmiLogin,
            this.tsmiTools,
            this.tsmiHelp,
            this.tsmiContract,
            this.tsmiParts});
            this.menu.Location = new System.Drawing.Point(0 , 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(962 , 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // tsmiLift
            // 
            this.tsmiLift.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLiftAdd,
            this.tsmiLiftAll});
            this.tsmiLift.Name = "tsmiLift";
            this.tsmiLift.Size = new System.Drawing.Size(68 , 21);
            this.tsmiLift.Text = "电梯管理";
            // 
            // tsmiLiftAdd
            // 
            this.tsmiLiftAdd.Name = "tsmiLiftAdd";
            this.tsmiLiftAdd.Size = new System.Drawing.Size(124 , 22);
            this.tsmiLiftAdd.Text = "新增电梯";
            // 
            // tsmiLiftAll
            // 
            this.tsmiLiftAll.Name = "tsmiLiftAll";
            this.tsmiLiftAll.Size = new System.Drawing.Size(124 , 22);
            this.tsmiLiftAll.Text = "所有电梯";
            // 
            // tsmiError
            // 
            this.tsmiError.Name = "tsmiError";
            this.tsmiError.Size = new System.Drawing.Size(68 , 21);
            this.tsmiError.Text = "故障记录";
            // 
            // tsmiPlan
            // 
            this.tsmiPlan.Name = "tsmiPlan";
            this.tsmiPlan.Size = new System.Drawing.Size(68 , 21);
            this.tsmiPlan.Text = "维保计划";
            // 
            // tsmiSQL
            // 
            this.tsmiSQL.Name = "tsmiSQL";
            this.tsmiSQL.Size = new System.Drawing.Size(56 , 21);
            this.tsmiSQL.Text = "数据库";
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(68 , 21);
            this.tsmiEmployee.Text = "员工管理";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(68 , 21);
            this.tsmiLogin.Text = "登陆管理";
            // 
            // tsmiTools
            // 
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(68 , 21);
            this.tsmiTools.Text = "系统工具";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44 , 21);
            this.tsmiHelp.Text = "帮助";
            // 
            // tsmiContract
            // 
            this.tsmiContract.Name = "tsmiContract";
            this.tsmiContract.Size = new System.Drawing.Size(68 , 21);
            this.tsmiContract.Text = "维保合同";
            // 
            // tsmiParts
            // 
            this.tsmiParts.Name = "tsmiParts";
            this.tsmiParts.Size = new System.Drawing.Size(68 , 21);
            this.tsmiParts.Text = "电梯配件";
            // 
            // tools
            // 
            this.tools.AutoSize = false;
            this.tools.BackColor = System.Drawing.SystemColors.Control;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbService,
            this.tsbErrorList,
            this.tsbSQL,
            this.tsbLogin,
            this.tsbExitPrint,
            this.tsbErrorListSelect});
            this.tools.Location = new System.Drawing.Point(0 , 25);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(962 , 53);
            this.tools.TabIndex = 1;
            this.tools.Text = "toolStrip1";
            // 
            // tsbService
            // 
            this.tsbService.Image = ((System.Drawing.Image)(resources.GetObject("tsbService.Image")));
            this.tsbService.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbService.Margin = new System.Windows.Forms.Padding(20 , 1 , 20 , 2);
            this.tsbService.Name = "tsbService";
            this.tsbService.Size = new System.Drawing.Size(108 , 50);
            this.tsbService.Text = "维保计划";
            this.tsbService.Click += new System.EventHandler(this.tsbService_Click);
            // 
            // tsbErrorList
            // 
            this.tsbErrorList.Image = ((System.Drawing.Image)(resources.GetObject("tsbErrorList.Image")));
            this.tsbErrorList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbErrorList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbErrorList.Margin = new System.Windows.Forms.Padding(20 , 1 , 20 , 2);
            this.tsbErrorList.Name = "tsbErrorList";
            this.tsbErrorList.Size = new System.Drawing.Size(108 , 50);
            this.tsbErrorList.Text = "故障记录";
            // 
            // tsbSQL
            // 
            this.tsbSQL.Image = ((System.Drawing.Image)(resources.GetObject("tsbSQL.Image")));
            this.tsbSQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSQL.Margin = new System.Windows.Forms.Padding(20 , 1 , 20 , 2);
            this.tsbSQL.Name = "tsbSQL";
            this.tsbSQL.Size = new System.Drawing.Size(108 , 50);
            this.tsbSQL.Text = "数据备份";
            // 
            // tsbLogin
            // 
            this.tsbLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogin.Image")));
            this.tsbLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogin.Margin = new System.Windows.Forms.Padding(20 , 1 , 20 , 2);
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.Size = new System.Drawing.Size(108 , 50);
            this.tsbLogin.Text = "登陆管理";
            // 
            // tsbExitPrint
            // 
            this.tsbExitPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbExitPrint.Image")));
            this.tsbExitPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExitPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExitPrint.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbExitPrint.Name = "tsbExitPrint";
            this.tsbExitPrint.Size = new System.Drawing.Size(108 , 50);
            this.tsbExitPrint.Text = "退出报表";
            this.tsbExitPrint.Visible = false;
            this.tsbExitPrint.Click += new System.EventHandler(this.tsbExitPrint_Click);
            // 
            // tsbErrorListSelect
            // 
            this.tsbErrorListSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbErrorListSelect.Image")));
            this.tsbErrorListSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbErrorListSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbErrorListSelect.Margin = new System.Windows.Forms.Padding(20 , 1 , 20 , 2);
            this.tsbErrorListSelect.Name = "tsbErrorListSelect";
            this.tsbErrorListSelect.Size = new System.Drawing.Size(108 , 50);
            this.tsbErrorListSelect.Text = "故障查找";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0 , 547);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(962 , 26);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(236 , 21);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = "当前登陆身份";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(236 , 21);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(236 , 21);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(236 , 21);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "当前系统时间";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0 , 78);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwMenu);
            this.splitContainer1.Panel1.Controls.Add(this.btnEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.btnParts);
            this.splitContainer1.Panel1.Controls.Add(this.btnContract);
            this.splitContainer1.Panel1.Controls.Add(this.btnPlan);
            this.splitContainer1.Panel1.Controls.Add(this.btnError);
            this.splitContainer1.Panel1.Controls.Add(this.btnLift);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(962 , 469);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // lvwMenu
            // 
            this.lvwMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lvwMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMenu.Font = new System.Drawing.Font("宋体" , 14.25F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ((byte)(134)));
            this.lvwMenu.HideSelection = false;
            this.lvwMenu.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvwMenu.LargeImageList = this.imageList;
            this.lvwMenu.Location = new System.Drawing.Point(0 , 40);
            this.lvwMenu.MultiSelect = false;
            this.lvwMenu.Name = "lvwMenu";
            this.lvwMenu.Scrollable = false;
            this.lvwMenu.ShowItemToolTips = true;
            this.lvwMenu.Size = new System.Drawing.Size(121 , 227);
            this.lvwMenu.TabIndex = 7;
            this.lvwMenu.UseCompatibleStateImageBehavior = false;
            this.lvwMenu.Click += new System.EventHandler(this.lvwMenu_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0 , "EmployeeAdd.png");
            this.imageList.Images.SetKeyName(1 , "Employee");
            this.imageList.Images.SetKeyName(2 , "ErrorLift.png");
            this.imageList.Images.SetKeyName(3 , "ErrorList");
            this.imageList.Images.SetKeyName(4 , "LiftAdd.png");
            this.imageList.Images.SetKeyName(5 , "Lift");
            this.imageList.Images.SetKeyName(6 , "Parts");
            this.imageList.Images.SetKeyName(7 , "PartsLift.png");
            this.imageList.Images.SetKeyName(8 , "Service.png");
            this.imageList.Images.SetKeyName(9 , "Service");
            this.imageList.Images.SetKeyName(10 , "ContractAll.png");
            this.imageList.Images.SetKeyName(11 , "Contract");
            this.imageList.Images.SetKeyName(12 , "ErrorLift");
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEmployee.Location = new System.Drawing.Point(0 , 267);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(121 , 40);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "员工管理";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnParts
            // 
            this.btnParts.BackColor = System.Drawing.SystemColors.Control;
            this.btnParts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnParts.Location = new System.Drawing.Point(0 , 307);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(121 , 40);
            this.btnParts.TabIndex = 4;
            this.btnParts.Text = "电梯配件";
            this.btnParts.UseVisualStyleBackColor = false;
            this.btnParts.Click += new System.EventHandler(this.btnParts_Click);
            // 
            // btnContract
            // 
            this.btnContract.BackColor = System.Drawing.SystemColors.Control;
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContract.Location = new System.Drawing.Point(0 , 347);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(121 , 40);
            this.btnContract.TabIndex = 3;
            this.btnContract.Text = "维保合同";
            this.btnContract.UseVisualStyleBackColor = false;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlan.Location = new System.Drawing.Point(0 , 387);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(121 , 40);
            this.btnPlan.TabIndex = 2;
            this.btnPlan.Text = "维保计划";
            this.btnPlan.UseVisualStyleBackColor = false;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.SystemColors.Control;
            this.btnError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnError.Location = new System.Drawing.Point(0 , 427);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(121 , 40);
            this.btnError.TabIndex = 1;
            this.btnError.Text = "故障记录";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnLift
            // 
            this.btnLift.BackColor = System.Drawing.SystemColors.Control;
            this.btnLift.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLift.Location = new System.Drawing.Point(0 , 0);
            this.btnLift.Name = "btnLift";
            this.btnLift.Size = new System.Drawing.Size(121 , 40);
            this.btnLift.TabIndex = 0;
            this.btnLift.Text = "电梯管理";
            this.btnLift.UseVisualStyleBackColor = false;
            this.btnLift.Click += new System.EventHandler(this.btnLift_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0 , 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwPrint);
            this.splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbxMiddle);
            this.splitContainer2.Panel2.Controls.Add(this.gbxDown);
            this.splitContainer2.Panel2.Controls.Add(this.gbxUp);
            this.splitContainer2.Panel2.Controls.Add(this.btnSplit);
            this.splitContainer2.Size = new System.Drawing.Size(838 , 469);
            this.splitContainer2.SplitterDistance = 129;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvwPrint
            // 
            this.lvwPrint.BackColor = System.Drawing.SystemColors.Control;
            this.lvwPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwPrint.LargeImageList = this.imageList;
            this.lvwPrint.Location = new System.Drawing.Point(0 , 0);
            this.lvwPrint.MultiSelect = false;
            this.lvwPrint.Name = "lvwPrint";
            this.lvwPrint.ShowItemToolTips = true;
            this.lvwPrint.Size = new System.Drawing.Size(127 , 467);
            this.lvwPrint.TabIndex = 0;
            this.lvwPrint.UseCompatibleStateImageBehavior = false;
            this.lvwPrint.Click += new System.EventHandler(this.lvwPrint_Click);
            // 
            // gbxMiddle
            // 
            this.gbxMiddle.Controls.Add(this.dgvInfo);
            this.gbxMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMiddle.Location = new System.Drawing.Point(18 , 125);
            this.gbxMiddle.Name = "gbxMiddle";
            this.gbxMiddle.Size = new System.Drawing.Size(688 , 265);
            this.gbxMiddle.TabIndex = 2;
            this.gbxMiddle.TabStop = false;
            this.gbxMiddle.Text = "当前记录";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            this.dgvInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.ContextMenuStrip = this.cmsDataGridView;
            this.dgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfo.Location = new System.Drawing.Point(3 , 17);
            this.dgvInfo.MultiSelect = false;
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.Size = new System.Drawing.Size(682 , 245);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.Sorted += new System.EventHandler(this.dgvInfo_Sorted);
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            // 
            // cmsDataGridView
            // 
            this.cmsDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelect,
            this.toolStripSeparator1,
            this.tsmiAdd,
            this.tsmiUpdate,
            this.tsmiDelete,
            this.toolStripSeparator2,
            this.tsmiPrint});
            this.cmsDataGridView.Name = "cmsDataGridView";
            this.cmsDataGridView.Size = new System.Drawing.Size(142 , 126);
            // 
            // tsmiSelect
            // 
            this.tsmiSelect.Name = "tsmiSelect";
            this.tsmiSelect.Size = new System.Drawing.Size(141 , 22);
            this.tsmiSelect.Text = "查看记录(&S)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138 , 6);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(141 , 22);
            this.tsmiAdd.Text = "添加记录(&A)";
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(141 , 22);
            this.tsmiUpdate.Text = "修改记录(&U)";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(141 , 22);
            this.tsmiDelete.Text = "删除记录(&D)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138 , 6);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(141 , 22);
            this.tsmiPrint.Text = "插入报表(&I)";
            // 
            // gbxDown
            // 
            this.gbxDown.Controls.Add(this.toolsDown);
            this.gbxDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxDown.Location = new System.Drawing.Point(18 , 390);
            this.gbxDown.Name = "gbxDown";
            this.gbxDown.Size = new System.Drawing.Size(688 , 77);
            this.gbxDown.TabIndex = 2;
            this.gbxDown.TabStop = false;
            this.gbxDown.Text = "记录浏览";
            // 
            // toolsDown
            // 
            this.toolsDown.AutoSize = false;
            this.toolsDown.BackColor = System.Drawing.SystemColors.Control;
            this.toolsDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolsDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLeftEnd,
            this.tsbLeft,
            this.tsbSelect,
            this.tsbRight,
            this.tsbRightEnd,
            this.tsbExit});
            this.toolsDown.Location = new System.Drawing.Point(3 , 14);
            this.toolsDown.Name = "toolsDown";
            this.toolsDown.Size = new System.Drawing.Size(682 , 60);
            this.toolsDown.TabIndex = 1;
            this.toolsDown.Text = "toolStrip1";
            // 
            // tsbLeftEnd
            // 
            this.tsbLeftEnd.Image = ((System.Drawing.Image)(resources.GetObject("tsbLeftEnd.Image")));
            this.tsbLeftEnd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLeftEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLeftEnd.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbLeftEnd.Name = "tsbLeftEnd";
            this.tsbLeftEnd.Size = new System.Drawing.Size(108 , 57);
            this.tsbLeftEnd.Text = "最前记录";
            this.tsbLeftEnd.Click += new System.EventHandler(this.tsbLeftEnd_Click);
            // 
            // tsbLeft
            // 
            this.tsbLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbLeft.Image")));
            this.tsbLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLeft.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbLeft.Name = "tsbLeft";
            this.tsbLeft.Size = new System.Drawing.Size(108 , 57);
            this.tsbLeft.Text = "上条记录";
            this.tsbLeft.Click += new System.EventHandler(this.tsbLeft_Click);
            // 
            // tsbSelect
            // 
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(108 , 57);
            this.tsbSelect.Text = "浏览记录";
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // tsbRight
            // 
            this.tsbRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbRight.Image")));
            this.tsbRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRight.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbRight.Name = "tsbRight";
            this.tsbRight.Size = new System.Drawing.Size(108 , 57);
            this.tsbRight.Text = "下条记录";
            this.tsbRight.Click += new System.EventHandler(this.tsbRight_Click);
            // 
            // tsbRightEnd
            // 
            this.tsbRightEnd.Image = ((System.Drawing.Image)(resources.GetObject("tsbRightEnd.Image")));
            this.tsbRightEnd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRightEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRightEnd.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbRightEnd.Name = "tsbRightEnd";
            this.tsbRightEnd.Size = new System.Drawing.Size(108 , 57);
            this.tsbRightEnd.Text = "最后记录";
            this.tsbRightEnd.Click += new System.EventHandler(this.tsbRightEnd_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(108 , 52);
            this.tsbExit.Text = "退出浏览";
            this.tsbExit.Visible = false;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // gbxUp
            // 
            this.gbxUp.Controls.Add(this.toolsUp);
            this.gbxUp.Controls.Add(this.pnlSelect);
            this.gbxUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxUp.Location = new System.Drawing.Point(18 , 0);
            this.gbxUp.Name = "gbxUp";
            this.gbxUp.Size = new System.Drawing.Size(688 , 125);
            this.gbxUp.TabIndex = 1;
            this.gbxUp.TabStop = false;
            this.gbxUp.Text = "记录过滤";
            // 
            // toolsUp
            // 
            this.toolsUp.AutoSize = false;
            this.toolsUp.BackColor = System.Drawing.SystemColors.Control;
            this.toolsUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAll,
            this.tsbAdd,
            this.tsbUpdate,
            this.tsbDelete,
            this.tsbPrint});
            this.toolsUp.Location = new System.Drawing.Point(3 , 17);
            this.toolsUp.Name = "toolsUp";
            this.toolsUp.Size = new System.Drawing.Size(682 , 58);
            this.toolsUp.TabIndex = 2;
            this.toolsUp.Text = "toolStrip2";
            this.toolsUp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolsUp_ItemClicked);
            // 
            // tsbAll
            // 
            this.tsbAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbAll.Image")));
            this.tsbAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAll.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbAll.Name = "tsbAll";
            this.tsbAll.Size = new System.Drawing.Size(108 , 55);
            this.tsbAll.Text = "恢复过滤";
            this.tsbAll.Click += new System.EventHandler(this.tsbAll_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(108 , 55);
            this.tsbAdd.Text = "添加记录";
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(108 , 55);
            this.tsbUpdate.Text = "修改记录";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(108 , 55);
            this.tsbDelete.Text = "删除记录";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Margin = new System.Windows.Forms.Padding(10 , 1 , 10 , 2);
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(108 , 55);
            this.tsbPrint.Text = "插入报表";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.gbxSelect);
            this.pnlSelect.Controls.Add(this.gbxNumber);
            this.pnlSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSelect.Location = new System.Drawing.Point(3 , 75);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(682 , 47);
            this.pnlSelect.TabIndex = 0;
            // 
            // gbxSelect
            // 
            this.gbxSelect.Controls.Add(this.pnlColor);
            this.gbxSelect.Controls.Add(this.btnSelect);
            this.gbxSelect.Controls.Add(this.chbxNow);
            this.gbxSelect.Controls.Add(this.txtSelect);
            this.gbxSelect.Controls.Add(this.lblSelect);
            this.gbxSelect.Controls.Add(this.cbxOperator);
            this.gbxSelect.Controls.Add(this.lblOperator);
            this.gbxSelect.Controls.Add(this.cbxColumnName);
            this.gbxSelect.Controls.Add(this.lblColumnName);
            this.gbxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxSelect.Location = new System.Drawing.Point(0 , 0);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(594 , 47);
            this.gbxSelect.TabIndex = 1;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "筛选查询当前记录";
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.lblColorLightYellow);
            this.pnlColor.Controls.Add(this.pbxColorLightYellow);
            this.pnlColor.Controls.Add(this.lblColorOrange);
            this.pnlColor.Controls.Add(this.pbxColorOrange);
            this.pnlColor.Controls.Add(this.lblColorRed);
            this.pnlColor.Controls.Add(this.pbxColorRed);
            this.pnlColor.Location = new System.Drawing.Point(594 , 14);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(397 , 27);
            this.pnlColor.TabIndex = 8;
            // 
            // lblColorLightYellow
            // 
            this.lblColorLightYellow.AutoSize = true;
            this.lblColorLightYellow.Location = new System.Drawing.Point(368 , 9);
            this.lblColorLightYellow.Name = "lblColorLightYellow";
            this.lblColorLightYellow.Size = new System.Drawing.Size(29 , 12);
            this.lblColorLightYellow.TabIndex = 5;
            this.lblColorLightYellow.Text = "预警";
            // 
            // pbxColorLightYellow
            // 
            this.pbxColorLightYellow.BackColor = System.Drawing.Color.LightYellow;
            this.pbxColorLightYellow.Location = new System.Drawing.Point(267 , 2);
            this.pbxColorLightYellow.Name = "pbxColorLightYellow";
            this.pbxColorLightYellow.Size = new System.Drawing.Size(100 , 23);
            this.pbxColorLightYellow.TabIndex = 4;
            this.pbxColorLightYellow.TabStop = false;
            // 
            // lblColorOrange
            // 
            this.lblColorOrange.AutoSize = true;
            this.lblColorOrange.Location = new System.Drawing.Point(237 , 9);
            this.lblColorOrange.Name = "lblColorOrange";
            this.lblColorOrange.Size = new System.Drawing.Size(29 , 12);
            this.lblColorOrange.TabIndex = 3;
            this.lblColorOrange.Text = "到期";
            // 
            // pbxColorOrange
            // 
            this.pbxColorOrange.BackColor = System.Drawing.Color.Orange;
            this.pbxColorOrange.Location = new System.Drawing.Point(135 , 2);
            this.pbxColorOrange.Name = "pbxColorOrange";
            this.pbxColorOrange.Size = new System.Drawing.Size(100 , 23);
            this.pbxColorOrange.TabIndex = 2;
            this.pbxColorOrange.TabStop = false;
            // 
            // lblColorRed
            // 
            this.lblColorRed.AutoSize = true;
            this.lblColorRed.Location = new System.Drawing.Point(105 , 9);
            this.lblColorRed.Name = "lblColorRed";
            this.lblColorRed.Size = new System.Drawing.Size(29 , 12);
            this.lblColorRed.TabIndex = 1;
            this.lblColorRed.Text = "超期";
            // 
            // pbxColorRed
            // 
            this.pbxColorRed.BackColor = System.Drawing.Color.Red;
            this.pbxColorRed.Location = new System.Drawing.Point(3 , 2);
            this.pbxColorRed.Name = "pbxColorRed";
            this.pbxColorRed.Size = new System.Drawing.Size(100 , 23);
            this.pbxColorRed.TabIndex = 0;
            this.pbxColorRed.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(504 , 17);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86 , 21);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "执行过滤";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // chbxNow
            // 
            this.chbxNow.AutoSize = true;
            this.chbxNow.Location = new System.Drawing.Point(434 , 21);
            this.chbxNow.Name = "chbxNow";
            this.chbxNow.Size = new System.Drawing.Size(72 , 16);
            this.chbxNow.TabIndex = 6;
            this.chbxNow.Text = "过滤当前";
            this.chbxNow.UseVisualStyleBackColor = true;
            // 
            // txtSelect
            // 
            this.txtSelect.BackColor = System.Drawing.SystemColors.Info;
            this.txtSelect.Location = new System.Drawing.Point(326 , 18);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(106 , 21);
            this.txtSelect.TabIndex = 5;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(291 , 21);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(35 , 12);
            this.lblSelect.TabIndex = 4;
            this.lblSelect.Text = "条件:";
            // 
            // cbxOperator
            // 
            this.cbxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperator.FormattingEnabled = true;
            this.cbxOperator.Items.AddRange(new object[] {
            "等于",
            "不等于",
            "大于",
            "小于",
            "大于等于",
            "小于等于",
            "模糊查询"});
            this.cbxOperator.Location = new System.Drawing.Point(221 , 18);
            this.cbxOperator.Name = "cbxOperator";
            this.cbxOperator.Size = new System.Drawing.Size(70 , 20);
            this.cbxOperator.TabIndex = 3;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(160 , 21);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(59 , 12);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "逻辑关系:";
            // 
            // cbxColumnName
            // 
            this.cbxColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColumnName.FormattingEnabled = true;
            this.cbxColumnName.Location = new System.Drawing.Point(53 , 18);
            this.cbxColumnName.Name = "cbxColumnName";
            this.cbxColumnName.Size = new System.Drawing.Size(104 , 20);
            this.cbxColumnName.TabIndex = 1;
            // 
            // lblColumnName
            // 
            this.lblColumnName.AutoSize = true;
            this.lblColumnName.Location = new System.Drawing.Point(6 , 21);
            this.lblColumnName.Name = "lblColumnName";
            this.lblColumnName.Size = new System.Drawing.Size(47 , 12);
            this.lblColumnName.TabIndex = 0;
            this.lblColumnName.Text = "字段名:";
            // 
            // gbxNumber
            // 
            this.gbxNumber.Controls.Add(this.lblNumber);
            this.gbxNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxNumber.Location = new System.Drawing.Point(594 , 0);
            this.gbxNumber.Name = "gbxNumber";
            this.gbxNumber.Size = new System.Drawing.Size(88 , 47);
            this.gbxNumber.TabIndex = 0;
            this.gbxNumber.TabStop = false;
            this.gbxNumber.Text = "当前记录数";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(39 , 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(11 , 12);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "0";
            // 
            // btnSplit
            // 
            this.btnSplit.BackgroundImage = global::Elevator_Manager.Properties.Resources.right;
            this.btnSplit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSplit.Location = new System.Drawing.Point(0 , 0);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(18 , 467);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // txtErrorListSelect
            // 
            this.txtErrorListSelect.BackColor = System.Drawing.SystemColors.Info;
            this.txtErrorListSelect.Location = new System.Drawing.Point(737 , 40);
            this.txtErrorListSelect.Name = "txtErrorListSelect";
            this.txtErrorListSelect.Size = new System.Drawing.Size(175 , 21);
            this.txtErrorListSelect.TabIndex = 4;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Documents and Settings\\Visual Studio 2008\\Projects\\nanqi\\Elevator Manager\\Elev" +
                "ator Manager\\bin\\Debug\\电梯维保管理系统帮助手册.CHM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F , 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962 , 573);
            this.Controls.Add(this.txtErrorListSelect);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(970 , 600);
            this.Name = "frmMain";
            this.helpProvider1.SetShowHelp(this , true);
            this.Text = "电梯维保管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.gbxMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.cmsDataGridView.ResumeLayout(false);
            this.gbxDown.ResumeLayout(false);
            this.toolsDown.ResumeLayout(false);
            this.toolsDown.PerformLayout();
            this.gbxUp.ResumeLayout(false);
            this.toolsUp.ResumeLayout(false);
            this.toolsUp.PerformLayout();
            this.pnlSelect.ResumeLayout(false);
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorLightYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColorRed)).EndInit();
            this.gbxNumber.ResumeLayout(false);
            this.gbxNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmiLift;
        private System.Windows.Forms.ToolStripMenuItem tsmiError;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlan;
        private System.Windows.Forms.ToolStripMenuItem tsmiSQL;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiContract;
        private System.Windows.Forms.ToolStripMenuItem tsmiParts;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLift;
        private System.Windows.Forms.Button btnParts;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiftAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiftAll;
        private System.Windows.Forms.ListView lvwMenu;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox gbxMiddle;
        private System.Windows.Forms.GroupBox gbxUp;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.ToolStrip toolsDown;
        private System.Windows.Forms.GroupBox gbxDown;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripButton tsbLeftEnd;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripButton tsbLeft;
        private System.Windows.Forms.ToolStripButton tsbRight;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.GroupBox gbxNumber;
        private System.Windows.Forms.Label lblColumnName;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.ComboBox cbxColumnName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox chbxNow;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStrip toolsUp;
        private System.Windows.Forms.ToolStripButton tsbAll;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbErrorList;
        private System.Windows.Forms.ToolStripButton tsbSQL;
        private System.Windows.Forms.ToolStripButton tsbService;
        private System.Windows.Forms.TextBox txtErrorListSelect;
        private System.Windows.Forms.ToolStripButton tsbLogin;
        private System.Windows.Forms.ToolStripButton tsbErrorListSelect;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.PictureBox pbxColorRed;
        private System.Windows.Forms.Label lblColorOrange;
        private System.Windows.Forms.PictureBox pbxColorOrange;
        private System.Windows.Forms.Label lblColorRed;
        private System.Windows.Forms.Label lblColorLightYellow;
        private System.Windows.Forms.PictureBox pbxColorLightYellow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton tsbRightEnd;
        private System.Windows.Forms.ListView lvwPrint;
        private System.Windows.Forms.ToolStripButton tsbExitPrint;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ContextMenuStrip cmsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
    }
}

