using System;

class URI
{

  static void Main(string[] args)
  {
    int spentTime = int.Parse(Console.ReadLine());
    int averageSpeed = int.Parse(Console.ReadLine());

    int distance = spentTime * averageSpeed;

    double totalFuelSpent = distance / 12.0;

    Console.WriteLine($"{totalFuelSpent:F3}");

  }

}