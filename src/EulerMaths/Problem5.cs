using System;
using System.Collections.Generic;
using System.Linq;

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
      var divisorRange = Enumerable.Range(1, 10).ToList();
      var result = Enumerable.Range(1, int.MaxValue).FirstOrDefault(n => divisorRange.All(divisor => n % divisor == 0));
      
      divisorRange = Enumerable.Range(11, 9).ToList();
      return CustomRange(result, n => n + result).FirstOrDefault(n => divisorRange.All(divisor => n % divisor == 0));
    }

    private static IEnumerable<long> CustomRange(long start, Func<long, long> step)
    {
      var n = start;
      while (true)
      {
        yield return n;
        n = step(n);
      }
    }
  }
}