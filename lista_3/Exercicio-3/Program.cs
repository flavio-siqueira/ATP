using System.Runtime.Intrinsics.X86;

class program
{
    static void Main(String[] args)
    {
        //entrada de dados/saída de dados:
        Console.WriteLine("Digite os números positivos");
        //chamada de procedimento:
        divisiveis();

    }
    static void divisiveis(){

        //declaracao das variaveis auxiliares:
        int aux = 0;
        int aux1 = 0;
        //laco de repeticao:
        for (int i = 0; i<=9; i++)        {
           int x = int.Parse(Console.ReadLine());
         //condicoes:
            if ((x % 3 == 0) && (x % 9 == 0))
            {
                Console.WriteLine("Número divisível por 3 e 9");
               
                aux++;
            }
            else if ((x % 2 == 0) && (x % 5 == 00)) {
                Console.WriteLine("Número divisível por 2 e 5");
                
                aux1++;
            
            }
            else Console.WriteLine("Não divisível pelos números acima (3,9) e (2,5)");

        }
        //imprimirmensagem ao usuario:
        Console.WriteLine("Quantidade de numero divisível por (3,5) = {0} e (2,5) = {1}",aux,aux1);
    }
}
