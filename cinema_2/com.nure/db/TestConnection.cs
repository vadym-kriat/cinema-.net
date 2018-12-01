using System;
using System.Linq;
using cinema_2.com.nure.models;

namespace cinema_2.db
{
    public class TestConnection
    {
        public static void TestSelectFromGenre()
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var result = (from sessiondb in context.Session
                             join filmdb in context.Film
                             on sessiondb.Film_id equals filmdb.Id
                             join roomdb in context.Room
                             on sessiondb.Room_id equals roomdb.Id
                             where sessiondb.Id == 1
                             select new Session()
                             {
                                 Id = sessiondb.Id,
                                 Film_id = filmdb.Id,
                                 Film = new Film()
                                 {
                                     Id = filmdb.Id,
                                     Name = filmdb.Name,
                                     Duration = filmdb.Duration,
                                     FirstPerformance = filmdb.FirstPerformance,
                                     Country = filmdb.Country,
                                     Genre = filmdb.Genre,
                                     Cost = filmdb.Cost,
                                     Type = filmdb.Type
                                 },
                                 Room_id = roomdb.Id,
                                 Room = new Room()
                                 {
                                     Id = roomdb.Id,
                                     Name = roomdb.Name,
                                     Row = roomdb.Row,
                                     Column = roomdb.Column
                                 }
                             }).Single();

                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}