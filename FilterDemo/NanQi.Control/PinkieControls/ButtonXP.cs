
/* By NanQi 201209 in Internet */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using PinkieControls;
using ButtonBase = PinkieControls.ButtonBase;

namespace NanQi.Controls.PinkieControls
{
   public class ButtonXP : ButtonBase
   {
      #region Schemes enum

      public enum Schemes
      {
         Blue,
         OliveGreen,
         Silver
      }

      #endregion

      private SolidBrush _brush01;
      private SolidBrush _brush02;
      private Pen _pen01;
      private Pen _pen02;
      private SolidBrush blueBrush04;
      private LinearGradientBrush bluesilverBrush02;
      private LinearGradientBrush bluesilverBrush03;
      private Pen bluesilverPen01;
      private Pen bluesilverPen02;
      private Pen bluesilverPen03;
      private Pen bluesilverPen04;
      private Pen bluesilverPen05;
      private Pen bluesilverPen06;
      private Pen bluesilverPen07;
      private Pen bluesilverPen08;
      private Pen bluesilverPen09;
      private Pen bluesilverPen10;
      private Pen bluesilverPen11;
      private Pen bluesilverPen12;
      private Pen bluesilverPen13;
      private Pen bluesilverPen14;
      private Pen bluesilverPen15;
      private Pen bluesilverPen16;
      private LinearGradientBrush brush00;
      private LinearGradientBrush brush01;
      private LinearGradientBrush brush05;
      private LinearGradientBrush brush09;
      private bool defaultScheme = true;
      private LinearGradientBrush oliveBrush02;
      private LinearGradientBrush oliveBrush03;
      private SolidBrush oliveBrush04;
      private Pen olivePen01;
      private Pen olivePen02;
      private Pen olivePen03;
      private Pen olivePen04;
      private Pen olivePen05;
      private Pen olivePen06;
      private Pen olivePen07;
      private Pen olivePen08;
      private Pen olivePen09;
      private Pen olivePen10;
      private Pen olivePen11;
      private Pen olivePen12;
      private Pen olivePen13;
      private Pen olivePen14;
      private Pen olivePen15;
      private Pen olivePen16;
      private Pen pen17;
      private Pen pen18;
      private Pen pen19;
      private Pen pen20;
      private Pen pen21;
      private Pen pen22;
      private Pen pen23;
      private Pen pen24;
      private Rectangle[] rects0;
      private Rectangle[] rects1;
      private Schemes scheme = Schemes.Blue;
      private SolidBrush silverBrush04;
      private SolidBrush silverBrush06;
      private LinearGradientBrush silverBrush07;
      private SolidBrush silverBrush08;

      public bool DefaultScheme
      {
         get { return defaultScheme; }
         set
         {
            defaultScheme = value;
            if (!defaultScheme)
            {
               return;
            }
            try
            {
               StringBuilder pszThemeFileName = new StringBuilder(0x100);
               StringBuilder pszColorBuff = new StringBuilder(0x100);
               WinAPI.GetCurrentThemeName(pszThemeFileName, pszThemeFileName.Capacity, pszColorBuff,
                                          pszColorBuff.Capacity, null, 0);
               switch (pszColorBuff.ToString())
               {
                  case "HomeStead":
                     scheme = Schemes.OliveGreen;
                     goto Label_008D;

                  case "Metallic":
                     scheme = Schemes.Silver;
                     goto Label_008D;
               }
               scheme = Schemes.Blue;
            }
            catch (Exception)
            {
               return;
            }
            Label_008D:
            base.Invalidate();
         }
      }

      [DefaultValue("Blue"), RefreshProperties(RefreshProperties.Repaint)]
      public Schemes Scheme
      {
         get { return scheme; }
         set
         {
            scheme = value;
            base.Invalidate();
         }
      }

