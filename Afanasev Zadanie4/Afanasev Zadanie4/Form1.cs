using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afanasev_Zadanie4
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
            a = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
            {
                a = (a + 100);
                textBox1.Text = Convert.ToString(a);
            }
            else if (radioButton2.Checked)
            {
                a = (a + 200);
                textBox1.Text = Convert.ToString(a);
            }
            else if (radioButton3.Checked)
            {
                a = (a + 300);
                textBox1.Text = Convert.ToString(a);
            }
        }
    }
}
