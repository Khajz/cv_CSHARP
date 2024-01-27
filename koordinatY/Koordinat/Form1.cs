using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koordinat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = int.Parse(textBox1.Text);
            double x2 = int.Parse(textBox2.Text);
            double y1 = int.Parse(textBox3.Text);
            double y2 = int.Parse(textBox4.Text);
            double m = (y1-y2)/(x1-x2);
            double c = y1 - x1;
            label6.Text = "y=" + m.ToString()+"x+" + c.ToString();

        }
    }
}
