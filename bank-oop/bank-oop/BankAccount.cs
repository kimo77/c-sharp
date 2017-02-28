using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    public class BankAccount
    {
        public string AccountNumber;
        private readonly List<AccountEvent> _events = new List<AccountEvent>();
        private double _saldo = 0;

        public BankAccount(string accountNumumber)
        {
            AccountNumber = accountNumumber;
        }

        public string GetAllEvents()
        {
            string events = "Account all transactions: \n";
            if (_events != null)
                foreach (var accEvent in _events)
                {
                    events = events + accEvent + "\n";
                }
            return events;

        }

        public string GetEventsByDate(string lowDate, string highDate)
        {

            var datEvents = (_events.Where(
                dEvent =>
                    dEvent.EventDate.CompareTo(Convert.ToDateTime(lowDate)) > 0 &&
                    dEvent.EventDate.CompareTo(Convert.ToDateTime(highDate)) < 0)).OrderBy(dEvent => dEvent.EventDate);
            string events = $"Account transactions from {lowDate} to {highDate}: \n";
            if (_events != null)
                foreach (var accEvent in datEvents)
                {
                    events = events + accEvent + "\n";
                }
            return events;

        }

        public string PrintSaldo()
        {
            return _saldo.ToString();
        }

        public void AddEvent(double summa, DateTime dateTime)
        {
            AccountEvent accEvent = new AccountEvent(dateTime, summa);
            _events.Add(accEvent);
            CalculateSaldo(summa);
        }

        private void CalculateSaldo(double summa)
        {
            _saldo = _saldo + summa;
        }
    }
}
