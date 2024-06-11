class program
{
    static void Main(string[] args)
    {
       //entrada e mensagem para o usuario:
        Console.WriteLine("Digite velocidade maxima permitida \ndigite velocidade do motorista");
        int velocidade = int.Parse(Console.ReadLine());
        int motorista = int.Parse(Console.ReadLine());
        int conta = motorista - velocidade;
        if (conta > 0) // condição para verificar valores a ser positivo para executar a função:
        {
            radar(conta);
        }

    }

    //procedimento de laçcos condicionais para decidir o valor de multa do motorista de acordo com enunciado:
    static void radar(int conta)
    {
        if (conta <= 10) { Console.WriteLine("Multado em 50 reais"); } // laço de condição:
        else if ((conta > 10) && (conta < 30)) Console.WriteLine("Multado em 100 reais");
        else if (conta > 30) Console.WriteLine("Multado em 200 reais");
    }




}