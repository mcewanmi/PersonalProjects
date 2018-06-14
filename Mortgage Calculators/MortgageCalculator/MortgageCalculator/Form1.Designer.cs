namespace MortgageCalculator
{
    partial class MortgageCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFinancialSelection = new System.Windows.Forms.ComboBox();
            this.fixedMonthlyPayment = new System.Windows.Forms.GroupBox();
            this.btnFixedMonthlyPay = new System.Windows.Forms.Button();
            this.textFixedPay = new System.Windows.Forms.TextBox();
            this.TextMonthlyInterestRate = new System.Windows.Forms.TextBox();
            this.labelInterest = new System.Windows.Forms.Label();
            this.TextMonths = new System.Windows.Forms.TextBox();
            this.Months = new System.Windows.Forms.Label();
            this.TextLoan = new System.Windows.Forms.TextBox();
            this.Loan = new System.Windows.Forms.Label();
            this.remainingLoanBalanceFixedLoan = new System.Windows.Forms.GroupBox();
            this.TextLoan2 = new System.Windows.Forms.TextBox();
            this.TextMonthsTotal = new System.Windows.Forms.TextBox();
            this.TextMonthsPast = new System.Windows.Forms.TextBox();
            this.TextInterest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemainingBalance = new System.Windows.Forms.Button();
            this.textRemainingLoan = new System.Windows.Forms.TextBox();
            this.labelInterest2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.futureValueSingleSum = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCompFreq = new System.Windows.Forms.ComboBox();
            this.btnFutureValueSingle = new System.Windows.Forms.Button();
            this.textFutureValue = new System.Windows.Forms.TextBox();
            this.textPeriodLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textInterestRate = new System.Windows.Forms.TextBox();
            this.monthlyPayment = new System.Windows.Forms.Label();
            this.textSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.futureValueRecurringPayments = new System.Windows.Forms.GroupBox();
            this.buttonCalculateRe = new System.Windows.Forms.Button();
            this.textFutureValueRec = new System.Windows.Forms.TextBox();
            this.textInterestRe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMonthsRe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPaymentsRe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fixedMonthlyPayment.SuspendLayout();
            this.remainingLoanBalanceFixedLoan.SuspendLayout();
            this.futureValueSingleSum.SuspendLayout();
            this.futureValueRecurringPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFinancialSelection
            // 
            this.comboBoxFinancialSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFinancialSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFinancialSelection.FormattingEnabled = true;
            this.comboBoxFinancialSelection.Items.AddRange(new object[] {
            "Calculate Fixed Monthly Payment",
            "Calculate Remaining Loan Balance of Fixed Loan",
            "Calculate Future Value of Single Sum",
            "Calculate Future Value of Recurring Payments"});
            this.comboBoxFinancialSelection.Location = new System.Drawing.Point(15, 30);
            this.comboBoxFinancialSelection.Name = "comboBoxFinancialSelection";
            this.comboBoxFinancialSelection.Size = new System.Drawing.Size(325, 24);
            this.comboBoxFinancialSelection.TabIndex = 0;
            this.comboBoxFinancialSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxFinancialSelection_SelectedIndexChanged);
            // 
            // fixedMonthlyPayment
            // 
            this.fixedMonthlyPayment.Controls.Add(this.btnFixedMonthlyPay);
            this.fixedMonthlyPayment.Controls.Add(this.textFixedPay);
            this.fixedMonthlyPayment.Controls.Add(this.TextMonthlyInterestRate);
            this.fixedMonthlyPayment.Controls.Add(this.labelInterest);
            this.fixedMonthlyPayment.Controls.Add(this.TextMonths);
            this.fixedMonthlyPayment.Controls.Add(this.Months);
            this.fixedMonthlyPayment.Controls.Add(this.TextLoan);
            this.fixedMonthlyPayment.Controls.Add(this.Loan);
            this.fixedMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixedMonthlyPayment.Location = new System.Drawing.Point(350, 25);
            this.fixedMonthlyPayment.Name = "fixedMonthlyPayment";
            this.fixedMonthlyPayment.Size = new System.Drawing.Size(350, 251);
            this.fixedMonthlyPayment.TabIndex = 1;
            this.fixedMonthlyPayment.TabStop = false;
            this.fixedMonthlyPayment.Text = "Fixed Monthly Payment";
            // 
            // btnFixedMonthlyPay
            // 
            this.btnFixedMonthlyPay.Location = new System.Drawing.Point(10, 188);
            this.btnFixedMonthlyPay.Name = "btnFixedMonthlyPay";
            this.btnFixedMonthlyPay.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFixedMonthlyPay.Size = new System.Drawing.Size(150, 42);
            this.btnFixedMonthlyPay.TabIndex = 4;
            this.btnFixedMonthlyPay.Text = "Calculate Fixed Monthly Pay";
            this.btnFixedMonthlyPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixedMonthlyPay.UseVisualStyleBackColor = true;
            this.btnFixedMonthlyPay.Click += new System.EventHandler(this.btnFixedMonthlyPay_Click);
            // 
            // textFixedPay
            // 
            this.textFixedPay.Location = new System.Drawing.Point(188, 198);
            this.textFixedPay.Name = "textFixedPay";
            this.textFixedPay.Size = new System.Drawing.Size(100, 22);
            this.textFixedPay.TabIndex = 5;
            // 
            // TextMonthlyInterestRate
            // 
            this.TextMonthlyInterestRate.Location = new System.Drawing.Point(10, 140);
            this.TextMonthlyInterestRate.Name = "TextMonthlyInterestRate";
            this.TextMonthlyInterestRate.Size = new System.Drawing.Size(150, 22);
            this.TextMonthlyInterestRate.TabIndex = 3;
            // 
            // labelInterest
            // 
            this.labelInterest.AutoSize = true;
            this.labelInterest.Location = new System.Drawing.Point(185, 135);
            this.labelInterest.MaximumSize = new System.Drawing.Size(150, 100);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(96, 32);
            this.labelInterest.TabIndex = 4;
            this.labelInterest.Text = "Quoted Annual\r\nInterest Rate";
            this.labelInterest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextMonths
            // 
            this.TextMonths.Location = new System.Drawing.Point(10, 90);
            this.TextMonths.Name = "TextMonths";
            this.TextMonths.Size = new System.Drawing.Size(150, 22);
            this.TextMonths.TabIndex = 2;
            // 
            // Months
            // 
            this.Months.AutoSize = true;
            this.Months.Location = new System.Drawing.Point(185, 93);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(116, 16);
            this.Months.TabIndex = 2;
            this.Months.Text = "Number of Months";
            // 
            // TextLoan
            // 
            this.TextLoan.Location = new System.Drawing.Point(10, 40);
            this.TextLoan.Name = "TextLoan";
            this.TextLoan.Size = new System.Drawing.Size(150, 22);
            this.TextLoan.TabIndex = 1;
            // 
            // Loan
            // 
            this.Loan.AutoSize = true;
            this.Loan.Location = new System.Drawing.Point(185, 43);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(63, 16);
            this.Loan.TabIndex = 0;
            this.Loan.Text = "Loan ($$)";
            // 
            // remainingLoanBalanceFixedLoan
            // 
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.TextLoan2);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.TextMonthsTotal);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.TextMonthsPast);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.TextInterest);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.label1);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.btnRemainingBalance);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.textRemainingLoan);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.labelInterest2);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.label5);
            this.remainingLoanBalanceFixedLoan.Controls.Add(this.label6);
            this.remainingLoanBalanceFixedLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLoanBalanceFixedLoan.Location = new System.Drawing.Point(350, 25);
            this.remainingLoanBalanceFixedLoan.Name = "remainingLoanBalanceFixedLoan";
            this.remainingLoanBalanceFixedLoan.Size = new System.Drawing.Size(350, 300);
            this.remainingLoanBalanceFixedLoan.TabIndex = 2;
            this.remainingLoanBalanceFixedLoan.TabStop = false;
            this.remainingLoanBalanceFixedLoan.Text = "Remaining Loan Balance - Fixed Loan";
            // 
            // TextLoan2
            // 
            this.TextLoan2.Location = new System.Drawing.Point(10, 40);
            this.TextLoan2.Name = "TextLoan2";
            this.TextLoan2.Size = new System.Drawing.Size(150, 22);
            this.TextLoan2.TabIndex = 1;
            // 
            // TextMonthsTotal
            // 
            this.TextMonthsTotal.Location = new System.Drawing.Point(10, 90);
            this.TextMonthsTotal.Name = "TextMonthsTotal";
            this.TextMonthsTotal.Size = new System.Drawing.Size(150, 22);
            this.TextMonthsTotal.TabIndex = 2;
            // 
            // TextMonthsPast
            // 
            this.TextMonthsPast.Location = new System.Drawing.Point(10, 140);
            this.TextMonthsPast.Name = "TextMonthsPast";
            this.TextMonthsPast.Size = new System.Drawing.Size(150, 22);
            this.TextMonthsPast.TabIndex = 3;
            // 
            // TextInterest
            // 
            this.TextInterest.Location = new System.Drawing.Point(10, 190);
            this.TextInterest.Name = "TextInterest";
            this.TextInterest.Size = new System.Drawing.Size(150, 22);
            this.TextInterest.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Months Past";
            // 
            // btnRemainingBalance
            // 
            this.btnRemainingBalance.Location = new System.Drawing.Point(10, 236);
            this.btnRemainingBalance.Name = "btnRemainingBalance";
            this.btnRemainingBalance.Size = new System.Drawing.Size(150, 42);
            this.btnRemainingBalance.TabIndex = 6;
            this.btnRemainingBalance.Text = "Calculate Remaining Loan Balance";
            this.btnRemainingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemainingBalance.UseVisualStyleBackColor = true;
            this.btnRemainingBalance.Click += new System.EventHandler(this.btnRemainingBalance_Click);
            // 
            // textRemainingLoan
            // 
            this.textRemainingLoan.Location = new System.Drawing.Point(200, 246);
            this.textRemainingLoan.Name = "textRemainingLoan";
            this.textRemainingLoan.Size = new System.Drawing.Size(100, 22);
            this.textRemainingLoan.TabIndex = 6;
            // 
            // labelInterest2
            // 
            this.labelInterest2.Location = new System.Drawing.Point(185, 184);
            this.labelInterest2.Name = "labelInterest2";
            this.labelInterest2.Size = new System.Drawing.Size(115, 35);
            this.labelInterest2.TabIndex = 4;
            this.labelInterest2.Text = "Quoted Annual\r\nInterest Rate";
            this.labelInterest2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of Months Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loan ($$)";
            // 
            // futureValueSingleSum
            // 
            this.futureValueSingleSum.Controls.Add(this.label10);
            this.futureValueSingleSum.Controls.Add(this.comboBoxCompFreq);
            this.futureValueSingleSum.Controls.Add(this.btnFutureValueSingle);
            this.futureValueSingleSum.Controls.Add(this.textFutureValue);
            this.futureValueSingleSum.Controls.Add(this.textPeriodLength);
            this.futureValueSingleSum.Controls.Add(this.label2);
            this.futureValueSingleSum.Controls.Add(this.textSum);
            this.futureValueSingleSum.Controls.Add(this.label4);
            this.futureValueSingleSum.Controls.Add(this.textInterestRate);
            this.futureValueSingleSum.Controls.Add(this.monthlyPayment);
            this.futureValueSingleSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureValueSingleSum.Location = new System.Drawing.Point(350, 25);
            this.futureValueSingleSum.Name = "futureValueSingleSum";
            this.futureValueSingleSum.Size = new System.Drawing.Size(350, 300);
            this.futureValueSingleSum.TabIndex = 6;
            this.futureValueSingleSum.TabStop = false;
            this.futureValueSingleSum.Text = "Single Sum - Future Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Compound Frequency";
            // 
            // comboBoxCompFreq
            // 
            this.comboBoxCompFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompFreq.FormattingEnabled = true;
            this.comboBoxCompFreq.Items.AddRange(new object[] {
            "Annual",
            "Semiannual",
            "Quarterly",
            "Monthly"});
            this.comboBoxCompFreq.Location = new System.Drawing.Point(10, 190);
            this.comboBoxCompFreq.Name = "comboBoxCompFreq";
            this.comboBoxCompFreq.Size = new System.Drawing.Size(150, 24);
            this.comboBoxCompFreq.TabIndex = 4;
            // 
            // btnFutureValueSingle
            // 
            this.btnFutureValueSingle.Location = new System.Drawing.Point(10, 236);
            this.btnFutureValueSingle.Name = "btnFutureValueSingle";
            this.btnFutureValueSingle.Size = new System.Drawing.Size(150, 42);
            this.btnFutureValueSingle.TabIndex = 5;
            this.btnFutureValueSingle.Text = "Calculate Future Value";
            this.btnFutureValueSingle.UseVisualStyleBackColor = true;
            this.btnFutureValueSingle.Click += new System.EventHandler(this.btnFutureValueSingle_Click);
            // 
            // textFutureValue
            // 
            this.textFutureValue.Location = new System.Drawing.Point(188, 246);
            this.textFutureValue.Name = "textFutureValue";
            this.textFutureValue.Size = new System.Drawing.Size(100, 22);
            this.textFutureValue.TabIndex = 6;
            // 
            // textPeriodLength
            // 
            this.textPeriodLength.Location = new System.Drawing.Point(10, 90);
            this.textPeriodLength.Name = "textPeriodLength";
            this.textPeriodLength.Size = new System.Drawing.Size(150, 22);
            this.textPeriodLength.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 93);
            this.label2.MaximumSize = new System.Drawing.Size(150, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Months";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textInterestRate
            // 
            this.textInterestRate.Location = new System.Drawing.Point(10, 140);
            this.textInterestRate.Name = "textInterestRate";
            this.textInterestRate.Size = new System.Drawing.Size(150, 22);
            this.textInterestRate.TabIndex = 3;
            // 
            // monthlyPayment
            // 
            this.monthlyPayment.AutoSize = true;
            this.monthlyPayment.Location = new System.Drawing.Point(185, 133);
            this.monthlyPayment.Name = "monthlyPayment";
            this.monthlyPayment.Size = new System.Drawing.Size(96, 32);
            this.monthlyPayment.TabIndex = 2;
            this.monthlyPayment.Text = "Quoted Annual\r\nInterest Rate";
            this.monthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(10, 40);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(150, 22);
            this.textSum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Present Value ($$)";
            // 
            // futureValueRecurringPayments
            // 
            this.futureValueRecurringPayments.Controls.Add(this.buttonCalculateRe);
            this.futureValueRecurringPayments.Controls.Add(this.textFutureValueRec);
            this.futureValueRecurringPayments.Controls.Add(this.textInterestRe);
            this.futureValueRecurringPayments.Controls.Add(this.label3);
            this.futureValueRecurringPayments.Controls.Add(this.label9);
            this.futureValueRecurringPayments.Controls.Add(this.textMonthsRe);
            this.futureValueRecurringPayments.Controls.Add(this.label7);
            this.futureValueRecurringPayments.Controls.Add(this.textPaymentsRe);
            this.futureValueRecurringPayments.Controls.Add(this.label8);
            this.futureValueRecurringPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureValueRecurringPayments.Location = new System.Drawing.Point(350, 25);
            this.futureValueRecurringPayments.Name = "futureValueRecurringPayments";
            this.futureValueRecurringPayments.Size = new System.Drawing.Size(350, 300);
            this.futureValueRecurringPayments.TabIndex = 6;
            this.futureValueRecurringPayments.TabStop = false;
            this.futureValueRecurringPayments.Text = "Future Value of Recurring Payments";
            // 
            // buttonCalculateRe
            // 
            this.buttonCalculateRe.Location = new System.Drawing.Point(10, 188);
            this.buttonCalculateRe.Name = "buttonCalculateRe";
            this.buttonCalculateRe.Size = new System.Drawing.Size(150, 42);
            this.buttonCalculateRe.TabIndex = 4;
            this.buttonCalculateRe.Text = "Calculate Future Value";
            this.buttonCalculateRe.UseVisualStyleBackColor = true;
            this.buttonCalculateRe.Click += new System.EventHandler(this.buttonCalculateRe_Click);
            // 
            // textFutureValueRec
            // 
            this.textFutureValueRec.Location = new System.Drawing.Point(188, 198);
            this.textFutureValueRec.Name = "textFutureValueRec";
            this.textFutureValueRec.Size = new System.Drawing.Size(100, 22);
            this.textFutureValueRec.TabIndex = 5;
            // 
            // textInterestRe
            // 
            this.textInterestRe.Location = new System.Drawing.Point(10, 140);
            this.textInterestRe.Name = "textInterestRe";
            this.textInterestRe.Size = new System.Drawing.Size(150, 22);
            this.textInterestRe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 135);
            this.label3.MaximumSize = new System.Drawing.Size(150, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quoted Annual\r\nInterest Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 250);
            this.label9.MaximumSize = new System.Drawing.Size(300, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 40);
            this.label9.TabIndex = 6;
            this.label9.Text = "Payment Due: End of Month\r\nPresent Value: $0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textMonthsRe
            // 
            this.textMonthsRe.Location = new System.Drawing.Point(10, 90);
            this.textMonthsRe.Name = "textMonthsRe";
            this.textMonthsRe.Size = new System.Drawing.Size(150, 22);
            this.textMonthsRe.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Number of Months";
            // 
            // textPaymentsRe
            // 
            this.textPaymentsRe.Location = new System.Drawing.Point(10, 40);
            this.textPaymentsRe.Name = "textPaymentsRe";
            this.textPaymentsRe.Size = new System.Drawing.Size(150, 22);
            this.textPaymentsRe.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(185, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Value of Recurring Payment ($$)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.remainingLoanBalanceFixedLoan);
            this.Controls.Add(this.futureValueSingleSum);
            this.Controls.Add(this.futureValueRecurringPayments);
            this.Controls.Add(this.fixedMonthlyPayment);
            this.Controls.Add(this.comboBoxFinancialSelection);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "MortgageCalculator";
            this.Text = "Mortgage Calculator";
            this.fixedMonthlyPayment.ResumeLayout(false);
            this.fixedMonthlyPayment.PerformLayout();
            this.remainingLoanBalanceFixedLoan.ResumeLayout(false);
            this.remainingLoanBalanceFixedLoan.PerformLayout();
            this.futureValueSingleSum.ResumeLayout(false);
            this.futureValueSingleSum.PerformLayout();
            this.futureValueRecurringPayments.ResumeLayout(false);
            this.futureValueRecurringPayments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFinancialSelection;
        private System.Windows.Forms.GroupBox fixedMonthlyPayment;
        private System.Windows.Forms.TextBox TextMonthlyInterestRate;
        private System.Windows.Forms.Label labelInterest;
        private System.Windows.Forms.TextBox TextMonths;
        private System.Windows.Forms.Label Months;
        private System.Windows.Forms.TextBox TextLoan;
        private System.Windows.Forms.Label Loan;
        private System.Windows.Forms.TextBox textFixedPay;
        private System.Windows.Forms.Button btnFixedMonthlyPay;
        private System.Windows.Forms.GroupBox remainingLoanBalanceFixedLoan;
        private System.Windows.Forms.Button btnRemainingBalance;
        private System.Windows.Forms.TextBox textRemainingLoan;
        private System.Windows.Forms.TextBox TextInterest;
        private System.Windows.Forms.Label labelInterest2;
        private System.Windows.Forms.TextBox TextMonthsTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextLoan2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextMonthsPast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox futureValueSingleSum;
        private System.Windows.Forms.Button btnFutureValueSingle;
        private System.Windows.Forms.TextBox textFutureValue;
        private System.Windows.Forms.TextBox textPeriodLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInterestRate;
        private System.Windows.Forms.Label monthlyPayment;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox futureValueRecurringPayments;
        private System.Windows.Forms.Button buttonCalculateRe;
        private System.Windows.Forms.TextBox textFutureValueRec;
        private System.Windows.Forms.TextBox textInterestRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMonthsRe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPaymentsRe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCompFreq;
    }
}

