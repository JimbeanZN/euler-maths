using System;
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
    public Problem17()
    {
      Problem = "Problem 17";
      Title = "Number letter counts";
    }

    protected internal override long Answer()
    {
      var numberDictionary = new Dictionary<int, string>
      {
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, "Four"},
        {5, "Five"},
        {6, "Six"},
        {7, "Seven"},
        {8, "Eight"},
        {9, "Nine"},
        {10, "Ten"}
      };

      return Enumerable.Range(1, 5).Select(n => numberDictionary[n].Length).Sum();
    }
  }
}