using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SQLBuilderDemo
{
    public class TablePanel : Panel
    {
        Relation _selectRelation = null;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiDelete;

        private RelationCollection _relations = new RelationCollection();

        public RelationCollection Relations
        {
            get { return _relations; }
            set { _relations = value; }
        }

        public TablePanel()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true); 
            SetStyle(ControlStyles.ResizeRedraw, true); 
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            Point sp;
            Point tp;
            ListView lvSource;
            ListView lvTarget;
            FrmTable frmSource;
            FrmTable frmTarget;

            Pen _penBorder = new Pen(Brushes.Black, 1);
            Pen _penHighlight = new Pen(new SolidBrush(SystemColors.Highlight), 2);
            Pen _pen = new Pen(Brushes.Black, 2);
            int offsetCheckboxWidth = 28;
            int offsetCheckboxHalfWidth = 8;
            int offsetLength = 20;

            Bitmap _bitmap = new Bitmap(28, 48);


            GraphicsPath path;

            Point centerPoint;

            Bitmap bitmap;
            Rectangle bitmapRect;

            bool isSelected = false;
            Bitmap selectBitmap = null;
            Rectangle selectBitmapRect = new Rectangle();

            foreach (Relation rela in _relations)
            {
                sp = rela.SourceItem.Position;
                tp = rela.TargetItem.Position;

                sp.Y += offsetCheckboxHalfWidth;
                tp.Y += offsetCheckboxHalfWidth;

                sp.X -= offsetCheckboxWidth;
                tp.X -= offsetCheckboxWidth;

                lvSource = rela.SourceItem.ListView;
                lvTarget = rela.TargetItem.ListView;

                if (lvSource == null || lvTarget == null) continue;

                frmSource = lvSource.Parent.Parent as FrmTable;
                frmTarget = lvTarget.Parent.Parent as FrmTable;

                if (frmSource == null || frmTarget == null) continue;

                sp = frmSource.PointToClient(lvSource.PointToScreen(sp));
                tp = frmTarget.PointToClient(lvTarget.PointToScreen(tp));

                if (sp.Y < 0) sp.Y = 0;
                if (sp.Y > frmSource.Height) sp.Y = frmSource.Height;

                if (tp.Y < 0) tp.Y = 0;
                if (tp.Y > frmTarget.Height) tp.Y = frmTarget.Height;

                sp = this.PointToClient(frmSource.PointToScreen(sp));
                tp = this.PointToClient(frmTarget.PointToScreen(tp));

                path = new GraphicsPath();

                if (sp.X > tp.X)
                {
                    tp.X += lvTarget.Parent.Parent.Width;
                    path.AddLine(tp, new Point(tp.X + offsetLength, tp.Y));

                    tp.X += offsetLength;
                    path.AddLine(tp, new Point(sp.X - offsetLength, sp.Y));
                    path.AddLine(new Point(sp.X - offsetLength, sp.Y), sp);

                    centerPoint = new Point((tp.X + sp.X - offsetLength) / 2, (tp.Y + sp.Y) / 2);
                }
                else
                {
                    sp.X += lvSource.Parent.Parent.Width;
                    path.AddLine(sp, new Point(sp.X + offsetLength, sp.Y));

                    sp.X += offsetLength;
                    path.AddLine(sp, new Point(tp.X - offsetLength, tp.Y));
                    path.AddLine(new Point(tp.X - offsetLength, tp.Y), tp);

                    centerPoint = new Point((sp.X + tp.X - offsetLength) / 2, (sp.Y + tp.Y) / 2);
                }

                e.Graphics.DrawPath(_pen, path);

                bitmap = rela.BufferImage.Clone() as Bitmap;
                bitmapRect = new Rectangle(
                    new Point(centerPoint.X - bitmap.Width / 2, centerPoint.Y - bitmap.Height / 2),
                    bitmap.Size);


                if (!isSelected && bitmapRect.Contains(this.PointToClient(MousePosition)))
                {
                    using (Graphics gBitmap = Graphics.FromImage(bitmap))
                    {
                        gBitmap.DrawRectangle(_penHighlight, 1, 1, 30, 50);
                    }

                    this.Cursor = Cursors.Hand;
                    isSelected = true;
                    selectBitmap = bitmap.Clone() as Bitmap;
                    selectBitmapRect = bitmapRect;

                    _selectRelation = rela;

                    continue;
                }
                else
                {
                    using (Graphics gBitmap = Graphics.FromImage(bitmap))
                    {
                        gBitmap.DrawRectangle(_penBorder, 2, 2, 28, 48);
                    }

                    this.Cursor = Cursors.Default;
                }

                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), bitmapRect);
                e.Graphics.DrawImageUnscaled(bitmap, bitmapRect);

            }//end foreach

            if (isSelected)
            {
                this.Cursor = Cursors.Hand;
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), selectBitmapRect);
                e.Graphics.DrawImageUnscaled(selectBitmap, selectBitmapRect);
            }
            else
            {
                _selectRelation = null;
            }

            base.OnPaint(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.Invalidate();
            base.OnMouseMove(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if ( _selectRelation != null) 
            {
                if (e.Button == MouseButtons.Left)
                {
                    tsmiEdit.PerformClick();
                }
                else
                {
                    contextMenuStrip1.Show(this.PointToScreen(new Point(e.X, e.Y)));
                }
            }

            base.OnMouseClick(e);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(106, 22);
            this.tsmiEdit.Text = "&Edit";
            this.tsmiEdit.Click += new EventHandler(tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(106, 22);
            this.tsmiDelete.Text = "&Delete";
            this.tsmiDelete.Click += new EventHandler(tsmiDelete_Click);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        void tsmiDelete_Click(object sender, EventArgs e)
        {
            _relations.Remove(_selectRelation);
            this.Cursor = Cursors.Default;
            this.Invalidate();
        }

        void tsmiEdit_Click(object sender, EventArgs e)
        {
            FrmRelation frm = new FrmRelation(_selectRelation);
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK) this.Invalidate();
        }
    }
}
