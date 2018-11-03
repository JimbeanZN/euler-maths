using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Multiples of 3 and 5
  ///   <para>https://projecteuler.net/problem=1</para>
  /// </summary>
  internal class Problem1 : ProblemBase
  {
    public Problem1()
    {
      Problem = "Problem 1";
      Title = "Multiples of 3 and 5";
    }

    protected internal override long Answer()
    {
      return Enumerable.Range(1, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
    }
  }
}