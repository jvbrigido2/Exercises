using System;

class URI
{

  static void Main(string[] args)
  {
    int n100, n50, n20, n10, n5, n2, n1;
    int value = int.Parse(Console.ReadLine());

    if (value > 0 && value < 1000000)
    {
      n100 = value / 100;
      n50 = (value % 100) / 50;
      n20 = ((value % 100) % 50) / 20;
      n10 = (((value % 100) % 50) % 20) / 10;
      n5 = ((((value % 100) % 50) % 20) % 10) / 5;
      n2 = (((((value % 100) % 50) % 20) % 10) % 5) / 2;
      n1 = ((((((value % 100) % 50) % 20) % 10) % 5) % 2) / 1;

      Console.WriteLine(value);
      Console.WriteLine($"{n100} nota(s) de R$ 100,00");
      Console.WriteLine($"{n50} nota(s) de R$ 50,00");
      Console.WriteLine($"{n20} nota(s) de R$ 20,00");
      Console.WriteLine($"{n10} nota(s) de R$ 10,00");
      Console.WriteLine($"{n5} nota(s) de R$ 5,00");
      Console.WriteLine($"{n2} nota(s) de R$ 2,00");
      Console.WriteLine($"{n1} nota(s) de R$ 1,00");
    }
    else
    {
      Console.WriteLine("Invalid value");
    }

  }

}