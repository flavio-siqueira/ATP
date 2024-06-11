using System.Diagnostics;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor digite o preço da diaria");
        double diaria = double.Parse(Console.ReadLine());
        //variaveis abaixo recebendo os valores das funções e as utillizando em outras funções:
       double x = valorPromocional(diaria);
       double z = valorArrecadado80(x);
       double w = valorArrecadado50(diaria);
        //Apresentando ao usuário os resultados:
        Console.WriteLine("Valor promocional diária = {0} \n Resultado letra b da questão = {1}\n Resultado letra c = {2}", x, z, w);
        diferenca(w,z); //Chamada do procedimento:

    }

    static double valorPromocional(double valor) // Valor promocional:
    {
        return valor * 0.25;
    }
    static double valorArrecadado80(double x)//valor arrecadado mais valor de promoção com 80% de presença:
    {
        double y = 75 * 0.80; //oitenta percento de arrrecadação:
        y += y + x;
        return y;
    }


    static double valorArrecadado50(double valor) // valor arrecadado mais valor diária normal com 50% de presença:
    {
        double y = 75 * 0.50;
        y += y + valor;
        return y;
    }

    static void diferenca(double x, double y)
    {
        Console.WriteLine("Diferença entre valores = " + (x - y));




    }
}