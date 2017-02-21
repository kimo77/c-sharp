using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar_code
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string barcode = "";
            string versio = "";
            string varalla = "";
            string iban = " FI79 4405 2020 0360 82";
            string eur = "";
            string sents = "";
            string summ = " 4 883,15";
            string viite = " 86851 62596 19897";
            string pvm = " 12.6.2010";

            //VERSIO

            if ((((iban.ToUpper()).Replace(" ", "")).Substring(0, 2)) == "FI" && (((viite.ToUpper()).Replace(" ", "")).Substring(0, 2)) == "RF")
            {
                versio = "5";
            }
            else versio = "4";
            
            //PVM

            pvm = pvm.Replace(" ", "");
            string[] pvm_arr = pvm.Split(new char[] { '.' });
            if (pvm_arr[0].Length < 2) pvm_arr[0] = pvm_arr[0].Insert(0, "0");
            if (pvm_arr[1].Length < 2) pvm_arr[1] = pvm_arr[1].Insert(0, "0");
            if (pvm_arr[2].Length > 2) pvm_arr[2] = pvm_arr[2].Substring(2);
            pvm = pvm_arr[2] + pvm_arr[1] + pvm_arr[0];

            //VIITE

            viite = (viite.Substring(2)).Replace(" ", "");
            if (versio == "5")
            {
                while (viite.Length < 23)
                {
                    viite = viite.Insert(2, "0");
                }
            }

            //VARALLA

            if (versio == "4")
            {
                while ((viite.Length + varalla.Length - 1) < 23)
                {
                    varalla = varalla.Insert(0, "0");
                }
            }


            //SUMMA

            summ = summ.Replace(" ", "");
            summ = summ.Replace(",", ".");
            string[] summ_arr = summ.Split(new char[] { '.' });
            eur = summ_arr[0];
            if (summ_arr.Length < 2) sents = "00";
            else sents = summ_arr[1];
            if (sents.Length < 2) sents.Insert(0, "0");
            summ = eur + sents;
            while(summ.Length < 8)
            {
                summ = summ.Insert(0, "0");
            }

            //IBAN

            iban = (iban.Replace(" ", "")).Substring(2);

            //BARCODE

            barcode = versio + iban + summ + varalla + viite + pvm;
            barcode = barcode.Replace(" ", "");






            Console.WriteLine(barcode);
            //Console.WriteLine(barcode.Length);
            Console.ReadKey();


        }
    }
}
