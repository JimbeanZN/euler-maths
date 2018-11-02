using System.Linq;

namespace EulerMaths
{
  /// <summary>
  /// Multiples of 3 and 5
  /// <para>https://projecteuler.net/problem=1</para>
  /// </summary>
  public static class Problem1
  {
    public static long Answer()
    {
      return Enumerable.Range(1, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
    }
  }
}
