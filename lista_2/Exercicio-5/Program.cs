class program
{
    static void Main(string[] args)
    { //entrada de dados do usuario abaixo:
        Console.WriteLine("Por favor digite a sua nota da prova");
        double nota = int.Parse(Console.ReadLine());
        //chamada do procedimento:
        categoria(nota);

    }

    //procedimento de verificação de desempenho utilizando laços condicionais: 
    static void categoria(double nota)
    {
        //lacos de condicoes abaixo:
        if (nota > 10) Console.WriteLine("Nota invalida");
        else if ((nota >= 8) && (nota <= 10)) Console.WriteLine("Ótimo");
        else if ((nota >= 7) && (nota < 8)) Console.WriteLine("bom");
        else if ((nota >= 5) && (nota < 7)) Console.WriteLine("Regular");
        else if (nota < 5) Console.WriteLine("Insatisfatório");
        else Console.WriteLine("Inválida");


    }
}