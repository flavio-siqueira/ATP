class program
{static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro");
        int x =int.Parse(Console.ReadLine());
        //chamada de procedimento:
        um(x);
    }

    //procedimento de laços condicionais onde encontramos valores para a função de acordo com regras de enunciado:
    static void um (int x)
    {
        if (x <= 1) Console.WriteLine(" Valor = 1");
        else if((x>1) &&(x<=2)) Console.WriteLine("Valor = 2"); 
        else if ((2<x) && (x<=3))
        {
            double y = Math.Pow(x, 2);
            Console.WriteLine(" Valor = " + y);

        }
        else if (x>3)
        {
            double y = Math.Pow(x, 3);
            Console.WriteLine(" Valor = " + y); // class matematica sendo utilizada:

        }
    }


}