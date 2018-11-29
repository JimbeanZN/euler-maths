using System;
using System.Linq;

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
      const long n = 10;
      var temp = n;

      for (var i = 1; i < n; i++)
      {
        temp *= (n - i);
      }

      return temp.ToString().ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
    }
  }
}