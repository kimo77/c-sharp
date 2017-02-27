using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ski_jumping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            int kPoint = Convert.ToInt32(KPointNud.Value);
            int jumpLen = Convert.ToInt32(JumpLengthNud.Value);
            float pointsPerMeter = 0;

            float resultFloat;

            if (kPoint < 20) pointsPerMeter = 0;
            else if (kPoint >= 20 && kPoint <= 24) pointsPerMeter = 4.8f;
            else if (kPoint >= 25 && kPoint <= 29) pointsPerMeter = 4.4f;
            else if (kPoint >= 30 && kPoint <= 34) pointsPerMeter = 4f;
            else if (kPoint >= 35 && kPoint <= 39) pointsPerMeter = 3.6f;
            else if (kPoint >= 40 && kPoint <= 49) pointsPerMeter = 3.2f;
            else if (kPoint >= 50 && kPoint <= 59) pointsPerMeter = 2.8f;
            else if (kPoint >= 60 && kPoint <= 69) pointsPerMeter = 2.4f;
            else if (kPoint >= 70 && kPoint <= 79) pointsPerMeter = 2.2f;
            else if (kPoint >= 80 && kPoint <= 99) pointsPerMeter = 2f;
            else if (kPoint >= 100 && kPoint <= 169) pointsPerMeter = 1.8f;
            else if (kPoint >= 170) pointsPerMeter = 1.2f;

            resultFloat = (jumpLen - kPoint) * pointsPerMeter + 60;

            resultTextBox.Text = resultFloat.ToString();
        }
    }
}
