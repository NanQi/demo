namespace SQLBuilderDemo
{
    partial class FrmTable
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
            this.LsvFields = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsvFields
            // 
            this.LsvFields.AllowDrop = true;
            this.LsvFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvFields.AutoArrange = false;
            this.LsvFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvFields.CheckBoxes = true;
            this.LsvFields.FullRowSelect = true;
            this.LsvFields.HideSelection = false;
            this.LsvFields.Location = new System.Drawing.Point(3, 3);
            this.LsvFields.Name = "LsvFields";
            this.LsvFields.Size = new System.Drawing.Size(174, 274);
            this.LsvFields.TabIndex = 1;
            this.LsvFields.UseCompatibleStateImageBehavior = false;
            this.LsvFields.View = System.Windows.Forms.View.List;
            this.LsvFields.DragDrop += new System.Windows.Forms.DragEventHandler(this.LsvFields_DragDrop);
            this.LsvFields.DragEnter += new System.Windows.Forms.DragEventHandler(this.LsvFields_DragEnter);
            this.LsvFields.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LsvFields_ItemDrag);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.LsvFields);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 280);
            this.panel1.TabIndex = 2;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RelationLocationChanged);
            // 
            // FrmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(180, 280);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "表名";
            this.Load += new System.EventHandler(this.FrmTable_Load);
            this.SizeChanged += new System.EventHandler(this.RelationLocationChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTable_FormClosed);
            this.LocationChanged += new System.EventHandler(this.RelationLocationChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LsvFields;
        private System.Windows.Forms.Panel panel1;


    }
}