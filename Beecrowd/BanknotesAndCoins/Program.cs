using System;

class URI
{

  static void Main(string[] args)
  {

    int n100, n50, n20, n10, n5, n2, n1, n050, n025, n010, n005, n001;
    int value = (int)(double.Parse(Console.ReadLine()) * 100);

    if (value > 0 && value < 100000000)
    {
      n100 = value / 10000;
      value %= 10000;
      n50 = value / 5000;
      value %= 5000;
      n20 = value / 2000;
      value %= 2000;
      n10 = value / 1000;
      value %= 1000;
      n5 = value / 500;
      value %= 500;
      n2 = value / 200;
      value %= 200;
      n1 = value / 100;
      value %= 100;
      n050 = value / 50;
      value %= 50;
      n025 = value / 25;
      value %= 25;
      n010 = value / 10;
      value %= 10;
      n005 = value / 5;
      value %= 5;
      n001 = value;

      Console.WriteLine("NOTAS:");
      Console.WriteLine($"{n100} nota(s) de R$ 100.00");
      Console.WriteLine($"{n50} nota(s) de R$ 50.00");
      Console.WriteLine($"{n20} nota(s) de R$ 20.00");
      Console.WriteLine($"{n10} nota(s) de R$ 10.00");
      Console.WriteLine($"{n5} nota(s) de R$ 5.00");
      Console.WriteLine($"{n2} nota(s) de R$ 2.00");
      Console.WriteLine("MOEDAS:");
      Console.WriteLine($"{n1} moeda(s) de R$ 1.00");
      Console.WriteLine($"{n050} moeda(s) de R$ 0.50");
      Console.WriteLine($"{n025} moeda(s) de R$ 0.25");
      Console.WriteLine($"{n010} moeda(s) de R$ 0.10");
      Console.WriteLine($"{n005} moeda(s) de R$ 0.05");
      Console.WriteLine($"{n001} moeda(s) de R$ 0.01");
    }
    else
    {
      Console.WriteLine("Invalid value");
    }
  }
}