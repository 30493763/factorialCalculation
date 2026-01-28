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
// last update date: 28-jan-2026
// last update time: 10:43 AM
// description: This program calculates the factorial of a given number using two different algorithms and compares their performance.
// Algorithem 2 reference: https://scicomp.stackexchange.com/questions/42510/what-are-the-benefits-of-cutting-by-half-the-number-of-multiplications-needed-to
// github repo:https://github.com/30493763/factorialCalculation.git

namespace factorialCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //***********************************************************************************************************************************
        //         CLICK EVENTS FOR BUTTONS AND OTHER CONTROLS
        //***********************************************************************************************************************************


        // click to clear input and output for another calculation
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


        // using 2 algorithms to calculate factorial and compare performance
        // here async await is used to prevent UI blocking during calculation
        private async void btnCheck_Click(object sender, EventArgs e) 
        {
            // input number validation, using method inputNumberValidation()
            // Must be a positive integer or 0, and less than 50000 because of the hardware limitation
            if ( !inputNumberValidation(txtInput.Text) ) 
                return;

            int n = int.Parse(txtInput.Text); // get input number after validation

            // Disable UI to prevent re-entrancy and show waiting cursor
            btnCheck.Enabled = false;
            txtInput.Enabled = false;
            var previousCursor = Cursor;
            Cursor = Cursors.WaitCursor;

            try
            {
                //Count time taken to execute the Algorithm 1
                var (result1, count1, timeTaken1) = await Factorial_Algo1Async1(n);

                //1. display factorial result
                lblResultNumeric1.Text = FormatNumber(result1);
                //2. display number of iterations
                lblIterationsResultAlgo1.Text = count1.ToString();
                //3. display time taken
                lblRunTimeResultAlgo1.Text = timeTaken1;



                var (result2, count2, timeTaken2) = await Factorial_Algo1Async2(n);

                //1. display factorial result
                lblResultNumeric2.Text = FormatNumber(result2);
                //2. display number of iterations
                lblIterationsResultAlgo2.Text = count2.ToString();
                //3. display time taken
                lblRunTimeResultAlgo2.Text = timeTaken2;

            }
            catch (Exception)
            {
                 MessageBox.Show("An error occurred during the calculation. Please try again.");
                 throw;
            }
            finally
            {
                // Re-enable UI and restore cursor
                btnCheck.Enabled = true;
                txtInput.Enabled = true;
                Cursor = previousCursor;
            }
        }

        //***********************************************************************************************************************************
        //         METHODS FOR FACTORIAL CALCULATION AND INPUT VALIDATION
        //***********************************************************************************************************************************

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

        // Async wrapper for Algorithm 1
        private Task<(BigInteger, int, string)> Factorial_Algo1Async1(int n)
        {
            return Task.Run(() => Factorial_Algo1(n));
        }

        // Async wrapper for Algorithm 2
        private Task<(BigInteger, int, string)> Factorial_Algo1Async2(int n)
        {
            return Task.Run(() => Factorial_Algo2(n));
        }

        // Algorithm 1: Standard iterative approach to calculate factorial
        private (BigInteger, int, string) Factorial_Algo1(int n)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // Start timing

            BigInteger result = new BigInteger(0); // 
            int count = 0;

            if (n < 0)
                throw new ArgumentException("Negative numbers do not have a factorial.");
            if (n == 0 || n == 1)
            {
                result = 1;
                count = 1;
            }

            result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
                count++;
            }

            stopwatch.Stop();  // stop time
            string timeTaken = stopwatch.ElapsedMilliseconds.ToString() + " ms";

            return (result, count, timeTaken);

        }

        // Algorithm 2: Optimized approach that reduces the number of multiplications by pairing factors
        //Algorithem 2 reference: https://scicomp.stackexchange.com/questions/42510/what-are-the-benefits-of-cutting-by-half-the-number-of-multiplications-needed-to
        private (BigInteger, int, string) Factorial_Algo2(int n)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // Start timing

            BigInteger result = new BigInteger(0);
            int count = 0;
            int factorial = 0;

            // if the input Number 'n' is odd, we can use algorithem for n+1 which is even, then divide the final result by n
            bool isEven = n % 2 == 0;  

            if (n < 0)
                throw new ArgumentException("Negative numbers do not have a factorial.");
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

            stopwatch.Stop();  // stop time
            string timeTaken = stopwatch.ElapsedMilliseconds.ToString() + " ms";

            return (result, count, timeTaken);
        }

        private string FormatNumber(BigInteger number)
        {
            const int MAX = 100000000; // the maximum number to show full digits without scientific notation for the labels on the Form

            if (number < MAX)
                return number.ToString("#,##0"); // e.g. "123,456,789"
            else
                return  number.ToString("E2"); // e.g. "1.23E+003"
        }
    }
}
