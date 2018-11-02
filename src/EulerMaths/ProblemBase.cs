namespace EulerMaths
{
  internal abstract class ProblemBase
  {
    protected internal string Problem { get; set; }
    protected internal string Title { get; set; }

    protected internal abstract long Answer();

    public string GetAnswer()
    {
      var watch = System.Diagnostics.Stopwatch.StartNew();
      var answer = Answer();
      watch.Stop();

      return $"{Problem} - {Title}: {answer}. Execution time in ms: {watch.ElapsedMilliseconds}";
    }
  }
}
