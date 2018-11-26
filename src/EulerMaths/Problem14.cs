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
      return Enumerable.Range(0, 1000000)
        .AsParallel()
        .Select(n => (n, GetCollatzSequenceCount(n)))
        .AsSequential()
        .OrderBy(n => n.Item2).Last()
        .n;
    }

    private static int GetCollatzSequenceCount(long candidate)
    {
      var sequenceCount = 0;
      while (candidate >= 1)
      {
        sequenceCount++;

        if (candidate == 1)
          break;

        candidate = (candidate % 2 == 0) ? EvenCollatz(candidate) : OddCollatz(candidate);
      }

      return sequenceCount;
    }

    private static long EvenCollatz(long n)
    {
      return n / 2;
    }

    private static long OddCollatz(long n)
    {
      return (3*n) + 1;
    }
  }
}