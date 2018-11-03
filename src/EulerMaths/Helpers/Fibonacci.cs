using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths.Helpers
{
  internal static class Fibonacci
  {
    public static IEnumerable<long> Take(int n)
    {
      return GetFibonacciSequence().Take(n).OrderBy(f => f);
    }

    public static IEnumerable<long> TakeWhile(Func<long, bool> predicate)
    {
      return GetFibonacciSequence().TakeWhile(predicate).OrderBy(f => f);
    }

    private static IEnumerable<long> GetFibonacciSequence()
    {
      var first = 0L;
      var second = 1L;

      yield return first;
      yield return second;

      while (true)
      {
        var current = first + second;
        yield return current;

        first = second;
        second = current;
      }
    }
  }
}
