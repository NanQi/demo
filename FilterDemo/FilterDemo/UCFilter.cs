
/* By NanQi 201209 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FilterDemo
{
   ///赋权筛选
   public partial class UCFilter : UserControl
   {
      ///这里对数据源进行两个存储，将选择与否专门存在一个bool[]中
      private DataTable _dtSource;
      private bool[] _isCheckedOfSource;
      private SiftItem[] _items;
      private string _filter;

      public UCFilter()
      {
         InitializeComponent();
      }

      public SiftItem[] Items
      {
         get { return _items; }
         set { _items = value; }
      }

      public bool[] IsCheckedOfSource
      {
         get { return _isCheckedOfSource; }
         set { _isCheckedOfSource = value; }
      }
      /// <summary>
      /// 绑定数据源 符合entitysimple规则,列依次为GUID/Code/Name/...
      /// </summary>
      /// <param name="dtSource"></param>
      /// <param name="checkGUIDs"></param>
      /// <exception cref="ArgumentNullException"></exception>
      public void Binding(DataTable dtSource, string[] checkGUIDs)
      {
         if (dtSource == null) throw new ArgumentNullException("dtSource");

         _dtSource = dtSource;
         _isCheckedOfSource = new bool[dtSource.Rows.Count];

         if (checkGUIDs.Length == dtSource.Rows.Count)
         {
            chbxAll.CheckState = CheckState.Checked;
         }
         else if (checkGUIDs.Length == 0)
         {
            chbxAll.CheckState = CheckState.Unchecked;            
         }
         else
         {
            chbxAll.CheckState = CheckState.Indeterminate;            
         }

         for (int i = 0; i < _dtSource.Rows.Count; i++)
         {
            _isCheckedOfSource[i] = Array.IndexOf(checkGUIDs, _dtSource.Rows[i][0].ToString()) != -1;
            EntityCheckedBox entity = new EntityCheckedBox(_dtSource.Rows[i], _isCheckedOfSource[i], i);
            lstCheckBox.Items.Add(entity, entity.IsChecked);
         }

         this.lstCheckBox.ItemCheck += this.lstCheckBox_ItemCheck;
         this.lstCheckBox.ItemCheck += this.lstCheckBox_ItemCheck_Checked;
         this.chbxAll.CheckStateChanged +=  this.chbxAll_CheckStateChanged;
      }

      void BindData()
      {
         if (_dtSource == null) throw new ArgumentNullException("请使用Binding方法绑定");

         this.lstCheckBox.ItemCheck -= this.lstCheckBox_ItemCheck_Checked;

         this.chbxAll.CheckStateChanged -= this.chbxAll_CheckStateChanged;
         chbxAll.CheckState = CheckState.Unchecked;
         this.chbxAll.CheckStateChanged += this.chbxAll_CheckStateChanged;

         lstCheckBox.Items.Clear();

         DataRow[] rows = _dtSource.Select(_filter);

         for (int i = 0; i < rows.Length; i++)
         {
            int index = _dtSource.Rows.IndexOf(rows[i]);
            EntityCheckedBox entity = new EntityCheckedBox(rows[i], _isCheckedOfSource[index], index);
            lstCheckBox.Items.Add(entity, entity.IsChecked);
         }

         this.lstCheckBox.ItemCheck += this.lstCheckBox_ItemCheck_Checked;
      }
      
      ///全选，自行处理选择方式，为Indeterminate时让选择
      private void chbxAll_Click(object sender, EventArgs e)
      {
         switch (chbxAll.CheckState)
         {
            case CheckState.Checked:
               chbxAll.CheckState = CheckState.Unchecked;
               break;
            case CheckState.Unchecked:
               chbxAll.CheckState = CheckState.Checked;
               break;
            case CheckState.Indeterminate:
               chbxAll.CheckState = CheckState.Checked;
               break;
            default:
               chbxAll.CheckState = CheckState.Indeterminate;
               break;
         }
      }

      ///当Item选择时，这里处理了相互影响的事件，主要控制上方全选按钮的选中状态
      private void lstCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
      {
         this.chbxAll.CheckStateChanged -= this.chbxAll_CheckStateChanged;

         if (e.NewValue == CheckState.Checked && lstCheckBox.CheckedItems.Count + 1 >= lstCheckBox.Items.Count)
         {
            chbxAll.CheckState = CheckState.Checked;
         }
         else if (e.NewValue == CheckState.Unchecked && lstCheckBox.CheckedItems.Count - 1 <= 0)
         {
            chbxAll.CheckState = CheckState.Unchecked;
         }
         else
         {
            chbxAll.CheckState = CheckState.Indeterminate;
         }

         this.chbxAll.CheckStateChanged += this.chbxAll_CheckStateChanged;
      }

      ///这个与上面的事件不同之处，只是用来保存选择的集合
      private void lstCheckBox_ItemCheck_Checked(object sender, ItemCheckEventArgs e)
      {
         this.chbxAll.CheckStateChanged -= this.chbxAll_CheckStateChanged;

         EntityCheckedBox entity = lstCheckBox.Items[e.Index] as EntityCheckedBox;
         _isCheckedOfSource[entity.IndexOfSource] = e.NewValue == CheckState.Checked;

         this.chbxAll.CheckStateChanged += this.chbxAll_CheckStateChanged;
      }

      ///响应全选状态对下面Item的影响
      private void chbxAll_CheckStateChanged(object sender, EventArgs e)
      {
         this.lstCheckBox.ItemCheck -= this.lstCheckBox_ItemCheck;

         switch (chbxAll.CheckState)
         {
            case CheckState.Checked:
               for (int i = 0; i < lstCheckBox.Items.Count; i++)
               {
                  lstCheckBox.SetItemChecked(i, true);
               }
               break;
            case CheckState.Unchecked:
               for (int i = 0; i < lstCheckBox.Items.Count; i++)
               {
                  lstCheckBox.SetItemChecked(i, false);
               }
               break;
            default:
               break;
         }

         this.lstCheckBox.ItemCheck += this.lstCheckBox_ItemCheck;
      }

      ///反选
      private void linklblInvert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         this.chbxAll.CheckStateChanged -= this.chbxAll_CheckStateChanged;
         this.lstCheckBox.ItemCheck -= this.lstCheckBox_ItemCheck;

         int[] indexs = new int[lstCheckBox.CheckedItems.Count];
         lstCheckBox.CheckedIndices.CopyTo(indexs, 0);

         for (int i = 0; i < lstCheckBox.Items.Count; i++)
         {
            lstCheckBox.SetItemChecked(i, Array.IndexOf(indexs, i) == -1);
         }

         if (indexs.Length == 0)
         {
            chbxAll.CheckState = CheckState.Checked;
         }
         else if (indexs.Length == lstCheckBox.Items.Count)
         {
            chbxAll.CheckState = CheckState.Unchecked;
         }

         this.lstCheckBox.ItemCheck += this.lstCheckBox_ItemCheck;
         this.chbxAll.CheckStateChanged += this.chbxAll_CheckStateChanged;
      }

      ///筛选，使用DataTable的Select方法筛选
      private void linklblSift_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         if (Items == null)
         {
            Items = new SiftItem[_dtSource.Columns.Count];

            for (int i = 0; i < _dtSource.Columns.Count; i++)
            {
               Items[i] = new SiftItem();
               Items[i].Display = _dtSource.Columns[i].ColumnName;
               Items[i].Value = _dtSource.Columns[i].ColumnName;
               Items[i].SiftType = SiftTypeEnum.Text;
            }
         }

         FrmSift frm = new FrmSift(Items);
         frm.Text = "筛选";
         frm.ShowDialog();

         if (frm.DialogResult != DialogResult.OK) return;
         _filter = frm.StrWhere;
         BindData();
      }
   }
}
