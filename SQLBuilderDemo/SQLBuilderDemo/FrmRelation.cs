using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQLBuilderDemo
{
    public partial class FrmRelation : Form
    {
        Relation _relation;

        public FrmRelation()
        {
            InitializeComponent();
        }

        public FrmRelation(Relation rela) : this()
        {
            _relation = rela;
        }

        private void FrmRelation_Load(object sender, EventArgs e)
        {
            if (_relation == null)
            {
                throw new ArgumentNullException("Relation");
            }

            lblSourceField.Text = (_relation.SourceItem.Tag as FieldData).ValName;
            lblTargetField.Text = (_relation.TargetItem.Tag as FieldData).ValName;

            lblSourceTable.Text = (_relation.SourceItem.ListView.Tag as TableData).ValName;
            lblTargetTable.Text = (_relation.TargetItem.ListView.Tag as TableData).ValName;


            comboBox1.Items.AddRange(GolbalVar.RelationOperator);

            comboBox1.SelectedIndex = _relation.RelationOperatorIndex;

            switch (_relation.JoinType)
            {
                case SqlJoinTypeEnum.inner:
                    radioButton1.Checked = true;
                    break;
                case SqlJoinTypeEnum.left:
                    radioButton2.Checked = true;
                    break;
                case SqlJoinTypeEnum.right:
                    radioButton3.Checked = true;
                    break;
                case SqlJoinTypeEnum.full:
                    radioButton4.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            _relation.RelationOperatorIndex = comboBox1.SelectedIndex;

            SqlJoinTypeEnum joinType = SqlJoinTypeEnum.inner;
            if (radioButton1.Checked)
            {
                joinType = SqlJoinTypeEnum.inner;
            }
            else if (radioButton2.Checked)
            {
                joinType = SqlJoinTypeEnum.left;
            }
            else if (radioButton3.Checked)
            {
                joinType = SqlJoinTypeEnum.right;
            }
            else if (radioButton4.Checked)
            {
                joinType = SqlJoinTypeEnum.full;
            }

            _relation.JoinType = joinType;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}