using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Largest prime factor
  ///   <para>https://projecteuler.net/problem=3</para>
  /// </summary>
  internal class Problem3 : ProblemBase<long>
  {
    public Problem3()
    {
      Problem = "Problem 3";
      Title = "Largest prime factor";
    }

    protected internal override long Answer()
    {
      const long x = 600851475143;
      return Primes.Take(1000).Reverse().First(n => x % n == 0);
    }
  }
}