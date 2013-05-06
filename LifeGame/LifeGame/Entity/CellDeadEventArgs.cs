using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeGame
{
   public class CellDeadEventArgs : EventArgs
   {
      public Cell Killer { get; set; }

      public int LastHurt { get; set; }
   }
}
