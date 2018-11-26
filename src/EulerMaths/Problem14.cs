using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Longest Collatz sequence
  ///   <para>https://projecteuler.net/problem=14</para>
  /// </summary>
  internal class Problem14 : ProblemBase<long>
  {
    public Problem14()
    {
      Problem = "Problem 14";
      Title = "Longest Collatz sequence";
    }

    protected internal override long Answer()
    {
      return Enumerable.Range(0, 1000000).AsParallel()
        .Select(n => new Tuple<int, IEnumerable<long>>(n, GetCollatzSequence(n)))
        .OrderBy(n => n.Item2.Count()).Last()
        .Item1;
    }

    private IEnumerable<long> GetCollatzSequence(long candidate)
    {
      var sequence = new List<long>();
      while (candidate >= 1)
      {
        sequence.Add(candidate);

        if (candidate == 1)
          break;

        candidate = (candidate % 2 == 0) ? EvenCollatz(candidate) : OddCollatz(candidate);
      }

      return sequence;
    }

    private static long EvenCollatz(long n)
    {
      if(n%2 == 0)
        return n / 2;

      throw new ArgumentException();
    }

    private static long OddCollatz(long n)
    {
      if(n%2 != 0)
        return (3*n) + 1;

      throw new ArgumentException();
    }
  }
}