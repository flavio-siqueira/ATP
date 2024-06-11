class Program
{
    static void Main(string[] args)
    {
        //Entrada de dados do usuario:
        Console.WriteLine("por favor digite um numero");
        int numero = NewMethod();
        //Chamadas de funções no método Main onde um procedimento recebe o valor de uma função:
        int receber = calculo(numero);
        calculo2(receber);
    }

    private static int NewMethod()
    {
        return int.Parse(Console.ReadLine());
    }

    //funcao de calculo de digito verificador:
    static int calculo(int numero)
    {
        int x = (numero / 100); // centena:
        int y = (numero % 100); //dezena:
        int z = (numero % 100) / 10; // unidade:

        int soma = ((x * 100) + y+(z * 10));
        int soma1 = (soma + numero);
        return soma1;
    }

    static void calculo2(int soma)
    {
        int x1 = (soma / 1000)*0;//milhar:
        int x = (x1 / 100)*1; //centena:
        int y = (x1 % 100)*2; //dezena:
        int z = ((x1 % 100) / 10)*3; // unidade:


        Console.Write(" valor = " +x1,x,y,z );
    }
   
}