      protected override void CreatePensBrushes()
      {
         DisposePensBrushes();
         if (base.Region != null)
         {
            int width = base.Width;
            int height = base.Height;
            brush00 = ColorManager.Brush00(new Rectangle(0, 0, width, height));
            bluesilverBrush02 = ColorManager.Brush02(Schemes.Blue, new Rectangle(2, 3, width - 4, height - 7));
            oliveBrush02 = ColorManager.Brush02(Schemes.OliveGreen, new Rectangle(2, 3, width - 4, height - 7));
            bluesilverBrush03 = ColorManager.Brush03(Schemes.Blue, new Rectangle(2, 3, width - 4, height - 7));
            oliveBrush03 = ColorManager.Brush03(Schemes.OliveGreen, new Rectangle(2, 3, width - 4, height - 7));
            blueBrush04 = ColorManager.Brush04(Schemes.Blue);
            oliveBrush04 = ColorManager.Brush04(Schemes.OliveGreen);
            silverBrush04 = ColorManager.Brush04(Schemes.Silver);
            bluesilverPen06 = ColorManager.Pen06(Schemes.Blue);
            olivePen06 = ColorManager.Pen06(Schemes.OliveGreen);
            bluesilverPen07 = ColorManager.Pen07(Schemes.Blue);
            olivePen07 = ColorManager.Pen07(Schemes.OliveGreen);
            bluesilverPen08 = ColorManager.Pen08(Schemes.Blue);
            olivePen08 = ColorManager.Pen08(Schemes.OliveGreen);
            bluesilverPen09 = ColorManager.Pen09(Schemes.Blue);
            olivePen09 = ColorManager.Pen09(Schemes.OliveGreen);
            bluesilverPen10 = ColorManager.Pen10(Schemes.Blue);
            olivePen10 = ColorManager.Pen10(Schemes.OliveGreen);
            bluesilverPen11 = ColorManager.Pen11(Schemes.Blue);
            olivePen11 = ColorManager.Pen11(Schemes.OliveGreen);
            bluesilverPen12 = ColorManager.Pen12(Schemes.Blue);
            olivePen12 = ColorManager.Pen12(Schemes.OliveGreen);
            bluesilverPen13 = ColorManager.Pen13(Schemes.Blue);
            olivePen13 = ColorManager.Pen13(Schemes.OliveGreen);
            bluesilverPen14 = ColorManager.Pen14(Schemes.Blue);
            olivePen14 = ColorManager.Pen14(Schemes.OliveGreen);
            bluesilverPen15 = ColorManager.Pen15(Schemes.Blue);
            olivePen15 = ColorManager.Pen15(Schemes.OliveGreen);
            bluesilverPen16 = ColorManager.Pen16(Schemes.Blue);
            olivePen16 = ColorManager.Pen16(Schemes.OliveGreen);
            _brush01 = ColorManager._Brush01(scheme);
            _brush02 = ColorManager._Brush02(scheme);
            _pen01 = ColorManager._Pen01(scheme);
            _pen02 = ColorManager._Pen02(scheme);
            silverBrush06 = ColorManager.Brush06();
            silverBrush07 = ColorManager.Brush07(new Rectangle(3, 3, width - 6, height - 7));
            silverBrush08 = ColorManager.Brush08();
            brush09 = ColorManager.Brush09(new Rectangle(3, 3, width - 5, height - 8));
            pen23 = ColorManager.Pen23();
            pen24 = ColorManager.Pen24();
            brush01 = ColorManager.Brush01(scheme, new Rectangle(2, 2, width - 5, height - 7));
            brush05 = ColorManager.Brush05(scheme, new Rectangle(2, 2, width - 5, height - 7));
            bluesilverPen01 = ColorManager.Pen01(Schemes.Blue);
            bluesilverPen02 = ColorManager.Pen02(Schemes.Blue);
            bluesilverPen03 = ColorManager.Pen03(Schemes.Blue);
            bluesilverPen04 = ColorManager.Pen04(Schemes.Blue, new Rectangle(width - 3, 4, 1, height - 5));
            bluesilverPen05 = ColorManager.Pen05(Schemes.Blue, new Rectangle(width - 2, 4, 1, height - 5));
            olivePen01 = ColorManager.Pen01(Schemes.OliveGreen);
            olivePen02 = ColorManager.Pen02(Schemes.OliveGreen);
            olivePen03 = ColorManager.Pen03(Schemes.OliveGreen);
            olivePen04 = ColorManager.Pen04(Schemes.OliveGreen, new Rectangle(width - 3, 4, 1, height - 5));
            olivePen05 = ColorManager.Pen05(Schemes.OliveGreen, new Rectangle(width - 2, 4, 1, height - 5));
            pen17 = ColorManager.Pen17(scheme, new Rectangle(2, 3, width - 4, height - 7));
            pen18 = ColorManager.Pen18(scheme, new Rectangle(3, 3, width - 4, height - 7));
            pen19 = ColorManager.Pen19(scheme);
            pen20 = ColorManager.Pen20(scheme);
            pen21 = ColorManager.Pen21(scheme);
            pen22 = ColorManager.Pen22(scheme);
            base.CreatePensBrushes();
         }
      }

