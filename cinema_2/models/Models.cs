using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_2.models
{
    public class Customer
    {
        private long _id;
        private string _firstName;
        private string _lastName;
        private string _phone;

        public long Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public override string ToString()
        {
            return "FiCustomer: id = " + _id +
                " first name = " + _firstName +
                " last name = "+ _lastName + 
                " phone = " + _phone;
        }
    }

    public class Film
    {
        private long _id;
        private string _name;
        private string _description;
        private int _duration;
        private DateTime _firstPerformance;
        private string _country;
        private string _genre;
        private float _cost;
        private string _type;

        public Film()
        {
            _firstPerformance = DateTime.Now;
        }

        public long Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public DateTime FirstPerformance { get => _firstPerformance; set => _firstPerformance = value; }
        public string Country { get => _country; set => _country = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public float Cost { get => _cost; set => _cost = value; }
        public string Type { get => _type; set => _type = value; }
        public string Description { get => _description; set => _description = value; }

        public override string ToString()
        {
            return "Film: id = " + _id + " name = " + _name; 
        }
    }

    public class Room
    {
        private long _id;
        private string _name;
        private List<Row> _rows;

        public Room()
        {
            _rows = new List<Row>();
        }
        
        public long Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        internal List<Row> Rows { get => _rows; set => _rows = value; }

        public override string ToString()
        {
            return "Room: id = " + _id + " name = " + _name + " roows = " + _rows;
        }

        public void AddRow(Row row)
        {
            Rows.Add(row);
        }

        public Row GetRowByNumber(int number)
        {
            var row = (from r in _rows where r.Number == number select r).SingleOrDefault();
            return row;
        }
    }

    public class Row
    {
        private long _id;
        private int _seats;
        private int _number;

        private long _room_id;
        private Room _room;

        public long Id { get => _id; set => _id = value; }
        public int Seats { get => _seats; set => _seats = value; }
        public int Number { get => _number; set => _number = value; }
        public long RoomId { get => _room_id; set => _room_id = value; }
        internal Room Room { get => _room; set => _room = value; }

        public override string ToString()
        {
            return "Row: id = " + _id + " seats = " + _seats + " number = " + _number;
        }
    }

    public class Session
    {
        private long _id;

        private long film_id;
        private Film _film;

        private long room_id;
        private Room _room;

        private DateTime _dateTime;

        public long Id { get => _id; set => _id = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public long FilmId { get => film_id; set => film_id = value; }
        public long RoomId { get => room_id; set => room_id = value; }
        internal Film Film { get => _film; set => _film = value; }
        internal Room Room { get => _room; set => _room = value; }
    }

    public class Booking
    {
        private long _id;

        private long session_id;
        private Session _session;

        private long customer_id;
        private Customer _customer;

        private long _row;
        private int _seat;

        public long Id { get => _id; set => _id = value; }
        public long Row { get => _row; set => _row = value; }
        public int Seat { get => _seat; set => _seat = value; }
        public long CustomerId { get => customer_id; set => customer_id = value; }
        public long SessionId { get => session_id; set => session_id = value; }
        internal Session Session { get => _session; set => _session = value; }
        internal Customer Customer { get => _customer; set => _customer = value; }
    }
}
