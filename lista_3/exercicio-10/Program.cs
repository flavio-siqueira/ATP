/* Escreva o algoritmo para um empresário que deseja fazer o levantamento do lucro das
mercadorias que ele comercializa. O usuário deve informar o preço de compra e de venda de
cada mercadoria. O algoritmo deve interromper a leitura quando o usuário informar o preço
de compra igual a 0. O algoritmo deve:
a) Determinar e escrever quantas mercadorias proporcionaram:
i) Lucro < 10%
ii) 10% <= Lucro <= 20%
iii) Lucro > 20%
b) Determinar e escrever o valor total de compra e de venda de todas as mercadorias,
*/


using System.Security.Cryptography;

class program
{
    static void main(string[] args)
    {
        Console.WriteLine("Digite o preco das mercadoria\n digite o preco dde venda");
        double P_mercadoria = 0;
        double P_venda = 0;
        double total = 0;
        double totalVenda = 0;
       do
        {
            P_mercadoria = double.Parse(Console.ReadLine());
            P_venda = double.Parse(Console.ReadLine());
            total += P_mercadoria;
            totalVenda += P_venda;
            Console.WriteLine(" "+ totalVenda);
            Console.WriteLine(" " + total); 
        }while(P_venda!=0);

    }


    static void lucroM10(double P_mercadoria, double P_venda)
    {
        double subtrair = P_venda - (P_mercadoria * 0.10);
        if ((subtrair + P_venda) < P_venda)
        {
            Console.WriteLine(" Valor menor de 10% de venda ");
            int contador = 0;
            contador++;
        }
        else if ((subtrair + P_venda) <= P_venda)
        {
            Console.WriteLine("valor entre3 10% e 20% de venda");
            int contador1 = 0;
            contador1++;

        }
        else if ((subtrair + P_venda) > (P_venda * 0.20))
        {
            Console.WriteLine("valor entre3 10% e 20% de venda");
            int contador2 = 0;
            contador2++;

        }
    }
}