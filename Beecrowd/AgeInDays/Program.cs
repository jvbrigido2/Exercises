using System;

class URI
{

  static void Main(string[] args)
  {

    int ageInDays = int.Parse(Console.ReadLine());

    int year = ageInDays / 365;
    int month = (ageInDays % 365) / 30;
    int day = (ageInDays % 365) % 30;

    Console.WriteLine($"{year} ano(s)");
    Console.WriteLine($"{month} mes(es)");
    Console.WriteLine($"{day} dia(s)");
  }

}
