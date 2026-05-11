class program
{
    static void Main(string[] args)
    {
        int wierzcholek = 10;
        int pien = 3;
        for (int i = 0; i < wierzcholek; i++)
        {
            for (int j = 0;  j < wierzcholek - i ; j++)
            {
                Console.Write("  ");
            }
            for(int g = 0; g < i * 2 + 1; g++)
            {
                Console.Write(" X");
            }
            Console.WriteLine();
            
        }
        for (int g = 0; g < pien; g++)
        {
            
            for (int j = 0; j < wierzcholek - pien + 2; j++)
            {
                Console.Write("  ");
            }
            for (int h = 0; h < pien; h++)
            {
                Console.Write(" X");
            }
            Console.WriteLine();
        }


    }

}
