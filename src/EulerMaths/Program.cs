﻿using System;

namespace EulerMaths
{
  public class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine(new Problem1().GetAnswer());
      Console.WriteLine(new Problem2().GetAnswer());
      Console.WriteLine(new Problem3().GetAnswer());
      Console.ReadLine();
    }
  }
}