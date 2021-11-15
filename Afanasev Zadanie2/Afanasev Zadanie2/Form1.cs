using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afanasev_Zadanie2
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
            int b;
            int c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);

            int d = (c / 100);
            double s = a * (1 + (1 + d / 12) ^ b);
            textBox4.Text = Convert.ToString(s);



        }
    }
}
