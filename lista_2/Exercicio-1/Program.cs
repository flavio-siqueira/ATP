class program
{static void Main(string[] args)
    {
        Console.WriteLine("Digite dois numeros");
        int x1 = int.Parse (Console.ReadLine()), x2 = int.Parse (Console.ReadLine ());
        if (x1 < x2)
        {
            Console.WriteLine("Maior número = " + x2);
        }
        else Console.WriteLine("Maior número = " + x1);

    }


}