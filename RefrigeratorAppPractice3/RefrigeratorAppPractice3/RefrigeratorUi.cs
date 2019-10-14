using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator _refrigerator = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _refrigerator.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
            maxWeightTakeTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            _refrigerator.NumberOfItems = Convert.ToInt32(itemTextBox.Text);
            _refrigerator.WeightPerItem = Convert.ToInt32(weightTextBox.Text);

            itemTextBox.Clear();
            weightTextBox.Clear();

            currentWeightTextBox.Text = _refrigerator.GetCurrentWeight().ToString();

            remainingWeightTextBox.Text = _refrigerator.GetRemainingtWeight().ToString();
        }
    }
}
