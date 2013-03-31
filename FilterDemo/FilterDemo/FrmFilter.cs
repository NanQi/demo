using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FilterDemo
{
   public partial class FrmFilter : Form
   {
      public FrmFilter()
      {
         InitializeComponent();
      }

      private DataTable _dtSource;

      public DataTable Data
      {
         get { return _dtSource; }
         set { _dtSource = value; }
      }

      private List<string> _lstCheck = new List<string>();

      public List<string> CheckList
      {
         get { return _lstCheck; }
         set { _lstCheck = value; }
      }
	

      private void FrmFilter_Load(object sender, EventArgs e)
      {
         SiftItem[] items = new SiftItem[4];
         items[0] = new SiftItem("编号", "编号", typeof(string));
         items[1] = new SiftItem("姓名", "姓名", typeof(string));
         items[2] = new SiftItem("工资", "工资", typeof(decimal));
         items[3] = new SiftItem("生日", "生日", typeof(DateTime));

         ucFilter1.Items = items;

         ucFilter1.Binding(Data, new string[0]);
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         for (int i = 0; i < _dtSource.Rows.Count; i++)
         {
            if (ucFilter1.IsCheckedOfSource[i])
            {
               _lstCheck.Add(_dtSource.Rows[i]["GUID"].ToString());
            }
         }

         this.DialogResult = DialogResult.OK;
         this.Close();
      }
   }
}