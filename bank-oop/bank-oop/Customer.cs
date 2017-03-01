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
        public readonly string _accountNumber;

        public Customer(string firstname, string lastname, string accountNumber)
        {
            _firstname = firstname;
            _lastname = lastname;
            _accountNumber = accountNumber;
        }



        public override string ToString()
        {
            return _firstname + " " + _lastname + "\n" + _accountNumber + "\n";
        }
    }
}
