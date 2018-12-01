using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_2.com.nure.models
{
    class Booking
    {
        private long _id;
        private long session_id;
        private Session _session;
        private long customer_id;
        private Customer _customer;
        private int _row;
        private int _seatNumber;

        public long Id { get => _id; set => _id = value; }
        public int Row { get => _row; set => _row = value; }
        public int SeatNumber { get => _seatNumber; set => _seatNumber = value; }
        public long Customer_id { get => customer_id; set => customer_id = value; }
        public long Session_id { get => session_id; set => session_id = value; }
        internal Session Session { get => _session; set => _session = value; }
        internal Customer Customer { get => _customer; set => _customer = value; }
    }

    class Customer
    {
        private long _id;
        private string _firstName;
        private string _lastName;
        private string _phone;

        public long Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }

    class Film
    {
        private long _id;
        private string _name;
        private int _duration;
        private DateTime firstPerformance;
        private string _country;
        private string _genre;
        private float _cost;
        private string _type;

        public long Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public DateTime FirstPerformance { get => firstPerformance; set => firstPerformance = value; }
        public string Country { get => _country; set => _country = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public float Cost { get => _cost; set => _cost = value; }
        public string Type { get => _type; set => _type = value; }

    }

    class Room
    {
        private long _id;
        private string _name;
        private int _row;
        private int _column;

        public long Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Row { get => _row; set => _row = value; }
        public int Column { get => _column; set => _column = value; }
    }

    class Session
    {
        private long _id;

        private long film_id;
        private Film _film;

        private long room_id;
        private Room _room;

        private DateTime _dateTime;

        public long Id { get => _id; set => _id = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public long Film_id { get => film_id; set => film_id = value; }
        public long Room_id { get => room_id; set => room_id = value; }
        internal Film Film { get => _film; set => _film = value; }
        internal Room Room { get => _room; set => _room = value; }
    }
}
