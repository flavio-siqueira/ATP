class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Digite os valores do catetos do triângulo retângulo");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine("Hipotenusa = " + hipotenusa(x, y, z));
    }
    // função matematica hipotenusa:
    static int hipotenusa(int x, int y, int z)
    {
        double hip = Math.Sqrt( Math.Pow((x+y+z), 2));
        return (int)hip;
    }

}