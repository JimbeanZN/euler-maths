using System.Linq;

namespace EulerMaths
{
  /// <summary>
  /// Multiples of 3 and 5
  /// <para>https://projecteuler.net/problem=1</para>
  /// </summary>
  public static class Problem1
  {
    private const string Problem = "Problem 1";
    private const string Title = "Multiples of 3 and 5";

    private static long Answer()
    {
      return Enumerable.Range(1, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
    }

    public static string GetAnswer()
    {
      var watch = System.Diagnostics.Stopwatch.StartNew();
      var answer = Answer();
      watch.Stop();

      return $"{Problem} - {Title}: {answer}. Execution time in ms: {watch.ElapsedMilliseconds}";
    }
  }
}
