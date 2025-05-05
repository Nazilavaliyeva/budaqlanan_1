using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budaqlanan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int netice = 0;
            
            if (number1 > number2)
            {
                netice = number1 + number2;
            }
            else if (number1 < number2)
            {
                netice = number2 - number1;
            }
            else
            {
                MessageBox.Show("Xəta baş verdi!");
            }
            label1.Text = netice.ToString();
        }

    }
}

