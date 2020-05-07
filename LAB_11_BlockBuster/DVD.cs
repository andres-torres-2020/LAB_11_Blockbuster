using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_11_BlockBuster
{
    class DVD : Movie
    {
        /*
         * Create a child of Movie named DVD with the following code: 
         * 
         * A method called Play() that takes no parameters and is void that
         *      will ask the user what scene they’d like to watch
         *      , print all the available scenes
         *      , and allow the user to select a scene from the list
         *      and print it out.
         */
        public DVD(string _title, Genre _category, int _runTime, List<string> _scenes)
            : base(_title, _category, _runTime, _scenes)
        {
        }
        public override void Play()
        {
            if (InputUtil.GetInputBoolYesNo("Play entire movie? (y/n)"))
            {
                PlayWholeMovie();
                return;
            }
            bool watchMoreScenes = true;
            PrintScenes();
            while (watchMoreScenes)
            {
                int sceneIndex = InputUtil.ReadInteger(
                    $"What scene of the DVD, {title}, would you like to watch? ", 1, scenes.Count);
                Console.WriteLine($"\tplaying scene {sceneIndex}: {scenes[sceneIndex - 1]}");
                string[] watchMoreYes = { "y", "yes" };
                string[] watchMoreNo = { "n", "no" };
                watchMoreScenes = InputUtil.GetInputBool("Watch another scene?", watchMoreYes, watchMoreNo);
            }
        }
        public override void PlayWholeMovie()
        {
            foreach (string scene in this.scenes)
            {
                Console.WriteLine(scene);
            }
        }
    }
}
