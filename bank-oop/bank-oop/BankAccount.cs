using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    public class BankAccount
    {
        private string _accNum;
        private List<AccountEvent> _events = new List<AccountEvent>();
        private double _saldo = 0;

        public BankAccount(string accNum)
        {
            _accNum = accNum;
        }

        public void PrintAllEvents()
        {
            if (_events != null)
                foreach (var accEvent in _events)
                {
                    Console.WriteLine(accEvent.Print());
                }
        } 

        public void PrintSaldo() => Console.WriteLine(_saldo.ToString());

        public void AddEvent(DateTime datetime, double summa)
        {
            AccountEvent accEvent = new AccountEvent(datetime, summa);
            _events.Add(accEvent);
            CalculateSaldo(summa);
        }

        private void CalculateSaldo(double summa)
        {
            _saldo = _saldo + summa;
        }
    }
}
