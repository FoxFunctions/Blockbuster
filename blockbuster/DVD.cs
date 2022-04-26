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

                        if (userChoice <= 0 || userChoice > b2.ourMovies[num].Scenes.Count)
                        {
                            Console.WriteLine("That is not a valid selection. Please try again .");
                        }
                        else
                        {
                            userChoice = userChoice - 1;
                            Console.WriteLine(b2.ourMovies[num].Scenes[userChoice]);
                        }
                        runAgain = WatchAnotherScene();
                        
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, that is not a valid input. Please try again");
                    continue;
                }
                
            }
            
            
        }

        public bool WatchAnotherScene()
        {
            Console.WriteLine("Watch Another Scene? y/n");
            string userWatchAgain = Console.ReadLine().ToLower().Trim();
            if (userWatchAgain == "y")
            {
                return true;
            }
            else if (userWatchAgain == "n")
            {
                Console.WriteLine("Bye");
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand. Please try again.");
                return WatchAnotherScene();
            }

        }
    }
}

/* Create a child of Movie named DVD with the following code: 
A method called Play() that takes no parameters and is void that will ask the user what scene they’d like to watch, print all the available scenes, and allow the user to select a scene from the list and print it out.*/