namespace FilterDemo
{
   partial class FrmMain
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.txtNO = new NanQi.Controls.TextBoxExtend();
         this.btnSearch = new NanQi.Controls.PinkieControls.ButtonXP();
         this.btnFilter = new NanQi.Controls.PinkieControls.ButtonXP();
         this.chbxList = new System.Windows.Forms.CheckBox();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
         this.dataGridView1.Location = new System.Drawing.Point(12, 59);
         this.dataGridView1.Name = "dataGridView1";
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
         this.dataGridView1.RowTemplate.Height = 23;
         this.dataGridView1.Size = new System.Drawing.Size(491, 268);
         this.dataGridView1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 26);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(41, 12);
         this.label1.TabIndex = 1;
         this.label1.Text = "编号：";
         // 
         // txtNO
         // 
         this.txtNO.inputType = NanQi.Controls.InputType.None;
         this.txtNO.Location = new System.Drawing.Point(59, 22);
         this.txtNO.Name = "txtNO";
         this.txtNO.Size = new System.Drawing.Size(150, 21);
         this.txtNO.TabIndex = 2;
         // 
         // btnSearch
         // 
         this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnSearch.DefaultScheme = true;
         this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnSearch.Hint = "";
         this.btnSearch.Location = new System.Drawing.Point(229, 15);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Blue;
         this.btnSearch.Size = new System.Drawing.Size(75, 35);
         this.btnSearch.TabIndex = 3;
         this.btnSearch.Text = "查询(F5)";
         // 
         // btnFilter
         // 
         this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
         this.btnFilter.DefaultScheme = true;
         this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.None;
         this.btnFilter.Hint = "";
         this.btnFilter.Location = new System.Drawing.Point(310, 15);
         this.btnFilter.Name = "btnFilter";
         this.btnFilter.Scheme = NanQi.Controls.PinkieControls.ButtonXP.Schemes.Blue;
         this.btnFilter.Size = new System.Drawing.Size(100, 35);
         this.btnFilter.TabIndex = 4;
         this.btnFilter.Text = "高级查找(F5)";
         // 
         // chbxList
         // 
         this.chbxList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.chbxList.Appearance = System.Windows.Forms.Appearance.Button;
         this.chbxList.Location = new System.Drawing.Point(440, 15);
         this.chbxList.Name = "chbxList";
         this.chbxList.Size = new System.Drawing.Size(63, 35);
         this.chbxList.TabIndex = 5;
         this.chbxList.Text = "列表选择";
         this.chbxList.UseVisualStyleBackColor = true;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(515, 339);
         this.Controls.Add(this.chbxList);
         this.Controls.Add(this.btnFilter);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.txtNO);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataGridView1);
         this.DoubleBuffered = true;
         this.MinimumSize = new System.Drawing.Size(523, 366);
         this.Name = "FrmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "筛选";
         this.Load += new System.EventHandler(this.FrmMain_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Label label1;
      private NanQi.Controls.TextBoxExtend txtNO;
      private NanQi.Controls.PinkieControls.ButtonXP btnSearch;
      private NanQi.Controls.PinkieControls.ButtonXP btnFilter;
      private System.Windows.Forms.CheckBox chbxList;
   }
}