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
  internal class Problem4 : ProblemBase<(int first, int second, int product, int palidrome)>
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

    protected internal override (int first, int second, int product, int palidrome) Answer()
    {
      const int start = 900;
      const int count = 99;
      
      var answers = from outer in Enumerable.Range(start, count)
                    from inner in Enumerable.Range(start, count)
                    let product = outer * inner
                    let palindrome = Convert.ToInt32(product.ToString().Reverse().Aggregate("", (current, z) => current + z))
                    select (outer, inner, product, palindrome);

      return answers.Last(n => n.product == n.palindrome);
    }
  }
}
