using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Untity;

namespace UntityTest
{
   class Program
   {
      static void Main(string[] args)
      {
         Point p1 = new Point(3, 3);
         Point p2 = new Point(3, 1);
         Point p3 = new Point(2, 1);
         Point p4 = new Point(1, 1);

         //Console.WriteLine(p1.Distance(p2));
         //Console.WriteLine(p1.Distance(p3));
         //Console.WriteLine(p1.Distance(p4));

         p1.Within(2).ForEach(p =>
            Console.WriteLine(p));

         //RandomUntity ran = new RandomUntity();
         //ran.GetRandom(1, 100, 100).ToList().ForEach(i=>
         //   Console.Write(i + "\t"));

         //Console.WriteLine(BitOperator.GetBinaryCount(0x00042400));
      }
   }
}
