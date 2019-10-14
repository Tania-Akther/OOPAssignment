using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }
        Calculator _calculator = new Calculator();
        private void AddButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = _calculator.Add().ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = _calculator.Subtract().ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = _calculator.Multiply().ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            _calculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            _calculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            resultTextBox.Text = _calculator.Divide().ToString();
        }
        private void ClearTextBox()
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
        }
    }
}
