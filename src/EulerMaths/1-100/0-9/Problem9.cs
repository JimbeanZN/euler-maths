using System;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Special Pythagorean triplet
  ///   <para>https://projecteuler.net/problem=9</para>
  /// </summary>
  internal class Problem9 : ProblemBase<long>
  {
    public Problem9()
    {
      Problem = "Problem 9";
      Title = "Special Pythagorean triplet";
    }

    protected internal override long Answer()
    {
      const int target = 1000;
      var combo = (
          from first in Enumerable.Range(1, target)
          from second in Enumerable.Range(1, target)
          where first < second
                && Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2)) % 1 == 0
          select new Tuple<int, int, int>(first, second,
            Convert.ToInt32(Math.Sqrt(Math.Pow(first, 2) + Math.Pow(second, 2)))))
        .First(n => n.Item1 + n.Item2 + n.Item3 == target);

      return combo.Item1 * combo.Item2 * combo.Item3;
    }
  }
}