using System.Collections.Generic;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Amicable numbers
  ///   <para>https://projecteuler.net/problem=21</para>
  /// </summary>
  internal class Problem21 : ProblemBase<long>
  {
    public Problem21()
    {
      Problem = "Problem 21";
      Title = "Amicable numbers";
    }

    protected internal override long Answer()
    {
      var range = Enumerable.Range(1, 10000).Select(x => new Problem21Divisor
      {
        Number = x,
        Divisors = new List<int>()
      }).ToList();

      for (var i = 0; i < range.Count(); i++)
      {
        var n = range[i].Number;

        for (var j = 1; j <= i; j++)
          if (n % j == 0)
          {
            range[i].Divisors.Add(j);
          }
      }

      var amicableNumbers = new List<Problem21Divisor>();

      foreach (var problem21Divisor in range)
      {
        if (amicableNumbers.Any(n => n.Number == problem21Divisor.Number))
        {
          continue;
        }

        var firstOrDefault = range.FirstOrDefault(n =>
          problem21Divisor.DivisorsSum == n.Number && problem21Divisor.Number == n.DivisorsSum &&
          problem21Divisor.Number != n.Number);

        if (firstOrDefault == null)
        {
          continue;
        }

        amicableNumbers.Add(problem21Divisor);
        amicableNumbers.Add(firstOrDefault);
      }

      return amicableNumbers.Sum(n => n.Number);
    }

    private class Problem21Divisor
    {
      public int Number { get; set; }
      public List<int> Divisors { get; set; }
      public int DivisorsSum => Divisors.Sum();
    }
  }
}