using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths.Helpers
{
  internal static class Fibonacci
  {
    public static long At(int index)
    {
      return Take(index).Max();
    }

    public static IEnumerable<long> Take(int count)
    {
      return GetFibonacciSequence().Take(count);
    }

    public static IEnumerable<long> TakeWhile(Func<long, bool> predicate)
    {
      return GetFibonacciSequence().TakeWhile(predicate);
    }

    public static long First(Func<long, bool> predicate)
    {
      return GetFibonacciSequence().First(predicate);
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