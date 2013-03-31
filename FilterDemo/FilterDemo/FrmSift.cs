
/* By NanQi 201209 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FilterDemo
{
   ///筛选
   public partial class FrmSift : Form
   {
      private decimal dec_01;
      private decimal dec_02;
      private SiftItem[] items;
      private string strWhere = string.Empty;

      ///重载构造函数，使用SiftItem[]构造
      public FrmSift(SiftItem[] items)
      {
         InitializeComponent();
         this.items = items;
      }

      ///重载构造函数，根据所给dgv转换为SiftItem，传入Indexs可隐藏不想显示的列（某些列不需要显示，比如经过转换后的列【1.是 0.否】）
      public FrmSift(DataGridView dgv, params int[] indexs)
      {
         InitializeComponent();

         List<SiftItem> lst = new List<SiftItem>();

         for (int i = 0; i < dgv.Columns.Count; i++)
         {
            if (!dgv.Columns[i].Visible) continue;
            if (indexs != null && Array.IndexOf(indexs, i) != -1) continue;
            if (dgv.Columns[i].ValueType == null)
            {
               continue;
            }

            SiftItem item = new SiftItem(dgv.Columns[i].HeaderText, dgv.Columns[i].Name, dgv.Columns[i].ValueType);

            lst.Add(item);
         }

         items = lst.ToArray();
      }

      ///获取或设置条件
      public string StrWhere
      {
         get { return strWhere; }
         set { strWhere = value; }
      }

      ///获取或设置当前SiftItems
      public SiftItem[] Items
      {
         get { return items; }
         set { items = value; }
      }

      ///索引器
      public SiftItem this[int index]
      {
         get { return items[index]; }
      }

      private void FrmSift_Load(object sender, EventArgs e)
      {
         tsmiA_Click(null, null);

         lvItems.Items.Clear();
         lvResult.Items.Clear();

         for (int i = 0; i < items.Length; i++)
         {
            ListViewItem item = new ListViewItem();
            item.Text = items[i].Display;
            item.Name = items[i].Value;
            item.Tag = items[i].SiftType;
            lvItems.Items.Add(item);
         }

         if (items.Length != 0)
         {
            lvItems.Items[0].Selected = true;
         }
      }

      ///当选择Item时，根据选择SiftItem的Type属性判断，显示不同的去展示
      private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (lvItems.SelectedItems == null || lvItems.SelectedItems.Count != 1) return;
         ListViewItem item = lvItems.SelectedItems[0];

         lblName.Text = item.Text + ":";

         SiftTypeEnum siftType = (SiftTypeEnum)item.Tag;

         switch (siftType)
         {
            case SiftTypeEnum.Text:
               pnlText.Visible = true;
               pnlDate.Visible = false;
               pnlMoney.Visible = false;
               break;
            case SiftTypeEnum.Date:
               pnlText.Visible = false;
               pnlDate.Visible = true;
               pnlMoney.Visible = false;
               break;
            case SiftTypeEnum.Money:
               pnlText.Visible = false;
               pnlDate.Visible = false;
               pnlMoney.Visible = true;
               break;
            default:
               pnlText.Visible = true;
               pnlDate.Visible = false;
               pnlMoney.Visible = false;
               break;
         }

         txtText.Clear();

         tsmiA_Click(null, null);

         txtMoney1.Text = "0.00";
         txtMoney2.Text = "0.00";

         dec_01 = 0;
         dec_02 = 0;
      }

      private void txtMoney1_Leave(object sender, EventArgs e)
      {
         if (txtMoney1.Text.Trim().Length == 0)
         {
            txtMoney1.Text = "0.00";
         }
         else
         {
            if (!decimal.TryParse(txtMoney1.Text.Trim(), out dec_01))
            {
               MessageBox.Show("请输入正确的数值");
               return;
            }
         }
      }

      private void txtMoney2_Leave(object sender, EventArgs e)
      {
         if (txtMoney2.Text.Trim().Length == 0)
         {
            txtMoney2.Text = "0.00";
         }
         else
         {
            if (!decimal.TryParse(txtMoney2.Text.Trim(), out dec_02))
            {
               MessageBox.Show("请输入正确的数值");
               return;
            }
         }
      }

      ///当文本按钮被点击
      private void btnText_Click(object sender, EventArgs e)
      {
         if (lvItems.SelectedItems == null || lvItems.SelectedItems.Count != 1) return;
         int index = lvItems.SelectedIndices[0];

         string name = lvItems.SelectedItems[0].Text;

         string strOperator1;
         string strOperator2;

         if (rbtn1.Checked)
         {
            strOperator1 = "包含";
            strOperator2 = "LIKE";
         }
         else
         {
            strOperator1 = "等于";
            strOperator2 = "=";
         }

         string display = txtText.Text.Trim();
         string value = string.Format("'{0}'", SqlHelper.FormatSql(txtText.Text.Trim()));

         if (string.IsNullOrEmpty(value))
         {
            MessageBox.Show("条件值不能为空!");
            return;
         }

         ListViewItem item = new ListViewItem();
         item.Text = name;
         item.Name = lvItems.SelectedItems[0].Name;
         item.Tag = index;

         ListViewItem.ListViewSubItem subItemOperator = new ListViewItem.ListViewSubItem();
         subItemOperator.Text = strOperator1;
         subItemOperator.Tag = strOperator2;

         ListViewItem.ListViewSubItem subItemValue = new ListViewItem.ListViewSubItem();
         subItemValue.Text = display;
         subItemValue.Tag = value;

         item.SubItems.Add(subItemOperator);
         item.SubItems.Add(subItemValue);

         for (int i = lvResult.Items.Count - 1; i >= 0; i--)
         {
            if (lvResult.Items[i].Tag.ToString() == index.ToString())
            {
               lvResult.Items[i].Remove();
            }
         }

         lvResult.Items.Add(item);
      }
      ///日期按钮点击事件，这里只适用于Demo
      private void btnDate_Click(object sender, EventArgs e)
      {
         if (lvItems.SelectedItems == null || lvItems.SelectedItems.Count != 1) return;
         int index = lvItems.SelectedIndices[0];

         string text = lvItems.SelectedItems[0].Text;
         string name = string.Format("{0}", lvItems.SelectedItems[0].Name);
         string display1 = dtpStart.Value.ToString("yyyy-MM-dd HH:mm:ss");
         string value1 = string.Format("'{0}'", dtpStart.Value.ToString("yyyy-MM-dd"));
         string display2 = dtpEnd.Value.ToString("yyyy-MM-dd HH:mm:ss");
         string value2 = string.Format("'{0}'", dtpEnd.Value.ToString("yyyy-MM-dd"));

         if (string.IsNullOrEmpty(value1) || string.IsNullOrEmpty(value2))
         {
            MessageBox.Show("条件值不能为空!");
            return;
         }

         ListViewItem item1 = new ListViewItem();
         item1.Text = text;
         item1.Name = name;
         item1.Tag = index;

         ListViewItem.ListViewSubItem subItemOperator1 = new ListViewItem.ListViewSubItem();
         subItemOperator1.Text = "从";
         subItemOperator1.Tag = ">";

         ListViewItem.ListViewSubItem subItemValue1 = new ListViewItem.ListViewSubItem();
         subItemValue1.Text = display1;
         subItemValue1.Tag = value1;

         item1.SubItems.Add(subItemOperator1);
         item1.SubItems.Add(subItemValue1);

         ListViewItem item2 = new ListViewItem();
         item2.Text = text;
         item2.Name = name;
         item2.Tag = index;

         ListViewItem.ListViewSubItem subItemOperator2 = new ListViewItem.ListViewSubItem();
         subItemOperator2.Text = "至";
         subItemOperator2.Tag = "<";

         ListViewItem.ListViewSubItem subItemValue2 = new ListViewItem.ListViewSubItem();
         subItemValue2.Text = display2;
         subItemValue2.Tag = value2;

         item2.SubItems.Add(subItemOperator2);
         item2.SubItems.Add(subItemValue2);

         for (int i = lvResult.Items.Count - 1; i >= 0; i--)
         {
            if (lvResult.Items[i].Tag.ToString() == index.ToString())
            {
               lvResult.Items[i].Remove();
            }
         }

         lvResult.Items.Add(item1);
         lvResult.Items.Add(item2);
      }

      ///数字按钮点击事件
      private void btnMoney_Click(object sender, EventArgs e)
      {
         if (lvItems.SelectedItems == null || lvItems.SelectedItems.Count != 1) return;
         int index = lvItems.SelectedIndices[0];

         string text = lvItems.SelectedItems[0].Text;
         string name = string.Format("{0}", lvItems.SelectedItems[0].Name);
         string display1 = dec_01.ToString();
         string value1 = SqlHelper.FormatSql(dec_01.ToString());
         string display2 = dec_02.ToString();
         string value2 = SqlHelper.FormatSql(dec_02.ToString());


         txtMoney1_Leave(null, null);
         txtMoney2_Leave(null, null);

         ListViewItem item1 = new ListViewItem();
         item1.Text = text;
         item1.Name = name;
         item1.Tag = index;

         ListViewItem.ListViewSubItem subItemOperator1 = new ListViewItem.ListViewSubItem();
         subItemOperator1.Text = "从";
         subItemOperator1.Tag = ">";

         ListViewItem.ListViewSubItem subItemValue1 = new ListViewItem.ListViewSubItem();
         subItemValue1.Text = display1;
         subItemValue1.Tag = value1;

         item1.SubItems.Add(subItemOperator1);
         item1.SubItems.Add(subItemValue1);

         ListViewItem item2 = new ListViewItem();
         item2.Text = text;
         item2.Name = name;
         item2.Tag = index;

         ListViewItem.ListViewSubItem subItemOperator2 = new ListViewItem.ListViewSubItem();
         subItemOperator2.Text = "至";
         subItemOperator2.Tag = "<";

         ListViewItem.ListViewSubItem subItemValue2 = new ListViewItem.ListViewSubItem();
         subItemValue2.Text = display2;
         subItemValue2.Tag = value2;

         item2.SubItems.Add(subItemOperator2);
         item2.SubItems.Add(subItemValue2);

         for (int i = lvResult.Items.Count - 1; i >= 0; i--)
         {
            if (lvResult.Items[i].Tag.ToString() == index.ToString())
            {
               lvResult.Items[i].Remove();
            }
         }

         lvResult.Items.Add(item1);
         lvResult.Items.Add(item2);
      }

      private void btnReset_Click(object sender, EventArgs e)
      {
         lvResult.Items.Clear();
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         for (int i = 0; i < lvResult.SelectedItems.Count; i++)
         {
            string index = lvResult.SelectedItems[i].Tag.ToString();

            for (int j = lvResult.Items.Count - 1; j >= 0; j--)
            {
               if (index == lvResult.Items[j].Tag.ToString())
               {
                  lvResult.Items[j].Remove();
               }
            }
         }
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         StringBuilder sb = new StringBuilder();

         for (int i = 0; i < lvResult.Items.Count; i++)
         {
            string name = lvResult.Items[i].Name;
            string oper = lvResult.Items[i].SubItems[1].Tag.ToString();
            string value = lvResult.Items[i].SubItems[2].Tag.ToString();

            //过滤
            if (name.Contains("/"))
            {
               name = string.Format("[{0}]", name);
            }

            if (oper == "LIKE")
            {
               StringBuilder strText = new StringBuilder(value);
               strText.Remove(value.Length - 1, 1);
               strText.Remove(0, 1);
               strText.Insert(0, "'%");
               strText.Append("%'");
               value = strText.ToString();
            }

            if (i == 0)
            {
               sb.AppendFormat("{0} {1} {2}", name, oper, value);
            }
            else
            {
               //if (lvResult.Items[i].Tag.ToString() == lvResult.Items[i - 1].Tag.ToString())
               //{
               //   sb.AppendFormat(" {0} {1}", oper, value);
               //}
               //else
               //{
               sb.AppendFormat(" AND {0} {1} {2}", name, oper, value);
               //}
            }
         }

         strWhere = sb.ToString();

         DialogResult = DialogResult.OK;
         Close();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Close();
      }

      #region 下拉菜单

      private void tsmiA_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         dtpStart.Value = dt;
         dtpEnd.Value = dt.AddDays(1);
      }

      private void tsmiB_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         dtpStart.Value = dt.AddDays(-1);
         dtpEnd.Value = dt;
      }

      private void tsmiC_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         dtpStart.Value = dt.AddDays(-2);
         dtpEnd.Value = dt.AddDays(-1);
      }

      private void tsmiD_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d"))); //本周周一
         DateTime endWeek = startWeek.AddDays(7); //本周周日
         dtpStart.Value = startWeek;
         dtpEnd.Value = endWeek;
      }

      private void tsmiE_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d"))).AddDays(-7);
         DateTime endWeek = startWeek.AddDays(7);
         dtpStart.Value = startWeek;
         dtpEnd.Value = endWeek;
      }

      private void tsmiF_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startMonth = dt.AddDays(1 - dt.Day); //本月月初
         DateTime endMonth = startMonth.AddMonths(1); //本月月末
         dtpStart.Value = startMonth;
         dtpEnd.Value = endMonth;
      }

      private void tsmiG_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startMonth = dt.AddDays(1 - dt.Day);
         DateTime endMonth = startMonth.AddDays(10);
         dtpStart.Value = startMonth;
         dtpEnd.Value = endMonth;
      }

      private void tsmiH_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startMonth = dt.AddDays(1 - dt.Day).AddDays(10);
         DateTime endMonth = startMonth.AddDays(10);
         dtpStart.Value = startMonth;
         dtpEnd.Value = endMonth;
      }

      private void tsmiI_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startMonth = dt.AddDays(1 - dt.Day);
         DateTime endMonth = startMonth.AddMonths(1);
         dtpStart.Value = startMonth.AddDays(20);
         dtpEnd.Value = endMonth;
      }

      private void tsmiJ_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startMonth = dt.AddDays(1 - dt.Day).AddMonths(-1);
         DateTime endMonth = startMonth.AddMonths(1);
         dtpStart.Value = startMonth;
         dtpEnd.Value = endMonth;
      }

      private void tsmiK_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startQuarter = dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day); //本季度初
         DateTime endQuarter = startQuarter.AddMonths(3); //本季度末

         dtpStart.Value = startQuarter;
         dtpEnd.Value = endQuarter;
      }

      private void tsmiL_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startQuarter = dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day).AddMonths(-3);
         DateTime endQuarter = startQuarter.AddMonths(3);

         dtpStart.Value = startQuarter;
         dtpEnd.Value = endQuarter;
      }

      private void tsmiM_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startYear = new DateTime(dt.Year, 1, 1); //本年年初
         DateTime endYear = new DateTime(dt.Year + 1, 1, 1); //本年年末
         dtpStart.Value = startYear;
         dtpEnd.Value = endYear;
      }

      private void tsmiN_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startYear = new DateTime(dt.Year - 1, 1, 1);
         DateTime endYear = new DateTime(dt.Year, 1, 1);
         dtpStart.Value = startYear;
         dtpEnd.Value = endYear;
      }

      private void tsmiO_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         dtpStart.Value = dt.AddDays(-7);
         dtpEnd.Value = dt.AddDays(1);
      }

      private void tsmiP_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         dtpStart.Value = dt.AddMonths(-1);
         dtpEnd.Value = dt.AddDays(1);
      }

      private void tsmiQ_Click(object sender, EventArgs e)
      {
         DateTime dt = DateTime.Now.Date;
         DateTime startMonth = dt.AddDays(1 - dt.Day);
         dtpStart.Value = startMonth;
         dtpEnd.Value = dt.AddDays(1);
      }

      #endregion

      private void txtText_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            btnText.PerformClick();
         }
      }
   }

   ///SiftItem类
   public class SiftItem
   {
      private string _display;
      private string _value;
      private SiftTypeEnum _siftType = SiftTypeEnum.Text;

      public SiftItem()
      {
      }

      //public SiftItem(string name, SiftTypeEnum siftType)
      //{
      //   Name = name;
      //   SiftType = siftType;
      //}

      ///根据所给Type分类，这里使用类型的ToString方法去判断，不是一种好的做法
      public SiftItem(string display, string value, Type type)
      {
         this._display = display;
         this._value = value;

         SiftTypeEnum siftType;

         switch (type.ToString())
         {
            case "System.Int16":
            case "System.Int32":
            case "System.Int64":
            case "System.Single":
            case "System.Double":
            case "System.Decimal":
               siftType = SiftTypeEnum.Money;
               break;
            case "System.DateTime":
               siftType = SiftTypeEnum.Date;
               break;
            default:
               siftType = SiftTypeEnum.Text;
               break;
         }

         SiftType = siftType;
      }

      public string Display
      {
         get { return _display; }
         set { _display = value; }
      }

      public string Value
      {
         get { return _value; }
         set { _value = value; }
      }

      public SiftTypeEnum SiftType
      {
         get { return _siftType; }
         set { _siftType = value; }
      }
   }
   ///SiftItem的Type枚举类型,现在主要分为文本/时间/数字
   public enum SiftTypeEnum
   {
      Text,
      Date,
      Money
   }
}