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

        private void primeCheck(int num1, int num2)
        {
            // Clearing previous text
            tb_sum.Text = String.Empty;

            // Declaring my variables
            int sum, ctr, i;
            int x = 0;

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
                    // Converting int to String
                    tb_sum.Text += sum.ToString() + "   ";
                    x++;
                }

                // Starting a new line after every 5 numbers
                if (x == 5)
                {
                    tb_sum.Text += " \r\n";
                    x = 0;
                }
            }

            return;
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
            int number1 = Int32.Parse(tb_num1.Text);
            int number2 = Int32.Parse(tb_num2.Text);

            primeCheck(number1, number2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
