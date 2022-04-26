using System;
namespace blockbuster
{
	public class VHS : Movie
	{
        
        int currentTime = 0;
        
        public VHS(string Title, int RunTime, List<string> Scenes, Genre MovieCategory) : base(Title, RunTime, Scenes, MovieCategory)
		{
            
		}

        public override void Play(int num)
        {
            BlockBuster b1 = new BlockBuster();
            while (currentTime < b1.ourMovies[num].Scenes.Count)
            {
                for (int i = 0; i < b1.ourMovies[num].Scenes.Count; i++)
                {
                    Console.WriteLine("Scene " + (i + 1) + ": " + b1.ourMovies[num].Scenes[currentTime]);
                    currentTime++;
                }
            }
        }
        public void Rewind()
        {
            currentTime = 0;
        } 
        
    }
}



/*A method called Play() that plays the scene at the current time and then increments CurrentTime. 
A method called Rewind() that returns nothing and sets CurrentTime to 0. */