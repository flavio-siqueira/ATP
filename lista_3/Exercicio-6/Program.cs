class program {

    static void main(String[] args)
    {
        Console.WriteLine("digite a quantidade de salrio  e a quantidade de filhos ");
        double salario = 0;
        do
        {
            int contador1 = 0;
            int contador = 0;
            salario = double.Parse(Console.ReadLine());

            if(salario > 0)
            {
                
                contador++; //contador para salario:
            }
            mediasalario(salario, contador);
            int filhos = int.Parse(Console.ReadLine());
            if (filhos > 0){

                
                contador1++; //contador para filhos

            }
            MediaFilhos(filhos, contador1);
            MaiorSalario(salario);
            percentual(salario);
        } while (salario != 0);




    }

    static void mediasalario(double salario, int contador)
    {
        salario += salario;
        double media = 0;
        media = salario / contador;
        Console.WriteLine("Media salario = " + media);
    }

    static void MediaFilhos(int filhos, int contador1)
    {
        filhos += filhos;
        double media = 0;
        media = filhos / contador1;
        Console.Write("Meida filhos "+media);


    }

    static void MaiorSalario(double salario)
    {
        double maiorS = salario;

        if(salario < maiorS)
        {

            maiorS = salario;

        }
        Console.WriteLine("Maior salario = "+maiorS);


    }

    static void percentual(double salario)
    {
        int media = 0;
        if (salario <= 100)
        {

            int contador = 0;
            contador++;
            media = contador / 100;

           

        }
        Console.WriteLine("salario abaixo ou até 100 reais = "+media);
    }



    }
