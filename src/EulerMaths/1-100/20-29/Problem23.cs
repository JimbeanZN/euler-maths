using System.Collections.Generic;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Non-abundant sums
  ///   <para>https://projecteuler.net/problem=23</para>
  /// </summary>
  internal class Problem23 : ProblemBase<long>
  {
    public Problem23()
    {
      Problem = "Problem 23";
      Title = "Non-abundant sums";
    }

    protected internal override long Answer()
    {
      var baseNumbers = Enumerable.Range(1, 28123).ToList();
      var abundantNumbers = baseNumbers.AsParallel().Where(IsAbundantNumber).ToList();
      var abundantSums = new List<int>();

      for (var i = 0; i < abundantNumbers.Count(); i++)
      for (var j = i; j < abundantNumbers.Count(); j++)
        abundantSums.Add(abundantNumbers[i] + abundantNumbers[j]);

      return baseNumbers.Except(abundantSums).Sum();
    }

    private static bool IsAbundantNumber(int num)
    {
      return Enumerable.Range(1, num - 1).Where(n => num % n == 0).Sum() > num;
    }
  }
}