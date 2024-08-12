using System;

class URI
{

  static void Main(string[] args)
  {

    int input = int.Parse(Console.ReadLine());

    int hours = input / 3600;

    int minutes = (input % 3600) / 60;

    int seconds = (input % 3600) % 60;

    Console.WriteLine($"{hours}:{minutes}:{seconds}");



  }

}