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

      yield return primeCandidate;
      primeCandidate++;

      while (true)
      {
        if (IsPrime(primeCandidate))
        {
          yield return primeCandidate;
        }

        primeCandidate += 2;
      }
    }

    private static bool IsPrime(long primeCandidate)
    {
      for (var i = 3; i <= (long) Math.Ceiling(Math.Sqrt(primeCandidate)); i += 2)
        if (primeCandidate % i == 0)
        {
          return false;
        }

      return primeCandidate != 1;
    }
  }
}