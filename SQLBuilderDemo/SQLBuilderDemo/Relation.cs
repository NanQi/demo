using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SQLBuilderDemo
{
    public class RelationCollection : List<Relation>
    {
        public RelationCollection()
            : base()
        {

        }

        public RelationCollection(int capacity)
            : base(capacity)
        {

        }

        public RelationCollection(IEnumerable<Relation> collection)
            : base(collection)
        {

        }
    }

    public class Relation
    {
        Bitmap _bufferImage;

        public Bitmap BufferImage
        {
            get
            {
                if (_bufferImage == null)
                {
                    _bufferImage = new Bitmap(32, 52);

                    using (Graphics g = Graphics.FromImage(_bufferImage))
                    {
                        Image img = Properties.Resources.ResourceManager.GetObject(_joinType.ToString()) as Image;
                        if (img != null) g.DrawImage(img, 4, 5, img.Width, img.Height);

                        SizeF size = g.MeasureString(GolbalVar.RelationOperator[_relationOperatorIndex], GolbalVar.font);
                        g.DrawString(GolbalVar.RelationOperator[_relationOperatorIndex], GolbalVar.font, new SolidBrush(Color.Black),
                            new PointF((32 - size.Width) / 2, 28));
                    }

                }
                return _bufferImage;
            }
        }

        private ListViewItem _source;

        public ListViewItem SourceItem
        {
            get { return _source; }
            set { _source = value; }
        }

        private ListViewItem _target;

        public ListViewItem TargetItem
        {
            get { return _target; }
            set { _target = value; }
        }

        private SqlJoinTypeEnum _joinType = SqlJoinTypeEnum.inner;

        public SqlJoinTypeEnum JoinType
        {
            get { return _joinType; }
            set
            {
                _joinType = value;
                _bufferImage = null;
            }
        }

        private int _relationOperatorIndex;

        public int RelationOperatorIndex
        {
            get { return _relationOperatorIndex; }
            set { _relationOperatorIndex = value; }
        }
	

        public Relation()
        {

        }

        public Relation(ListViewItem source, ListViewItem target)
            : this()
        {
            this._source = source;
            this._target = target;
        }
    }

    public enum SqlJoinTypeEnum
    {
        inner, left, right, full
    }

}

