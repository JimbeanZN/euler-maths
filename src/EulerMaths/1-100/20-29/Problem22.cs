using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Names scores
  ///   <para>https://projecteuler.net/problem=22</para>
  /// </summary>
  internal class Problem22 : ProblemBase<long>
  {
    public Problem22()
    {
      Problem = "Problem 22";
      Title = "Names scores";
    }

    protected internal override long Answer()
    {
      return GetNames()
        .Select(n =>
          n.ToCharArray()
            .Sum(c => Convert.ToInt32(c) - 64))
        .Select((x, i) => x * (i + 1))
        .Sum();
    }

    private static IEnumerable<string> GetNames()
    {
      var rawNames = File.ReadAllText(@"..\..\..\Files\p022_names.txt");
      return rawNames.Split(',').AsParallel().Select(x => x.Replace("\"", "")).ToImmutableSortedSet();
    }
  }
}