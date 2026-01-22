using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// aurthor: ching ho, Li
// student id: 30493763
// last update date: 12-jan-2026
// last update time: 10:37 PM
// description: This program calculates the factorial of a given number using two different algorithms and compares their performance.
// algo 2 reference: https://scicomp.stackexchange.com/questions/42510/what-are-the-benefits-of-cutting-by-half-the-number-of-multiplications-needed-to
// github repo:https://github.com/30493763/factorialCalculation.git

namespace factorialCalculation
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblResultNumeric1.Text = "";
            lblResultNumeric2.Text = "";
            lblIterationsResultAlgo1.Text = "";
            lblIterationsResultAlgo2.Text = "";
            lblRunTimeResultAlgo1.Text = "";
            lblRunTimeResultAlgo2.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string inputNumber = txtInput.Text;

            if ( !inputNumberValidation(inputNumber) )
                return;


            //Count time taken to execute the algo 1
            Stopwatch stopwatch = new Stopwatch();

            // Start timing
            stopwatch.Start();            
            var (result1, count1) = Factorial_Algo1(int.Parse(txtInput.Text));
            // stop time
            stopwatch.Stop();

            lblResultNumeric1.Text = FormatNumber(result1);
            lblIterationsResultAlgo1.Text = count1.ToString();
            lblRunTimeResultAlgo1.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";

            stopwatch.Reset();

            // Start timing
            stopwatch.Start();             
            var (result2, count2) = Factorial_Algo2(int.Parse(txtInput.Text));
            // stop time
            stopwatch.Stop();   

            lblResultNumeric2.Text = FormatNumber(result2);
            lblIterationsResultAlgo2.Text = count2.ToString();
            lblRunTimeResultAlgo2.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
        }

        private bool inputNumberValidation(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a number.");
                return false;
            }
            if (!int.TryParse(input, out int n))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
                return false;
            }
            if (n < 0)
            {
                MessageBox.Show("Negative numbers do not have a factorial. Please enter a non-negative integer.");
                return false;
            }
            if (n > 50000)
            {
                MessageBox.Show("Input too large. Please enter a number less than or equal to 10,000.");
                return false;
            }
            return true;
        }

        private (BigInteger, int) Factorial_Algo1(int n)
        {
            BigInteger c = new BigInteger(0);
            int count = 0;
            if (n < 0)
            {
                throw new ArgumentException("Negative numbers do not have a factorial.");
            }
            if (n == 0 || n == 1)
            {
                //return 1;
                c = 1;
                count = 1;
            }
            c = 1;
            for (int i = 2; i <= n; i++)
            {
                c *= i;
                count++;
            }
            return (c, count);
        }

        private (BigInteger, int) Factorial_Algo2(int n)
        {
            BigInteger result = new BigInteger(0);
            int count = 0;
            int factorial = 0;
            bool isEven = n % 2 == 0;

            if (n < 0)
            {
                throw new ArgumentException("Negative numbers do not have a factorial.");
            }
            if (n == 0 || n == 1)
            {
                result = 1;
                count = 1;
            }
            else
            {
                if (isEven)
                    factorial = n;
                else
                    factorial = n + 1;
                
                BigInteger temp2 = new BigInteger(0);
                result = factorial;
                temp2 = factorial;
                for (int i = factorial; i >2; i -= 2)
                {
                    temp2 += i-2;
                    result *= temp2;
                    count++;
                }

                if (!isEven)
                {
                    result = result/factorial;
                    count++;
                }
            }
            return (result, count);
        }

        private string FormatNumber(BigInteger number)
        {
            BigInteger MAX = new BigInteger(0);

            MAX = 100000000;

            if (number < MAX)
            {
                MessageBox.Show($"fuck 1 {number.ToString()}");
                return number.ToString("#,##0");
            }
            else
            {
                //MessageBox.Show($"fuck 2 {number.ToString()}");
                //return string.Format("{0:0.###E+0}", number);

                string formatted = number.ToString("E2"); // "1.23E+003"
                return formatted;
            }
        }

        private void lblResultNumeric1_Click(object sender, EventArgs e)
        {

        }
    }
}
