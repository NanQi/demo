namespace Elevator_Manager
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTitle
            // 
            this.pbxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbxTitle.Image")));
            this.pbxTitle.Location = new System.Drawing.Point(6 , 20);
            this.pbxTitle.Name = "pbxTitle";
            this.pbxTitle.Size = new System.Drawing.Size(365 , 125);
            this.pbxTitle.TabIndex = 6;
            this.pbxTitle.TabStop = false;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.pbxTitle);
            this.gbxInfo.Controls.Add(this.btnCancel);
            this.gbxInfo.Controls.Add(this.btnOk);
            this.gbxInfo.Controls.Add(this.txtLoginPwd);
            this.gbxInfo.Controls.Add(this.lblLoginPwd);
            this.gbxInfo.Controls.Add(this.txtLoginName);
            this.gbxInfo.Controls.Add(this.lblLoginName);
            this.gbxInfo.Location = new System.Drawing.Point(12 , 10);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(380 , 274);
            this.gbxInfo.TabIndex = 2;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "登陆信息";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(200 , 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75 , 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "退  出";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(105 , 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75 , 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "登  陆";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.BackColor = System.Drawing.SystemColors.Info;
            this.txtLoginPwd.Location = new System.Drawing.Point(158 , 196);
            this.txtLoginPwd.MaxLength = 20;
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(129 , 21);
            this.txtLoginPwd.TabIndex = 3;
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(93 , 199);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(59 , 12);
            this.lblLoginPwd.TabIndex = 2;
            this.lblLoginPwd.Text = "登陆密码:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.BackColor = System.Drawing.SystemColors.Info;
            this.txtLoginName.Location = new System.Drawing.Point(158 , 163);
            this.txtLoginName.MaxLength = 20;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(129 , 21);
            this.txtLoginName.TabIndex = 1;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(93 , 166);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(59 , 12);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "登陆名称:";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F , 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403 , 293);
            this.Controls.Add(this.gbxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTitle;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.ErrorProvider error;


    }
}