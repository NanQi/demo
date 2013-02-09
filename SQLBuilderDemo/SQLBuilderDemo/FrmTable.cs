using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQLBuilderDemo
{
    public partial class FrmTable : Form
    {
        private TablePanel _parentPanel;
        private TableData _table;

        public TableData Table
        {
            get { return _table; }
            set { _table = value; }
        }

        public FrmTable()
        {
            InitializeComponent();
        }

        public FrmTable(TableData table) : this()
        {
            this._table = table;
        }

        private void FrmTable_Load(object sender, EventArgs e)
        {
            if (_table == null)
            {
                throw new ArgumentNullException("Table");
            }

            LsvFields.Tag = _table;

            this.Text = _table.ToString();
            ListViewItem lvi;
            foreach (FieldData field in _table.Fields)
            {
                lvi = new ListViewItem(field.ToString());
                lvi.Tag = field;
                this.LsvFields.Items.Add(lvi);
            }

            TablePanel pnl = this.Parent as TablePanel;

            if (pnl != null)
            {
                _parentPanel = pnl;
            }

            LsvFields.Height = _table.Fields.Count * 17 + 20;
        }

        private void LsvFields_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListViewItem aitem = e.Item as ListViewItem;
            if ((e.Button == MouseButtons.Left) && (aitem != null))
            {
                aitem.Selected = true;
                this.LsvFields.DoDragDrop(aitem, DragDropEffects.Link);
            } 
        }

        private void LsvFields_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem sourceItem = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;

                if (!sourceItem.ListView.Parent.Parent.Equals(this))
                {
                    e.Effect = DragDropEffects.Link;
                    return;
                }
            }

            e.Effect = DragDropEffects.None;
        }

        private void LsvFields_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = LsvFields.PointToClient(new Point(e.X, e.Y));
            ListViewItem targetItem = LsvFields.GetItemAt(targetPoint.X, targetPoint.Y);
            if (targetItem == null) return;

            ListViewItem sourceItem =  e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
            if (sourceItem == null) return;

            targetItem.Selected = true;

            Relation rela = new Relation(sourceItem, targetItem);
            _parentPanel.Relations.Add(rela);
            _parentPanel.Invalidate();
        }

        private void RelationLocationChanged(object sender, EventArgs e)
        {
            if (_parentPanel != null)
            {
                _parentPanel.Invalidate();
            }
        }

        private void FrmTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = _parentPanel.Relations.Count - 1; i >= 0; i--)
            {
                if (_parentPanel.Relations[i].SourceItem.ListView.Parent.Parent.Equals(this) ||
                    _parentPanel.Relations[i].TargetItem.ListView.Parent.Parent.Equals(this))
                {
                    _parentPanel.Relations.RemoveAt(i);
                }
            }
        }
    }
}