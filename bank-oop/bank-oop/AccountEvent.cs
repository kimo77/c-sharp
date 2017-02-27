using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    public class AccountEvent
    {
        private DateTime _eventDate;
        private readonly double _summa;

        public AccountEvent(DateTime eventDate, double summa)
        {
            _eventDate = eventDate;
            _summa = summa;
        }

        public string Print() => _eventDate.ToString() + " - " + _summa.ToString();
    }
}
