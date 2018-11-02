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
    private static readonly double Phi = (1 + Math.Sqrt(5)) / 2;

    private static long Fib(int index)
    {
      var asymp = Math.Pow(Phi, index) / Math.Sqrt(5);

      return Convert.ToInt64(Math.Round(asymp));
    }

    private static long Answer()
    {
      return Enumerable.Range(0, 50).Select(Fib).Where(n => n < 4000000 && n % 2 == 0).Sum();
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
