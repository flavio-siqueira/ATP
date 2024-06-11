class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digite dois numeros inteiros");
        int x1 = int.Parse(Console.ReadLine()), x2 = int.Parse(Console.ReadLine());
        int y = x1 + x2;
        condicao(y);
    }

    //procedimento de condicao seguinte as regras de comparações:
    static void condicao(int x)
    {
        if (x >= 10)
        {
            x += 5;
            Console.Write(" valor com a soma de dois números mais 5 = " + x);

        }
        else
        {
            x += 7;
            Console.WriteLine("valor com a soma de dois números mais 7 = " + x);
        }
    }
}