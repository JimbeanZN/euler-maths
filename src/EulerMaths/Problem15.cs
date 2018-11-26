namespace EulerMaths
{
  /// <summary>
  ///   Lattice paths
  ///   <para>https://projecteuler.net/problem=15</para>
  /// </summary>
  internal class Problem15 : ProblemBase<long>
  {
    public Problem15()
    {
      Problem = "Problem 15";
      Title = "Lattice paths";
    }

    protected internal override long Answer()
    {
      const int gridSize = 20;
      long paths = 1;
 
      for (var i = 0; i < gridSize; i++) {
        paths *= (2 * gridSize) - i;
        paths /= i + 1;
      }

      return paths;
    }
  }
}