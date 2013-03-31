namespace FilterDemo
{
   partial class FrmSift
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
         this.lvItems = new System.Windows.Forms.ListView();
         this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.lblName = new System.Windows.Forms.Label();
         this.pnlDate = new System.Windows.Forms.Panel();
         this.btnDate = new NanQi.Controls.PinkieControls.ButtonXP();
         this.menuTime = new System.Windows.Forms.MenuStrip();
         this.tsmiChoose = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiA = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiB = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiC = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.tsmiD = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiE = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.tsmiF = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiG = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiH = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiI = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiJ = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.tsmiK = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiL = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiM = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiN = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.tsmiO = new System.Windows.Forms.ToolStripMenuItem();
         this.tsmiP = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.tsmiQ = new System.Windows.Forms.ToolStripMenuItem();
         this.dtpEnd = new System.Windows.Forms.DateTimePicker();
         this.dtpStart = new System.Windows.Forms.DateTimePicker();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.pnlText = new System.Windows.Forms.Panel();
         this.btnText = new NanQi.Controls.PinkieControls.ButtonXP();
         this.txtText = new System.Windows.Forms.TextBox();
         this.rbtn2 = new System.Windows.Forms.RadioButton();
         this.rbtn1 = new System.Windows.Forms.RadioButton();
         this.pnlMoney = new System.Windows.Forms.Panel();
         this.btnMoney = new NanQi.Controls.PinkieControls.ButtonXP();
         this.txtMoney2 = new NanQi.Controls.TextBoxExtend();
         this.txtMoney1 = new NanQi.Controls.TextBoxExtend();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lvResult = new System.Windows.Forms.ListView();
         this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
         this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
         this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
         this.btnOK = new NanQi.Controls.PinkieControls.ButtonXP();
         this.btnCancel = new NanQi.Controls.PinkieControls.ButtonXP();
         this.btnDelete = new NanQi.Controls.PinkieControls.ButtonXP();
         this.btnReset = new NanQi.Controls.PinkieControls.ButtonXP();
         this.groupBox1.SuspendLayout();
         this.pnlDate.SuspendLayout();
         this.menuTime.SuspendLayout();
         this.pnlText.SuspendLayout();
         this.pnlMoney.SuspendLayout();
         this.SuspendLayout();
         // 
         // lvItems
         // 
         this.lvItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
         this.lvItems.FullRowSelect = true;
         this.lvItems.Location = new System.Drawing.Point(12, 12);
         this.lvItems.MultiSelect = false;
         this.lvItems.Name = "lvItems";
         this.lvItems.Size = new System.Drawing.Size(152, 373);
         this.lvItems.TabIndex = 0;
         this.lvItems.UseCompatibleStateImageBehavior = false;
         this.lvItems.View = System.Windows.Forms.View.Details;
         this.lvItems.SelectedIndexChanged += new System.EventHandler(this.lvItems_SelectedIndexChanged);
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "条件项目";
         this.columnHeader1.Width = 150;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.lblName);
         this.groupBox1.Controls.Add(this.pnlDate);
         this.groupBox1.Controls.Add(this.pnlText);
         this.groupBox1.Controls.Add(this.pnlMoney);
         this.groupBox1.Location = new System.Drawing.Point(164, 6);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(220, 380);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         // 
         // lblName
         // 
         this.lblName.AutoSize = true;
         this.lblName.Location = new System.Drawing.Point(7, 21);
         this.lblName.Name = "lblName";
         this.lblName.Size = new System.Drawing.Size(35, 12);
         this.lblName.TabIndex = 0;
         this.lblName.Text = "名称:";
         // 
         // pnlDate
         // 
         this.pnlDate.Controls.Add(this.btnDate);
         this.pnlDate.Controls.Add(this.menuTime);
         this.pnlDate.Controls.Add(this.dtpEnd);
         this.pnlDate.Controls.Add(this.dtpStart);
         this.pnlDate.Controls.Add(this.label4);
         this.pnlDate.Controls.Add(this.label5);
         this.pnlDate.Location = new System.Drawing.Point(9, 47);
         this.pnlDate.Name = "pnlDate";
         this.pnlDate.Size = new System.Drawing.Size(199, 233);
         this.pnlDate.TabIndex = 195;
         this.pnlDate.Visible = false;
         // 
         // btnDate
         // 
         this.btnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnDate.DefaultScheme = true;
         this.btnDate.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.btnDate.ForeColor = System.Drawing.Color.Black;
         this.btnDate.Hint = "";
         this.btnDate.Location = new System.Drawing.Point(69, 184);
         this.btnDate.Name = "btnDate";
         this.btnDate.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Silver;
         this.btnDate.Size = new System.Drawing.Size(75, 30);
         this.btnDate.TabIndex = 16;
         this.btnDate.Text = ">>";
         this.btnDate.TextColor = System.Drawing.Color.Black;
         this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
         // 
         // menuTime
         // 
         this.menuTime.BackColor = System.Drawing.Color.Transparent;
         this.menuTime.Dock = System.Windows.Forms.DockStyle.None;
         this.menuTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChoose});
         this.menuTime.Location = new System.Drawing.Point(12, 23);
         this.menuTime.Name = "menuTime";
         this.menuTime.Padding = new System.Windows.Forms.Padding(0);
         this.menuTime.Size = new System.Drawing.Size(93, 24);
         this.menuTime.TabIndex = 164;
         this.menuTime.Text = "menuStrip1";
         // 
         // tsmiChoose
         // 
         this.tsmiChoose.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiA,
            this.tsmiB,
            this.tsmiC,
            this.toolStripSeparator1,
            this.tsmiD,
            this.tsmiE,
            this.toolStripSeparator2,
            this.tsmiF,
            this.tsmiG,
            this.tsmiH,
            this.tsmiI,
            this.tsmiJ,
            this.toolStripSeparator3,
            this.tsmiK,
            this.tsmiL,
            this.tsmiM,
            this.tsmiN,
            this.toolStripSeparator4,
            this.tsmiO,
            this.tsmiP,
            this.toolStripSeparator5,
            this.tsmiQ});
         this.tsmiChoose.Name = "tsmiChoose";
         this.tsmiChoose.Size = new System.Drawing.Size(91, 24);
         this.tsmiChoose.Text = "时间段选择↓";
         // 
         // tsmiA
         // 
         this.tsmiA.Name = "tsmiA";
         this.tsmiA.Size = new System.Drawing.Size(138, 22);
         this.tsmiA.Text = "今天(&A)";
         this.tsmiA.Click += new System.EventHandler(this.tsmiA_Click);
         // 
         // tsmiB
         // 
         this.tsmiB.Name = "tsmiB";
         this.tsmiB.Size = new System.Drawing.Size(138, 22);
         this.tsmiB.Text = "昨天(&B)";
         this.tsmiB.Click += new System.EventHandler(this.tsmiB_Click);
         // 
         // tsmiC
         // 
         this.tsmiC.Name = "tsmiC";
         this.tsmiC.Size = new System.Drawing.Size(138, 22);
         this.tsmiC.Text = "前天(&C)";
         this.tsmiC.Click += new System.EventHandler(this.tsmiC_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
         // 
         // tsmiD
         // 
         this.tsmiD.Name = "tsmiD";
         this.tsmiD.Size = new System.Drawing.Size(138, 22);
         this.tsmiD.Text = "本周(&D)";
         this.tsmiD.Click += new System.EventHandler(this.tsmiD_Click);
         // 
         // tsmiE
         // 
         this.tsmiE.Name = "tsmiE";
         this.tsmiE.Size = new System.Drawing.Size(138, 22);
         this.tsmiE.Text = "上周(&E)";
         this.tsmiE.Click += new System.EventHandler(this.tsmiE_Click);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
         // 
         // tsmiF
         // 
         this.tsmiF.Name = "tsmiF";
         this.tsmiF.Size = new System.Drawing.Size(138, 22);
         this.tsmiF.Text = "本月(&F)";
         this.tsmiF.Click += new System.EventHandler(this.tsmiF_Click);
         // 
         // tsmiG
         // 
         this.tsmiG.Name = "tsmiG";
         this.tsmiG.Size = new System.Drawing.Size(138, 22);
         this.tsmiG.Text = "本月上旬(&G)";
         this.tsmiG.Click += new System.EventHandler(this.tsmiG_Click);
         // 
         // tsmiH
         // 
         this.tsmiH.Name = "tsmiH";
         this.tsmiH.Size = new System.Drawing.Size(138, 22);
         this.tsmiH.Text = "本月中旬(&H)";
         this.tsmiH.Click += new System.EventHandler(this.tsmiH_Click);
         // 
         // tsmiI
         // 
         this.tsmiI.Name = "tsmiI";
         this.tsmiI.Size = new System.Drawing.Size(138, 22);
         this.tsmiI.Text = "本月下旬(&I)";
         this.tsmiI.Click += new System.EventHandler(this.tsmiI_Click);
         // 
         // tsmiJ
         // 
         this.tsmiJ.Name = "tsmiJ";
         this.tsmiJ.Size = new System.Drawing.Size(138, 22);
         this.tsmiJ.Text = "上月(&J)";
         this.tsmiJ.Click += new System.EventHandler(this.tsmiJ_Click);
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
         // 
         // tsmiK
         // 
         this.tsmiK.Name = "tsmiK";
         this.tsmiK.Size = new System.Drawing.Size(138, 22);
         this.tsmiK.Text = "本季度(&K)";
         this.tsmiK.Click += new System.EventHandler(this.tsmiK_Click);
         // 
         // tsmiL
         // 
         this.tsmiL.Name = "tsmiL";
         this.tsmiL.Size = new System.Drawing.Size(138, 22);
         this.tsmiL.Text = "上季度(&L)";
         this.tsmiL.Click += new System.EventHandler(this.tsmiL_Click);
         // 
         // tsmiM
         // 
         this.tsmiM.Name = "tsmiM";
         this.tsmiM.Size = new System.Drawing.Size(138, 22);
         this.tsmiM.Text = "本年(&M)";
         this.tsmiM.Click += new System.EventHandler(this.tsmiM_Click);
         // 
         // tsmiN
         // 
         this.tsmiN.Name = "tsmiN";
         this.tsmiN.Size = new System.Drawing.Size(138, 22);
         this.tsmiN.Text = "上年(&N)";
         this.tsmiN.Click += new System.EventHandler(this.tsmiN_Click);
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(135, 6);
         // 
         // tsmiO
         // 
         this.tsmiO.Name = "tsmiO";
         this.tsmiO.Size = new System.Drawing.Size(138, 22);
         this.tsmiO.Text = "最近一周(&O)";
         this.tsmiO.Click += new System.EventHandler(this.tsmiO_Click);
         // 
         // tsmiP
         // 
         this.tsmiP.Name = "tsmiP";
         this.tsmiP.Size = new System.Drawing.Size(138, 22);
         this.tsmiP.Text = "最近一月(&P)";
         this.tsmiP.Click += new System.EventHandler(this.tsmiP_Click);
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(135, 6);
         // 
         // tsmiQ
         // 
         this.tsmiQ.Name = "tsmiQ";
         this.tsmiQ.Size = new System.Drawing.Size(138, 22);
         this.tsmiQ.Text = "本月至今(&Q)";
         this.tsmiQ.Click += new System.EventHandler(this.tsmiQ_Click);
         // 
         // dtpEnd
         // 
         this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
         this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtpEnd.Location = new System.Drawing.Point(45, 113);
         this.dtpEnd.Name = "dtpEnd";
         this.dtpEnd.Size = new System.Drawing.Size(140, 21);
         this.dtpEnd.TabIndex = 162;
         // 
         // dtpStart
         // 
         this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
         this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtpStart.Location = new System.Drawing.Point(44, 63);
         this.dtpStart.Name = "dtpStart";
         this.dtpStart.Size = new System.Drawing.Size(140, 21);
         this.dtpStart.TabIndex = 161;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 117);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(17, 12);
         this.label4.TabIndex = 1;
         this.label4.Text = "至";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 67);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(17, 12);
         this.label5.TabIndex = 0;
         this.label5.Text = "从";
         // 
         // pnlText
         // 
         this.pnlText.Controls.Add(this.btnText);
         this.pnlText.Controls.Add(this.txtText);
         this.pnlText.Controls.Add(this.rbtn2);
         this.pnlText.Controls.Add(this.rbtn1);
         this.pnlText.Location = new System.Drawing.Point(9, 47);
         this.pnlText.Name = "pnlText";
         this.pnlText.Size = new System.Drawing.Size(199, 233);
         this.pnlText.TabIndex = 1;
         // 
         // btnText
         // 
         this.btnText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnText.DefaultScheme = true;
         this.btnText.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnText.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.btnText.ForeColor = System.Drawing.Color.Black;
         this.btnText.Hint = "";
         this.btnText.Location = new System.Drawing.Point(69, 184);
         this.btnText.Name = "btnText";
         this.btnText.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Silver;
         this.btnText.Size = new System.Drawing.Size(75, 30);
         this.btnText.TabIndex = 196;
         this.btnText.Text = ">>";
         this.btnText.TextColor = System.Drawing.Color.Black;
         this.btnText.Click += new System.EventHandler(this.btnText_Click);
         // 
         // txtText
         // 
         this.txtText.Location = new System.Drawing.Point(15, 64);
         this.txtText.Name = "txtText";
         this.txtText.Size = new System.Drawing.Size(168, 21);
         this.txtText.TabIndex = 2;
         this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
         // 
         // rbtn2
         // 
         this.rbtn2.AutoSize = true;
         this.rbtn2.Location = new System.Drawing.Point(97, 23);
         this.rbtn2.Name = "rbtn2";
         this.rbtn2.Size = new System.Drawing.Size(47, 16);
         this.rbtn2.TabIndex = 1;
         this.rbtn2.Text = "等于";
         this.rbtn2.UseVisualStyleBackColor = true;
         // 
         // rbtn1
         // 
         this.rbtn1.AutoSize = true;
         this.rbtn1.Checked = true;
         this.rbtn1.Location = new System.Drawing.Point(15, 23);
         this.rbtn1.Name = "rbtn1";
         this.rbtn1.Size = new System.Drawing.Size(47, 16);
         this.rbtn1.TabIndex = 0;
         this.rbtn1.TabStop = true;
         this.rbtn1.Text = "包含";
         this.rbtn1.UseVisualStyleBackColor = true;
         // 
         // pnlMoney
         // 
         this.pnlMoney.Controls.Add(this.btnMoney);
         this.pnlMoney.Controls.Add(this.txtMoney2);
         this.pnlMoney.Controls.Add(this.txtMoney1);
         this.pnlMoney.Controls.Add(this.label3);
         this.pnlMoney.Controls.Add(this.label2);
         this.pnlMoney.Location = new System.Drawing.Point(9, 47);
         this.pnlMoney.Name = "pnlMoney";
         this.pnlMoney.Size = new System.Drawing.Size(199, 233);
         this.pnlMoney.TabIndex = 3;
         this.pnlMoney.Visible = false;
         // 
         // btnMoney
         // 
         this.btnMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnMoney.DefaultScheme = true;
         this.btnMoney.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnMoney.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.btnMoney.ForeColor = System.Drawing.Color.Black;
         this.btnMoney.Hint = "";
         this.btnMoney.Location = new System.Drawing.Point(69, 184);
         this.btnMoney.Name = "btnMoney";
         this.btnMoney.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Silver;
         this.btnMoney.Size = new System.Drawing.Size(75, 30);
         this.btnMoney.TabIndex = 195;
         this.btnMoney.Text = ">>";
         this.btnMoney.TextColor = System.Drawing.Color.Black;
         this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
         // 
         // txtMoney2
         // 
         this.txtMoney2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.txtMoney2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
         this.txtMoney2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtMoney2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.txtMoney2.ForeColor = System.Drawing.Color.Green;
         this.txtMoney2.inputType = NanQi.Controls.InputType.Decimal;
         this.txtMoney2.Location = new System.Drawing.Point(47, 67);
         this.txtMoney2.Name = "txtMoney2";
         this.txtMoney2.Size = new System.Drawing.Size(138, 26);
         this.txtMoney2.TabIndex = 194;
         this.txtMoney2.Text = "0.00";
         this.txtMoney2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtMoney2.Leave += new System.EventHandler(this.txtMoney2_Leave);
         // 
         // txtMoney1
         // 
         this.txtMoney1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.txtMoney1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
         this.txtMoney1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtMoney1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.txtMoney1.ForeColor = System.Drawing.Color.Green;
         this.txtMoney1.inputType = NanQi.Controls.InputType.Decimal;
         this.txtMoney1.Location = new System.Drawing.Point(47, 17);
         this.txtMoney1.Name = "txtMoney1";
         this.txtMoney1.Size = new System.Drawing.Size(138, 26);
         this.txtMoney1.TabIndex = 193;
         this.txtMoney1.Text = "0.00";
         this.txtMoney1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtMoney1.Leave += new System.EventHandler(this.txtMoney1_Leave);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(13, 73);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(17, 12);
         this.label3.TabIndex = 1;
         this.label3.Text = "至";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(13, 23);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(17, 12);
         this.label2.TabIndex = 0;
         this.label2.Text = "从";
         // 
         // lvResult
         // 
         this.lvResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
         this.lvResult.FullRowSelect = true;
         this.lvResult.Location = new System.Drawing.Point(383, 12);
         this.lvResult.MultiSelect = false;
         this.lvResult.Name = "lvResult";
         this.lvResult.Size = new System.Drawing.Size(318, 373);
         this.lvResult.TabIndex = 2;
         this.lvResult.UseCompatibleStateImageBehavior = false;
         this.lvResult.View = System.Windows.Forms.View.Details;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "条件项目";
         this.columnHeader2.Width = 120;
         // 
         // columnHeader3
         // 
         this.columnHeader3.Text = "操作符";
         this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.columnHeader3.Width = 75;
         // 
         // columnHeader4
         // 
         this.columnHeader4.Text = "条件值";
         this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.columnHeader4.Width = 120;
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnOK.DefaultScheme = true;
         this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnOK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.btnOK.ForeColor = System.Drawing.Color.Black;
         this.btnOK.Hint = "";
         this.btnOK.Location = new System.Drawing.Point(545, 391);
         this.btnOK.Name = "btnOK";
         this.btnOK.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Silver;
         this.btnOK.Size = new System.Drawing.Size(75, 30);
         this.btnOK.TabIndex = 12;
         this.btnOK.Text = "确认(&A)";
         this.btnOK.TextColor = System.Drawing.Color.Black;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnCancel.DefaultScheme = true;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.btnCancel.ForeColor = System.Drawing.Color.Black;
         this.btnCancel.Hint = "";
         this.btnCancel.Location = new System.Drawing.Point(626, 391);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Silver;
         this.btnCancel.Size = new System.Drawing.Size(75, 30);
         this.btnCancel.TabIndex = 13;
         this.btnCancel.Text = "取消(&C)";
         this.btnCancel.TextColor = System.Drawing.Color.Black;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnDelete.DefaultScheme = true;
         this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnDelete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.btnDelete.ForeColor = System.Drawing.Color.Black;
         this.btnDelete.Hint = "";
         this.btnDelete.Location = new System.Drawing.Point(464, 391);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Silver;
         this.btnDelete.Size = new System.Drawing.Size(75, 30);
         this.btnDelete.TabIndex = 14;
         this.btnDelete.Text = "删除(&D)";
         this.btnDelete.TextColor = System.Drawing.Color.Black;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnReset
         // 
         this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnReset.DefaultScheme = true;
         this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnReset.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.btnReset.ForeColor = System.Drawing.Color.Black;
         this.btnReset.Hint = "";
         this.btnReset.Location = new System.Drawing.Point(383, 391);
         this.btnReset.Name = "btnReset";
         this.btnReset.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Silver;
         this.btnReset.Size = new System.Drawing.Size(75, 30);
         this.btnReset.TabIndex = 15;
         this.btnReset.Text = "重置(&R)";
         this.btnReset.TextColor = System.Drawing.Color.Black;
         this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
         // 
         // FrmSift
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(720, 436);
         this.Controls.Add(this.btnReset);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.lvResult);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.lvItems);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmSift";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "高级查询";
         this.Load += new System.EventHandler(this.FrmSift_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.pnlDate.ResumeLayout(false);
         this.pnlDate.PerformLayout();
         this.menuTime.ResumeLayout(false);
         this.menuTime.PerformLayout();
         this.pnlText.ResumeLayout(false);
         this.pnlText.PerformLayout();
         this.pnlMoney.ResumeLayout(false);
         this.pnlMoney.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListView lvItems;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ListView lvResult;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.ColumnHeader columnHeader3;
      private System.Windows.Forms.ColumnHeader columnHeader4;
      private System.Windows.Forms.Label lblName;
      private System.Windows.Forms.Panel pnlText;
      private System.Windows.Forms.RadioButton rbtn1;
      private System.Windows.Forms.RadioButton rbtn2;
      private System.Windows.Forms.TextBox txtText;
      private System.Windows.Forms.Panel pnlMoney;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private NanQi.Controls.TextBoxExtend txtMoney1;
      private NanQi.Controls.TextBoxExtend txtMoney2;
      private System.Windows.Forms.Panel pnlDate;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.DateTimePicker dtpStart;
      private System.Windows.Forms.DateTimePicker dtpEnd;
      private System.Windows.Forms.MenuStrip menuTime;
      private System.Windows.Forms.ToolStripMenuItem tsmiChoose;
      private System.Windows.Forms.ToolStripMenuItem tsmiA;
      private System.Windows.Forms.ToolStripMenuItem tsmiB;
      private System.Windows.Forms.ToolStripMenuItem tsmiC;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem tsmiD;
      private System.Windows.Forms.ToolStripMenuItem tsmiE;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem tsmiF;
      private System.Windows.Forms.ToolStripMenuItem tsmiG;
      private System.Windows.Forms.ToolStripMenuItem tsmiH;
      private System.Windows.Forms.ToolStripMenuItem tsmiI;
      private System.Windows.Forms.ToolStripMenuItem tsmiJ;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
      private System.Windows.Forms.ToolStripMenuItem tsmiK;
      private System.Windows.Forms.ToolStripMenuItem tsmiL;
      private System.Windows.Forms.ToolStripMenuItem tsmiM;
      private System.Windows.Forms.ToolStripMenuItem tsmiN;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
      private System.Windows.Forms.ToolStripMenuItem tsmiO;
      private System.Windows.Forms.ToolStripMenuItem tsmiP;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
      private System.Windows.Forms.ToolStripMenuItem tsmiQ;
      private NanQi.Controls.PinkieControls.ButtonXP btnOK;
      private NanQi.Controls.PinkieControls.ButtonXP btnCancel;
      private NanQi.Controls.PinkieControls.ButtonXP btnDelete;
      private NanQi.Controls.PinkieControls.ButtonXP btnReset;
      private NanQi.Controls.PinkieControls.ButtonXP btnDate;
      private NanQi.Controls.PinkieControls.ButtonXP btnMoney;
      private NanQi.Controls.PinkieControls.ButtonXP btnText;

   }
}