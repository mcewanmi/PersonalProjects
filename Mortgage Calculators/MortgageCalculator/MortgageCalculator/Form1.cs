/* Financial Calculator
 * 6/10/18
 * By Michael
 *
 *
 * With this program you can utilize four different financial calculators, each one providing a result you can copy and paste 
 * for greater ease of use. The calculators are as follows: Fixed Monthly Payment, Remaining Loan Balance of Fixed Loan,
 * Future Value of Single Sum, and Future Value of Recurring Payments.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//equations obtained from:  https://www.mtgprofessor.com/formulas.htm
//							https://qrc.depaul.edu/StudyGuide2009/Notes/Savings%20Accounts/Compound%20Interest.htm
//							https://www.calculatorsoup.com/calculators/financial/simple-interest-plus-principal-calculator.php

namespace MortgageCalculator
{
    public partial class MortgageCalculator : Form
    {
        public MortgageCalculator()
        {
            InitializeComponent();
            //set default Financial Calculator to Option 1 (0th)
            comboBoxFinancialSelection.SelectedIndex = 0;
          
        }

        private void comboBoxFinancialSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

			//Whatever option is selected, set its respective GroupBox visible and the rest invisible
            switch (comboBoxFinancialSelection.SelectedIndex)
            {
                case 0:
                    fixedMonthlyPayment.Visible = true;
                    remainingLoanBalanceFixedLoan.Visible = false;
                    futureValueSingleSum.Visible = false;
                    futureValueRecurringPayments.Visible = false;
                    break;
                case 1:
                    remainingLoanBalanceFixedLoan.Visible = true;
                    fixedMonthlyPayment.Visible = false;
                    futureValueSingleSum.Visible = false;
                    futureValueRecurringPayments.Visible = false;
                    break;
                case 2:
                    futureValueSingleSum.Visible = true;
                    remainingLoanBalanceFixedLoan.Visible = false;
                    fixedMonthlyPayment.Visible = false;
                    futureValueRecurringPayments.Visible = false;

					//When the User selects the calculator for the future value from a single sum,
					//set the default option of that calculator's ComboBox to the 4th apparent option.
                    comboBoxCompFreq.SelectedIndex = 3;

                    break;
                case 3:
                    futureValueRecurringPayments.Visible = true;
                    futureValueSingleSum.Visible = false;
                    remainingLoanBalanceFixedLoan.Visible = false;
                    fixedMonthlyPayment.Visible = false;
                    break;
               default:
                    fixedMonthlyPayment.Visible = true;
                    remainingLoanBalanceFixedLoan.Visible = false;
                    futureValueSingleSum.Visible = false;
                    futureValueRecurringPayments.Visible = false;
                    break;
            }

        }

		//Determine the Future Value of a Single Investment Made Today
        private void btnFutureValueSingle_Click(object sender, EventArgs e)
        {
            double sum = 0D, interest = 0D, compoundFreq=12;
            int months =0;

			//Select the frequency of interest accumulation over the span of 1 year
            switch(comboBoxCompFreq.SelectedIndex){
                case 0:
                    compoundFreq = 1;
                    break;
                case 1:
                    compoundFreq = 2;
                    break;
                case 2:
                    compoundFreq = 4;
                    break;
                case 3:
                    compoundFreq = 12;
                    break;
                default:
                    compoundFreq = 12;
                    break;
            }

			//Accept only numeric values
            try
            {
                sum = double.Parse(textSum.Text);

				//Interest is the only variable between all of the calculators where non-numeric input is allowed within reason
                interest = double.Parse(textInterestRate.Text.Replace("%", "")) / 100D;

                months = int.Parse(textPeriodLength.Text);

            }
            catch (Exception ex)
            {//If something goes wrong, provide a reasonable solution as well as the exact issue
                MessageBox.Show("Please enter proper decimal or integer values.\n\n" + ex);
            }

          
			//variables are renamed here to more easily follow the equations provided by the above websites
            double S = sum, C = interest;
            double T = months/12D;
            double N = compoundFreq;


			//ensure the user is attempting to find interest accumulated over valid length of time
            double FVn = sum;

            if (1/N <= T)
                FVn = S * Math.Pow(1 + C / N, N * T);
            else
                MessageBox.Show("Your initial value has not earned interest yet in this period of time.");

			//Output to TextBox to allow user to copy/paste
            textFutureValue.Text = FVn.ToString("0.00"); //"0.00" allows for clean monetary formatting

        }

		//Determine How Much You Need to Pay Per Month To Pay Off A Fixed Interest Loan
		private void btnFixedMonthlyPay_Click(object sender, EventArgs e)
        {
            double loan=0, interest=0.0D;
            int months=0;

			//Attempt to accept inputs
			try
            {
                loan = double.Parse(TextLoan.Text);
                months = int.Parse(TextMonths.Text);
                interest = double.Parse(TextMonthlyInterestRate.Text.Replace("%", "")) / 1200.0D;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter proper decimal or integer values.\n\n" + ex);
            }
            
			//Rename variables to match the formula on the respective website for easier transcription
            double L = loan, C = interest;
            int N = months;

			//Formula
            double pay = L *(C*Math.Pow(1D+C, N))/(Math.Pow(1D+C, N)-1D);

			//Output
            textFixedPay.Text = pay.ToString("0.00");
        }

		//Determine The Remaining Balance Of A Loan With A Fixed Interest Rate
        private void btnRemainingBalance_Click(object sender, EventArgs e)
        {
            double loan = 0.0D, interest = 0.0D;
            int monthsTotal = 0, monthsPast=0;

			//Attempt to accept inputs
            try
            {
                loan = double.Parse(TextLoan2.Text);
                monthsTotal = int.Parse(TextMonthsTotal.Text);
                monthsPast = int.Parse(TextMonthsPast.Text);
                interest = double.Parse(TextInterest.Text.Replace("%", "")) / 1200.0D;
             }  
            catch (Exception ex)
            {
                MessageBox.Show("Please enter proper decimal or integer values.\n\n" + ex);
            }

			//Match website variable names
            double L = loan, C = interest;
            int N = monthsTotal, MP = monthsPast;

			//Website formula
            double remainder =(double)L*(Math.Pow(1D+(double)C, N)-Math.Pow(1.0D+(double)C, MP))/(Math.Pow(1D+(double)C, N)-1d);

			//Output
			textRemainingLoan.Text = remainder.ToString("0.00");

        }

		//Determine The Total Future Value Of A Series Of Payments Of Equal Size Accumulating Interest
        private void buttonCalculateRe_Click(object sender, EventArgs e)
        {
            double payments=0D, rate=0D; int months=0;

			//Attempt to accept inputs
            try
            {
                payments = double.Parse(textPaymentsRe.Text);
                months = int.Parse(textMonthsRe.Text);
                rate = double.Parse(textInterestRe.Text.Replace("%", "")) / 1200.0D;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter proper decimal or integer values.\n\n" + ex);
            }

			//Match website variable names
            double P = payments, C = rate;
            int N = months;

			//Website formula
            double FVn = P * (Math.Pow(1D + C, N) - 1) / C;

			//Output
            textFutureValueRec.Text = FVn.ToString("0.00");

        }

       
    }
}
