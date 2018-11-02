using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  /// Even Fibonacci numbers
  /// <para>https://projecteuler.net/problem=2</para>
  /// </summary>
  public static class Problem2
  {
    private const string Problem = "Problem 2";
    private const string Title = "Even Fibonacci numbers";
    
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

    private static long Answer()
    {
      return GetFibonacciSequence().TakeWhile(n => n < 4000000).Where(n => n % 2 == 0).Sum();
    }

    public static string GetAnswer()
    {
      var watch = System.Diagnostics.Stopwatch.StartNew();
      var answer = Answer();
      watch.Stop();

      return $"{Problem} - {Title}: {answer}. Execution time in ms: {watch.ElapsedMilliseconds}";
    }
  }
}