      protected override void CreateRegion()
      {
         int width = base.Width;
         int height = base.Height;
         rects0 = new Rectangle[] {new Rectangle(2, 4, 2, height - 8), new Rectangle(width - 4, 4, 2, height - 8)};
         rects1 = new Rectangle[]
                     {
                        new Rectangle(2, 1, 2, 2), new Rectangle(1, 2, 2, 2), new Rectangle(width - 4, 1, 2, 2),
                        new Rectangle(width - 3, 2, 2, 2), new Rectangle(2, height - 3, 2, 2),
                        new Rectangle(1, height - 4, 2, 2), new Rectangle(width - 4, height - 3, 2, 2),
                        new Rectangle(width - 3, height - 4, 2, 2)
                     };
         Point[] points = new Point[]
                             {
                                new Point(1, 0), new Point(width - 1, 0), new Point(width - 1, 1), new Point(width, 1),
                                new Point(width, height - 1), new Point(width - 1, height - 1),
                                new Point(width - 1, height), new Point(1, height), new Point(1, height - 1),
                                new Point(0, height - 1), new Point(0, 1), new Point(1, 1)
                             };
         GraphicsPath path = new GraphicsPath();
         path.AddLines(points);
         base.Region = new Region(path);
         base.CreateRegion();
      }

