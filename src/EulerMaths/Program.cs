using System;

namespace EulerMaths
{
  public class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine(new Problem1().GetAnswer());
      Console.WriteLine(new Problem2().GetAnswer());
      Console.WriteLine(new Problem3().GetAnswer());
      Console.WriteLine(new Problem4().GetAnswer());
      Console.WriteLine(new Problem5().GetAnswer());
      Console.WriteLine(new Problem6().GetAnswer());
      Console.WriteLine(new Problem7().GetAnswer());
      Console.ReadLine();
    }
  }
}