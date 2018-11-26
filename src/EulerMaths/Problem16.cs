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
      var calculatedValue = Math.Pow(baseValue, power).ToString().ToCharArray();

      return calculatedValue.Sum(value => Convert.ToInt32(value.ToString()));
    }
  }
}