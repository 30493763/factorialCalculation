using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Count time taken to execute the algo 1
            Stopwatch stopwatch = new Stopwatch();

            // Start timing
            stopwatch.Start();            
            var (result1, count1) = Factorial_Algo1(int.Parse(txtInput.Text));
            // stop time
            stopwatch.Stop();   

            lblResultNumeric1.Text = result1.ToString();
            txtIterationsResultAlgo1.Text = count1.ToString();
            txtRunTimeResultAlgo1.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";

            stopwatch.Reset();

            // Start timing
            stopwatch.Start();             
            var (result2, count2) = Factorial_Algo2(int.Parse(txtInput.Text));
            // stop time
            stopwatch.Stop();   

            lblResultNumeric2.Text = result2.ToString();
            txtIterationsResultAlgo2.Text = count2.ToString();
            txtRunTimeResultAlgo2.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
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
    }
}
