using System;
using System.Collections.Generic;
using System.Linq;

namespace ChuanHoangUtilLive
{
    class Program
    {
        static void Main()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie {Name = "Tien nghich", Category = "Donghua", Imdb = 8, Studio = "ChinaStudio", Year = 2023},
                new Movie {Name = "Endgame", Category = "Superhero", Imdb = 9, Studio = "Marvel", Year  = 2018},
                new Movie {Name = "Game of Throne", Category = "Fantasy", Imdb = 7, Studio = "Unknown", Year = 2020},
                new Movie {Name = "The Lord of the rings", Category = "Fantasy", Imdb = 9, Studio = "Hollywood", Year = 2001},
                new Movie {Name = "Vo lam truyen ky", Category = "Kiem hiep", Imdb = 7, Studio = "ChinaStudio", Year = 2005},
                new Movie {Name = "Cuu am chan kinh", Category = "Game", Imdb = 8, Studio = "SnailGame", Year = 2013},
            };
            var fillterMovies = movies.Where(m => m.Category == "Fantasy");
            foreach (var m in fillterMovies)
                Console.WriteLine($"Name = {m.Name}");
        }
    }
    class Movie
    {
        public string Name { set; get; }
        public string Category { set; get; }
        public byte Imdb { set; get; }
        public string Studio { set; get; }
        public int Year { set; get; }
    }
}