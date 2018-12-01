using System.Linq;
using System.Collections.Generic;
using cinema_2.com.nure.models;
using cinema_2.db;

namespace cinema_2.com.nure.db.persistence
{
    class FilmPersistence
    {
        public Film FindById(long id)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var film = (from filmdb in context.Film
                            where filmdb.Id == id
                            select new Film()).SingleOrDefault();
                return film;
            }
        }

        public List<Film> FindAll()
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var films = (from f in context.Film
                             select new Film()).ToList();
                return films;
            }
        }

        public List<Film> FindByName(string name)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var films = (from f in context.Film
                             where f.Name.Contains(name) && f.Name.EndsWith(name)
                             select new Film()).ToList();
                return films;
            }
        }
    }


}
