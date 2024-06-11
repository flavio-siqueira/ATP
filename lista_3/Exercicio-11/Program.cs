class progrma
{
    static void main(String[] args)
    {
        Console.WriteLine("escolha uma opcao 1 -\n2 -\n3 -\n4 -\n5 - nulo\n6 - branco");
        int x = 0;
        int contador = 0;
        int contador1 = 0;
        int contador2 = 0;
        int contador3 = 0;
        int contador4 = 0;
        int contador5 = 0;
        int contador6 = 0;
        do
        {
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
               
                    contador++;
                    break;
                case 2:
                    
                    contador2++;
                    break;
                case 3:
                    
                    contador3++;
                    break;
                case 4:
                    
                    contador4++;
                    break;
                case 5:
                    
                    contador5++;
                    break;
                case 6:

                    contador6++;
                    break;
            }


        } while (x!=0);
        Console.WriteLine("Votos 1 total = {0}",contador);
        Console.WriteLine("Votos 2 total = {0}", contador2);
        Console.WriteLine("Votos 3 total = {0}", contador3);
        Console.WriteLine("Votos 4 total = {0}", contador4);
        Console.WriteLine("Votos 5 total = {0}", contador5);
        Console.WriteLine("Votos 6 total = {0}", contador6);
        


    }

}