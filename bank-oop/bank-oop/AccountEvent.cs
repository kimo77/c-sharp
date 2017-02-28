using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    public class AccountEvent
    {
        public DateTime EventDate { get; }
        private readonly double _summa;

        public AccountEvent(DateTime eventDate, double summa)
        {
            EventDate = eventDate;
            _summa = summa;
       
        }

        public override string ToString()
        {
            return EventDate + "  " +_summa;
        }
    }
}
