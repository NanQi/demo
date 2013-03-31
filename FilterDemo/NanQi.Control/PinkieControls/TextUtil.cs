
/* By NanQi 201209 in Internet */

using System.Drawing;

namespace PinkieControls
{
   public class TextUtil
   {
      private TextUtil()
      {
      }

      public static Size GetTextSize(Graphics graphics, string text, Font font, Size size)
      {
         if (text.Length == 0)
         {
            return Size.Empty;
         }
         StringFormat stringFormat = new StringFormat();
         stringFormat.FormatFlags = StringFormatFlags.FitBlackBox;
         RectangleF layoutRect = new RectangleF(0f, 0f, size.Width, size.Height);
         CharacterRange[] ranges = new CharacterRange[] {new CharacterRange(0, text.Length)};
         Region[] regionArray = new Region[1];
         stringFormat.SetMeasurableCharacterRanges(ranges);
         Rectangle rectangle =
            Rectangle.Round(graphics.MeasureCharacterRanges(text, font, layoutRect, stringFormat)[0].GetBounds(graphics));
         return new Size(rectangle.Width, rectangle.Height);
      }
   }
}