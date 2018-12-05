using System;
using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Factorial digit sum
  ///   <para>https://projecteuler.net/problem=20</para>
  /// </summary>
  internal class Problem20 : ProblemBase<long>
  {
    public Problem20()
    {
      Problem = "Problem 20";
      Title = "Factorial digit sum";
    }

    protected internal override long Answer()
    {
      const long n = 100;
      var answer = LargeNumberMultiplication.Calculate(n, n, 1, iterationEnd => iterationEnd,
        (nextMultiplier, iteration) => nextMultiplier - iteration);

      return answer.ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
    }
  }
}