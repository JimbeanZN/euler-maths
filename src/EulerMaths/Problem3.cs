using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  /// Largest prime factor
  /// <para>https://projecteuler.net/problem=3</para>
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
      var primes = Primes.Take(20);

      return 0;
    }
  }
}
