using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Highly divisible triangular number
  ///   <para>https://projecteuler.net/problem=12</para>
  /// </summary>
  internal class Problem12 : ProblemBase<long>
  {
    public Problem12()
    {
      Problem = "Problem 12";
      Title = "Highly divisible triangular number";
    }

    protected internal override long Answer()
    {
      var takeWhile = GetTriangleSequence().Take(10000).ToList();

      return 0;
    }

    private static IEnumerable<Tuple<long, int>> GetTriangleSequence()
    {
      var n = 1L;
      var candidate = 1L;

      yield return new Tuple<long, int>(candidate, 1);
      n++;
      candidate += n;

      while (true)
      {
        var answers = new List<long>();
        for (var i = 1L; i <= candidate; i++)
        {
          if (answers.Any(x => x == i))
          {
            break;
          }

          if (candidate % i != 0) continue;
          answers.Add(i);
          answers.Add(candidate / i);
        }

        yield return new Tuple<long, int>(candidate, answers.Count);

        n++;
        candidate += n;
      }
    }
  }
}