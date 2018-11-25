using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_2.com.nure.models
{
    class Session
    {
        private long _id;
        private long _filmId;
        private Film _film;
        private long _roomId;
        private Room _room;
        private DateTime _dateTime;

        private List<Booking> _bookings;

        public long Id { get => _id; set => _id = value; }
        public long FilmId { get => _filmId; set => _filmId = value; }
        public long RoomId { get => _roomId; set => _roomId = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        internal Film Film { get => _film; set => _film = value; }
        internal Room Room { get => _room; set => _room = value; }
        internal List<Booking> Bookings { get => _bookings; set => _bookings = value; }
    }
}
