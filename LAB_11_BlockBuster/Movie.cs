using System;
using System.Collections.Generic;

namespace LAB_11_BlockBuster
{
    enum Genre { DRAMA = 1, COMEDY, HORROR, ROMANCE, ACTION  };
    abstract class Movie
    {
        /*
            Create an abstract Movie class with the following: 
            A property for Title that’s a string 
            A property for Category that’s of Enum Genre
            An int property for RunTime (in minutes) 
            A list of strings called Scenes
            A virtual method called PrintInfo() that prints all properties in the class to the console save for the scenes.
            A method called PrintScenes() that prints all the scenes in the list along with their index. 
            An abstract method with no return type called Play()
         */
        public string title { get; set; }
        public Genre category { get; set; }
        public int runTime { get; set; }
        public List<string> scenes { get; set; }

        public Movie(string _title, Genre _category, int _runTime, List<string> _scenes)
        {
            title = _title;
            category = _category;
            runTime = _runTime;
            scenes = _scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"\ttitle: {title}\tcategory: {category}\trunTime: {runTime} minutes");
        }
        public void PrintScenes()
        {
            if (scenes.Count <= 0)
            {
                Console.WriteLine("No scenes in this flick!");
                return;
            }
            for (int i = 0; i < scenes.Count; i++)
            {
                Console.WriteLine($" scene {i+1} > {scenes[i]}");
            }
        }
        public abstract void Play();
        // play each scene from start to finish
        public abstract void PlayWholeMovie();
    }
}
