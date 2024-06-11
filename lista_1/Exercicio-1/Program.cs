class Program
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Dígite a base e altura do retângulo");
        //Declarações de variaveis para recebimento de valores inteiros:
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Perímetro = " + perimetro(x, y));
        Console.WriteLine("Area = " + area(x, y));
        Console.WriteLine("Diagonal = " + diagonal(x, y));
    }

    static int perimetro(int x, int y)
    {  return (x + y) * 2; }

    static int area(int x, int y)
    {  return x * y; }
    static double diagonal(int x, int y)
    {
        double diagonal = Math.Sqrt(Math.Pow((x + y), 2));
        return diagonal;
    }
}