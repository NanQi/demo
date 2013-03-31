
/* By NanQi 201209 in Internet */

using System.Drawing;
using System.Drawing.Drawing2D;
using NanQi.Controls.PinkieControls;

namespace PinkieControls
{
   public class ColorManager
   {
      public static SolidBrush _Brush01(ButtonXP.Schemes scheme)
      {
         switch (scheme)
         {
            case ButtonXP.Schemes.OliveGreen:
               return new SolidBrush(Color.FromArgb(0x40, 0xca, 0xc4, 0xb8));

            case ButtonXP.Schemes.Silver:
               return new SolidBrush(Color.FromArgb(0x40, 0xc4, 0xc3, 0xbf));
         }
         return new SolidBrush(Color.FromArgb(0x40, 0xc9, 0xc7, 0xba));
      }

      public static SolidBrush _Brush02(ButtonXP.Schemes scheme)
      {
         switch (scheme)
         {
            case ButtonXP.Schemes.OliveGreen:
               return new SolidBrush(Color.FromArgb(0xf6, 0xf2, 0xe9));

            case ButtonXP.Schemes.Silver:
               return new SolidBrush(Color.FromArgb(0xf1, 0xf1, 0xed));
         }
         return new SolidBrush(Color.FromArgb(0xf5, 0xf4, 0xea));
      }

      public static Pen _Pen01(ButtonXP.Schemes scheme)
      {
         switch (scheme)
         {
            case ButtonXP.Schemes.OliveGreen:
               return new Pen(Color.FromArgb(0xca, 0xc4, 0xb8));

            case ButtonXP.Schemes.Silver:
               return new Pen(Color.FromArgb(0xc4, 0xc3, 0xbf));
         }
         return new Pen(Color.FromArgb(0xc9, 0xc7, 0xba));
      }

      public static Pen _Pen02(ButtonXP.Schemes scheme)
      {
         switch (scheme)
         {
            case ButtonXP.Schemes.OliveGreen:
               return new Pen(Color.FromArgb(170, 0xca, 0xc4, 0xb8));

            case ButtonXP.Schemes.Silver:
               return new Pen(Color.FromArgb(170, 0xc4, 0xc3, 0xbf));
         }
         return new Pen(Color.FromArgb(170, 0xc9, 0xc7, 0xba));
      }

      public static LinearGradientBrush Brush00(Rectangle rect)
      {
         return new LinearGradientBrush(rect, Color.FromArgb(0x40, 0xab, 0xa8, 0x89),
                                        Color.FromArgb(0x5c, 0xff, 0xff, 0xff), 85f);
      }

