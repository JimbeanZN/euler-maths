using System;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Power digit sum
  ///   <para>https://projecteuler.net/problem=16</para>
  /// </summary>
  internal class Problem16 : ProblemBase<long>
  {
    public Problem16()
    {
      Problem = "Problem 16";
      Title = "Power digit sum";
    }

    protected internal override long Answer()
    {
      const int baseValue = 2;
      const int power = 1000;

      var answer = baseValue.ToString();
      for (var i = 0; i < power - 1; i++)
      {
        var carryOver = 0L;
        var newAnswer = "";
        for (var j = answer.Length - 1; j >= 0; j--)
        {
          var currentWorkingDigit = Convert.ToInt32(answer[j].ToString());
          var newWorkingAnswer = currentWorkingDigit * baseValue + carryOver;

          var lastCharOfWorkingAnswer = newWorkingAnswer.ToString().Last().ToString();
          newAnswer = lastCharOfWorkingAnswer + newAnswer;

          carryOver = (newWorkingAnswer - Convert.ToInt32(lastCharOfWorkingAnswer)) / 10;
        }

        answer = carryOver != 0 ? carryOver + newAnswer : newAnswer;
      }

      return answer.ToCharArray().Sum(n => Convert.ToInt32(n.ToString()));
    }
  }
}