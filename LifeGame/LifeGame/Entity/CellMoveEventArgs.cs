using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LifeGame
{
   public class CellMoveEventArgs : EventArgs
   {
      public Point OriginPosition { get; set; }
      public Point TargetPosition { get; set; }
   }
}
