using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sicaklikDonusumleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox1.Text);
            double sonuc = (sayi1 - 32) / 1.8;
            textBox3.Text = sayi1 + " Fahrenayt " +  Math.Round(sonuc,1) + " Celcius'a eşittir!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1= double.Parse(textBox1.Text);
            double sonuc = (sayi1) * 9 / 5 + 32;
            textBox3.Text = sayi1 + " Celcius " + Math.Round(sonuc, 1) + " Fahrenhayt'a eşittir!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1=double.Parse(textBox1.Text);
            double sonuc = sayi1 + 273.15;
            textBox3.Text = sayi1 + " Celcius " + sonuc + " Kelvin'e eşittir!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox1.Text);
            double sonuc = (sayi1 - 32) / 1.8;
            double sonuc1 = sonuc + 273.15;
            textBox3.Text= sayi1 + " Fahrenhayt " + sonuc1 + " Kelvin'e eşittir!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
