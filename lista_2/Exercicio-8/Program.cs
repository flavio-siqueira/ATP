class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite o salrio");
    double x = double.Parse (Console.ReadLine());
        salario(x);
    }


    static void salario(double x)
    {
        switch (x)
        {
            case 350:
                Console.WriteLine("aumento de 8% = " + (x * 0.8));
                break;
            case 1000:
                Console.WriteLine("aumento de 11% =" + (x * 0.11));
                break;

        }



    }

}