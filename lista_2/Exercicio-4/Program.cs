using System.ComponentModel;

class program
{
    static void Main(string[] args)
    {
        //entrada de dados/ mensagem para o usuario:
        Console.WriteLine("Por favor digite a sua idade e o ano atual");
        int idade = int.Parse (Console.ReadLine()), ano = int.Parse((Console.ReadLine()));
        int valor = (ano - idade);
        Console.WriteLine("Digite s se vc ja fez aniversario esse ano ou N se não");
        char letra =char.Parse ( Console.ReadLine());
        //chamada de procedimento:
        habilitado(valor, letra);
    }
    //procedimento de verificação de maior idade:
    static void habilitado(int valor, char s )
    {
        // comando interno booleano onde executa determinadas instruções abaixo:
        switch(s){
            case 's':
                int anos = valor + 1;
                if (anos >= 18) { Console.WriteLine("pode dirigir e é maior de 18 anos"); }
                else Console.WriteLine("Não é maior de 18 e não poderás dirigir");
                
                break;      
            case 'n':
                if (valor >= 18)
                {
                    Console.WriteLine("poderá dirigir este anos");
                }
                else
                    Console.WriteLine("Menor de 18 anos não pode dirigir");
                break;

        }


    }

}