using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths.Helpers
{
  internal static class Primes
  {
    public static long At(int index)
    {
      return Take(index).Max();
    }

    public static IEnumerable<long> Take(int n)
    {
      return GetPrimeSequence().Take(n);
    }

    public static IEnumerable<long> TakeWhile(Func<long, bool> predicate)
    {
      return GetPrimeSequence().TakeWhile(predicate);
    }

    private static IEnumerable<long> GetPrimeSequence()
    {
      var primeCandidate = 2L;

      while (true)
      {
        if (IsPrime(primeCandidate))
        {
          yield return primeCandidate;
        }

        primeCandidate++;
      }
    }

    private static bool IsPrime(long primeCandidate)
    {
      return Enumerable.Range(2, (int) Math.Sqrt(primeCandidate) - 1).All(divisor => primeCandidate % divisor != 0);
    }
  }
}