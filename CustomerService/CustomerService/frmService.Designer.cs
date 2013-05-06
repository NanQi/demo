namespace CustomerService
{
    partial class frmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmService));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxEmployee = new CustomerService.LineComboBox();
            this.cbxTraffic = new CustomerService.LineComboBox();
            this.dtpSolution = new CustomerService.LineDateTimePicker();
            this.panel1 = new CustomerService.ShadowPanel();
            this.cbxCustomerGroup = new CustomerService.LineComboBoxTree();
            this.cbxPayStatus = new CustomerService.LineComboBox();
            this.cbxEvaluate = new CustomerService.LineComboBox();
            this.cbxType = new CustomerService.LineComboBox();
            this.txtFault = new CustomerService.LineTextBox();
            this.dtpAccept = new CustomerService.LineDateTimePicker();
            this.cbxName = new CustomerService.LineComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSum = new CustomerService.LineTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtServiceMoney = new CustomerService.LineTextBox();
            this.txtMaterialMoney = new CustomerService.LineTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaterial = new CustomerService.LineTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResult = new CustomerService.LineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSolution = new CustomerService.LineTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNO = new CustomerService.LineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(472, 361);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 70;
            this.btnOK.Text = "确定(&A)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(381, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "保存新增(&N)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(485, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 73;
            this.label17.Text = "维护人员：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 71;
            this.label10.Text = "交通方式：";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(553, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 67;
            this.label9.Text = "解决时间：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripSplitButton4,
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(639, 37);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::CustomerService.Properties.Resources.Left;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(72, 34);
            this.toolStripButton4.Text = "上一单";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::CustomerService.Properties.Resources.Right;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(72, 34);
            this.toolStripButton3.Text = "下一单";
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(63, 34);
            this.toolStripSplitButton4.Text = "操作(&E)";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Margin = new System.Windows.Forms.Padding(325, 1, 0, 2);
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(63, 34);
            this.toolStripSplitButton3.Text = "打印(&P)";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::CustomerService.Properties.Resources.Left;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 34);
            this.toolStripButton1.Text = "上一单";
            // 
            // tsbRight
            // 
            this.tsbRight.Image = global::CustomerService.Properties.Resources.Right;
            this.tsbRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRight.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbRight.Name = "tsbRight";
            this.tsbRight.Size = new System.Drawing.Size(72, 34);
            this.tsbRight.Text = "下一单";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(63, 34);
            this.toolStripSplitButton2.Text = "操作(&E)";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(320, 1, 0, 2);
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(63, 34);
            this.toolStripSplitButton1.Text = "打印(&P)";
            // 
            // tsbCustomer
            // 
            this.tsbCustomer.Image = global::CustomerService.Properties.Resources.Right;
            this.tsbCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCustomer.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbCustomer.Name = "tsbCustomer";
            this.tsbCustomer.Size = new System.Drawing.Size(72, 34);
            this.tsbCustomer.Text = "下一单";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::CustomerService.Properties.Resources.Left;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(72, 34);
            this.toolStripButton2.Text = "上一单";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.cbxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Items.AddRange(new object[] {
            "李四",
            "王五"});
            this.cbxEmployee.Location = new System.Drawing.Point(547, 326);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(76, 20);
            this.cbxEmployee.TabIndex = 79;
            // 
            // cbxTraffic
            // 
            this.cbxTraffic.BackColor = System.Drawing.SystemColors.Control;
            this.cbxTraffic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTraffic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTraffic.FormattingEnabled = true;
            this.cbxTraffic.Items.AddRange(new object[] {
            "公交",
            "自驾"});
            this.cbxTraffic.Location = new System.Drawing.Point(403, 326);
            this.cbxTraffic.Name = "cbxTraffic";
            this.cbxTraffic.Size = new System.Drawing.Size(76, 20);
            this.cbxTraffic.TabIndex = 78;
            // 
            // dtpSolution
            // 
            this.dtpSolution.CustomFormat = "yy-MM-dd HH:mm";
            this.dtpSolution.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSolution.Location = new System.Drawing.Point(212, 325);
            this.dtpSolution.Name = "dtpSolution";
            this.dtpSolution.Size = new System.Drawing.Size(122, 21);
            this.dtpSolution.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.Empty;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxCustomerGroup);
            this.panel1.Controls.Add(this.cbxPayStatus);
            this.panel1.Controls.Add(this.cbxEvaluate);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.txtFault);
            this.panel1.Controls.Add(this.dtpAccept);
            this.panel1.Controls.Add(this.cbxName);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtServiceMoney);
            this.panel1.Controls.Add(this.txtMaterialMoney);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtMaterial);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSolution);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.PanelColor = System.Drawing.Color.Empty;
            this.panel1.Size = new System.Drawing.Size(615, 273);
            this.panel1.TabIndex = 66;
            // 
            // cbxCustomerGroup
            // 
            this.cbxCustomerGroup.AbsoluteChildrenSelectableOnly = true;
            this.cbxCustomerGroup.BranchSeparator = "-";
            this.cbxCustomerGroup.Imagelist = null;
            this.cbxCustomerGroup.Location = new System.Drawing.Point(80, 39);
            this.cbxCustomerGroup.Name = "cbxCustomerGroup";
            this.cbxCustomerGroup.SelectedNode = null;
            this.cbxCustomerGroup.Size = new System.Drawing.Size(170, 22);
            this.cbxCustomerGroup.TabIndex = 1;
            this.cbxCustomerGroup.Leave += new System.EventHandler(this.cbxCustomerGroup_Leave);
            // 
            // cbxPayStatus
            // 
            this.cbxPayStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxPayStatus.FormattingEnabled = true;
            this.cbxPayStatus.Items.AddRange(new object[] {
            "已付",
            "未付",
            "部分付",
            "欠款",
            "付清"});
            this.cbxPayStatus.Location = new System.Drawing.Point(80, 237);
            this.cbxPayStatus.Name = "cbxPayStatus";
            this.cbxPayStatus.Size = new System.Drawing.Size(171, 20);
            this.cbxPayStatus.TabIndex = 64;
            // 
            // cbxEvaluate
            // 
            this.cbxEvaluate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxEvaluate.FormattingEnabled = true;
            this.cbxEvaluate.Items.AddRange(new object[] {
            "很好",
            "满意",
            "一般",
            "不好",
            "很差"});
            this.cbxEvaluate.Location = new System.Drawing.Point(80, 181);
            this.cbxEvaluate.Name = "cbxEvaluate";
            this.cbxEvaluate.Size = new System.Drawing.Size(171, 20);
            this.cbxEvaluate.TabIndex = 63;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "现场服务",
            "远程服务"});
            this.cbxType.Location = new System.Drawing.Point(81, 69);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(170, 20);
            this.cbxType.TabIndex = 62;
            // 
            // txtFault
            // 
            this.txtFault.Location = new System.Drawing.Point(81, 96);
            this.txtFault.Name = "txtFault";
            this.txtFault.Size = new System.Drawing.Size(523, 21);
            this.txtFault.TabIndex = 61;
            // 
            // dtpAccept
            // 
            this.dtpAccept.CustomFormat = "yy-MM-dd HH:mm";
            this.dtpAccept.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAccept.Location = new System.Drawing.Point(321, 9);
            this.dtpAccept.Name = "dtpAccept";
            this.dtpAccept.Size = new System.Drawing.Size(122, 21);
            this.dtpAccept.TabIndex = 60;
            // 
            // cbxName
            // 
            this.cbxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(256, 41);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(170, 20);
            this.cbxName.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 51;
            this.label16.Text = "付款情况：";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(538, 208);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(66, 21);
            this.txtSum.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 49;
            this.label15.Text = "总    计：";
            // 
            // txtServiceMoney
            // 
            this.txtServiceMoney.Location = new System.Drawing.Point(399, 208);
            this.txtServiceMoney.Name = "txtServiceMoney";
            this.txtServiceMoney.Size = new System.Drawing.Size(66, 21);
            this.txtServiceMoney.TabIndex = 48;
            // 
            // txtMaterialMoney
            // 
            this.txtMaterialMoney.Location = new System.Drawing.Point(262, 208);
            this.txtMaterialMoney.Name = "txtMaterialMoney";
            this.txtMaterialMoney.Size = new System.Drawing.Size(66, 21);
            this.txtMaterialMoney.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 43;
            this.label14.Text = "服 务 费：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(201, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "材 料 费：";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(81, 208);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(110, 21);
            this.txtMaterial.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "使用材料：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "服务评价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "处理结果：";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(81, 152);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(170, 21);
            this.txtResult.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "解决方案：";
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(82, 124);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(523, 21);
            this.txtSolution.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(253, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "受理时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "故障现象：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "服务类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "客户名称：";
            // 
            // txtNO
            // 
            this.txtNO.Location = new System.Drawing.Point(512, 9);
            this.txtNO.Name = "txtNO";
            this.txtNO.Size = new System.Drawing.Size(93, 21);
            this.txtNO.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(444, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务编号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户服务单";
            // 
            // frmService
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(639, 394);
            this.Controls.Add(this.cbxEmployee);
            this.Controls.Add(this.cbxTraffic);
            this.Controls.Add(this.dtpSolution);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(645, 422);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(645, 422);
            this.Name = "frmService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "客户服务单";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private LineTextBox txtSum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private LineTextBox txtServiceMoney;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private LineTextBox txtMaterial;
        private System.Windows.Forms.Button btnCancel;
        private LineTextBox txtMaterialMoney;
        private System.Windows.Forms.Label label7;
        private LineTextBox txtResult;
        private System.Windows.Forms.Label label6;
        private LineTextBox txtSolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private ShadowPanel panel1;
        private LineTextBox txtNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRight;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private LineComboBox cbxName;
        private LineDateTimePicker dtpAccept;
        private LineDateTimePicker dtpSolution;
        private System.Windows.Forms.ToolStripButton tsbCustomer;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private LineTextBox txtFault;
        private LineComboBox cbxType;
        private LineComboBox cbxEvaluate;
        private LineComboBox cbxPayStatus;
        private LineComboBox cbxTraffic;
        private LineComboBox cbxEmployee;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private LineComboBoxTree cbxCustomerGroup;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}