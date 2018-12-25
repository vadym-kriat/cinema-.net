using System;
using System.Windows.Forms;
using cinema_2.db.persistence;
using cinema_2.models;
using cinema_2.services;

namespace cinema_2
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /*public static void Main()
        {
            TestCustomer();
            TestFilm();
            TestRoom();
            TestBooking();
            TestSession();
            Console.ReadLine();
        }*/

        public static void TestCustomer()
        {
            CustomerPersistance customerPersistance = new CustomerPersistance();

            Customer customer = new Customer()
            {
                FirstName = "john",
                LastName = "dao",
                Phone = "066-777-88-99"
            };
            customerPersistance.Save(customer);

            customer.FirstName = "test";
            customerPersistance.Save(customer);

            customerPersistance.Remove(customer);
        }

        public static void TestFilm()
        {
            FilmPersistence filmPersistance = new FilmPersistence();

            Film film = new Film()
            {
                Name = "test",
                FirstPerformance = new DateTime(),
                Duration = 123,
                Description = "test1"
            };
            filmPersistance.Save(film);

            film.Name = "1233";
            filmPersistance.Save(film);

            filmPersistance.Remove(film);
        }

        public static void TestRoom()
        {
            RoomPersistence roomPersistence = new RoomPersistence();

            Room room = new Room()
            {
                Name = "test"
            };

            for (int i = 0; i < 15; i++)
            {
                room.AddRow(new Row() {
                    Seats = 15,
                    Number = i + 1
                });
            }

            roomPersistence.Save(room);

            room.Name = "12124124124";
            roomPersistence.Save(room);

            roomPersistence.Remove(room);
        }

        public static void TestBooking()
        {
            BookingService bookingService = new BookingService();
            BookingPersistance bookingPersistance = new BookingPersistance();

            Booking booking = bookingService.Book(1, 1, 3, 3);

            
            bookingPersistance.Remove(booking);
        }

        public static void TestSession()
        {
            SessionPersistance sessionPersistance = new SessionPersistance();

            Session session = new Session()
            {
                FilmId = 1,
                RoomId = 1,
                DateTime = new DateTime()
            };

            sessionPersistance.Save(session);

            session.DateTime = new DateTime();

            sessionPersistance.Save(session);

            sessionPersistance.Remove(session);
        }
    }
}