      protected override void DisposePensBrushes()
      {
         if (brush01 != null)
         {
            brush01.Dispose();
         }
         if (bluesilverBrush02 != null)
         {
            bluesilverBrush02.Dispose();
         }
         if (bluesilverBrush03 != null)
         {
            bluesilverBrush03.Dispose();
         }
         if (oliveBrush02 != null)
         {
            oliveBrush02.Dispose();
         }
         if (oliveBrush03 != null)
         {
            oliveBrush03.Dispose();
         }
         if (blueBrush04 != null)
         {
            blueBrush04.Dispose();
         }
         if (oliveBrush04 != null)
         {
            oliveBrush04.Dispose();
         }
         if (silverBrush04 != null)
         {
            silverBrush04.Dispose();
         }
         if (brush05 != null)
         {
            brush05.Dispose();
         }
         if (silverBrush06 != null)
         {
            silverBrush06.Dispose();
         }
         if (silverBrush07 != null)
         {
            silverBrush07.Dispose();
         }
         if (silverBrush08 != null)
         {
            silverBrush08.Dispose();
         }
         if (brush09 != null)
         {
            brush09.Dispose();
         }
         if (bluesilverPen01 != null)
         {
            bluesilverPen01.Dispose();
         }
         if (bluesilverPen02 != null)
         {
            bluesilverPen02.Dispose();
         }
         if (bluesilverPen03 != null)
         {
            bluesilverPen03.Dispose();
         }
         if (bluesilverPen04 != null)
         {
            bluesilverPen04.Dispose();
         }
         if (bluesilverPen05 != null)
         {
            bluesilverPen05.Dispose();
         }
         if (bluesilverPen06 != null)
         {
            bluesilverPen06.Dispose();
         }
         if (bluesilverPen07 != null)
         {
            bluesilverPen07.Dispose();
         }
         if (bluesilverPen08 != null)
         {
            bluesilverPen08.Dispose();
         }
         if (bluesilverPen09 != null)
         {
            bluesilverPen09.Dispose();
         }
         if (bluesilverPen10 != null)
         {
            bluesilverPen10.Dispose();
         }
         if (bluesilverPen11 != null)
         {
            bluesilverPen11.Dispose();
         }
         if (bluesilverPen12 != null)
         {
            bluesilverPen12.Dispose();
         }
         if (bluesilverPen13 != null)
         {
            bluesilverPen13.Dispose();
         }
         if (bluesilverPen14 != null)
         {
            bluesilverPen14.Dispose();
         }
         if (bluesilverPen15 != null)
         {
            bluesilverPen15.Dispose();
         }
         if (bluesilverPen16 != null)
         {
            bluesilverPen16.Dispose();
         }
         if (olivePen01 != null)
         {
            olivePen01.Dispose();
         }
         if (olivePen02 != null)
         {
            olivePen02.Dispose();
         }
         if (olivePen03 != null)
         {
            olivePen03.Dispose();
         }
         if (olivePen04 != null)
         {
            olivePen04.Dispose();
         }
         if (olivePen05 != null)
         {
            olivePen05.Dispose();
         }
         if (olivePen06 != null)
         {
            olivePen06.Dispose();
         }
         if (olivePen07 != null)
         {
            olivePen07.Dispose();
         }
         if (olivePen08 != null)
         {
            olivePen08.Dispose();
         }
         if (olivePen09 != null)
         {
            olivePen09.Dispose();
         }
         if (olivePen10 != null)
         {
            olivePen10.Dispose();
         }
         if (olivePen11 != null)
         {
            olivePen11.Dispose();
         }
         if (olivePen12 != null)
         {
            olivePen12.Dispose();
         }
         if (olivePen13 != null)
         {
            olivePen13.Dispose();
         }
         if (olivePen14 != null)
         {
            olivePen14.Dispose();
         }
         if (olivePen15 != null)
         {
            olivePen15.Dispose();
         }
         if (olivePen16 != null)
         {
            olivePen16.Dispose();
         }
         if (pen17 != null)
         {
            pen17.Dispose();
         }
         if (pen18 != null)
         {
            pen18.Dispose();
         }
         if (pen19 != null)
         {
            pen19.Dispose();
         }
         if (pen20 != null)
         {
            pen20.Dispose();
         }
         if (pen21 != null)
         {
            pen21.Dispose();
         }
         if (pen22 != null)
         {
            pen22.Dispose();
         }
         if (pen23 != null)
         {
            pen23.Dispose();
         }
         if (pen24 != null)
         {
            pen24.Dispose();
         }
         if (_brush01 != null)
         {
            _brush01.Dispose();
         }
         if (_brush02 != null)
         {
            _brush02.Dispose();
         }
         if (_pen01 != null)
         {
            _pen01.Dispose();
         }
         if (_pen02 != null)
         {
            _pen02.Dispose();
         }
         base.DisposePensBrushes();
      }

