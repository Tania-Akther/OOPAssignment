using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }
        Account account = new Account();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            account.accountNumber = accountNoTextBox.Text;
            account.customerName = customerNameTextBox.Text;

            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            account.Deposit(amount);

            amountTextBox.Clear();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {

            double amount = Convert.ToDouble(amountTextBox.Text);
            account.Withdraw(amount);

            amountTextBox.Clear();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.GetReport());
        }
    }
}
