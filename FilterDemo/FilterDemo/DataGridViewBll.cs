
/* By NanQi 201209 modify Internet */

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace FilterDemo
{
   public class DataGridViewBll
   {
      /// <summary>
      /// 要设置的DataGridView
      /// </summary>
      private DataGridView dgv;

      /// <summary>
      /// 显示DataGridView数据的TextBox集合
      /// </summary>
      /// <summary>
      /// 设置数据编号显示X坐标距离
      /// </summary>
      private const int iX = 10;

      /// <summary>
      /// 设置数据编号显示Y坐标距离
      /// </summary>
      private const int iY = 5;


      /// <summary>
      /// 带参的构造函数
      /// </summary>
      /// <param name="dgvIN">要操作的DataGridView</param>
      public DataGridViewBll(DataGridView dgvIN)
      {
         Add(dgvIN);
      }

      /// <summary>
      /// 添加DataGridView到业务处理类中
      /// </summary>
      /// <param name="dgvIN">要操作的DataGridView</param>
      public void Add(DataGridView dgvIN)
      {
         dgv = dgvIN;

         //注册事件
         dgv.CellPainting += dgv_CellPainting;
         dgv.RowPostPaint += dgv_RowPostPaint;
         //dgv.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_CellMouseDoubleClick);   


         dgv.ReadOnly = true;
      }

      /// <summary>
      /// 添加数据集到DataGridView
      /// </summary>
      /// <param name="obj">数据集</param>
      public void DataSource(object obj)
      {
         dgv.DataSource = obj;

         //控件显示设置
         dgv_Style();
      }

      #region 外观设置

      /// <summary>
      /// 设置列显示  -- 必须放在dataGridView数据读取后
      /// </summary>
      public void dgv_ColumnsVisible(int iColumn, bool isVisible)
      {
         dgv.Columns[iColumn].Visible = isVisible;
      }

      /// <summary>
      /// 设置列显示  -- 必须放在dataGridView数据1读取后
      /// </summary>
      public void dgv_ColumnsText(int iColumn, string headerText)
      {
         dgv.Columns[iColumn].HeaderText = headerText;
      }

      /// <summary>
      /// 设置列宽度  -- 必须放在dataGridView数据读取后
      /// </summary>
      public void dgv_ColumnsWidth(int iColumn, int iWidth)
      {
         dgv.Columns[iColumn].Width = iWidth;
      }

      /// <summary>
      /// DataGridView 外观设置
      /// </summary>
      private void dgv_Style()
      {
         DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
         DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
         DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

         dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = SystemColors.Control;
         dataGridViewCellStyle1.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((134)));
         dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
         dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;

         dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = SystemColors.Window;
         dataGridViewCellStyle2.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((134)));
         dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
         dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(250, 189, 129);
         dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 0);
         dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;


         dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = SystemColors.Control;
         dataGridViewCellStyle3.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((134)));
         dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
         dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
         dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;

         dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         dgv.DefaultCellStyle = dataGridViewCellStyle2;
         dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;

         dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         dgv.MultiSelect = true;

         //dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         dgv.AllowUserToAddRows = false;
         dgv.AllowUserToDeleteRows = false;
         dgv.AllowUserToOrderColumns = false;
         dgv.AllowUserToResizeColumns = false;
         dgv.AllowUserToResizeRows = false;
         //this.dgv.GridColor = Color.BlueViolet;
         //this.dgv.BorderStyle = BorderStyle.Fixed3D;
         //this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
         //this.dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
         //this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

         if (dgv.RowCount > 0 && dgv.RowCount < 99)
         {
            dgv.RowHeadersWidth = 30;
         }
         else if (dgv.RowCount > 99 && dgv.RowCount < 999)
         {
            dgv.RowHeadersWidth = 35;
         }
         else if (dgv.RowCount > 999 && dgv.RowCount < 9999)
         {
            dgv.RowHeadersWidth = 40;
         }
         else if (dgv.RowCount > 9999 && dgv.RowCount < 99999)
         {
            dgv.RowHeadersWidth = 45;
         }
         else if (dgv.RowCount > 99999 && dgv.RowCount < 999999)
         {
            dgv.RowHeadersWidth = 50;
         }
         else
         {
            dgv.RowHeadersWidth = 25;
         }

         dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         dgv.ColumnHeadersHeight = 25;

         dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

         //dgv.ScrollBars = ScrollBars.Vertical;
      }

      #endregion

      #region 事件

      /// <summary>
      /// 执行行级绘画事件 -- 实现数据编号显示
      /// </summary>
      private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
      {
         using (SolidBrush b = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
         {
            e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1, CultureInfo.CurrentUICulture),
                                  e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + iX, e.RowBounds.Location.Y + iY);
         }
      }

      private static void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
      {
         //Color mLinearColor1 = Color.FromArgb(252, 248, 239);
         //Color mLinearColor2 = Color.FromArgb(247, 230, 192);
         Color mLinearColor1 = Color.FromArgb(248, 250, 251);
         Color mLinearColor2 = Color.FromArgb(248, 250, 251);
         Color mGridColor = Color.FromArgb(111, 169, 217); //网格线的颜色
         //控件的焦点框颜色 

         Rectangle Rect = new Rectangle(e.CellBounds.X - 1, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height - 1);
         LinearGradientBrush LinearGradientBrush = new LinearGradientBrush(Rect, mLinearColor1, mLinearColor2,
                                                                           LinearGradientMode.Vertical);

         try
         {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
               e.Graphics.FillRectangle(LinearGradientBrush, Rect);
               e.Graphics.DrawRectangle(new Pen(mGridColor), Rect);
               e.PaintContent(e.CellBounds);
               e.Handled = true;
            }
         }
         catch
         {
         }
      }

      #endregion
   }
}