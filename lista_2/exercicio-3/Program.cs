class program
{static void Main(string[] args)
    {
        Console.WriteLine("Digite dois numeros inteiros");
        int x1 = int.Parse(Console.ReadLine()), x2 = int.Parse(Console.ReadLine());
        equacao(x1, x2);

    }

    //procedimento de calculo da equação :
    static void equacao(int x, int b)
    {
        int y = b - x;
        if (y == 0) {Console.WriteLine("valor de x da equação = " + y);}
        else {Console.WriteLine("Equação não iguala a 0 \nPor favor digite outro valor"); }
    }

}