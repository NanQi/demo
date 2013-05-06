using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LifeGame
{
   public static class Rule
   {
      #region Field
      public const int ROWS = 40;
      public const int COLUMNS = 40;

      public const int CELLWIDTH = 11;

      public static Pen GRIDPEN = new Pen(Color.FromArgb(0x33, 0x33, 0x33));

      static Random _ran = new Random();

      public static ulong GameTime = 0;

      public const int 可分配点 = 6;
      public const int 初始属性点 = 3;
      public const int 初始HP = 20;
      public const int 初始白天视野 = 3;
      public const int 初始夜晚视野 = 1;
      public const int 初始速度 = 1;
      public const int 初始能力 = 3;

      public const int 可获取属性点 = 5;

      public const double 获取属性点几率 = 0.1;
      #endregion

      public static bool IsDay
      {
         get
         {
            return (GameTime & 9) > 4 ? true : false;
         }
      }

      public static int Dice
      {
         get
         {
            return _ran.Next(6) + 1;
         }
      }

      public static int Dice3
      {
         get
         {
            return Dice - 3;
         }
      }
   }
}
