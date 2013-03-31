
/* By NanQi 201209 in Internet */

using System.Runtime.InteropServices;
using System.Text;

namespace PinkieControls
{
   public class WinAPI
   {
      [DllImport("UxTheme.dll", CharSet = CharSet.Unicode)]
      public static extern int GetCurrentThemeName(StringBuilder pszThemeFileName, int dwMaxNameChars,
                                                   StringBuilder pszColorBuff, int cchMaxColorChars,
                                                   StringBuilder pszSizeBuff, int cchMaxSizeChars);

      [DllImport("UxTheme.dll")]
      public static extern bool IsAppThemed();
   }
}