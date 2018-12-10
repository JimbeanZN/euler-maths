using System;
using System.Linq;

namespace EulerMaths.Helpers
{
  internal static class LargeNumberMultiplication
  {
    public static string Calculate(long baseMultipler, long iterations, long iterationStart,
      Func<long, long> iterationEnd, Func<long, long, long> nextMultiplier)
    {
      var answer = baseMultipler.ToString();
      for (var i = iterationStart; i < iterationEnd.Invoke(iterations); i++)
      {
        var next = nextMultiplier.Invoke(baseMultipler, i);

        var carryOver = 0L;
        var newAnswer = "";
        for (var j = answer.Length - 1; j >= 0; j--)
        {
          var currentWorkingDigit = Convert.ToInt32(answer[j].ToString());
          var newWorkingAnswer = currentWorkingDigit * next + carryOver;

          var lastCharOfWorkingAnswer = newWorkingAnswer.ToString().Last().ToString();
          newAnswer = lastCharOfWorkingAnswer + newAnswer;

          carryOver = (newWorkingAnswer - Convert.ToInt32(lastCharOfWorkingAnswer)) / 10;
        }

        answer = carryOver != 0 ? carryOver + newAnswer : newAnswer;
      }

      return answer;
    }
  }
}