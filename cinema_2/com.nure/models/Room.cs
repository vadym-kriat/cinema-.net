using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_2.com.nure.models
{
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
}
