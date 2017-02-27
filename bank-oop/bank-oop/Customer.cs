using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    class Customer
    {
        private string _firstname;
        private string _lastname;
        private string _accNum;

        public Customer(string firstname, string lastname, string accNum)
        {
            _firstname = firstname;
            _lastname = lastname;
            _accNum = accNum;
        }

        public override string ToString()
        {
            return _firstname + " " + " " + _lastname + " " + _accNum;
        }
    }
}
