using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    public class Customer
    {
        public readonly string _firstname;
        public readonly string _lastname;
        //private readonly string _accountNumber;

        public Customer(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }



        public override string ToString()
        {
            return _firstname + " " + " " + _lastname + " ";
        }
    }
}
