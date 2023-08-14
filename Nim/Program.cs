namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Nim";
            Random random = new Random();
            int matches = 7;
            Console.WriteLine("Rules: There are 7 matches. Pick from 1 to 3. Person to pick the last match lose.\n");
            while (true)
            {
                    Console.WriteLine("How many matches will you take?\n");
                    int playerChoice = Convert.ToInt32(Console.ReadLine());
                    if (playerChoice < 1 || playerChoice > 3)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        matches -= playerChoice;
                    }
                    if (matches == 0)
                    {
                        Console.WriteLine("You lose!!");
                    Console.ReadKey();
                        break;
                    }

                    if (matches > 3)
                    {
                        matches -= random.Next(1, 4);
                    }
                    else if (matches > 2)
                    {
                        matches -= random.Next(1, 3);
                    }
                    else
                    {
                        matches--;
                    }
                    if(matches == 0)
                    {
                        Console.WriteLine("PC lose, you win!!");
                        Console.ReadKey();
                        break;
                    }
                Console.WriteLine("There are " + matches + " left");
                
            }
        }
    }
}