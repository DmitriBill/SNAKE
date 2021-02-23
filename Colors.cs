using System;

namespace Snake
{
    public class Colors
    {
        public Colors(int score) 
        {
            if (score <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (score >= 3 && score <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (score >= 6 && score <= 8)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (score >= 9 && score <= 11)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
