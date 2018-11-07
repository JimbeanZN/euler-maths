using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Largest palindrome product
  ///   <para>https://projecteuler.net/problem=4</para>
  /// </summary>
  internal class Problem4 : ProblemBase<Tuple<int, int, int, int>>
  {
    public Problem4()
    {
      Problem = "Problem 4";
      Title = "Largest palindrome product";
    }

    public override string GetAnswer()
    {
      var watch = Stopwatch.StartNew();
      var answer = Answer();
      watch.Stop();

      return
        $"{Problem} - {Title}: {answer.Item3} ({answer.Item1} * {answer.Item2}). Execution time in ms: {watch.ElapsedMilliseconds}";
    }

    protected internal override Tuple<int, int, int, int> Answer()
    {
      var answers = new List<Tuple<int, int, int, int>>();
      var o = 900;
      var m = 999;
      for (var i = o; i <= m; i++)
      {
        for (var j = o; j < m; j++)
        {
          var x = i* j;
          var y = Convert.ToInt32(x.ToString().Reverse().Aggregate("", (current, z) => current + z));

          answers.Add(new Tuple<int, int, int, int>(i, j, x, y));
        }
      }

      return answers.Where(n => n.Item3 == n.Item4).Max();
    }
  }
}
