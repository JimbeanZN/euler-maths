using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Even Fibonacci numbers
  ///   <para>https://projecteuler.net/problem=2</para>
  /// </summary>
  internal class Problem2 : ProblemBase<long>
  {
    public Problem2()
    {
      Problem = "Problem 2";
      Title = "Even Fibonacci numbers";
    }

    protected internal override long Answer()
    {
      return Fibonacci.TakeWhile(n => n < 4000000).Where(n => n % 2 == 0).Sum();
    }
  }
}