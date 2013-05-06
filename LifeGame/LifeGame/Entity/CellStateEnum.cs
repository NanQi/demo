using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGame
{
   public static class CellStateEnum
   {
      public const int 没有状态         = 0x00000000;
      public const int 战斗中           = 0x00000001;
      public const int 逃跑             = 0x00000002;
      public const int 濒死             = 0x00000004;

      //战斗
      /// <summary>
      /// 每回合 0.5 * 敏捷几率解除被拌摔效果
      /// </summary>
      public const int 被拌摔           = 0x00000008;
   }
}
