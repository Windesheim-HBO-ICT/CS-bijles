using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Film> films = new List<Film>
            {
                new Film("Spiderman", 1999, "David"),
                new Film("Breaking bad", 2005, "Martin"),
                new Film("Smallfoot", 1995, "Lynch"),
                new Film("Venom", 1989, "Abbas"),
                new Film("First Man", 1993, "Joel"),
                new Film("Jonny English", 1997, "Steven"),
                new Film("Big bang theorie", 1955, "Errol"),
            };


            var recentFilms = films.Where(i => i.ReleaseYear >= 1990).OrderByDescending(i => i.ReleaseYear).Select(i=>i.ReleaseYear);
            foreach (var recentFilm in recentFilms)
            {
                Console.WriteLine($"{recentFilm}");
            }
            Console.WriteLine();
            films.RemoveAt(1);

            foreach (var recentFilm in recentFilms)
            {
                Console.WriteLine($"{recentFilm}");
            }
            Console.WriteLine();


            var recentFilms2 = from f in films where f.ReleaseYear >= 1990 orderby f.ReleaseYear descending select f.ReleaseYear;
            foreach (var recentFilm in recentFilms2)
            {
                Console.WriteLine($"{recentFilm}");
            }
            Console.WriteLine();

            var allNames = films.Select(f => f.Name).Aggregate((f1, f2) => f1+ ", " + f2);
            Console.WriteLine(allNames);
        }
    }
}
