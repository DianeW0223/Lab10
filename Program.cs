using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Movies
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool run = true;

            Console.WriteLine("Welcome to the movie list application");
            Console.WriteLine("There are 10 movies in this list.");

            List<Movie> movies = new List<Movie>();
            Movie a = new Movie("Silence of the Lambs", "horror");
            movies.Add(a);
            Movie b = new Movie("Saw", "horror");
            movies.Add(b);
            Movie c = new Movie("Moana", "animated");
            movies.Add(c);
            Movie d = new Movie("IT", "horror");
            movies.Add(d);
            Movie e = new Movie("star trek", "scifi");
            movies.Add(e);
            Movie f = new Movie("Star Ship Troopers", "scifi");
            movies.Add(f);
            Movie g = new Movie("Pocahontas", "animated");
            movies.Add(g);
            Movie h = new Movie("Chucky", "horror");
            movies.Add(h);
            Movie i = new Movie("The Lion King", "animated");
            movies.Add(i);
            Movie j = new Movie("Independence Day", "scifi");
            movies.Add(j);
            while (run == true)
            {
                Console.WriteLine("What category are you interested in? scifi, horror, animated");
                string input = Console.ReadLine();
                foreach (Movie cj in movies)
                {
                    string cat = cj.getCategory();
                    if ((cat == "horror") && (cat == input))
                    {
                        Console.WriteLine("\n" + cj.getTitle() + " is a horror movie");
                    }
                    else if ((cat == "scifi") && (cat == input))
                    {
                        Console.WriteLine("\n" + cj.getTitle() + " is a scifi movie");
                    }
                    else if ((cat == "animated") && (cat == input))
                    {
                        Console.WriteLine("\n" + cj.getTitle() + " is an animated movie");
                    }
                    
                    

                }
                run = Continue();

            }

        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("\nContinue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("\nGood Bye!");
            }
            else
            {
                Console.WriteLine("\nI'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }


    }
}
