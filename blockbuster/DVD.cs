using System;
namespace blockbuster
{
    public class DVD : Movie
    {
        public DVD(string Title, int RunTime, List<string> Scenes, Genre MovieCategory) : base(Title, RunTime, Scenes, MovieCategory)
        {

        }
        public override void Play(int num)
        {
            BlockBuster b2 = new BlockBuster();
            bool runAgain = true;
            while (true)
            {
                try
                {
                    while (runAgain)
                    {
                        Console.WriteLine($"Which scene of {b2.ourMovies[num].Title} do you want to watch? Please enter a number ranging from 1 - {b2.ourMovies[num].Scenes.Count}");
                        int userChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (userChoice <= 0 || userChoice > b2.ourMovies[num].Scenes.Count)
                        {
                            Console.WriteLine("That is not a valid selection. Please try again .");
                        }
                        else
                        {
                            userChoice = userChoice - 1;
                            Console.WriteLine(b2.ourMovies[num].Scenes[userChoice]);
                            Console.WriteLine();
                            runAgain = WatchAnotherScene();
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, that is not a valid input. Please try again");
                    continue;
                }
                break;
            }
        }
        public bool WatchAnotherScene()
        {
            Console.WriteLine("Watch Another Scene? y/n");
            string userWatchAgain = Console.ReadLine().ToLower().Trim();
            Console.WriteLine();
            if (userWatchAgain == "y")
            {
                return true;
            }
            else if (userWatchAgain == "n")
            {

                return false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand. Please try again.");
                return WatchAnotherScene();
            }
        }
        public void PlayWholeDVD(int num)
        { BlockBuster b = new BlockBuster();
            for (int i =0; i < b.ourMovies[num].Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i+1}: {b.ourMovies[num].Scenes[i]}");
            }
        }
    }
}