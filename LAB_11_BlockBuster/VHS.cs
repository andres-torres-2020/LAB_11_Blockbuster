using System;
using System.Collections.Generic;

namespace LAB_11_BlockBuster
{
    class VHS : Movie
    {
        /*
         * Create a child class of Movie called VHS and code the following:
         * A property called CurrentTime 
         * A method called Play() that plays the scene at the current time and then increments CurrentTime. 
         * A method called Rewind() that returns nothing and sets CurrentTime to 0.
         */
        public int currentTime { get; set; } = 0;
        public VHS(string _title, Genre _category, int _runTime, List<string> _scenes)
            : base(_title, _category, _runTime, _scenes)
        {
        }
        public override void Play()
        {
            if (InputUtil.GetInputBoolYesNo("Would you like to play the entire movie? (y/n)"))
            {
                this.PlayWholeMovie();
                return;
            }
            try
            {
                Console.WriteLine($"\tplaying scene {currentTime}: {scenes[currentTime]}");
                currentTime++;
            }
            catch
            {
                Console.WriteLine("\nYou've reached the final scene! Please be kind and rewind.\nWait! Modernly, we auto-rewind.\n");
                Rewind();
            }
        }
        public void Rewind()
        {
            currentTime = 0;
        }

        public override void PlayWholeMovie()
        {
            if (currentTime > 0 && InputUtil.GetInputBoolYesNo("The cassette is not set to play from the beginning. Rewind? (y/n)"))
            {
                Rewind();
            }
            //play from current position to end of movie
            for (;  currentTime < scenes.Count; currentTime++)
            {
                Console.WriteLine($"{scenes[currentTime]}");
            }
        }
    }
}
