using System.Collections.Generic;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Number letter counts
  ///   <para>https://projecteuler.net/problem=17</para>
  /// </summary>
  internal class Problem17 : ProblemBase<long>
  {
    private static readonly Dictionary<int, string> NumberDictionary = new Dictionary<int, string>
    {
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"},
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"},
      {20, "twenty"},
      {30, "thirty"},
      {40, "forty"},
      {50, "fifty"},
      {60, "sixty"},
      {70, "seventy"},
      {80, "eighty"},
      {90, "ninety"},
      {100, "hundred"},
      {1000, "thousand"}
    };

    public Problem17()
    {
      Problem = "Problem 17";
      Title = "Number letter counts";
    }

    protected internal override long Answer()
    {
      return Enumerable.Range(1, 1000).Select(n => GetNumberWordString(n).Length).Sum();
    }

    private static string GetNumberWordString(int number)
    {
      var answer = "";
      var worker = number / 1000;

      if (worker > 0)
      {
        answer += NumberDictionary[worker] + NumberDictionary[1000];
        number -= worker * 1000;

        if (number > 0 && number < 100)
        {
          answer += "and";
        }
      }

      worker = number / 100;

      if (worker > 0)
      {
        answer += NumberDictionary[worker] + NumberDictionary[100];
        number -= worker * 100;

        if (number > 0 && number < 100)
        {
          answer += "and";
        }
      }

      worker = number / 10;

      if (worker > 1 && number > 20)
      {
        answer += NumberDictionary[worker * 10];
        number -= worker * 10;
      }

      if (number > 0)
      {
        answer += NumberDictionary[number];
      }

      return answer;
    }
  }
}