      public static LinearGradientBrush Brush01(ButtonXP.Schemes scheme, Rectangle rect)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new LinearGradientBrush(rect, Color.FromArgb(0xff, 0xff, 0xf6), Color.FromArgb(0xf6, 0xf3, 0xe0), 90f);
         }
         return new LinearGradientBrush(rect, Color.FromArgb(0xff, 0xff, 0xff), Color.FromArgb(240, 240, 0xea), 90f);
      }

      public static LinearGradientBrush Brush02(ButtonXP.Schemes scheme, Rectangle rect)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new LinearGradientBrush(rect, Color.FromArgb(0xb1, 0xcb, 0x80), Color.FromArgb(0x90, 0xc1, 0x54), 90f);
         }
         return new LinearGradientBrush(rect, Color.FromArgb(0xba, 0xd3, 0xf5), Color.FromArgb(0x89, 0xad, 0xe4), 90f);
      }

      public static LinearGradientBrush Brush03(ButtonXP.Schemes scheme, Rectangle rect)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new LinearGradientBrush(rect, Color.FromArgb(0xed, 190, 150), Color.FromArgb(0xe3, 0x91, 0x4f), 90f);
         }
         return new LinearGradientBrush(rect, Color.FromArgb(0xfd, 0xd8, 0x89), Color.FromArgb(0xf8, 0xb2, 0x30), 90f);
      }

      public static SolidBrush Brush04(ButtonXP.Schemes scheme)
      {
         switch (scheme)
         {
            case ButtonXP.Schemes.OliveGreen:
               return new SolidBrush(Color.FromArgb(0x5c, 0x6d, 0x8a, 0x4d));

            case ButtonXP.Schemes.Silver:
               return new SolidBrush(Color.FromArgb(0x5c, 0x55, 0x7d, 0xa2));
         }
         return new SolidBrush(Color.FromArgb(0x5c, 0x55, 0x7d, 0xa2));
      }

      public static LinearGradientBrush Brush05(ButtonXP.Schemes scheme, Rectangle rect)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new LinearGradientBrush(rect, Color.FromArgb(0xee, 230, 210), Color.FromArgb(0xec, 0xe4, 0xce), 90f);
         }
         return new LinearGradientBrush(rect, Color.FromArgb(0xe5, 0xe4, 0xdd), Color.FromArgb(0xe2, 0xe2, 0xda), 90f);
      }

      public static SolidBrush Brush06()
      {
         return new SolidBrush(Color.FromArgb(0xff, 0xff, 0xff));
      }

      public static LinearGradientBrush Brush07(Rectangle rect)
      {
         LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(0xfd, 0xfd, 0xfd),
                                                             Color.FromArgb(0xc9, 200, 220), 90f);
         float[] numArray3 = new float[3];
         numArray3[1] = 0.008f;
         numArray3[2] = 1f;
         float[] numArray = numArray3;
         numArray3 = new float[3];
         numArray3[1] = 0.32f;
         numArray3[2] = 1f;
         float[] numArray2 = numArray3;
         Blend blend = new Blend();
         blend.Factors = numArray;
         blend.Positions = numArray2;
         brush.Blend = blend;
         return brush;
      }

      public static SolidBrush Brush08()
      {
         return new SolidBrush(Color.FromArgb(0xc6, 0xc5, 0xd7));
      }

      public static LinearGradientBrush Brush09(Rectangle rect)
      {
         LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(0xac, 0xab, 0xbf),
                                                             Color.FromArgb(0xf8, 0xfc, 0xfd), 90f);
         float[] numArray3 = new float[3];
         numArray3[1] = 0.992f;
         numArray3[2] = 1f;
         float[] numArray = numArray3;
         numArray3 = new float[3];
         numArray3[1] = 0.68f;
         numArray3[2] = 1f;
         float[] numArray2 = numArray3;
         Blend blend = new Blend();
         blend.Factors = numArray;
         blend.Positions = numArray2;
         brush.Blend = blend;
         return brush;
      }

      public static Pen Pen01(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xf3, 0xee, 0xdb));
         }
         return new Pen(Color.FromArgb(0xec, 0xeb, 230));
      }

      public static Pen Pen02(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xec, 0xe1, 0xc9));
         }
         return new Pen(Color.FromArgb(0xe2, 0xdf, 0xd6));
      }

      public static Pen Pen03(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xe3, 0xd1, 0xb8));
         }
         return new Pen(Color.FromArgb(0xd6, 0xd0, 0xc5));
      }

      public static Pen Pen04(ButtonXP.Schemes scheme, Rectangle rect)
      {
         LinearGradientBrush brush;
         Pen pen;
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            brush = new LinearGradientBrush(rect, Color.FromArgb(0xfb, 0xf7, 0xe8),
                                            Color.FromArgb(0x40, 0xd8, 0xb5, 0x90), 90f);
            pen = new Pen(brush);
            brush.Dispose();
            return pen;
         }
         brush = new LinearGradientBrush(rect, Color.FromArgb(0xf5, 0xf4, 0xf2), Color.FromArgb(0x40, 0xba, 0xae, 160),
                                         90f);
         pen = new Pen(brush);
         brush.Dispose();
         return pen;
      }

      public static Pen Pen05(ButtonXP.Schemes scheme, Rectangle rect)
      {
         LinearGradientBrush brush;
         Pen pen;
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            brush = new LinearGradientBrush(rect, Color.FromArgb(0xf6, 0xf1, 0xe0),
                                            Color.FromArgb(0x40, 0xc2, 0x9c, 120), 90f);
            pen = new Pen(brush);
            brush.Dispose();
            return pen;
         }
         brush = new LinearGradientBrush(rect, Color.FromArgb(240, 0xee, 0xea), Color.FromArgb(0x40, 0xaf, 0xa8, 0x8e),
                                         90f);
         pen = new Pen(brush);
         brush.Dispose();
         return pen;
      }

      public static Pen Pen06(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xc2, 0xd1, 0x8f));
         }
         return new Pen(Color.FromArgb(0xce, 0xe7, 0xff));
      }

      public static Pen Pen07(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xb1, 0xcb, 0x80));
         }
         return new Pen(Color.FromArgb(0xbc, 0xd4, 0xf6));
      }

      public static Pen Pen08(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0x90, 0xc1, 0x54));
         }
         return new Pen(Color.FromArgb(0x89, 0xad, 0xe4));
      }

      public static Pen Pen09(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xa8, 0xa7, 0x66));
         }
         return new Pen(Color.FromArgb(0x69, 130, 0xee));
      }

      public static Pen Pen10(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xfc, 0xc5, 0x95));
         }
         return new Pen(Color.FromArgb(0xff, 240, 0xcf));
      }

      public static Pen Pen11(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xed, 190, 150));
         }
         return new Pen(Color.FromArgb(0xfd, 0xd8, 0x89));
      }

      public static Pen Pen12(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xe3, 0x91, 0x4f));
         }
         return new Pen(Color.FromArgb(0xf8, 0xb2, 0x30));
      }

      public static Pen Pen13(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xcf, 0x72, 0x25));
         }
         return new Pen(Color.FromArgb(0xe5, 0x97, 0));
      }

      public static Pen Pen14(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0x37, 0x62, 6));
         }
         return new Pen(Color.FromArgb(0, 60, 0x74));
      }

      public static Pen Pen15(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0x6d, 0x8a, 0x4d));
         }
         return new Pen(Color.FromArgb(0x55, 0x7d, 0xa2));
      }

      public static Pen Pen16(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xc0, 0x6d, 0x8a, 0x4d));
         }
         return new Pen(Color.FromArgb(0xc0, 0x55, 0x7d, 0xa2));
      }

      public static Pen Pen17(ButtonXP.Schemes scheme, Rectangle rect)
      {
         LinearGradientBrush brush;
         Pen pen;
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            brush = new LinearGradientBrush(rect, Color.FromArgb(0xe4, 0xd4, 0xbf), Color.FromArgb(0xe5, 0xd9, 0xc3),
                                            90f);
            pen = new Pen(brush);
            brush.Dispose();
            return pen;
         }
         brush = new LinearGradientBrush(rect, Color.FromArgb(0xd8, 0xd4, 0xcb), Color.FromArgb(0xda, 0xd8, 0xcf), 90f);
         pen = new Pen(brush);
         brush.Dispose();
         return pen;
      }

      public static Pen Pen18(ButtonXP.Schemes scheme, Rectangle rect)
      {
         LinearGradientBrush brush;
         Pen pen;
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            brush = new LinearGradientBrush(rect, Color.FromArgb(0xe8, 0xdb, 0xc5), Color.FromArgb(0xea, 0xe0, 0xc9),
                                            90f);
            pen = new Pen(brush);
            brush.Dispose();
            return pen;
         }
         brush = new LinearGradientBrush(rect, Color.FromArgb(0xdd, 0xda, 0xd1), Color.FromArgb(0xdf, 0xde, 0xd6), 90f);
         pen = new Pen(brush);
         brush.Dispose();
         return pen;
      }

      public static Pen Pen19(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xdf, 0xcd, 180));
         }
         return new Pen(Color.FromArgb(0xd1, 0xcc, 0xc0));
      }

      public static Pen Pen20(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xe7, 0xd9, 0xc3));
         }
         return new Pen(Color.FromArgb(220, 0xd8, 0xcf));
      }

      public static Pen Pen21(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xf2, 0xec, 0xd8));
         }
         return new Pen(Color.FromArgb(0xea, 0xe9, 0xe3));
      }

      public static Pen Pen22(ButtonXP.Schemes scheme)
      {
         if (scheme == ButtonXP.Schemes.OliveGreen)
         {
            return new Pen(Color.FromArgb(0xf8, 0xf4, 0xe4));
         }
         return new Pen(Color.FromArgb(0xf2, 0xf1, 0xee));
      }

      public static Pen Pen23()
      {
         return new Pen(Color.FromArgb(0xff, 0xff, 0xff));
      }

      public static Pen Pen24()
      {
         return new Pen(Color.FromArgb(0xac, 0xab, 0xbd));
      }
   }
}