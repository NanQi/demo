namespace WindowsFormsApplication1
{
    partial class WinFormPager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormPager));
            this.lblPager = new System.Windows.Forms.Label();
            this.lbPre = new System.Windows.Forms.Label();
            this.txtToPageIndex = new System.Windows.Forms.TextBox();
            this.lbEnd = new System.Windows.Forms.Label();
            this.imglstPager = new System.Windows.Forms.ImageList(this.components);
            this.btnToPageIndex = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tlt = new System.Windows.Forms.ToolTip(this.components);
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPager
            // 
            this.lblPager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPager.AutoSize = true;
            this.lblPager.Location = new System.Drawing.Point(13, 11);
            this.lblPager.Name = "lblPager";
            this.lblPager.Size = new System.Drawing.Size(287, 12);
            this.lblPager.TabIndex = 0;
            this.lblPager.Text = "总共{0}条记录,当前第{1}页,共{2}页,每页{3}条记录";
            // 
            // lbPre
            // 
            this.lbPre.AutoSize = true;
            this.lbPre.Location = new System.Drawing.Point(158, 12);
            this.lbPre.Name = "lbPre";
            this.lbPre.Size = new System.Drawing.Size(17, 12);
            this.lbPre.TabIndex = 5;
            this.lbPre.Text = "第";
            // 
            // txtToPageIndex
            // 
            this.txtToPageIndex.Location = new System.Drawing.Point(181, 7);
            this.txtToPageIndex.Name = "txtToPageIndex";
            this.txtToPageIndex.Size = new System.Drawing.Size(58, 21);
            this.txtToPageIndex.TabIndex = 6;
            this.txtToPageIndex.Text = "1";
            this.txtToPageIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtToPageIndex.Enter += new System.EventHandler(this.txtToPageIndex_Enter);
            this.txtToPageIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToPageIndex_KeyPress);
            this.txtToPageIndex.Leave += new System.EventHandler(this.txtToPageIndex_Leave);
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(242, 12);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(17, 12);
            this.lbEnd.TabIndex = 7;
            this.lbEnd.Text = "页";
            // 
            // imglstPager
            // 
            this.imglstPager.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstPager.ImageStream")));
            this.imglstPager.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstPager.Images.SetKeyName(0, "first.gif");
            this.imglstPager.Images.SetKeyName(1, "prev.gif");
            this.imglstPager.Images.SetKeyName(2, "next.gif");
            this.imglstPager.Images.SetKeyName(3, "last.gif");
            // 
            // btnToPageIndex
            // 
            this.btnToPageIndex.Location = new System.Drawing.Point(265, 6);
            this.btnToPageIndex.Name = "btnToPageIndex";
            this.btnToPageIndex.Size = new System.Drawing.Size(44, 23);
            this.btnToPageIndex.TabIndex = 8;
            this.btnToPageIndex.Text = "跳转";
            this.btnToPageIndex.UseVisualStyleBackColor = true;
            this.btnToPageIndex.Click += new System.EventHandler(this.btnToPageIndex_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnFirst);
            this.pnl.Controls.Add(this.btnToPageIndex);
            this.pnl.Controls.Add(this.btnPrevious);
            this.pnl.Controls.Add(this.lbEnd);
            this.pnl.Controls.Add(this.btnNext);
            this.pnl.Controls.Add(this.txtToPageIndex);
            this.pnl.Controls.Add(this.btnLast);
            this.pnl.Controls.Add(this.lbPre);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl.Location = new System.Drawing.Point(314, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(313, 35);
            this.pnl.TabIndex = 9;
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(3, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(35, 23);
            this.btnFirst.TabIndex = 1;
            this.tlt.SetToolTip(this.btnFirst, "首页");
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(41, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 23);
            this.btnPrevious.TabIndex = 2;
            this.tlt.SetToolTip(this.btnPrevious, "上一页");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(79, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 23);
            this.btnNext.TabIndex = 3;
            this.tlt.SetToolTip(this.btnNext, "下一页");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(117, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(35, 23);
            this.btnLast.TabIndex = 4;
            this.tlt.SetToolTip(this.btnLast, "尾页");
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // WinFormPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.lblPager);
            this.Name = "WinFormPager";
            this.Size = new System.Drawing.Size(627, 35);
            this.Load += new System.EventHandler(this.WinFormPager_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WinFormPager_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinFormPager_MouseMove);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPager;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lbPre;
        private System.Windows.Forms.TextBox txtToPageIndex;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Button btnToPageIndex;
        private System.Windows.Forms.ImageList imglstPager;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ToolTip tlt;
    }
}
