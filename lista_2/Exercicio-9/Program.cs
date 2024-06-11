class program
{
    static public void Main(string[] args)
    {
        //entrada de dados:
        Console.WriteLine("Digite um simbolo <, >, = ou outro simbolo");
        char x = char.Parse(Console.ReadLine());
        switch (x)
        {
            // estrutura booleana abaixo:
            case '>':
                Console.WriteLine("Sinal maior");
                break;
            case '<':
                Console.WriteLine("Sinal menor");
                break;
            case '=':
                Console.WriteLine("Sinal igual");
                break;
            default:
                Console.WriteLine("Outro sinal");
                break;
        }


    }
}