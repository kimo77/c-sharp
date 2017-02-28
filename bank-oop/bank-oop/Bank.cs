using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    public class Bank
    {
        private string _name;
        //private List<BankAccount> accounts = new List<BankAccount>();
        public Dictionary<BankAccount, Customer> Accounts = new Dictionary<BankAccount, Customer>();

        public Bank(string name)
        {
            _name = name;
        }

        
        public string CreateNewAccount(Customer customer)
        {
            Random rand = new Random();
            string accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
                int nextChar = rand.Next(0, 9);
                accountNumber = accountNumber + nextChar.ToString();
            }

            BankAccount account = new BankAccount(accountNumber);
            Accounts.Add(account, customer);
            return accountNumber;
        }

        public void NewTransaction(string firstname, string lastname, double summa)
        {
            //bank_oop.Customer customer = accounts.Find(item => )
        }

    }
}
