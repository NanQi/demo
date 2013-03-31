namespace FilterDemo
{
   partial class UCFilter
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

      #region 组件设计器生成的代码

      /// <summary> 
      /// 设计器支持所需的方法 - 不要
      /// 使用代码编辑器修改此方法的内容。
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFilter));
         this.linklblSift = new System.Windows.Forms.LinkLabel();
         this.linklblInvert = new System.Windows.Forms.LinkLabel();
         this.chbxAll = new System.Windows.Forms.CheckBox();
         this.lstCheckBox = new System.Windows.Forms.CheckedListBox();
         this.SuspendLayout();
         // 
         // linklblSift
         // 
         this.linklblSift.Image = ((System.Drawing.Image)(resources.GetObject("linklblSift.Image")));
         this.linklblSift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.linklblSift.Location = new System.Drawing.Point(125, 4);
         this.linklblSift.Name = "linklblSift";
         this.linklblSift.Size = new System.Drawing.Size(48, 23);
         this.linklblSift.TabIndex = 7;
         this.linklblSift.TabStop = true;
         this.linklblSift.Text = "筛选";
         this.linklblSift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.linklblSift.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSift_LinkClicked);
         // 
         // linklblInvert
         // 
         this.linklblInvert.Image = ((System.Drawing.Image)(resources.GetObject("linklblInvert.Image")));
         this.linklblInvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.linklblInvert.Location = new System.Drawing.Point(71, 4);
         this.linklblInvert.Name = "linklblInvert";
         this.linklblInvert.Size = new System.Drawing.Size(48, 23);
         this.linklblInvert.TabIndex = 6;
         this.linklblInvert.TabStop = true;
         this.linklblInvert.Text = "反选";
         this.linklblInvert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.linklblInvert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblInvert_LinkClicked);
         // 
         // chbxAll
         // 
         this.chbxAll.AutoCheck = false;
         this.chbxAll.AutoSize = true;
         this.chbxAll.Checked = true;
         this.chbxAll.CheckState = System.Windows.Forms.CheckState.Indeterminate;
         this.chbxAll.Location = new System.Drawing.Point(18, 7);
         this.chbxAll.Name = "chbxAll";
         this.chbxAll.Size = new System.Drawing.Size(48, 16);
         this.chbxAll.TabIndex = 5;
         this.chbxAll.Text = "全选";
         this.chbxAll.UseVisualStyleBackColor = true;
         this.chbxAll.Click += new System.EventHandler(this.chbxAll_Click);
         // 
         // lstCheckBox
         // 
         this.lstCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.lstCheckBox.BackColor = System.Drawing.SystemColors.Control;
         this.lstCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.lstCheckBox.CheckOnClick = true;
         this.lstCheckBox.FormattingEnabled = true;
         this.lstCheckBox.Location = new System.Drawing.Point(17, 30);
         this.lstCheckBox.Name = "lstCheckBox";
         this.lstCheckBox.Size = new System.Drawing.Size(240, 304);
         this.lstCheckBox.TabIndex = 4;
         // 
         // UCFilter
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.linklblSift);
         this.Controls.Add(this.linklblInvert);
         this.Controls.Add(this.chbxAll);
         this.Controls.Add(this.lstCheckBox);
         this.Name = "UCFilter";
         this.Size = new System.Drawing.Size(260, 337);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.LinkLabel linklblInvert;
      public System.Windows.Forms.CheckedListBox lstCheckBox;
      private System.Windows.Forms.CheckBox chbxAll;
      public System.Windows.Forms.LinkLabel linklblSift;
   }
}
