using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showCorrectTextBox(testBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showCorrectTextBox(textBox2);
        }

        private void showCorrectTextBox(TextBox box) {
            if (box == testBox1)
            {
                testBox1.Visible = true;
            }
            else {
                testBox1.Visible = false;
            }

            if (box == textBox2)
            {
                textBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
            }
        }
    }
}
