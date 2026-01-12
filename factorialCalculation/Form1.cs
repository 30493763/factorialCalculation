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
            lblResultNumeric.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();

            // Start timing
            stopwatch.Start();
            var (result, count) = Factorial_Algo1(int.Parse(txtInput.Text));

            // Stop timing
            stopwatch.Stop();

            // Get the elapsed time
            //Console.WriteLine($"Processing time: {stopwatch.ElapsedMilliseconds} ms");
            lblResultNumeric.Text = result.ToString();
            txtIterationsResultAlgo1.Text = count.ToString();
            txtRunTimeResultAlgo1.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
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

        private void txtIterationsResultAlgo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
