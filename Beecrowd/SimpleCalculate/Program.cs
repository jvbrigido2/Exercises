using System;

class URI
{

    static void Main(string[] args)
    {
        string[] data = new string[3];
        data = Console.ReadLine().Split(" ");
        int codeProduct1 = int.Parse(data[0]);
        int numberUnits1 = int.Parse(data[1]);
        double priceUnit1 = double.Parse(data[2]);

        string[] data2 = new string[3];
        data2 = Console.ReadLine().Split(" ");
        int codeProduct2 = int.Parse(data2[0]);
        int numberUnits2 = int.Parse(data2[1]);
        double priceUnit2 = double.Parse(data2[2]);

        double total = numberUnits1 * priceUnit1 + numberUnits2 * priceUnit2;

        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

        Console.ReadKey();

    }

}
