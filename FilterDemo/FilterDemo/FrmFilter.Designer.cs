namespace FilterDemo
{
   partial class FrmFilter
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
         this.btnCancel = new NanQi.Controls.PinkieControls.ButtonXP();
         this.btnOK = new NanQi.Controls.PinkieControls.ButtonXP();
         this.ucFilter1 = new FilterDemo.UCFilter();
         this.SuspendLayout();
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnCancel.DefaultScheme = true;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Hint = "";
         this.btnCancel.Location = new System.Drawing.Point(202, 368);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Blue;
         this.btnCancel.Size = new System.Drawing.Size(75, 35);
         this.btnCancel.TabIndex = 1;
         this.btnCancel.Text = "取消(ES&C)";
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnOK.DefaultScheme = true;
         this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnOK.Hint = "";
         this.btnOK.Location = new System.Drawing.Point(121, 368);
         this.btnOK.Name = "btnOK";
         this.btnOK.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Blue;
         this.btnOK.Size = new System.Drawing.Size(75, 35);
         this.btnOK.TabIndex = 2;
         this.btnOK.Text = "确定(&A)";
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // ucFilter1
         // 
         this.ucFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.ucFilter1.IsCheckedOfSource = null;
         this.ucFilter1.Items = null;
         this.ucFilter1.Location = new System.Drawing.Point(12, 12);
         this.ucFilter1.Name = "ucFilter1";
         this.ucFilter1.Size = new System.Drawing.Size(260, 337);
         this.ucFilter1.TabIndex = 0;
         // 
         // FrmFilter
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(289, 415);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.ucFilter1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmFilter";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "列表选择";
         this.Load += new System.EventHandler(this.FrmFilter_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private UCFilter ucFilter1;
      private NanQi.Controls.PinkieControls.ButtonXP btnCancel;
      private NanQi.Controls.PinkieControls.ButtonXP btnOK;

   }
}