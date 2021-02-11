// Decompiled with JetBrains decompiler
// Type: GeekBrains2.Program
// Assembly: GeekBrains2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F58098E4-1AE6-4EE8-A9F5-7C11FD117350
// Assembly location: C:\GeekBrains2\GeekBrains2\GeekBrains2\bin\Debug\netcoreapp3.1\GeekBrains2.dll

using System;

namespace GeekBrains2
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.Write("Введите число ");
      if ((Convert.ToInt32(Console.ReadLine()) & 1) == 0)
        Console.WriteLine("Четное число");
      else
        Console.WriteLine("Нечетное число");
      Console.ReadLine();
    }
  }
}
