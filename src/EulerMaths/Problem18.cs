using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerMaths
{
  /// <summary>
  ///   Maximum path sum I
  ///   <para>https://projecteuler.net/problem=18</para>
  /// </summary>
  internal class Problem18 : ProblemBase<long>
  {
    public Problem18()
    {
      Problem = "Problem 18";
      Title = "Maximum path sum I";
    }

    protected internal override long Answer()
    {
      var inputTriangle = new int[Triangle.Length, Triangle.Length];
      
      for (var i = 0; i < Triangle.Length; i++)
      {
        var ints = Triangle[i].Split(' ').Select(n => Convert.ToInt32(n.ToString())).ToList();
        for (var j = 0; j < ints.Count; j++)
        {
          inputTriangle[i, j] = ints[j];
        }
      }

      for (var i = inputTriangle.GetLength(0) - 2; i >= 0; i--) {
        for (var j = 0; j <= i; j++) {
          inputTriangle[i, j] += Math.Max(inputTriangle[i+1,j], inputTriangle[i+1, j+1]);
        }
      }

      return inputTriangle[0, 0];

      //foreach (var s in Triangle.Reverse())
      //{
      //  var ints = s.Split(' ').Select(n => Convert.ToInt32(n)).ToList();

      //  var x = ints[index];

      //  if (ints.Count == 2)
      //  {
      //    x = ints.Max();
      //  }

      //  if (ints.Count > 2)
      //  {
      //    if (index == ints.Count - 1 && ints[index - 1] > x)
      //    {
      //      x = ints[index - 1];
      //    }
      //    else if (ints[index+1] > x)
      //    {
      //      x = ints[index + 1];
      //    }
      //  }
        
      //  answer += x;
      //  index = ints.IndexOf(x);
      //}

      //return answer;
    }

    private static readonly string[] Triangle = {
      "75",
      "95 64",
      "17 47 82",
      "18 35 87 10",
      "20 04 82 47 65",
      "19 01 23 75 03 34",
      "88 02 77 73 07 63 67",
      "99 65 04 28 06 16 70 92",
      "41 41 26 56 83 40 80 70 33",
      "41 48 72 33 47 32 37 16 94 29",
      "53 71 44 65 25 43 91 52 97 51 14",
      "70 11 33 28 77 73 17 78 39 68 17 57",
      "91 71 52 38 17 14 91 43 58 50 27 29 48",
      "63 66 04 68 89 53 67 30 73 16 69 87 40 31",
      "04 62 98 27 23 09 70 98 73 93 38 53 60 04 23"
    };
  }
}