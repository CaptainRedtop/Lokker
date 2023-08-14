namespace HeldOgLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Held og Lotto";

            Random random = new Random();
            int[] lotto = new int[8];
            Console.WriteLine("Todays numbers are:\n");
            for (int i = 0; i < 8; i++)
            {
                if (i < 7)
                {
                    int number = random.Next(1, 37);
                    if (lotto.Contains(number))
                    {
                        continue;
                    }
                    else
                    {
                        lotto[i] = (number);
                    }
                }
                else
                {
                    int number = random.Next(1, 37);
                    lotto[i] = (number);
                }
            }
            for (int i = 0; i < lotto.Length; i++)
            {
                if (i < 7)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Array.Sort(lotto);
                    Console.Write(lotto[i] + " ");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(lotto[i]);
                    Thread.Sleep(2000);
                }
                
            }
            Console.ResetColor();
            Console.WriteLine("\n\nDid you win?");
            Console.ReadKey();
        }
    }
}