using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Untity
{
   public static class LinqExpand
   {
      static RandomUntity _random = new RandomUntity();

      public static TSource RandomElement<TSource>(this IEnumerable<TSource> source)
      {
         return source.DefaultIfEmpty().ElementAt(_random.Next(source.Count()));
      }

      public static TSource RandomElement<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
      {
         return source.Where(predicate).RandomElement();
      }
   }
}
