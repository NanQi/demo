using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Untity
{
   public static class PointUntity
   {
      public static int Distance(this Point p1, Point p2)
      {
         return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y);
      }

      public static List<Point> Within(this Point p, int distance)
      {
         List<Point> lstResult = new List<Point>();

         Func<int, List<Point>> func = dis =>
            {
               List<Point> lst = new List<Point>();

               foreach (var item in Enumerable.Range(1, dis))
               {
                  if (item != dis)
                  {
                     lst.Add(p + new Size(item, dis - Math.Abs(item)));
                     lst.Add(p + new Size(item, -(dis - Math.Abs(item))));
                     lst.Add(p + new Size(-item, dis - Math.Abs(item)));
                     lst.Add(p + new Size(-item, -(dis - Math.Abs(item))));
                  }
                  else
                  {
                     lst.Add(p + new Size(item, dis - Math.Abs(item)));
                     lst.Add(p + new Size(-item, dis - Math.Abs(item)));
                     lst.Add(p + new Size(dis - Math.Abs(item), item));
                     lst.Add(p + new Size(dis - Math.Abs(item), -item));
                  }

                  
               }

               return lst;
            };
           

         foreach (var item in Enumerable.Range(1, distance))
         {
            lstResult.AddRange(func(item));
         }

         return lstResult;
      }
   }
}
