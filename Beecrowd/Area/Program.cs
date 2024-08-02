using System;

class URI
{

  static void Main(string[] args)
  {

    const double PI = 3.14159;
    double triangle, circle, trapezium, square, rectangle;

    string[] input = Console.ReadLine().Split(' ');
    double firstNumber = double.Parse(input[0]);
    double secondNumber = double.Parse(input[1]);
    double thirdNumber = double.Parse(input[2]);

    triangle = (firstNumber * thirdNumber) / 2.0;
    circle = PI * Math.Pow(thirdNumber, 2);
    trapezium = ((firstNumber + secondNumber) * thirdNumber) / 2.0;
    square = Math.Pow(secondNumber, 2);
    rectangle = firstNumber * secondNumber;

    Console.WriteLine($"TRIANGULO: {triangle:F3}");
    Console.WriteLine($"CIRCULO: {circle:F3}");
    Console.WriteLine($"TRAPEZIO: {trapezium:F3}");
    Console.WriteLine($"QUADRADO: {square:F3}");
    Console.WriteLine($"RETANGULO: {rectangle:F3}");

  }

}