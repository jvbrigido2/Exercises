using System;

class URI
{

  static void Main(string[] args)
  {
    int totalDistance = int.Parse(Console.ReadLine());
    double spentFuel = double.Parse(Console.ReadLine());
    double average = totalDistance / spentFuel;

    Console.WriteLine($"{average:F3} km/l");




  }

}