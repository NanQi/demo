
/* By NanQi 201209 in Internet */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PinkieControls
{
   public class ButtonBase : Control, IButtonControl
   {
      #region States enum

      public enum States
      {
         Normal,
         MouseOver,
         Pushed
      }

      #endregion

      private readonly Container components;
      private Rectangle bounds;
      private DialogResult dialogResult = DialogResult.None;
      private Point iPoint;
      private Image image;
      protected bool isDefault;
      protected GraphicsPath path;
      private StringFormat sf;
      protected States state = States.Normal;
      private Point tPoint;
      private SolidBrush textBrush;
      private Color textColor = SystemColors.ControlText;
      protected ToolTip toolTip;

      public ButtonBase()
      {
         try
         {
            base.SetStyle(ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.StandardDoubleClick, false);
            base.SetStyle(ControlStyles.Selectable, true);
            base.Size = new Size(10, 10);
            base.ResizeRedraw = true;
            toolTip = new ToolTip();
         }
         catch
         {
         }
      }

      public string Hint
      {
         get { return toolTip.GetToolTip(this); }
         set
         {
            toolTip.RemoveAll();
            toolTip.SetToolTip(this, value);
         }
      }

      [DefaultValue((string) null), RefreshProperties(RefreshProperties.Repaint)]
      public Image Image
      {
         get { return image; }
         set
         {
            image = value;
            base.Invalidate();
         }
      }

      public override string Text
      {
         get { return base.Text; }
         set
         {
            base.Text = value;
            base.Invalidate();
         }
      }

      [RefreshProperties(RefreshProperties.Repaint), DefaultValue(typeof (Color), "ControlText")]
      public Color TextColor
      {
         get { return textColor; }
         set
         {
            textColor = value;
            if (textBrush != null)
            {
               textBrush.Dispose();
            }
            textBrush = new SolidBrush(textColor);
            base.Invalidate();
         }
      }

      #region IButtonControl Members

      public void NotifyDefault(bool value)
      {
         isDefault = value;
         base.Invalidate();
      }

      public void PerformClick()
      {
         if (base.CanSelect)
         {
            OnClick(EventArgs.Empty);
         }
      }

      public DialogResult DialogResult
      {
         get { return dialogResult; }
         set { dialogResult = value; }
      }

      #endregion

      protected virtual void CreatePensBrushes()
      {
         if (textBrush != null)
         {
            textBrush.Dispose();
         }
         textBrush = new SolidBrush(textColor);
      }

      protected virtual void CreateRegion()
      {
      }

      protected override void Dispose(bool disposing)
      {
         if (disposing)
         {
            DisposePensBrushes();
            if (components != null)
            {
               components.Dispose();
            }
         }
         base.Dispose(disposing);
      }

      protected virtual void DisposePensBrushes()
      {
         if (textBrush != null)
         {
            textBrush.Dispose();
         }
      }

      private void GetPoints()
      {
         int width = base.Width;
         int height = base.Height;
         if (Image != null)
         {
            if (Text.Length == 0)
            {
               iPoint = new Point((width - Image.Width)/2, (height - Image.Height)/2);
            }
            else
            {
               iPoint = new Point(7, (height - Image.Height)/2);
            }
            tPoint = new Point((7 + Image.Width) + 7, (height - Font.Height)/2);
         }
         else
         {
            Size size = TextUtil.GetTextSize(base.CreateGraphics(), Text.Replace("&", ""), Font, new Size(width, height));
            tPoint = new Point(((width - size.Width) - 2)/2, (height - Font.Height)/2);
         }
      }

      protected override void OnClick(EventArgs e)
      {
         if (state == States.Pushed)
         {
            state = States.Normal;
            base.Invalidate(bounds);
         }
         if (dialogResult != DialogResult.None)
         {
            base.FindForm().DialogResult = DialogResult;
         }
         base.OnClick(e);
      }

      protected override void OnEnter(EventArgs e)
      {
         base.Invalidate(bounds);
         base.OnEnter(e);
      }

      protected override void OnKeyDown(KeyEventArgs ke)
      {
         if ((ke.KeyData == Keys.Return) || (ke.KeyData == Keys.Space))
         {
            PerformClick();
         }
         base.OnKeyDown(ke);
      }

      protected override void OnKeyUp(KeyEventArgs ke)
      {
         base.OnKeyUp(ke);
      }

      protected override void OnLeave(EventArgs e)
      {
         base.Invalidate(bounds);
         base.OnLeave(e);
      }

      protected override void OnMouseDown(MouseEventArgs e)
      {
         if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
         {
            if (bounds.Contains(e.X, e.Y))
            {
               state = States.Pushed;
               base.Focus();
            }
            else
            {
               state = States.Normal;
            }
            base.Invalidate(bounds);
            base.OnMouseDown(e);
         }
      }

      protected override void OnMouseEnter(EventArgs e)
      {
         state = States.MouseOver;
         base.Invalidate(bounds);
         base.OnMouseEnter(e);
      }

      protected override void OnMouseLeave(EventArgs e)
      {
         state = States.Normal;
         base.Invalidate();
         base.OnMouseLeave(e);
      }

      protected override void OnMouseMove(MouseEventArgs e)
      {
         if (!bounds.Contains(e.X, e.Y))
         {
            state = States.Normal;
         }
         else
         {
            state = States.MouseOver;
         }
         base.Invalidate(bounds);
         base.OnMouseMove(e);
      }

      protected override void OnMouseUp(MouseEventArgs e)
      {
         if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
         {
            state = States.Normal;
         }
         base.Invalidate(bounds);
         base.OnMouseUp(e);
      }

      protected override void OnPaint(PaintEventArgs e)
      {
         if (image != null)
         {
            if (base.Enabled)
            {
               e.Graphics.DrawImage(image, iPoint);
            }
            else
            {
               ControlPaint.DrawImageDisabled(e.Graphics, image, iPoint.X, iPoint.Y, BackColor);
            }
         }
         e.Graphics.DrawString(Text, Font, textBrush, tPoint, sf);
      }

      protected override void OnParentChanged(EventArgs e)
      {
         if (base.Parent != null)
         {
            GetPoints();
            CreateRegion();
            base.OnParentChanged(e);
         }
      }

      protected override void OnSizeChanged(EventArgs e)
      {
         bounds = new Rectangle(0, 0, base.Width, base.Height);
         OnParentChanged(e);
         base.OnSizeChanged(e);
      }

      protected override void OnTextChanged(EventArgs e)
      {
         if (sf != null)
         {
            sf.Dispose();
         }
         sf = new StringFormat();
         sf.HotkeyPrefix = HotkeyPrefix.Show;
         GetPoints();
         base.OnTextChanged(e);
      }

      protected override bool ProcessMnemonic(char charCode)
      {
         if (IsMnemonic(charCode, base.Text))
         {
            PerformClick();
            return true;
         }
         return base.ProcessMnemonic(charCode);
      }
   }
}