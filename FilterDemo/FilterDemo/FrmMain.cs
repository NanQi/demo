using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterDemo
{
   public partial class FrmMain : Form
   {
      DataGridViewBll dgvBLL;
      string _strWhere = string.Empty;

      public FrmMain()
      {
         InitializeComponent();

         dgvBLL = new DataGridViewBll(dataGridView1);

         btnSearch.Click += delegate
         {
            _strWhere = GetWhere();
            BindData();
         };

         btnFilter.Click += delegate
         {
            FrmSift frm = new FrmSift(this.dataGridView1, 1);
            DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;
            _strWhere = frm.StrWhere;
            BindData();
         };

         chbxList.Click += delegate
         {
            FrmFilter frm = new FrmFilter();
            frm.Data = SqlHelper.GetData(string.Empty);
            DialogResult result = frm.ShowDialog();
            chbxList.Checked = false;

            if (result == DialogResult.OK)
            {
               BindData();

               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                  if (frm.CheckList.Contains(dataGridView1.Rows[i].Cells["GUID"].Value.ToString()))
                  {
                     dataGridView1.Rows[i].Selected = true;
                  }
               }
            }
         };
      }

      /// <summary>
      /// 查询条件
      /// </summary>
      public string StrWhere
      {
         get { return _strWhere; }
         set { _strWhere = value; }
      }

      /// <summary>
      /// 获取条件
      /// </summary>
      /// <returns></returns>
      public string GetWhere()
      {
         StringBuilder strWhere = new StringBuilder();

         strWhere.AppendFormat("编号 LIKE '%{0}%'", SqlHelper.FormatSql(txtNO.Text.Trim()));

         return strWhere.ToString();
      }

      private void FrmMain_Load(object sender, EventArgs e)
      {
         BindData();
      }

      void BindData()
      {
         dataGridView1.DataSource = SqlHelper.GetData(string.Empty);

         dgvBLL.DataSource(SqlHelper.GetData(_strWhere));
         dgvBLL.dgv_ColumnsVisible(0, false);

         dgvBLL.dgv_ColumnsWidth(1, 100);
         dgvBLL.dgv_ColumnsWidth(2, 100);
         dgvBLL.dgv_ColumnsWidth(3, 100);
         dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

         dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
         dataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
         dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy年MM月dd日";
      }
   }
}