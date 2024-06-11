class Program
{
    static void Main(string[] args)
    {
        //Mensagem e entrada de dados ao usuario:
        Console.WriteLine("Digite a quantidade de dias dentro da empresa sem acidentes");
        int dias = Convert.ToInt32(Console.ReadLine());
        Defatoracao(dias);

    }
    //procedimento de defatoracao dos dias em ANO/MÊS/DIAS:
    static void Defatoracao(int dias)
    {
        //anos
        int anos = (dias / 365);
        int meses = (dias% 365)/30;
        int unidade = (dias % 365)%30;

        Console.WriteLine("São exatamente\n {0} anos\n {1} Meses\n {2} dias ", anos, meses, unidade);

    }


}