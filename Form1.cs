using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class Form1 : Form
    {

        private void primeCheck(int 1num, int 2num)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaring my variables
            int num1, num2, sum, ctr, i;
            int x = 0;
            num1 = Int32.Parse(tb_num1.Text);
            num2 = Int32.Parse(tb_num2.Text);
            //sum = num1 + num2;

            for (sum = num1; sum <= num2; sum++)
            {
                ctr = 0;

                for (i = 2; i <= sum / 2; i++)
                {
                    if (sum % i == 0) // Checking/Counting remainders
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && sum != 1)
                {
                    //Console.Write("{0} ", sum);

                    // Converting int to String
                    tb_sum.Text += sum.ToString() + " ";
                    x++;
                }

                // Starting a new line after every 5 numbers
                if (x == 5)
                {
                    tb_sum.Text += " \r\n";
                    x = 0;
                }
            }

            //lbl_sum.Text = sum.ToString();
        }
    }
}