      protected override void OnPaint(PaintEventArgs e)
      {
         int width = base.Width;
         int height = base.Height;
         CreatePensBrushes();
         e.Graphics.CompositingQuality = CompositingQuality.GammaCorrected;
         if (!base.Enabled)
         {
            e.Graphics.FillRectangle(_brush02, 2, 2, width - 4, height - 4);
            e.Graphics.DrawLine(_pen01, 3, 1, width - 4, 1);
            e.Graphics.DrawLine(_pen01, 3, height - 2, width - 4, height - 2);
            e.Graphics.DrawLine(_pen01, 1, 3, 1, height - 4);
            e.Graphics.DrawLine(_pen01, width - 2, 3, width - 2, height - 4);
            e.Graphics.DrawLine(_pen02, 1, 2, 2, 1);
            e.Graphics.DrawLine(_pen02, 1, height - 3, 2, height - 2);
            e.Graphics.DrawLine(_pen02, width - 2, 2, width - 3, 1);
            e.Graphics.DrawLine(_pen02, (width - 2), (height - 3), (width - 3), (height - 2));
            e.Graphics.FillRectangles(_brush01, rects1);
            goto Label_0D2E;
         }
         e.Graphics.FillRectangle(brush00, new Rectangle(0, 0, width, height));
         switch (base.state)
         {
            case States.Normal:
               switch (scheme)
               {
                  case Schemes.OliveGreen:
                     e.Graphics.FillRectangle(brush01, 2, 2, width - 4, height - 7);
                     e.Graphics.DrawLine(olivePen01, 2, height - 5, width - 2, height - 5);
                     e.Graphics.DrawLine(olivePen02, 2, height - 4, width - 2, height - 4);
                     e.Graphics.DrawLine(olivePen03, 2, height - 3, width - 2, height - 3);
                     e.Graphics.DrawLine(olivePen04, width - 4, 4, width - 4, height - 5);
                     e.Graphics.DrawLine(olivePen05, width - 3, 4, width - 3, height - 5);
                     if (base.isDefault)
                     {
                        e.Graphics.FillRectangles(oliveBrush02, rects0);
                        e.Graphics.DrawLine(olivePen06, 2, 2, width - 3, 2);
                        e.Graphics.DrawLine(olivePen07, 2, 3, width - 3, 3);
                        e.Graphics.DrawLine(olivePen08, 2, height - 4, width - 3, height - 4);
                        e.Graphics.DrawLine(olivePen09, 2, height - 3, width - 3, height - 3);
                     }
                     goto Label_0914;

                  case Schemes.Silver:
                     e.Graphics.FillRectangle(silverBrush06, 2, 2, width - 4, height - 4);
                     e.Graphics.FillRectangle(silverBrush07, 3, 4, width - 6, height - 8);
                     e.Graphics.FillRectangle(silverBrush08, 2, height - 4, width - 4, 2);
                     if (base.isDefault)
                     {
                        e.Graphics.FillRectangles(bluesilverBrush02, rects0);
                        e.Graphics.DrawLine(pen23, 3, 4, 3, height - 4);
                        e.Graphics.DrawLine(pen23, width - 4, 4, width - 4, height - 4);
                        e.Graphics.DrawLine(bluesilverPen06, 2, 2, width - 3, 2);
                        e.Graphics.DrawLine(bluesilverPen07, 2, 3, width - 3, 3);
                        e.Graphics.DrawLine(bluesilverPen08, 2, height - 4, width - 3, height - 4);
                        e.Graphics.DrawLine(bluesilverPen09, 2, height - 3, width - 3, height - 3);
                     }
                     goto Label_0914;
               }
               e.Graphics.FillRectangle(brush01, 2, 2, width - 4, height - 7);
               e.Graphics.DrawLine(bluesilverPen01, 2, height - 5, width - 2, height - 5);
               e.Graphics.DrawLine(bluesilverPen02, 2, height - 4, width - 2, height - 4);
               e.Graphics.DrawLine(bluesilverPen03, 2, height - 3, width - 2, height - 3);
               e.Graphics.DrawLine(bluesilverPen04, width - 4, 4, width - 4, height - 5);
               e.Graphics.DrawLine(bluesilverPen05, width - 3, 4, width - 3, height - 5);
               if (base.isDefault)
               {
                  e.Graphics.FillRectangles(bluesilverBrush02, rects0);
                  e.Graphics.DrawLine(bluesilverPen06, 2, 2, width - 3, 2);
                  e.Graphics.DrawLine(bluesilverPen07, 2, 3, width - 3, 3);
                  e.Graphics.DrawLine(bluesilverPen08, 2, height - 4, width - 3, height - 4);
                  e.Graphics.DrawLine(bluesilverPen09, 2, height - 3, width - 3, height - 3);
               }
               goto Label_0914;

            case States.MouseOver:
               switch (scheme)
               {
                  case Schemes.OliveGreen:
                     e.Graphics.FillRectangle(brush01, 2, 2, width - 4, height - 7);
                     e.Graphics.DrawLine(olivePen01, 2, height - 5, width - 4, height - 5);
                     e.Graphics.DrawLine(olivePen02, 2, height - 4, width - 4, height - 4);
                     e.Graphics.DrawLine(olivePen03, 2, height - 3, width - 4, height - 3);
                     e.Graphics.DrawLine(olivePen04, width - 4, 4, width - 4, height - 5);
                     e.Graphics.DrawLine(olivePen05, width - 3, 4, width - 3, height - 5);
                     e.Graphics.FillRectangles(oliveBrush03, rects0);
                     e.Graphics.DrawLine(olivePen10, 2, 2, width - 3, 2);
                     e.Graphics.DrawLine(olivePen11, 2, 3, width - 3, 3);
                     e.Graphics.DrawLine(olivePen12, 2, height - 4, width - 3, height - 4);
                     e.Graphics.DrawLine(olivePen13, 2, height - 3, width - 3, height - 3);
                     goto Label_0914;

                  case Schemes.Silver:
                     e.Graphics.FillRectangle(silverBrush06, 2, 2, width - 4, height - 4);
                     e.Graphics.FillRectangle(silverBrush07, 3, 4, width - 6, height - 8);
                     e.Graphics.FillRectangle(silverBrush08, 2, height - 4, width - 4, 2);
                     e.Graphics.FillRectangles(bluesilverBrush03, rects0);
                     e.Graphics.DrawLine(bluesilverPen10, 2, 2, width - 3, 2);
                     e.Graphics.DrawLine(bluesilverPen11, 2, 3, width - 3, 3);
                     e.Graphics.DrawLine(bluesilverPen12, 2, height - 4, width - 3, height - 4);
                     e.Graphics.DrawLine(bluesilverPen13, 2, height - 3, width - 3, height - 3);
                     goto Label_0914;
               }
               e.Graphics.FillRectangle(brush01, 2, 2, width - 4, height - 7);
               e.Graphics.DrawLine(bluesilverPen01, 2, height - 5, width - 4, height - 5);
               e.Graphics.DrawLine(bluesilverPen02, 2, height - 4, width - 4, height - 4);
               e.Graphics.DrawLine(bluesilverPen03, 2, height - 3, width - 4, height - 3);
               e.Graphics.DrawLine(bluesilverPen04, width - 4, 4, width - 4, height - 5);
               e.Graphics.DrawLine(bluesilverPen05, width - 3, 4, width - 3, height - 5);
               e.Graphics.FillRectangles(bluesilverBrush03, rects0);
               e.Graphics.DrawLine(bluesilverPen10, 2, 2, width - 3, 2);
               e.Graphics.DrawLine(bluesilverPen11, 2, 3, width - 3, 3);
               e.Graphics.DrawLine(bluesilverPen12, 2, height - 4, width - 3, height - 4);
               e.Graphics.DrawLine(bluesilverPen13, 2, height - 3, width - 3, height - 3);
               goto Label_0914;

            case States.Pushed:
               switch (scheme)
               {
                  case Schemes.Silver:
                     e.Graphics.FillRectangle(silverBrush06, 2, 2, width - 4, height - 4);
                     e.Graphics.FillRectangle(brush09, 3, 4, width - 6, height - 9);
                     e.Graphics.DrawLine(pen24, 4, 3, width - 4, 3);
                     goto Label_0914;
               }
               break;

            default:
               goto Label_0914;
         }
         e.Graphics.FillRectangle(brush05, 2, 4, width - 4, height - 8);
         e.Graphics.DrawLine(pen17, 2, 3, 2, height - 4);
         e.Graphics.DrawLine(pen18, 3, 3, 3, height - 4);
         e.Graphics.DrawLine(pen19, 2, 2, width - 3, 2);
         e.Graphics.DrawLine(pen20, 2, 3, width - 3, 3);
         e.Graphics.DrawLine(pen21, 2, height - 4, width - 3, height - 4);
         e.Graphics.DrawLine(pen22, 2, height - 3, width - 3, height - 3);
         Label_0914:
         switch (scheme)
         {
            case Schemes.OliveGreen:
               e.Graphics.DrawLine(olivePen15, 1, 3, 3, 1);
               e.Graphics.DrawLine(olivePen15, width - 2, 3, width - 4, 1);
               e.Graphics.DrawLine(olivePen15, 1, height - 4, 3, height - 2);
               e.Graphics.DrawLine(olivePen15, (width - 2), (height - 4), (width - 4), (height - 2));
               e.Graphics.DrawLine(olivePen16, 1, 2, 2, 1);
               e.Graphics.DrawLine(olivePen16, 1, height - 3, 2, height - 2);
               e.Graphics.DrawLine(olivePen16, width - 2, 2, width - 3, 1);
               e.Graphics.DrawLine(olivePen16, (width - 2), (height - 3), (width - 3), (height - 2));
               e.Graphics.DrawLine(olivePen14, 3, 1, width - 4, 1);
               e.Graphics.DrawLine(olivePen14, 3, height - 2, width - 4, height - 2);
               e.Graphics.DrawLine(olivePen14, 1, 3, 1, height - 4);
               e.Graphics.DrawLine(olivePen14, width - 2, 3, width - 2, height - 4);
               e.Graphics.FillRectangles(oliveBrush04, rects1);
               break;

            case Schemes.Silver:
               e.Graphics.DrawLine(bluesilverPen15, 1, 3, 3, 1);
               e.Graphics.DrawLine(bluesilverPen15, width - 2, 3, width - 4, 1);
               e.Graphics.DrawLine(bluesilverPen15, 1, height - 4, 3, height - 2);
               e.Graphics.DrawLine(bluesilverPen15, (width - 2), (height - 4), (width - 4), (height - 2));
               e.Graphics.DrawLine(bluesilverPen16, 1, 2, 2, 1);
               e.Graphics.DrawLine(bluesilverPen16, 1, height - 3, 2, height - 2);
               e.Graphics.DrawLine(bluesilverPen16, width - 2, 2, width - 3, 1);
               e.Graphics.DrawLine(bluesilverPen16, (width - 2), (height - 3), (width - 3), (height - 2));
               e.Graphics.DrawLine(bluesilverPen14, 3, 1, width - 4, 1);
               e.Graphics.DrawLine(bluesilverPen14, 3, height - 2, width - 4, height - 2);
               e.Graphics.DrawLine(bluesilverPen14, 1, 3, 1, height - 4);
               e.Graphics.DrawLine(bluesilverPen14, width - 2, 3, width - 2, height - 4);
               e.Graphics.FillRectangles(silverBrush04, rects1);
               break;

            default:
               e.Graphics.DrawLine(bluesilverPen15, 1, 3, 3, 1);
               e.Graphics.DrawLine(bluesilverPen15, width - 2, 3, width - 4, 1);
               e.Graphics.DrawLine(bluesilverPen15, 1, height - 4, 3, height - 2);
               e.Graphics.DrawLine(bluesilverPen15, (width - 2), (height - 4), (width - 4), (height - 2));
               e.Graphics.DrawLine(bluesilverPen16, 1, 2, 2, 1);
               e.Graphics.DrawLine(bluesilverPen16, 1, height - 3, 2, height - 2);
               e.Graphics.DrawLine(bluesilverPen16, width - 2, 2, width - 3, 1);
               e.Graphics.DrawLine(bluesilverPen16, (width - 2), (height - 3), (width - 3), (height - 2));
               e.Graphics.DrawLine(bluesilverPen14, 3, 1, width - 4, 1);
               e.Graphics.DrawLine(bluesilverPen14, 3, height - 2, width - 4, height - 2);
               e.Graphics.DrawLine(bluesilverPen14, 1, 3, 1, height - 4);
               e.Graphics.DrawLine(bluesilverPen14, width - 2, 3, width - 2, height - 4);
               e.Graphics.FillRectangles(blueBrush04, rects1);
               break;
         }
         if (Focused)
         {
            ControlPaint.DrawFocusRectangle(e.Graphics, new Rectangle(3, 3, width - 6, height - 6), Color.Black,
                                            BackColor);
         }
         Label_0D2E:
         base.OnPaint(e);
         DisposePensBrushes();
      }

      protected override void OnParentChanged(EventArgs e)
      {
         if (base.Parent != null)
         {
            BackColor = Color.FromArgb(0, base.Parent.BackColor);
            base.OnParentChanged(e);
         }
      }
   }
}