using System;
namespace blockbuster
{
    public class Helper
    {
        public bool RunAgain()
        {
            Console.WriteLine("Would you like to watch a different movie? Please enter y or n");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't quite get that. Please enter y or n.");
            }
            return RunAgain();
        }
    }
}

