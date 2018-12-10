using System;
using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Power digit sum
  ///   <para>https://projecteuler.net/problem=16</para>
  /// </summary>
  internal class Problem16 : ProblemBase<long>
  {
    public Problem16()
    {
      Problem = "Problem 16";
      Title = "Power digit sum";
    }

    protected internal override long Answer()
    {
      const int baseValue = 2;
      const int power = 1000;
      var answer = LargeNumberMultiplication.Calculate(baseValue, power, 0, iterationEnd => iterationEnd - 1,
        (nextMultiplier, iteration) => nextMultiplier);

      return answer.ToCharArray().Sum(n => Convert.ToInt32(n.ToString()));
    }
  }
}