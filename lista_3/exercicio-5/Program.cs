class program{
    static void main(String[] args) {

        Console.WriteLine("digite um numero");
        int x = int.Parse(Console.ReadLine());

        if ((x > 0) && (x % 2 == 0))
        {
            for (int i = 0; i < x; i++)
            {
                int aux2 = 0;
                aux2++;
                /////////////////////////
                int aux = 0;
                aux = (i + 1)/(aux2+1);



                Console.WriteLine("  " + aux);


            }



        }
    
    
    }




}