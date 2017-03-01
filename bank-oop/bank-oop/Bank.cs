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
        public Dictionary<BankAccount, Customer> Accounts = new Dictionary<BankAccount, Customer>();

        public Bank(string name)
        {
            _name = name;
        }

        
        public string CreateNewAccount(string firstname, string lastname)
        {
            
            Random rand = new Random();
            string accountNumber = "FI";
            for (int i = 0; i < 16; i++)
            {
                int nextChar = rand.Next(0, 9);
                accountNumber = accountNumber + nextChar.ToString();
            }
            Customer customer = new Customer(firstname, lastname, accountNumber);
            BankAccount account = new BankAccount(accountNumber);
            Accounts.Add(account, customer);
            return accountNumber;
        }

        public BankAccount GetAccountByName(string firstname, string lastname)
        {
            BankAccount account = Accounts.FirstOrDefault(item => item.Value._firstname == firstname && item.Value._lastname == lastname).Key;
            return account;
        }

        public BankAccount GetAccountByAccountNumber(string accountNumber)
        {
            BankAccount account = Accounts.FirstOrDefault(item => item.Key.AccountNumber == accountNumber).Key;
            return account;
        }
        public void CreateNewTransactionByName(string firstname, string lastname, double summa, string dateTime)
        {
            GetAccountByName(firstname, lastname).AddEvent(summa, Convert.ToDateTime(dateTime));
        }

        public void CreateNewTransactionByName(string firstname, string lastname, double summa)
        {
            GetAccountByName(firstname, lastname).AddEvent(summa, DateTime.Now);
        }

        public void CreateNewTransactionByAccount(string accountNumber, double summa, string dateTime)
        {
            GetAccountByAccountNumber(accountNumber).AddEvent(summa, Convert.ToDateTime(dateTime));
        }

        public void CreateNewTransactionByAccount(string accountNumber, double summa)
        {
            GetAccountByAccountNumber(accountNumber).AddEvent(summa, DateTime.Now);
        }

        public string GetSaldoByName(string firstname, string lastname)
        {
            return Accounts[GetAccountByName(firstname, lastname)] + " saldo: " + GetAccountByName(firstname, lastname).PrintSaldo();
        }

        public string GetAllTransactionsByName(string firstname, string lastname)
        {
            return GetAccountByName(firstname, lastname).GetAllEvents();
        }

        public string GetAllTransactionsByAccountNumber(string accountNumber)
        {
            return GetAccountByAccountNumber(accountNumber).GetAllEvents();
        }
        public string GetTransactionsByNameDateTime(string firstname, string lastname, string lowDate, string highDate)
        {
            return GetAccountByName(firstname, lastname).GetEventsByDate(lowDate, highDate);
        }
        public string GetTransactionsByAccountDateTime(string accountNumber, string lowDate, string highDate)
        {
            return GetAccountByAccountNumber(accountNumber).GetEventsByDate(lowDate, highDate);
        }

    }
}
