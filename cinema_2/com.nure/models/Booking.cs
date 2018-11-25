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
        private Session _session;
        private Customer _customer;
        private int _row;
        private int _seatNumber;

        public long Id { get => _id; set => _id = value; }
        public int Row { get => _row; set => _row = value; }
        public int SeatNumber { get => _seatNumber; set => _seatNumber = value; }
        internal Session Session { get => _session; set => _session = value; }
        internal Customer Customer { get => _customer; set => _customer = value; }
    }
}
