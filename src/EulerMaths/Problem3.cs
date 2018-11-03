using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Largest prime factor
  ///   <para>https://projecteuler.net/problem=3</para>
  /// </summary>
  internal class Problem3 : ProblemBase
  {
    public Problem3()
    {
      Problem = "Problem 3";
      Title = "Largest prime factor";
    }

    protected internal override long Answer()
    {
      const int x = 13261326;
      return Primes.TakeWhile(n => n <= x).Reverse().First(n => x % n == 0);
    }
  }
}