
/* By NanQi 201209 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NanQi.Controls
{
   [ToolboxBitmap(typeof (Button))]
   public class ImageButton : Button
   {
      #region field

      private Image _imageDown;
      private Image _imageHover;
      private Image _imageNormal;

      #endregion

      public ImageButton()
      {
         SetStyle(ControlStyles.UserPaint, true); //自绘
         SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
         SetStyle(ControlStyles.ResizeRedraw, true); //调整大小时重绘
         SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
         SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲
         //this.SetStyle(ControlStyles.Opaque, true);//如果为真，控件将绘制为不透明，不绘制背景
         SetStyle(ControlStyles.SupportsTransparentBackColor, true); //透明效果

         base.FlatStyle = FlatStyle.Flat;
         base.FlatAppearance.BorderSize = 0;
         base.FlatAppearance.MouseDownBackColor = base.FlatAppearance.MouseOverBackColor = Color.Transparent;
         BackColor = Color.Transparent;
         BackgroundImageLayout = ImageLayout.None;
         Text = string.Empty;
         base.Width = 80;
         base.Height = 30;
         base.SetStyle(ControlStyles.Selectable, false);
      }

      [Description("鼠标按下时的图片"), Category("ImageButton")]
      public Image ImageDown
      {
         get { return _imageDown; }
         set { _imageDown = value; }
      }

      [Description("鼠标经过时的图片"), Category("ImageButton")]
      public Image ImageHover
      {
         get { return _imageHover; }
         set { _imageHover = value; }
      }

      [Description("初始状态下的图片"), Category("ImageButton")]
      public Image ImageNormal
      {
         get { return _imageNormal; }
         set
         {
            _imageNormal = value;
            BackgroundImage = _imageNormal;
         }
      }

      protected override void OnMouseDown(MouseEventArgs mevent)
      {
         BackgroundImage = _imageDown;
         base.OnMouseDown(mevent);
      }

      protected override void OnMouseEnter(EventArgs e)
      {
         BackgroundImage = _imageHover;
         base.Invalidate(false);
         base.OnMouseEnter(e);
      }

      protected override void OnMouseLeave(EventArgs e)
      {
         BackgroundImage = _imageNormal;
         base.Invalidate(false);
         base.OnMouseLeave(e);
      }

      protected override void OnMouseUp(MouseEventArgs mevent)
      {
         BackgroundImage = _imageHover;
         base.OnMouseUp(mevent);
      }
   }
}