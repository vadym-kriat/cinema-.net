using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_2.com.nure.models
{
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
}
