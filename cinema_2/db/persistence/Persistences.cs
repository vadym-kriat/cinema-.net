using System;
using System.Linq;
using System.Collections.Generic;
using cinema_2.models;
using cinema_2.db;
using cinema_2.exceptions;

namespace cinema_2.db.persistence
{
    class FilmPersistence
    {
        public Film FindById(long id)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var film = (from f in context.Film
                            where f.Id == id
                            select f).SingleOrDefault();
                return film;
            }
        }

        public List<Film> FindAll()
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var films = (from f in context.Film
                             orderby f.Id descending
                             select f).ToList();
                return films;
            }
        }

        public List<Film> FindByName(string name)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var films = (from f in context.Film
                             where f.Name.Contains(name)
                             select f).ToList();
                return films;
            }
        }

        public Film Save(Film film)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                try
                {
                    context.Update(film);
                    context.SaveChanges();
                } catch (Exception e)
                {
                    throw new UpdateExceptions("Save film error.");
                }
                
            }
            return film;
        }

        public void Remove(Film film)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Film.Remove(film);
                context.SaveChanges();
            }
        }
    }

    class RoomPersistence
    {
        public Room FindById(long id)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var room = (from r in context.Room
                            where r.Id == id
                            select r).SingleOrDefault();
                return room;
            }
        }

        public List<Room> FindAll()
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var rooms = (from r in context.Room
                             select new Room()
                             {
                                 Id = r.Id,
                                 Name = r.Name,
                                 Rows = (from t in r.Rows select t).ToList()
                             }).ToList();
                return rooms;
            }
        }

        public Room Save(Room room)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Update(room);
                context.SaveChanges();
            }
            return room;
        }

        public Room Remove(Room room)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Room.Remove(room);
                context.SaveChanges();
            }
            return room;
        }
    }

    class CustomerPersistance
    {
        public Customer FindById(long id)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var customer = (from c in context.Customer
                            where c.Id == id
                            select c).SingleOrDefault();
                return customer;
            }
        }

        public List<Customer> FindAll()
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var customer = (from c in context.Customer
                             select c).ToList();
                return customer;
            }
        }

        public Customer Save(Customer customer)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Update(customer);
                context.SaveChanges();
            }
            return customer;
        }

        public void Remove(Customer customer)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Customer.Remove(customer);
                context.SaveChanges();
            }
        }
    }

    class SessionPersistance
    {
        public Session FindById(long id)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var session = (from s in context.Session
                                join r in context.Room
                                on s.RoomId equals r.Id
                                join f in context.Film
                                on s.FilmId equals f.Id
                                select new Session()
                                {
                                    Id = s.Id,
                                    FilmId = s.FilmId,
                                    Film = f,
                                    RoomId = s.RoomId,
                                    Room = new Room()
                                    {
                                        Id = r.Id,
                                        Name = r.Name,
                                        Rows = (from t in r.Rows where t.RoomId == r.Id select t).ToList()
                                    },
                                    DateTime = s.DateTime
                                }).SingleOrDefault();
                return session;
            }
        }

        public List<Session> FindAll()
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var session = (from s in context.Session
                               join r in context.Room on s.RoomId equals r.Id
                               join f in context.Film on s.FilmId equals f.Id
                               select new Session() {
                                   Id = s.Id,
                                   FilmId = s.FilmId,
                                   Film = f,
                                   RoomId = s.RoomId,
                                   Room = new Room()
                                   {
                                       Id = r.Id,
                                       Name = r.Name,
                                       Rows = (from t in r.Rows  where t.RoomId == r.Id select t).ToList()
                                   },
                                   DateTime = s.DateTime
                               }).ToList();
                return session;
            }
        }

        public Session Save(Session session)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Update(session);
                context.SaveChanges();
            }
            return session;
        }

        public Session Remove(Session session)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Session.Remove(session);
                context.SaveChanges();
            }
            return session;
        }
    }

    class BookingPersistance
    {
        public Booking FindById(long id)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var booking = (from b in context.Booking
                               join c in context.Customer on b.CustomerId equals c.Id
                               where b.Id == id
                               select new Booking() {
                                   Id = b.Id,
                                   SessionId = b.SessionId,
                                   CustomerId = b.CustomerId,
                                   Customer = c,
                                   Row = b.Row,
                                   Seat = b.Seat
                               }).SingleOrDefault();
                booking.Session = new SessionPersistance().FindById(booking.SessionId);
                return booking;
            }
        }

        public List<Booking> FindAll()
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var bookings = (from b in context.Booking
                                join c in context.Customer on b.CustomerId equals c.Id
                                select new Booking()
                                {
                                    Id = b.Id,
                                    SessionId = b.SessionId,
                                    CustomerId = b.CustomerId,
                                    Customer = c,
                                    Row = b.Row,
                                    Seat = b.Seat
                                }).ToList();

                SessionPersistance persistance = new SessionPersistance();
                foreach (var item in bookings)
                {
                    item.Session = persistance.FindById(item.SessionId);
                }
                return bookings;
            }
        }

        public Booking FindBySessionAndSeats(long sessionId, int row, int seat)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                var booking = (from b in context.Booking
                               where b.SessionId == sessionId
                               && b.Row == row
                               && b.Seat == seat
                               select b).SingleOrDefault();
                return booking;
            }
        }

        public Booking Save(Booking booking)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Update(booking);
                context.SaveChanges();
            }
            return booking;
        }

        public void Remove(Booking booking)
        {
            using (MySqlDbContext context = new MySqlDbContext())
            {
                context.Booking.Remove(booking);
                context.SaveChanges();
            }
        }
    }
}
