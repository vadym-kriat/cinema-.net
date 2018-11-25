using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_2.com.nure.models
{
    class Customer
    {
        private long _id;
        private string _first_name;
        private string _last_name;
        private string _phone;

        public long Id { get => _id; set => _id = value; }
        public string First_name { get => _first_name; set => _first_name = value; }
        public string Last_name { get => _last_name; set => _last_name = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
