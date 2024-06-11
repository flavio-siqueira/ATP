class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite um valor quallquer");
        int x = int.Parse(Console.ReadLine());
        int aux2 = 0;
        for (int i = 0; i < x; i++)
        {
            int aux = x;
            aux--;
            aux2 = aux+i;

        }
        Console.WriteLine("Valor" + aux2);



}