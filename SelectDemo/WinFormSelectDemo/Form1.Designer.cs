namespace WinFormSelectDemo
{
    partial class Form1
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
            this.chbxList = new System.Windows.Forms.CheckedListBox();
            this.chbxAll = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbxList
            // 
            this.chbxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxList.CheckOnClick = true;
            this.chbxList.FormattingEnabled = true;
            this.chbxList.Items.AddRange(new object[] {
            "Data1",
            "Data1",
            "Data2",
            "Data2",
            "Data3",
            "Data3",
            "Data4",
            "Data4",
            "Data5",
            "Data5"});
            this.chbxList.Location = new System.Drawing.Point(12, 40);
            this.chbxList.Name = "chbxList";
            this.chbxList.Size = new System.Drawing.Size(268, 180);
            this.chbxList.TabIndex = 1;
            this.chbxList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chbxList_ItemCheck);
            // 
            // chbxAll
            // 
            this.chbxAll.AutoSize = true;
            this.chbxAll.Location = new System.Drawing.Point(14, 12);
            this.chbxAll.Name = "chbxAll";
            this.chbxAll.Size = new System.Drawing.Size(78, 16);
            this.chbxAll.TabIndex = 0;
            this.chbxAll.Text = "SelectAll";
            this.chbxAll.UseVisualStyleBackColor = true;
            this.chbxAll.CheckedChanged += new System.EventHandler(this.chbxAll_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(205, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chbxAll);
            this.Controls.Add(this.chbxList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chbxList;
        private System.Windows.Forms.CheckBox chbxAll;
        private System.Windows.Forms.Button btnExit;
    }
}

