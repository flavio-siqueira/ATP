using System.Runtime.Intrinsics.X86;

class program
{
    static void Main(String[] args)
    {
        //entrada de dados/saida de dados:
        Console.WriteLine("Digite os números positivos");
        //variaveis declaradas fora do laço pois não estava tendo visibilidade:
        int aux = 0, x = 0;
        int aux1 = 0;
        int aux2 = 0;
        do //laço repetições:
        {
            x = int.Parse(Console.ReadLine()); // dado recebido:
            x += x;
            if (x > 0)
            {
                aux++; //contador

            }
            else if (x < 0)
            {
                aux1++; //contador
            }

            else if (x == 0)
            {
                aux2++; //contador
            }

        } while (x != 10000);
        //comando de saida com as quantidades de valores e a sua percentagem:
        Console.WriteLine("Negativos{0}, Positivos{1} e iguais a Zero {2}", aux1, aux, aux2);
        Console.WriteLine("Valor total vezes o percentual de valores digitados ",x*((aux1 + aux2+aux)/100));
    }
}
