using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_oop
{
    class Test
    {
        public static void RunTest()
        {
            Bank bank = new Bank("Nordea");
            bank.CreateNewAccount("Vitali", "Nikolaev");
            bank.CreateNewTransactionByName("Vitali", "Nikolaev", +1900, "12.01.2016");
            bank.CreateNewTransactionByName("Vitali", "Nikolaev", -350, "17.06.2016");
            bank.CreateNewTransactionByName("Vitali", "Nikolaev", -250, "22.01.2017");
            bank.CreateNewTransactionByName("Vitali", "Nikolaev", -300, "12.02.2017");
            bank.CreateNewTransactionByName("Vitali", "Nikolaev", +22000);

            bank.CreateNewAccount("Jussi", "Heikelä");
            bank.CreateNewTransactionByName("Jussi", "Heikelä", +8700, "14.04.2016");
            bank.CreateNewTransactionByName("Jussi", "Heikelä", -700, "01.10.2016");
            bank.CreateNewTransactionByName("Jussi", "Heikelä", -300, "13.02.2017");
            bank.CreateNewTransactionByName("Jussi", "Heikelä", -1550, "24.02.2017");
            bank.CreateNewTransactionByName("Jussi", "Heikelä", -1900);

            bank.CreateNewAccount("Juha", "Itkonen");
            bank.CreateNewTransactionByName("Juha", "Itkonen", +19340, "08.06.2016");
            bank.CreateNewTransactionByName("Juha", "Itkonen", -5000, "17.01.2016");
            bank.CreateNewTransactionByName("Juha", "Itkonen", -2450, "27.01.2017");
            bank.CreateNewTransactionByName("Juha", "Itkonen", -840, "06.02.2017");


            Console.WriteLine(bank.GetSaldoByName("Vitali", "Nikolaev") + "\n");
            Console.WriteLine(bank.GetAllTransactionsByName("Vitali", "Nikolaev"));
            Console.WriteLine(bank.GetTransactionsByNameDateTime("Vitali", "Nikolaev", "16.01.2016", "28.01.2017"));
            Console.WriteLine(bank.GetSaldoByName("Jussi", "Heikelä") + "\n");
            Console.WriteLine(bank.GetAllTransactionsByName("Jussi", "Heikelä"));
            Console.WriteLine(bank.GetTransactionsByNameDateTime("Jussi", "Heikelä", "13.04.2016", "23.02.2017"));
            Console.WriteLine(bank.GetSaldoByName("Juha", "Itkonen") + "\n");
            Console.WriteLine(bank.GetAllTransactionsByName("Juha", "Itkonen"));
            Console.WriteLine(bank.GetTransactionsByNameDateTime("Juha", "Itkonen", "07.06.2016", "05.02.2017"));
        }
    }
}
