class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Por  favor digite a quantidade de \n- deposito \n- Taxa\n-Mês");

        double quantidade = double.Parse (Console.ReadLine ()), taxa = double.Parse(Console.ReadLine());
        int mes = int.Parse(Console.ReadLine());
        Equacao(quantidade, taxa, mes);
    }

    static void Equacao(double x, double y, int z)
    {
        double soma = Math.Pow ((1* y),z)-1;
        double valor = (soma * x) / y;
        Console.WriteLine("Valor {0:f2}= ", valor);
    }

}