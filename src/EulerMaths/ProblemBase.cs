using System.Diagnostics;

namespace EulerMaths
{
  internal abstract class ProblemBase<T>
  {
    protected internal string Problem { get; set; }
    protected internal string Title { get; set; }

    protected internal abstract T Answer();

    public virtual string GetAnswer()
    {
      var watch = Stopwatch.StartNew();
      var answer = Answer();
      watch.Stop();

      return $"{Problem} - {Title}: {answer}. Execution time in ms: {watch.ElapsedMilliseconds}";
    }
  }
}