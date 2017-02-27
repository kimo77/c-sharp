using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iban_lask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            string ibanTemp = accountTextBox.Text.Replace(" ", "");
            ibanTemp = ibanTemp.Replace("-", "");

            bool isNum = true;
            foreach(char ch in ibanTemp)
            {
                if (!char.IsDigit(ch)) isNum = false;
            }


            if (isNum)
            {
                string ibanTemp1 = ibanTemp.Substring(0, 6);
                string ibanTemp2 = ibanTemp.Substring(6, ibanTemp.Length - ibanTemp1.Length);

                while (ibanTemp.Length < 14)
                {
                    ibanTemp1 = ibanTemp1 + "0";
                    ibanTemp = ibanTemp1 + ibanTemp2;
                }
                decimal ibanCheckNum = Decimal.Parse(ibanTemp + "151800");
                while (ibanCheckNum % 97 != 1) ibanCheckNum++;
                string checkNum = (ibanCheckNum.ToString()).Substring(18);
                ResultLbl.Text = "IBAN: " + "FI" + checkNum + ibanTemp;
                attnLbl.Text = "";
            }
            else
            {
                attnLbl.Text = "Account number contains invalid characters";
                ResultLbl.Text = "IBAN: ";
            }
        }
    }
}
