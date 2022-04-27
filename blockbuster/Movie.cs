using System;
namespace blockbuster
{	public enum Genre
    {
		Drama,
		Comedy,
		Horror,
		Romance,
		Action
    }
	public abstract class Movie
	{
		public string Title  { get; set; }
		public int RunTime   { get; set; }
		public List<string> Scenes { get; set; }
		public Genre MovieCategory {get; set;}

		public Movie(string Title, int RunTime, List<string> Scenes, Genre MovieCategory)
		{
			this.Title = Title;
			this.RunTime = RunTime;
			this.Scenes = Scenes;
			this.MovieCategory = MovieCategory;
		}
		public virtual void PrintInfo()
        {	
            Console.WriteLine("Movie Title: " + Title);
            Console.WriteLine("Movie Category: " + MovieCategory);
            Console.WriteLine("Movie Run Time: " + RunTime);
        }
		public void PrintScenes(List<string> sceneList)
        {
			for (int i = 0; i < sceneList.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {sceneList[i]}.");
            }
        }
		public abstract void Play(int num);
	}
}