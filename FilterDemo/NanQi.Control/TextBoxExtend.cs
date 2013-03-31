
/* By NanQi 201209 modify Internet */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NanQi.Controls
{
   /// <summary>
   /// 扩展TextBox，使其可以输入Int，Decimal或者原始值
   /// </summary>
   [ToolboxBitmap(typeof (TextBox)), Description("TextBox的扩展")]
   public partial class TextBoxExtend : TextBox
   {
      #region IProcessCmdKey 接口

      /// <summary>
      /// 按键处理类
      /// </summary>
      private IProcessCmdKey _ProcessCmdKey = ProcessCmdKeyFactory.CreateProcessCmdKey(InputType.None);

      #endregion

      #region Text

      /// <summary>
      /// Gets or sets the current text in the <see cref="T:System.Windows.Forms.TextBox"/>.
      /// </summary>
      /// <value></value>
      /// <returns>The text displayed in the control.</returns>
      [Category("Extend Property")]
      public override string Text
      {
         get { return base.Text; }
         set
         {
            if (_ProcessCmdKey.CheckText(value))
            {
               base.Text = value;
            }
            else
            {
               base.Text = "";
            }
         }
      }

      #endregion

      #region Property

      #region 输入类型

      /// <summary>
      /// 输入类型
      /// </summary>
      private InputType _inputType = InputType.None;

      /// <summary>
      /// Gets or sets the type of the input.
      /// 输入类型
      /// </summary>
      /// <value>The type of the input.</value>
      [Category("Extend Property")]
      public InputType inputType
      {
         get { return _inputType; }
         set
         {
            _inputType = value;
            _ProcessCmdKey = ProcessCmdKeyFactory.CreateProcessCmdKey(value);
            base.Text = "";
         }
      }

      #endregion

      #endregion

      #region Construtor

      #endregion

      #region Override Process Command Key

      /// <summary>
      /// Gets a value indicating the state of the <see cref="P:System.Windows.Forms.TextBoxBase.ShortcutsEnabled"/> property.
      /// </summary>
      /// <param name="msg">A <see cref="T:System.Windows.Forms.Message"/>, passed by reference that represents the window message to process.</param>
      /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys"/> values that represents the shortcut key to process.</param>
      /// <returns>
      /// true if the shortcut key was processed by the control; otherwise, false.
      /// </returns>
      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         _ProcessCmdKey.Text = base.Text;
         if (_ProcessCmdKey.ProcessCmdKey(ref msg, keyData))
         {
            return true;
         }
         base.Text = _ProcessCmdKey.Text;
         return base.ProcessCmdKey(ref msg, keyData);
      }

      #endregion

      /// <summary> 
      /// 边框颜色 
      /// </summary> 
      private Color _BorderColor = Color.FromArgb(0xA7, 0xA6, 0xAA);

      /// <summary> 
      /// 热点边框颜色 
      /// </summary> 
      private Color _HotColor = Color.FromArgb(0x33, 0x5E, 0xA8);

      /// <summary> 
      /// 是否启用热点效果 
      /// </summary> 
      private bool _HotTrack = true;

      /// <summary> 
      /// 是否鼠标MouseOver状态 
      /// </summary> 
      private bool _IsMouseOver;

      #region 属性

      /// <summary> 
      /// 是否启用热点效果 
      /// </summary> 
      [Category("行为"),
       Description("获得或设置一个值，指示当鼠标经过控件时控件边框是否发生变化。只在控件的BorderStyle为FixedSingle时有效"),
       DefaultValue(true)]
      public bool HotTrack
      {
         get { return _HotTrack; }
         set
         {
            _HotTrack = value;
            //在该值发生变化时重绘控件，下同 
            //在设计模式下，更改该属性时，如果不调用该语句， 
            //则不能立即看到设计试图中该控件相应的变化 
            Invalidate();
         }
      }

      /// <summary> 
      /// 边框颜色 
      /// </summary> 
      [Category("外观"),
       Description("获得或设置控件的边框颜色"),
       DefaultValue(typeof (Color), "#A7A6AA")]
      public Color BorderColor
      {
         get { return _BorderColor; }
         set
         {
            _BorderColor = value;
            Invalidate();
         }
      }

      /// <summary> 
      /// 热点时边框颜色 
      /// </summary> 
      [Category("外观"),
       Description("获得或设置当鼠标经过控件时控件的边框颜色。只在控件的BorderStyle为FixedSingle时有效"),
       DefaultValue(typeof (Color), "#335EA8")]
      public Color HotColor
      {
         get { return _HotColor; }
         set
         {
            _HotColor = value;
            Invalidate();
         }
      }

      #endregion 属性

      /// <summary> 
      /// 获得当前进程，以便重绘控件 
      /// </summary> 
      /// <param name="hWnd"></param> 
      /// <returns></returns> 
      [DllImport("user32.dll")]
      private static extern IntPtr GetWindowDC(IntPtr hWnd);

      [DllImport("user32.dll")]
      private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

      /// <summary> 
      /// 鼠标移动到该控件上时 
      /// </summary> 
      /// <param name="e"></param> 
      protected override void OnMouseMove(MouseEventArgs e)
      {
         //鼠标状态 
         _IsMouseOver = true;
         //如果启用HotTrack，则开始重绘 
         //如果不加判断这里不加判断，则当不启用HotTrack， 
         //鼠标在控件上移动时，控件边框会不断重绘， 
         //导致控件边框闪烁。下同 
         //谁有更好的办法？Please tell me , Thanks。 
         if (_HotTrack)
         {
            //重绘 
            Invalidate();
         }
         base.OnMouseMove(e);
      }

      /// <summary> 
      /// 当鼠标从该控件移开时 
      /// </summary> 
      /// <param name="e"></param> 
      protected override void OnMouseLeave(EventArgs e)
      {
         _IsMouseOver = false;

         if (_HotTrack)
         {
            //重绘 
            Invalidate();
         }
         base.OnMouseLeave(e);
      }

      /// <summary> 
      /// 当该控件获得焦点时 
      /// </summary> 
      /// <param name="e"></param> 
      protected override void OnGotFocus(EventArgs e)
      {
         if (_HotTrack)
         {
            //重绘 
            Invalidate();
            Select(Text.Length, 0);
         }
         base.OnGotFocus(e);
      }

      /// <summary> 
      /// 当该控件失去焦点时 
      /// </summary> 
      /// <param name="e"></param> 
      protected override void OnLostFocus(EventArgs e)
      {
         if (_HotTrack)
         {
            //重绘 
            Invalidate();
            Select(0, 0);
         }
         base.OnLostFocus(e);
      }

      protected override void OnKeyDown(KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Down)
         {
            SendKeys.Send("{Tab}");
         }

         if (e.KeyCode == Keys.Up)
         {
            SendKeys.Send("+{TAB}");
         }

         if (e.KeyCode == Keys.Enter)
         {
            SendKeys.Send("{Tab}");
         }
      }

      /// <summary> 
      /// 获得操作系统消息 
      /// </summary> 
      /// <param name="m"></param> 
      protected override void WndProc(ref Message m)
      {
         base.WndProc(ref m);
         if (m.Msg != 0xf && m.Msg != 0x133) return;
         //拦截系统消息，获得当前控件进程以便重绘。 
         //一些控件（如TextBox、Button等）是由系统进程绘制，重载OnPaint方法将不起作用. 
         //所有这里并没有使用重载OnPaint方法绘制TextBox边框。 
         // 
         //MSDN:重写 OnPaint 将禁止修改所有控件的外观。 
         //那些由 Windows 完成其所有绘图的控件（例如 Textbox）从不调用它们的 OnPaint 方法， 
         //因此将永远不会使用自定义代码。请参见您要修改的特定控件的文档， 
         //查看 OnPaint 方法是否可用。如果某个控件未将 OnPaint 作为成员方法列出， 
         //则您无法通过重写此方法改变其外观。 
         // 
         //MSDN:要了解可用的 Message.Msg、Message.LParam 和 Message.WParam 值， 
         //请参考位于 MSDN Library 中的 Platform SDK 文档参考。可在 Platform SDK（“Core SDK”一节） 
         //下载中包含的 windows.h 头文件中找到实际常数值，该文件也可在 MSDN 上找到。 
         IntPtr hDC = GetWindowDC(m.HWnd);
         if (hDC.ToInt32() == 0)
         {
            return;
         }

         //只有在边框样式为FixedSingle时自定义边框样式才有效 
         if (BorderStyle == BorderStyle.FixedSingle)
         {
            //边框Width为1个像素 
            Pen pen = new Pen(_BorderColor, 1);

            if (_HotTrack)
            {
               if (Focused)
               {
                  pen.Color = _HotColor;
               }
               else
               {
                  pen.Color = _IsMouseOver ? _HotColor : _BorderColor;
               }
            }
            //绘制边框 
            Graphics g = Graphics.FromHdc(hDC);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            pen.Dispose();

            if (inputType != InputType.None)
            {
               //屏蔽TextBox的右键
               ContextMenu cm = new ContextMenu();
               ContextMenu = cm;
            }
         }
         //返回结果 
         m.Result = IntPtr.Zero;
         //释放 
         ReleaseDC(m.HWnd, hDC);
      }
   }

   #region Input Type

   /// <summary>
   /// 输入类型 TextBoxExtend 中输入的类型
   /// </summary>
   public enum InputType
   {
      // 原始输入模式
      None = 1,
      // 输入为Int类型
      Int = 2,
      // 输入为Decimal类型
      Decimal = 3
   }

   #endregion

   #region 处理ProcessCmdKey的方法接口

   /// <summary>
   /// 处理ProcessCmdKey的方法接口
   /// </summary>
   public abstract class IProcessCmdKey
   {
      #region Property

      /// <summary>
      /// 显示的Text值
      /// </summary>
      private string _Text;

      /// <summary>
      /// 显示的Text值
      /// </summary>
      public string Text
      {
         get { return _Text; }
         set { _Text = value; }
      }

      #endregion

      /// <summary>
      /// Checks the text.
      /// </summary>
      /// <param name="Text">The text.</param>
      /// <returns></returns>
      public abstract bool CheckText(string Text);

      /// <summary>
      /// Processes the CMD key.
      /// </summary>
      /// <param name="msg">The MSG.</param>
      /// <param name="keyData">The key data.</param>
      /// <returns></returns>
      public abstract bool ProcessCmdKey(ref Message msg, Keys keyData);
   }

   #endregion

   #region 不处理任何按键的类

   /// <summary>
   /// 不处理任何按键的类
   /// </summary>
   public class ProcessCmdKeyNone : IProcessCmdKey
   {
      #region CheckText

      /// <summary>
      /// Checks the text.
      /// </summary>
      /// <param name="Text">The text.</param>
      /// <returns></returns>
      public override bool CheckText(string Text)
      {
         return true;
      }

      #endregion

      /// <summary>
      /// Processes the CMD key.
      /// </summary>
      /// <param name="msg">The MSG.</param>
      /// <param name="keyData">The key data.</param>
      /// <returns></returns>
      public override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         return false;
      }
   }

   #endregion

   #region 处理数字任何按键的类

   /// <summary>
   /// 处理数字任何按键的类
   /// </summary>
   public class ProcessCmdKeyInt : IProcessCmdKey
   {
      #region CheckText

      /// <summary>
      /// Checks the text.
      /// </summary>
      /// <param name="Text">The text.</param>
      /// <returns></returns>
      public override bool CheckText(string Text)
      {
         try
         {
            if (Text == string.Empty || Text == null)
            {
               return false;
            }

            Int32.Parse(Text);
            return true;
         }
         catch (Exception err)
         {
            MessageBox.Show(err.ToString());
            return false;
         }
      }

      #endregion

      /// <summary>
      /// Processes the CMD key.
      /// </summary>
      /// <param name="msg">The MSG.</param>
      /// <param name="keyData">The key data.</param>
      /// <returns></returns>
      public override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if ((keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9)
             || (keyData >= Keys.D0 && keyData <= Keys.D9)
             || keyData == Keys.Tab
             || keyData == Keys.Back
             || keyData == Keys.Delete
             || keyData == (Keys.Shift | Keys.Home)
             || keyData == (Keys.Shift | Keys.End)
             || keyData == Keys.Home
             || keyData == Keys.Up
             || keyData == Keys.Down
             || keyData == Keys.End
             || keyData == Keys.Left
             || keyData == Keys.Enter
             || keyData == Keys.Right)
         {
            return false;
         }
         return true;
      }
   }

   #endregion

   #region 处理浮点数据的类

   /// <summary>
   /// 处理浮点数据的类
   /// </summary>
   public class ProcessCmdKeyDecimal : IProcessCmdKey
   {
      #region CheckText

      /// <summary>
      /// Checks the text.
      /// </summary>
      /// <param name="Text">The text.</param>
      /// <returns></returns>
      public override bool CheckText(string Text)
      {
         try
         {
            if (Text == String.Empty || Text == null)
            {
               return false;
            }
            else
            {
               Decimal.Parse(Text);
               return true;
            }
         }
         catch (Exception err)
         {
            MessageBox.Show(err.ToString());
            return false;
         }
      }

      #endregion

      /// <summary>
      /// Processes the CMD key.
      /// </summary>
      /// <param name="msg">The MSG.</param>
      /// <param name="keyData">The key data.</param>
      /// <returns></returns>
      public override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == Keys.Decimal || keyData == Keys.OemPeriod)
         {
            if (Text == string.Empty || Text.Contains("."))
            {
               return true;
            }
            return false;
         }
         if ((keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9)
             || (keyData >= Keys.D0 && keyData <= Keys.D9)
             || keyData == Keys.Tab
             || keyData == Keys.Back
             || keyData == Keys.Delete
             || keyData == (Keys.Shift | Keys.Home)
             || keyData == (Keys.Shift | Keys.End)
             || keyData == Keys.Home
             || keyData == Keys.Up
             || keyData == Keys.Down
             || keyData == Keys.End
             || keyData == Keys.Left
             || keyData == Keys.Enter
             || keyData == Keys.OemMinus
             || keyData == Keys.Right)
         {
            return false;
         }
         return true;
      }
   }

   #endregion

   #region 工厂方法获得ProcessCmdKey的实例

   /// <summary>
   /// 工厂方法获得ProcessCmdKey的实例
   /// </summary>
   public class ProcessCmdKeyFactory
   {
      /// <summary>
      /// Creates the process CMD key Class
      /// </summary>
      /// <param name="inputType">Type of the input.</param>
      /// <returns>IProcessCmdKey的实例</returns>
      public static IProcessCmdKey CreateProcessCmdKey(InputType inputType)
      {
         switch (inputType)
         {
            case InputType.None:
               return new ProcessCmdKeyNone();
            case InputType.Int:
               return new ProcessCmdKeyInt();
            case InputType.Decimal:
               return new ProcessCmdKeyDecimal();
            default:
               return new ProcessCmdKeyNone();
         }
      }
   }

   #endregion
}