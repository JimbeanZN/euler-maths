using System;

namespace EulerMaths
{
  /// <summary>
  ///   Counting Sundays
  ///   <para>https://projecteuler.net/problem=19</para>
  /// </summary>
  internal class Problem19 : ProblemBase<long>
  {
    public Problem19()
    {
      Problem = "Problem 19";
      Title = "Counting Sundays";
    }

    protected internal override long Answer()
    {
      var count = 0;

      var workingDate = new DateTime(1901, 1, 1);
      var finalDate = new DateTime(2001, 1, 1);

      while (workingDate < finalDate)
      {
        if (workingDate.DayOfWeek == DayOfWeek.Sunday)
        {
          count++;
        }

        workingDate = workingDate.AddMonths(1);
      }

      return count;
    }
  }
}