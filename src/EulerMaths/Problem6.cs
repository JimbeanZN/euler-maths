using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Sum square difference
  ///   <para>https://projecteuler.net/problem=6</para>
  /// </summary>
  internal class Problem6 : ProblemBase<long>
  {
    public Problem6()
    {
      Problem = "Problem 6";
      Title = "Sum square difference";
    }

    protected internal override long Answer()
    {
      const int range = 100;
      const int power = 2;
      var sumOfSquares = Enumerable.Range(1, range).Select(n => Math.Pow(n, power)).Sum();
      var squareOfSum = Math.Pow(Enumerable.Range(1, range).Sum(), power);
      return Convert.ToInt64(squareOfSum - sumOfSquares);
    }
  }
}
