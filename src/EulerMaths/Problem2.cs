using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  /// Even Fibonacci numbers
  /// <para>https://projecteuler.net/problem=2</para>
  /// </summary>
  internal class Problem2 : ProblemBase
  {
    public Problem2()
    {
      Problem = "Problem 2";
      Title = "Even Fibonacci numbers";
    }
    
    protected internal override long Answer()
    {
      return GetFibonacciSequence().TakeWhile(n => n < 4000000).Where(n => n % 2 == 0).Sum();
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
