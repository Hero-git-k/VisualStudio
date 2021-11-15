using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afanasev_Zadanie7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                a = (a * 135);
                textBox2.Text = Convert.ToString(a);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                a = (a * 215);
                textBox2.Text = Convert.ToString(a);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                a = (a * 414);
                textBox2.Text = Convert.ToString(a);
            }
        }
    }
}
