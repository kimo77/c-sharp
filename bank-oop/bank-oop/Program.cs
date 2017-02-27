using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Nordea");
            Customer asiakas1 = new Customer("Vitali", "Nikolaev", bank.CreateNewAccount());
            Console.WriteLine(asiakas1);
            Console.ReadKey();

        }
    }
}
