using System;
using System.Collections.Generic;
using cinema_2.com.nure.db.persistence;
using cinema_2.com.nure.models;

namespace cinema_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FilmPersistence filmPersistence = new FilmPersistence();
            Film film = filmPersistence.FindById(3);
            Console.WriteLine(film == null);
            Console.WriteLine(film);

            List<Film> films = filmPersistence.FindByName("антас");
            Console.WriteLine(films);

            Console.ReadLine();
        }
    }
}