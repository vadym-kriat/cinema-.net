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
        private string _firstName;
        private string _lastName;
        private string _phone;

        public long Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
