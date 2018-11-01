using System.Linq;

namespace EulerMaths
{
  /// <summary>
  /// Multiples of 3 and 5
  /// <para>https://projecteuler.net/problem=1</para>
  /// <para>If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.</para>
  /// <para></para>
  /// <para>Find the sum of all the multiples of 3 or 5 below 1000.</para>
  /// </summary>
  public static class Problem1
  {
    public static int Answer()
    {
      return Enumerable.Range(1, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
    }
  }
}
