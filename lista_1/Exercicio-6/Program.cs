class program
{
    static void Main(string[] args)
    {
        //mensagem para o usuario e recebimento de valores:
        Console.WriteLine("Por favor digite os dois valores inteiros");
        int x = int.Parse(Console.ReadLine()),y = int.Parse(Console.ReadLine());
        trocar(x, y);
    }


    //Procedimento trocar de valores:
    static void trocar(int x, int y)
    {
        int aux = x;
        x = y;
        y = aux;
        Console.WriteLine("Valores trocados {0} {1} ", x, y);

    }
}