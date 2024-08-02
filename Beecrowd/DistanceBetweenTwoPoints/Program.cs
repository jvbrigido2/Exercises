using System;

class URI
{

  static void Main(string[] args)
  {

    string[] inputs1 = Console.ReadLine().Split(' ');
    double x1 = double.Parse(inputs1[0]);
    double y1 = double.Parse(inputs1[1]);

    string[] inputs2 = Console.ReadLine().Split(' ');
    double x2 = double.Parse(inputs2[0]);
    double y2 = double.Parse(inputs2[1]);

    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    Console.WriteLine($"{distance:F4}");

  }

}
