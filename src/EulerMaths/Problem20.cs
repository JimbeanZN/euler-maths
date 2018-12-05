using System;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Factorial digit sum
  ///   <para>https://projecteuler.net/problem=20</para>
  /// </summary>
  internal class Problem20 : ProblemBase<long>
  {
    public Problem20()
    {
      Problem = "Problem 20";
      Title = "Factorial digit sum";
    }

    protected internal override long Answer()
    {
      const long n = 100;
      var answer = n.ToString();

      for (var i = 1; i < n; i++)
      {
        var next = n - i;

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

      return answer.ToCharArray().Sum(c => Convert.ToInt32(c.ToString()));
    }
  }
}