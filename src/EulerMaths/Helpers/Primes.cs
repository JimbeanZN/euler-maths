using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths.Helpers
{
  internal static class Primes
  {
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
      var primeCandidate = 0L;
      
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
      if ((primeCandidate & 1) == 0)
      {
        return primeCandidate == 2 ? true : false;
      }

      for (var i = 3; (i * i) <= primeCandidate; i += 2)
      {
        if (primeCandidate % i == 0)
        {
          return false;
        }
      }

      return primeCandidate != 1;
    }
  }
}
