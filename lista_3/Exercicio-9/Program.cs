class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i <= x; i++)
        {
            int aux2 = i += (i - 1);
            
            if(aux2 < x) Console.WriteLine(" " + aux2);

        }

    }

}