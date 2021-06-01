using System;

namespace KnockKnock
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Knock Knock!");
                string firstResponse = Console.ReadLine().Trim();
                if(firstResponse.Equals("Who's there?", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                } else
                if(firstResponse.Equals("Whos there?", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("You need to work on your apostrophes.");

                } else if(firstResponse.EndsWith("!"))
                {
                    Console.WriteLine("Don't get too exicted, we are just starting the joke!");
                }
                else 
                {
                    Console.WriteLine("Don't you know how this works?");
                }
            } while (true);

            do
            {
                Console.WriteLine("Spell");
                string secondResponse = Console.ReadLine().Trim();
                if(secondResponse.Equals("Spell who?", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                } else if(secondResponse.EndsWith("!"))
                {
                    Console.WriteLine("Don't get too excited, you might ruin the punchline!");
                } else
                {
                    Console.WriteLine("Don't you know how this works?");
                }
            } while (true);

            Console.WriteLine("W");
            Console.WriteLine("H");
            Console.WriteLine("O");
        }
    }
}
