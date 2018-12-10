namespace EulerMaths
{
  /// <summary>
  ///   Highly divisible triangular number
  ///   <para>https://projecteuler.net/problem=12</para>
  /// </summary>
  internal class Problem12 : ProblemBase<long>
  {
    public Problem12()
    {
      Problem = "Problem 12";
      Title = "Highly divisible triangular number";
    }

    protected internal override long Answer()
    {
      var index = FindTriangleIndex(500);

      return index * (index + 1) / 2;
    }

    private static long FindTriangleIndex(long limit)
    {
      var n = 1L;
      var lnum = GetNumberOfDivisors(n);
      var rnum = GetNumberOfDivisors(n + 1);

      while (lnum * rnum < 500)
      {
        n++;
        lnum = rnum;
        rnum = GetNumberOfDivisors(n + 1);
      }

      return n;
    }

    private static long GetNumberOfDivisors(long n)
    {
      if (n % 2 == 0)
      {
        n = n / 2;
      }

      var divisors = 1L;
      var count = 0;
      while (n % 2 == 0)
      {
        count += 1;
        n = n / 2;
      }

      divisors = divisors * (count + 1);
      var p = 3;

      while (n != 1)
      {
        count = 0;
        while (n % p == 0)
        {
          count += 1;
          n = n / p;
        }

        divisors = divisors * (count + 1);
        p += 2;
      }

      return divisors;
    }
  }
}