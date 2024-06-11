class Program
{public static void Main(string[] args)
    {
        Console.WriteLine("Digite o salario ");
        double salario = double.Parse(console.ReadLine());
        double kilo = salario / 7;
        Console.WriteLine("Por favor digite a quantidade  de kilowhatts gasta");
        double Qkilo = double.Parse(Console.ReadLine());
        Qkilo = kilo * Qkilo;
        Console.Writeli("Quantidade gasta em reais de kilowhatts = " + Qkilo);
        novoValor(Qkilo);

    }

    static void novoValor(double x)
    {
        double valor = 0, Valordesconto;
        valor = Qkilo * 0.10;
        Valordesconto = Qkilo + x;
        Console.WriteLine("Valor com desconto"+ Valordesconto);

    }


}