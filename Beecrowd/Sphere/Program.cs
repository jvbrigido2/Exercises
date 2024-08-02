using System;

class URI
{

  static void Main(string[] args)
  {

    const double PI = 3.14159;
    double radius = double.Parse(Console.ReadLine());


    double sphere = (4 / 3.0) * PI * Math.Pow(radius, 3);

    Console.WriteLine($"VOLUME = {sphere:F3}");

  }

}