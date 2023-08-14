namespace Juletræet_Med_Sin_Pynt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaces = 8;
            int asterix = 1;
            int count = 0;
            bool green = true;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                if (green)
                {
                    for (int j = 0; j < asterix; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                    green = false;
                }
                else
                {
                    for (int j = 0; j < asterix; j++)
                    {
                        if (j % 2 == 0)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("*");
                        
                    }
                    green = true;
                }
                Console.WriteLine();
                asterix += 2;
                spaces--;
                count++;
            }
            Console.ReadKey();
        }
    }
}