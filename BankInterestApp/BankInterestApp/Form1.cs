using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankInterestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double interest;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string bankname = "";
            double time;
            double balance;
            bankname = bankNameComboBox.Text;
            time = Convert.ToDouble(timeTextBox.Text);
            balance= Convert.ToDouble(BalanceTextBox.Text);

            if (bankname == "BRAC")
            {
                interest = balance * time * 0.06;
                interestResultLebel.Text = Convert.ToString(interest);
            }
            else if (bankname == "DBBL")
            {
                interest = balance * time * 0.07;
                interestResultLebel.Text = Convert.ToString(interest);
            }
            else
            {
                interest = balance * time * 0.08;
                interestResultLebel.Text = Convert.ToString(interest);
            }
        }
    }
}
