using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace international_reference_number
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string getNum = insertTextBox.Text;
            getNum = getNum.Replace(" ", "");
            string finRefNum;
            bool isNum = true;
            foreach (char ch in getNum)
            {
                if (!Char.IsDigit(ch)) isNum = false;
            }
            if (isNum && getNum.Length > 4 && getNum.Length < 20)
            ///////////////////////********************* Create Finnish reference number
            {
                if (newRbtn.Checked)
                {
                    int iterNun = 0;
                    int checkNumTemp = 0;
                    char ch;
                    for (int i = getNum.Length; i > 0; i--)
                    {
                        ch = getNum[i - 1];
                        if (iterNun == 0)
                        {
                            checkNumTemp = checkNumTemp + (Convert.ToInt32(ch.ToString())) * 7;
                        }
                        else if (iterNun == 1)
                        {
                            checkNumTemp = checkNumTemp + (Convert.ToInt32(ch.ToString())) * 3;
                        }
                        else if (iterNun == 2)
                        {
                            checkNumTemp = checkNumTemp + (Convert.ToInt32(ch.ToString())) * 1;
                        }
                        iterNun++;
                        if (iterNun == 3) iterNun = 0;
                    }

                    int checkNum = 0;
                    while (checkNumTemp % 10 != 0)
                    {
                        checkNumTemp++;
                        checkNum++;
                    }


                    finRefNum = getNum + checkNum.ToString();
                }

                else finRefNum = getNum;

                ///////////////////////********************* Create international reference number

                string interRefNumTemp = finRefNum + "271500";
                decimal refNumDes = decimal.Parse(interRefNumTemp);
                decimal interChekNum = 98 - (refNumDes % 97);
                string checkNumStr = interChekNum.ToString();
                if (checkNumStr.Length < 2) checkNumStr = "0" + checkNumStr;

                string interRefNum = "RF" + checkNumStr + finRefNum;
                //resultTextBox.ForeColor = Color.Black;
                resultTextBox.Text = interRefNum;




            }
            else
            {
                //resultTextBox.ForeColor = Color.Red;
                resultTextBox.Text = "Entered an invalid number!";
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string getNum = insertTextBox.Text;
            getNum = (getNum.Replace(" ", "")).ToUpper();
            string lettering = getNum.Substring(0, 2);
            string number = getNum.Substring(2, getNum.Length - 2);
            bool isNum = true;
            foreach (char ch in number)
            {
                if (!Char.IsDigit(ch)) isNum = false;
            }
            if (isNum && lettering == "RF")
            {
                number = number.Substring(2, number.Length - 2) + "2715" + number.Substring(0, 2);
                decimal numberDec = Decimal.Parse(number);
                if (numberDec % 97 == 1)
                {
                    resultTextBox.Text = "International reference number is OK";
                }
                else
                {
                    resultTextBox.Text = "Entered an invalid number!";
                }
            }
            else
            {
                resultTextBox.Text = "Entered an invalid number!";
            }


        }
    }
}
