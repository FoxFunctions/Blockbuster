namespace blockbuster
{
    public class Program
    {
        public static void Main()
        {
            Helper h = new Helper();
            BlockBuster r = new BlockBuster();
            bool runAgain = true;

            while (runAgain)
            {   
                Console.WriteLine("Welcome to GC Blockbuster.");
                Console.WriteLine();
                r.WatchMovie();
                runAgain = h.RunAgain();
                Console.WriteLine("Good Bye!");
            }
        }
    }
}