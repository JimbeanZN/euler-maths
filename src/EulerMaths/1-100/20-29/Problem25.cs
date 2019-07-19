using System;
using System.Collections.Generic;
using System.Linq;
using EulerMaths.Helpers;

namespace EulerMaths
{
  /// <summary>
  ///   1000-digit Fibonacci number
  ///   <para>https://projecteuler.net/problem=25</para>
  /// </summary>
  internal class Problem25 : ProblemBase<string>
  {
    public Problem25()
    {
      Problem = "Problem 25";
      Title = "1000-digit Fibonacci number";
    }

    protected internal override string Answer()
    {
      StringFibonacci().First(n => n.ToString().Length == 1000);
      return _index.ToString();
    }

    private static long _index = 1;

    private static IEnumerable<string> StringFibonacci()
    {
      var first = "0";
      var second = "1";

      yield return first;
      yield return second;

      while (true)
      {
        var newAnswer = "";
        var carryOver = 0L;

        for (var i = first.Length - 1; i >= 0; i--)
        {
          var firstCurrentDigit = int.Parse(first[i].ToString());
          var secondCurrentDigit = int.Parse(second[second.Length - first.Length + i].ToString());
          var newWorkingAnswer = firstCurrentDigit + secondCurrentDigit + carryOver;

          var lastCharOfWorkingAnswer = newWorkingAnswer.ToString().Last().ToString();
          newAnswer = lastCharOfWorkingAnswer + newAnswer;

          carryOver = (newWorkingAnswer - Convert.ToInt32(lastCharOfWorkingAnswer)) / 10;
        }

        if (first.Length != second.Length)
        {
          carryOver = int.Parse(second[0].ToString()) + carryOver;
        }

        var x = carryOver != 0 ? carryOver + newAnswer : newAnswer;

        _index++;
        yield return x;

        first = second;
        second = x;
      }
    }
  }
}