

class URI
{

  static void Main(string[] args)
  {

    string[] inputs = Console.ReadLine().Split(' ');

    int A, B, C, D;

    A = int.Parse(inputs[0]);
    B = int.Parse(inputs[1]);
    C = int.Parse(inputs[2]);
    D = int.Parse(inputs[3]);

    if ((B > C && D > A) && (C + D > A + B) && C > 0 && D > 0 && (A % 2 == 0))
    {
      Console.WriteLine("Valores aceitos");
    }
    else
    {
      Console.WriteLine("Valores nao aceitos");
    }


  }

}