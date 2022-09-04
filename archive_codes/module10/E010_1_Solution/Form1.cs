using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E010_1_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            //pop up a message box
            string greeting = "Hello " + textBox1.Text
                + ", welcome to C# Essential Training";

            if (name.Length == 0)
            {
                MessageBox.Show("Please enter a name");
            }
            else
            { 
                label2.Text = greeting;
            }
        }

        // when the button is clicked,
        // read the text in textBox1,
        // and then populate text in label2
    }
}
