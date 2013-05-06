using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Untity
{
   public static class BitOperator
   {
      ///////////////////////////////////////////////////////////////////////
      // Get how many 1s in an integer's binary expression
      ///////////////////////////////////////////////////////////////////////
      public static int GetBinaryCount(int i)
      {
         int count = 0;

         while (Convert.ToBoolean(i))
         {
            ++count;
            i = (i - 1) & i;
         }

         return count;
      }
   }
}
