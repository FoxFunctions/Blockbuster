namespace blockbuster
{
    public class Program
    {
        public static void Main()
        {
            List<string> helper = new List<string>();
            BlockBuster r = new BlockBuster();
            //DVD d = new DVD("", 22, helper, Genre.Drama);
            VHS v = new VHS("", 22, helper, Genre.Drama);
            Console.WriteLine("Welcome to GC Blockbuster.");
            r.WatchMovie();
            //v.Play(1);   
        }
    }
}