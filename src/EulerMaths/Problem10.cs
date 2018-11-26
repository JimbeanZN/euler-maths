using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Summation of primes
  ///   <para>https://projecteuler.net/problem=10</para>
  /// </summary>
  internal class Problem10 : ProblemBase<long>
  {
    public Problem10()
    {
      Problem = "Problem 10";
      Title = "Summation of primes";
    }

    protected internal override long Answer()
    {
      return Primes.TakeWhile(n => n < 2000000).Sum();
    }
  }
}