// Jethro De Burca 21519033

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimeNumber
{
    public partial class Form1 : Form
    {
        // Determining if a numberis prime
        private Boolean IsPrime(int n)
        {
            bool primeFlag = true;

            // Calculating the square root of n
            double sRoot = Math.Sqrt(n);

            for (int i = 2; i <= sRoot; i++)
            {
                // If there are any factors of n, then it's not a prime number
                if ((n % i) == 0)
                {
                    primeFlag = false;
                    break;
                }
            }
            return (primeFlag);
        }

        private void PrimeCheck(int num1, int num2)
        {
            // Clearing previous text
            tb_sum.Text = String.Empty;

            // Creating an empty string to store the prime numbers
            String str = "";

            // Declaring my variables
            int i;
            int lineCount = 0;

            // Swapping values if second num2 is larger than num1
            if (num1 > num2) {
                (num2, num1) = (num1, num2);
            }

            for (i = num1; i <= num2; i++)
            {
                // Checking if the number is a prime number
                Boolean prime = IsPrime(i);

                if (i != 1 && prime == true)
                {
                    // Converting int to String
                    str += i.ToString() + "\t";
                    lineCount++;
                }

                // Starting a new line after every 5 numbers
                if (lineCount == 5)
                {
                    str += " \r\n";
                    lineCount = 0;
                }
            }
            // Displing all primes stored in str
            tb_sum.Text = str;
        }

        // Constructing the form
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Calling the PrimeCheck method on user inputs
            PrimeCheck(Int32.Parse(tb_num1.Text), Int32.Parse(tb_num2.Text));
        }

        // Not sure how to remove these
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
