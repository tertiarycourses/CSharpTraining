using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E010_2_Solution.src;

namespace E010_2_Solution
{
    public partial class Form1 : Form
    {
            CalculatorLogic calculatorLogic = new CalculatorLogic();
        public Form1()
        { 

            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                char buttonText = char.Parse(button.Text);

                //Debug
                //MessageBox.Show("button " + buttonText + " is clicked"); 

                string formula;
                string result;
                calculatorLogic.AddDigit(buttonText, out formula, out result);

                labelFormula.Text = formula;
                labelResult.Text = result;

            }
        }
    }
}
