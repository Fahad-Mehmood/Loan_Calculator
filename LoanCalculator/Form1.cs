using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult i;
            i = MessageBox.Show("Conform to exit","Loan System",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (i == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtInterestRate.Clear();
            txtloan.Clear();
            txtNoofYear.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment;
            double numberofYears;
            String iMonthlyPayment, iTotalPayment;
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberofYears = Convert.ToDouble(txtNoofYear.Text);
            loanAmount = Convert.ToDouble(txtloan.Text);
            MonthlyPayment = loanAmount * monthlyInterestRate / (1-1/Math.Pow(1+monthlyInterestRate,numberofYears*12));

            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            //iMonthlyPayment = String.Format("{0:C}",MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            TotalPayment = MonthlyPayment *numberofYears* 12;
            //iTotalPayment = String.Format("{0:C}",TotalPayment);

            lblTotalPayment.Text = (TotalPayment).ToString();

           // txtloan.Text = String.Format("{0:C}",loanAmount);
                }

        public Form1()
        {
        
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("Loan Management System" + "\n");
            rtfReceipt.AppendText("  Develop by BSCS-3 " + "\n");
            rtfReceipt.AppendText("----------------------------------------------" + "\n");
            rtfReceipt.AppendText("Amount of Loan" + "\t" + txtloan.Text + "\n");
            rtfReceipt.AppendText("Number of Year " + "\t" + txtNoofYear.Text + "\n");
            rtfReceipt.AppendText("Interest Rate " + "\t"  + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("Monthly Payment " + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Total Payment " + "\t"   + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("----------------------------------------------" + "\n");
            rtfReceipt.AppendText("------------------Thank You------------------" + "\n");
        }

        private void txtloan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
