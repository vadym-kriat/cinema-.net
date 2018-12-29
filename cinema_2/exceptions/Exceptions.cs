using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_2.exceptions
{
    class UpdateExceptions : Exception
    {
        public UpdateExceptions()
        {
        }

        public UpdateExceptions(string message)
            : base(message)
        {
        }

        public UpdateExceptions(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
