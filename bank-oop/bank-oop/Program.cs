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
            Customer customer = new Customer("Vitali", "Nikolaev");
            bank.CreateNewAccount(customer);

            BankAccount account = bank.Accounts.FirstOrDefault(item => item.Value._firstname == "Vitali").Key;
            account.AddEvent(1900);


            Console.WriteLine(customer + " - saldo: " + account.PrintSaldo());
            Console.ReadKey();

        }
    }
}
