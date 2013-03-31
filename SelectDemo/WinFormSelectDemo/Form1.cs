using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormSelectDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbxAll_CheckedChanged(object sender, EventArgs e)
        {
            chbxList.ItemCheck -= this.chbxList_ItemCheck; 

            for (int i = 0; i < chbxList.Items.Count; i++)
            {
                chbxList.SetItemChecked(i, chbxAll.Checked);
            }

            chbxList.ItemCheck += this.chbxList_ItemCheck; 
        }

        private void chbxList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.chbxAll.CheckedChanged -= this.chbxAll_CheckedChanged;

            if (e.NewValue == CheckState.Checked && chbxList.CheckedItems.Count + 1 >= chbxList.Items.Count)
            {
                chbxAll.CheckState = CheckState.Checked;
            }
            else if (e.NewValue == CheckState.Unchecked && chbxList.CheckedItems.Count - 1 <= 0)
            {
                chbxAll.CheckState = CheckState.Unchecked;
            }
            else
            {
                chbxAll.CheckState = CheckState.Indeterminate;
            }

            this.chbxAll.CheckedChanged += this.chbxAll_CheckedChanged;
        }
    }
}
