using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        Salary _salary = new Salary();
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {

            _salary.employeeName = employeeNameTextBox.Text;
            _salary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            _salary.houseRentPercent = Convert.ToDouble(homeRentTextBox.Text);
            _salary.medicalAllowancePercent = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show(_salary.GetSalary());
        }
    }
}
