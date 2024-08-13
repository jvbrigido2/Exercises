using System;

class URI
{

  static void Main(string[] args)
  {

    string[] inputs = Console.ReadLine().Split(' ');

    double A, B, C, delta, R1, R2;

    A = double.Parse(inputs[0]);
    B = double.Parse(inputs[1]);
    C = double.Parse(inputs[2]);

    delta = Math.Pow(B, 2) - (4 * A * C);

    if (A == 0 || delta < 0)
    {
      Console.WriteLine("Impossivel calcular");
    }
    else
    {
      R1 = (-B + Math.Sqrt(delta)) / 2.0 * A;
      R2 = (-B - Math.Sqrt(delta)) / 2.0 * A;

      Console.WriteLine($"R1 = {R1:F5}");
      Console.WriteLine($"R2 = {R2:F5}");

    }

  }

}
