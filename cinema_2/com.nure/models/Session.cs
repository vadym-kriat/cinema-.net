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
        private Film _film;
        private Room _room;
        private DateTime _dateTime;

        public long Id { get => _id; set => _id = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        internal Film Film { get => _film; set => _film = value; }
        internal Room Room { get => _room; set => _room = value; }
    }
}
