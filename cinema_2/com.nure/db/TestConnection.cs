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
                var query = (from session in context.Session where session.Id == 1 select session).ToList();

                foreach (Session g in query)
                    Console.WriteLine(g.Id + "\n");

                Console.ReadLine();
            }
        }
    }
}