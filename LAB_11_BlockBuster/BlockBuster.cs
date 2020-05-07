using System;
using System.Collections.Generic;

namespace LAB_11_BlockBuster
{
    class BlockBuster
    {
        /*
         * Lastly, create a class named Blockbuster that contains the following code:
         * 
         * List<Movie> Movies - this should contain at least 6 movies, 3 DVDs, 3 VHS all your choice
         * 
         * PrintMovies() - this will print all the movie titles in the Movies list along with their indexes.
         * 
         * CheckOut() - this will
         *      call PrintMovies()
         *      and ask the user which movie they’d like to check out,
         *      get an index from the user,
         *      select a movie from the list
         *      and PrintInfo() on that movie.
         */
        protected static List<Movie> movies = new List<Movie>
        {
            new DVD("movie1", Genre.ACTION, 120, new List<string>{"scene#1","scene#2","scene#3","scene#4"}),
            new DVD("movie2", Genre.HORROR, 90, new List<string>{"scene#1","scene#2","scene#3","scene#4"}),
            new DVD("movie3", Genre.DRAMA, 90, new List<string>{"scene#1","scene#2","scene#3","scene#4"}),

            new VHS("Acassette", Genre.DRAMA, 110, new List<string>{"one","two","three"}),
            new VHS("Bcassette", Genre.ACTION, 100, new List<string>{"won","too"}),
            new VHS("Dcassette", Genre.COMEDY, 90, new List<string>{"one","two","three",})
        };
        public void PrintMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"\t{i + 1} {movies[i].category}\t{movies[i].title}");
            }
        }
        public void CheckOut()
        {
            PrintMovies();
            int movieIndex = InputUtil.ReadInteger("\nWhat movie would you like to watch? ", 1, movies.Count);
            Movie selectedMovie = movies[movieIndex - 1];
            selectedMovie.PrintInfo();

            string[] watchMoreYes = { "y", "yes" };
            string[] watchMoreNo = { "n", "no" };
            bool watchMovieNow = InputUtil.GetInputBool("\nDo you want to watch the movie? Y/N", watchMoreYes, watchMoreNo);
            if (watchMovieNow)
            {
                selectedMovie.Play();
            }
        }
    }
}
