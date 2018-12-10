using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   10001st prime
  ///   <para>https://projecteuler.net/problem=7</para>
  /// </summary>
  internal class Problem7 : ProblemBase<long>
  {
    public Problem7()
    {
      Problem = "Problem 7";
      Title = "10001st prime";
    }

    protected internal override long Answer()
    {
      return Primes.Take(10001).Last();
    }
  }
}