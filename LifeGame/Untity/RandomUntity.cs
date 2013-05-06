using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Untity
{
   public class RandomUntity : Random
   {
      /// <summary>
      /// 获取不重复随机整数（minValue最小取1）
      /// </summary>
      /// <param name="minValue">最小值（最小取1）</param>
      /// <param name="maxValue">最大值</param>
      /// <param name="count">数量</param>
      /// <returns></returns>
      public int[] GetNotRepeatRandom(int minValue, int maxValue, int count)
      {
         int[] intList = new int[maxValue];

         for (int i = 0; i < maxValue; i++)
         {
            intList[i] = i + minValue;
         }

         int[] intRet = new int[count];
         int n = maxValue;

         for (int i = 0; i < count; i++)
         {
            int index = base.Next(0, n);
            intRet[i] = intList[index];
            intList[index] = intList[--n];
         }

         return intRet;
      }

      public bool Probability(double pro)
      {
         if (base.NextDouble() < pro)
         {
            return true;
         }

         return false;
      }

   }
}
