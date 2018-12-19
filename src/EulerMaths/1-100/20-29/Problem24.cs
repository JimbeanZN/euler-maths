using System;
using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   Lexicographic permutations
  ///   <para>https://projecteuler.net/problem=24</para>
  /// </summary>
  internal class Problem24 : ProblemBase<string>
  {
    public Problem24()
    {
      Problem = "Problem 24";
      Title = "Lexicographic permutations";
    }

    protected internal override string Answer()
    {
      var numbers = Enumerable.Range(0, 10).ToList();
      var removalables = Enumerable.Range(0, 10).ToList();
      var n = 999999;
      var answer = "";

      for (var i = numbers.Count - 1; i >= 0; i--)
      {
        var factorial = Convert.ToInt32(LargeNumberMultiplication.Calculate(numbers[i], numbers[i], 1,
          iterationEnd => iterationEnd,
          (nextMultiplier, iteration) => nextMultiplier - iteration));
        var x = (n / factorial) | 0;
        answer += removalables[x].ToString();
        removalables.RemoveAt(x);
        n = n % factorial;

        if (n != 0)
        {
          continue;
        }

        answer += n;
        break;
      }

      return answer;
    }
  }
}