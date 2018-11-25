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
                var query = (from genre in context.Genre where genre.Id == 1 select genre).ToList();

                foreach (Genre g in query)
                    Console.WriteLine(g.Id + " " + g.Name + "\n");

                Console.ReadLine();
            }
        }
    }
}