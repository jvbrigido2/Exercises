using System;

class URI
{

  static void Main(string[] args)
  {
    int greatest;
    string[] inputs = Console.ReadLine().Split(' ');
    int firstNumber = int.Parse(inputs[0]);
    int secondNumber = int.Parse(inputs[1]);
    int thirdNumber = int.Parse(inputs[2]);

    greatest = Greatest(firstNumber, secondNumber);
    greatest = Greatest(greatest, thirdNumber);

    Console.WriteLine($"{greatest} eh o maior");

  }

  static int Greatest(int number1, int number2)
  {
    return (number1 + number2 + Math.Abs(number1 - number2)) / 2;
  }

}