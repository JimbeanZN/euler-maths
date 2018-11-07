using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerMaths
{
  /// <summary>
  ///   Smallest multiple
  ///   <para>https://projecteuler.net/problem=5</para>
  /// </summary>
  internal class Problem5 : ProblemBase<long>
  {
    public Problem5()
    {
      Problem = "Problem 5";
      Title = "Smallest multiple";
    }

    protected internal override long Answer()
    {
      var divisorRange = Enumerable.Range(1, 19).ToList();
      return Enumerable.Range(1, int.MaxValue).FirstOrDefault(i => divisorRange.All(divisor => i % divisor == 0));
    }
  }
}
