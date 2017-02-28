using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    public class BankAccount
    {
        private string _accountNumber;
        private List<AccountEvent> _events = new List<AccountEvent>();
        private double _saldo = 0;

        public BankAccount(string accountNumumber)
        {
            _accountNumber = accountNumumber;
        }

        public void PrintAllEvents()
        {
            if (_events != null)
                foreach (var accEvent in _events)
                {
                    Console.WriteLine(accEvent.Print());
                }
        }

        public string PrintSaldo()
        {
            return _saldo.ToString();
        }

        public void AddEvent(double summa)
        {
            AccountEvent accEvent = new AccountEvent(DateTime.Now, summa);
            _events.Add(accEvent);
            CalculateSaldo(summa);
        }

        private void CalculateSaldo(double summa)
        {
            _saldo = _saldo + summa;
        }
    }
}
