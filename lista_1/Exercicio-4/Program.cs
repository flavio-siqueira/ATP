class Program
{
    public static void Main(string[] args)
    {   //Entrada de dados pelo usuario utilizando vetores:
        Console.WriteLine("Digite os 2 pontos X do gráfico");
        int[] VetorX = new int[2];
        for (int i = 0; i < VetorX.Length; i++)
        {
            VetorX[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Digite os 2 pontos Y do gráfico");

        //Entrada de dados pelo usuario utilizando vetores:
            int[] VetorY = new int[2];
        for (int i = 0; i < VetorY.Length; i++)
        { VetorY[i] = int.Parse(Console.ReadLine()); }
        Equacao(VetorY, VetorX);

    }
    //Funcao de calculo matematico utilizando classe math e parametos inteiros vetoriais:
    static void Equacao(int[] x, int[] y)
    {
        int soma = x.Length - (x.Length - 1);
        int somaY = y.Length - (y.Length - 1);
        double Valor =Math.Sqrt ( Math.Pow(soma, 2) + Math.Pow(somaY, 2));
        Console.WriteLine(" Valor Equação = {0:f2}", Valor);

    }
}