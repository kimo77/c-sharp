using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    class Bank
    {
        private string _name;
        private List<BankAccount> accounts = new List<BankAccount>();

        public Bank(string name)
        {
            _name = name;
        }

        
        public string CreateNewAccount()
        {
            Random rand = new Random();
            string accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
                int nextChar = rand.Next(0, 9);
                accountNumber = accountNumber + nextChar.ToString();
            }

            BankAccount account = new BankAccount(accountNumber);
            accounts.Add(account);
            return accountNumber;
        }
    }
}
