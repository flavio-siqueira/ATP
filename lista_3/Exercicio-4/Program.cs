class program{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        int x = int.Parse(Console.ReadLine());
        //chamda de procedimento:
        fatoral (x);
    }


    //procedimento de retorno de valores fatorados:
    static void fatoral(int x)
    {
        int aux3 = 1;
        for (int i = 0; i <= x; i++)
        {

            aux3++; // contador para que sempre esteja um numero a mais:
            int poxa = aux3 *= i;
            



            Console.WriteLine("faturando ={0}", poxa);


        }
      


    }

    }