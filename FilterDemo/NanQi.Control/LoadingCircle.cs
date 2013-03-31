
/* By NanQi 201209 in Internet */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NanQi.Controls
{
   public class LoadingCircle : System.Windows.Forms.Control
   {
      #region StylePresets enum

      public enum StylePresets
      {
         // ReSharper disable InconsistentNaming
         MacOSX,
         // ReSharper restore InconsistentNaming
         Firefox,
         // ReSharper disable InconsistentNaming
         IE7,
         // ReSharper restore InconsistentNaming
         Custom
      }

      #endregion

      //private const int DefaultInnerCircleRadius = 8;
      //private const int DefaultNumberOfSpoke = 10;
      //private const int DefaultOuterCircleRadius = 10;
      //private const int DefaultSpokeThickness = 4;
      //private const int FireFoxInnerCircleRadius = 6;
      //private const int FireFoxNumberOfSpoke = 9;
      //private const int FireFoxOuterCircleRadius = 7;
      //private const int FireFoxSpokeThickness = 4;
      private const int IE7InnerCircleRadius = 8;
      private const int IE7NumberOfSpoke = 0x18;
      private const int IE7OuterCircleRadius = 9;
      private const int IE7SpokeThickness = 4;
      private const int MacOSXInnerCircleRadius = 5;
      private const int MacOSXNumberOfSpoke = 12;
      private const int MacOSXOuterCircleRadius = 11;
      private const int MacOSXSpokeThickness = 2;
      private const double NumberOfDegreesInCircle = 360.0;
      private const double NumberOfDegreesInHalfCircle = 180.0;
      private readonly Color DefaultColor = Color.DarkGray;
      private readonly IContainer components;
      private readonly Timer m_Timer;
      private double[] m_Angles;
      private PointF m_CenterPoint;
      private Color m_Color;
      private Color[] m_Colors;
      private int m_InnerCircleRadius;
      private bool m_IsTimerActive;
      private int m_NumberOfSpoke;
      private int m_OuterCircleRadius;
      private int m_ProgressValue;
      private int m_SpokeThickness;
      private StylePresets m_StylePreset;

      public LoadingCircle()
      {
         base.SetStyle(ControlStyles.UserPaint, true);
         base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
         base.SetStyle(ControlStyles.ResizeRedraw, true);
         base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
         m_Color = DefaultColor;
         GenerateColorsPallet();
         GetSpokesAngles();
         GetControlCenterPoint();
         m_Timer = new Timer();
         m_Timer.Tick += aTimer_Tick;
         ActiveTimer();
         base.Resize += LoadingCircle_Resize;
      }

      /// <summary>
      /// 获取或设置激活状态
      /// </summary>
      [Category("LoadingCircle"), Description("获取或设置激活状态")]
      public bool Active
      {
         get { return m_IsTimerActive; }
         set
         {
            m_IsTimerActive = value;
            ActiveTimer();
         }
      }

      /// <summary>
      /// 获取或设置颜色
      /// </summary>
      [TypeConverter("System.Drawing.ColorConverter"), Category("LoadingCircle"),
       Description("获取或设置颜色")]
      public Color Color
      {
         get { return m_Color; }
         set
         {
            m_Color = value;
            GenerateColorsPallet();
            base.Invalidate();
         }
      }

      /// <summary>
      /// 获取或设置内圆的半径
      /// </summary>
      [Category("LoadingCircle"), Description("获取或设置内圆的半径")]
      public int InnerCircleRadius
      {
         get
         {
            if (m_InnerCircleRadius == 0)
            {
               m_InnerCircleRadius = 8;
            }
            return m_InnerCircleRadius;
         }
         set
         {
            m_InnerCircleRadius = value;
            base.Invalidate();
         }
      }

      /// <summary>
      /// 获取或设置辐条的数量
      /// </summary>
      [Description("获取或设置辐条的数量"), Category("LoadingCircle")]
      public int NumberSpoke
      {
         get
         {
            if (m_NumberOfSpoke == 0)
            {
               m_NumberOfSpoke = 10;
            }
            return m_NumberOfSpoke;
         }
         set
         {
            if ((m_NumberOfSpoke == value) || (m_NumberOfSpoke <= 0)) return;
            m_NumberOfSpoke = value;
            GenerateColorsPallet();
            GetSpokesAngles();
            base.Invalidate();
         }
      }

      /// <summary>
      /// 获取或设置外圆半径
      /// </summary>
      [Category("LoadingCircle"), Description("获取或设置外圆半径")]
      public int OuterCircleRadius
      {
         get
         {
            if (m_OuterCircleRadius == 0)
            {
               m_OuterCircleRadius = 10;
            }
            return m_OuterCircleRadius;
         }
         set
         {
            m_OuterCircleRadius = value;
            base.Invalidate();
         }
      }

      /// <summary>
      /// 获取或设置的旋转速度。越高的速度越慢。
      /// </summary>
      [Category("LoadingCircle"), Description("获取或设置的旋转速度。越高的速度越慢。")]
      public int RotationSpeed
      {
         get { return m_Timer.Interval; }
         set
         {
            if (value > 0)
            {
               m_Timer.Interval = value;
            }
         }
      }

      /// <summary>
      /// 获取或设置一个辐条的厚度
      /// </summary>
      [Description("获取或设置一个辐条的厚度"), Category("LoadingCircle")]
      public int SpokeThickness
      {
         get
         {
            if (m_SpokeThickness <= 0)
            {
               m_SpokeThickness = 4;
            }
            return m_SpokeThickness;
         }
         set
         {
            m_SpokeThickness = value;
            base.Invalidate();
         }
      }

      /// <summary>
      /// 快速设置这些预设的风格，或自定义的样式
      /// </summary>
      [Description("快速设置这些预设的风格，或自定义的样式"),
       DefaultValue(typeof (StylePresets), "Custom"), Category("LoadingCircle")]
      public StylePresets StylePreset
      {
         get { return m_StylePreset; }
         set
         {
            m_StylePreset = value;
            switch (m_StylePreset)
            {
               case StylePresets.MacOSX:
                  SetCircleAppearance(12, 2, 5, 11);
                  break;

               case StylePresets.Firefox:
                  SetCircleAppearance(9, 4, 6, 7);
                  break;

               case StylePresets.IE7:
                  SetCircleAppearance(0x18, 4, 8, 9);
                  break;

               case StylePresets.Custom:
                  SetCircleAppearance(10, 4, 8, 10);
                  break;
            }
         }
      }

      private void ActiveTimer()
      {
         if (m_IsTimerActive)
         {
            m_Timer.Start();
         }
         else
         {
            m_Timer.Stop();
            m_ProgressValue = 0;
         }
         GenerateColorsPallet();
         base.Invalidate();
      }

      private void aTimer_Tick(object sender, EventArgs e)
      {
         m_ProgressValue = ++m_ProgressValue%m_NumberOfSpoke;
         base.Invalidate();
      }

      private Color Darken(Color _objColor, int _intPercent)
      {
         int r = _objColor.R;
         int g = _objColor.G;
         int b = _objColor.B;
         return Color.FromArgb(_intPercent, Math.Min(r, 0xff), Math.Min(g, 0xff), Math.Min(b, 0xff));
      }

      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      private void DrawLine(Graphics _objGraphics, PointF _objPointOne, PointF _objPointTwo, Color _objColor,
                            int _intLineThickness)
      {
         using (Pen pen = new Pen(new SolidBrush(_objColor), _intLineThickness))
         {
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            _objGraphics.DrawLine(pen, _objPointOne, _objPointTwo);
         }
      }

      private void GenerateColorsPallet()
      {
         m_Colors = GenerateColorsPallet(m_Color, Active, m_NumberOfSpoke);
      }

      private Color[] GenerateColorsPallet(Color _objColor, bool _blnShadeColor, int _intNbSpoke)
      {
         Color[] colorArray = new Color[NumberSpoke];
         byte num = (byte) (0xff/NumberSpoke);
         byte num2 = 0;
         for (int i = 0; i < NumberSpoke; i++)
         {
            if (_blnShadeColor)
            {
               if ((i == 0) || (i < (NumberSpoke - _intNbSpoke)))
               {
                  colorArray[i] = _objColor;
               }
               else
               {
                  num2 = (byte) (num2 + num);
                  if (num2 > 0xff)
                  {
                     num2 = 0xff;
                  }
                  colorArray[i] = Darken(_objColor, num2);
               }
            }
            else
            {
               colorArray[i] = _objColor;
            }
         }
         return colorArray;
      }

      private void GetControlCenterPoint()
      {
         m_CenterPoint = GetControlCenterPoint(this);
      }

      private PointF GetControlCenterPoint(System.Windows.Forms.Control _objControl)
      {
         return new PointF((_objControl.Width/2), ((_objControl.Height/2) - 1));
      }

      private PointF GetCoordinate(PointF _objCircleCenter, int _intRadius, double _dblAngle)
      {
         double d = (3.1415926535897931*_dblAngle)/180.0;
         return new PointF(_objCircleCenter.X + (_intRadius*((float) Math.Cos(d))),
                           _objCircleCenter.Y + (_intRadius*((float) Math.Sin(d))));
      }

      public override Size GetPreferredSize(Size proposedSize)
      {
         proposedSize.Width = (m_OuterCircleRadius + m_SpokeThickness)*2;
         return proposedSize;
      }

      private void GetSpokesAngles()
      {
         m_Angles = GetSpokesAngles(NumberSpoke);
      }

      private double[] GetSpokesAngles(int _intNumberSpoke)
      {
         double[] numArray = new double[_intNumberSpoke];
         double num = 360.0/(_intNumberSpoke);
         for (int i = 0; i < _intNumberSpoke; i++)
         {
            numArray[i] = (i == 0) ? num : (numArray[i - 1] + num);
         }
         return numArray;
      }

      private void LoadingCircle_Resize(object sender, EventArgs e)
      {
         GetControlCenterPoint();
      }

      protected override void OnPaint(PaintEventArgs e)
      {
         if (m_NumberOfSpoke > 0)
         {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            int progressValue = m_ProgressValue;
            for (int i = 0; i < m_NumberOfSpoke; i++)
            {
               progressValue = progressValue%m_NumberOfSpoke;
               DrawLine(e.Graphics, GetCoordinate(m_CenterPoint, m_InnerCircleRadius, m_Angles[progressValue]),
                        GetCoordinate(m_CenterPoint, m_OuterCircleRadius, m_Angles[progressValue]), m_Colors[i],
                        m_SpokeThickness);
               progressValue++;
            }
         }
         base.OnPaint(e);
      }

      public void SetCircleAppearance(int numberSpoke, int spokeThickness, int innerCircleRadius,
                                      int outerCircleRadius)
      {
         NumberSpoke = numberSpoke;
         SpokeThickness = spokeThickness;
         InnerCircleRadius = innerCircleRadius;
         OuterCircleRadius = outerCircleRadius;
         base.Invalidate();
      }
   }
}