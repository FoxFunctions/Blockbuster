﻿using System;
namespace blockbuster
{ 
	public class BlockBuster
	{	
		public  List<string> testList = new List<string>() {"first thing", "second thing" };
		public static List<string> coolRunningScene = new List<string>() { "Jamaica is really hot. No bobsled team yet", "Jamaica forms a bobsled team and is going to compete in the olympics!!", "Jamaica loses the bobsled race" };
		public static List<string> marioScene = new List<string>() { "Bowser has trapped the princess in a pipe.", "Mario retreives his snake from his plumbing toolkit", "Mario rescues the princess" };
		public static List<string> batmanScene = new List<string>() { "Batman works alone.", "Now, Batman has a sidekick.", "Batman notices Gotham is REALLY cold.", "Batman defeats Mr. Freeze." };
		public static List<string> wednesdayScene = new List<string>() { "A new group of Freshman try out for the football team.", "They fail miserably.", "The freshman form their own league and play on Wednesday nights." };
		public static List<string> sammyScene = new List<string>() { "Sammy Sosa teaches you how to contact an offshore physcian to prescribe PED's", "Sammy Sosa teaches you how to safely consume PED's.", "Sammy Sosa speaks briefly about swinging a baseball bat." };
		public static List<string> twisterScene = new List<string>() { "Good Weather.", "Bad weather.", "Flying Cow.", "Good weather." };
		

		public static VHS CoolRunnings = new VHS("Cool Runnings", 82, coolRunningScene, Genre.Comedy);
		public static VHS Mario = new VHS("Mario: The Pipe Cleaner", 95, marioScene, Genre.Drama);
		public static VHS BatmanAndRobin = new VHS("Batman and Robin", 124, batmanScene, Genre.Horror);
		public static DVD WednesdayNightLights = new DVD("Wednesday Night Lights: The other guys.", 22, wednesdayScene, Genre.Drama);
		public static DVD SammySosa = new DVD("If I can do it, so can you: A guide to hitting home runs by Sammy Sosa", 65, sammyScene, Genre.Comedy);
		public static DVD Twister = new DVD("Twister", 142, twisterScene, Genre.Romance);
		public int userChoice;

		public  List<Movie> ourMovies = new List<Movie>() {CoolRunnings, Mario, BatmanAndRobin, WednesdayNightLights, SammySosa, Twister };


		public void PrintMovies()
        {
			for (int i = 0; i < ourMovies.Count; i++)
            {
                Console.WriteLine($"{i+1}) {ourMovies[i].Title}");
            }
        }

		public Movie CheckOut()
        {
			while (true)
			{
				try
				{
					PrintMovies();
                    Console.WriteLine();
					Console.WriteLine("Which movie would you like to checkout?");
					userChoice = int.Parse(Console.ReadLine());

					if (userChoice <= 0 || userChoice > ourMovies.Count)
					{
						Console.WriteLine("Sorry, that is not a valid response.");
						return CheckOut();
					}
					else
					{
						PrintInfo(ourMovies, userChoice - 1);
						return ourMovies[userChoice-1];
					}
				}
				catch
				{
					Console.WriteLine("Sorry, that is not a valid response");
					return CheckOut();
				}
			}
        }

		public void PrintInfo(List<Movie> ourMovies, int index)
		{
			Console.WriteLine("Movie Title: " + ourMovies[index].Title);
			Console.WriteLine("Movie Category: " + ourMovies[index].MovieCategory);
			Console.WriteLine("Movie Run Time: " + ourMovies[index].RunTime + " minutes.");
		}

		public void PrintScene()
        {
			for (int i =0; i < ourMovies[userChoice - 1].Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i+1}: {ourMovies[userChoice - 1].Scenes[i]}");
            }
        }

		public void WatchMovie()
		{
			while (true)
			{
				Movie userMovie = CheckOut();
				int userMovieChoice = ourMovies.IndexOf(userMovie);

                Console.WriteLine("Would you like to watch this movie? Please enter y/n");
				string watchMovie = Console.ReadLine().ToLower().Trim();
				if (watchMovie == "y")
                {
					if (ourMovies[userMovieChoice] is DVD)
                    {
						WednesdayNightLights.Play(userMovieChoice);
						Console.WriteLine("Bye");
						break;
					}
					else if (ourMovies[userMovieChoice] is VHS)
					{
						CoolRunnings.Play(userMovieChoice);
						Console.WriteLine("Bye");
						break;
					}
				}
				else if (watchMovie == "n")
                {
                    Console.WriteLine("Bye");
					break;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't get that. Please try again.");
                }
			}
		}
	}
}


/* Lastly, create a class named Blockbuster that contains the following code: 
List<Movie> Movies - this should contain at least 6 movies, 3 DVDs, 3 VHS all your choice
PrintMovies() - this will print all the movie titles in the Movies list along with their indexes.
CheckOut() - this will call PrintMovies() and ask the user which movie they’d like to check out, get an index from the user, select a movie from the list and PrintInfo() on that movie.
The method should return the Movie object selected by the user.*/