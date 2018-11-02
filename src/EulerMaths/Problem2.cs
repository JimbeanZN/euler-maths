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
    private static readonly double Phi = (1 + Math.Sqrt(5))/2;
    private static int Fib(int index)
    {
      var asymp = Math.Pow(Phi, index) / Math.Sqrt(5);

      return Convert.ToInt32(Math.Round(asymp));
    }

    public static int Answer()
    {
      return Enumerable.Range(0, 40).Select(Fib).Where(n => n < 4000000 && n % 2 == 0).Sum();
    }
  }
}
