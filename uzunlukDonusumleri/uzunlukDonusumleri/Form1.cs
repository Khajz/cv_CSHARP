using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uzunlukDonusumleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi=double.Parse(textBox1.Text);
            double sonuc = sayi / 100;
            label3.Text=sonuc.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            double sonuc = sayi * 100;
            double sonuc1 = Math.Round(sonuc, 2);
            label3.Text = sonuc1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            double sonuc = sayi * 10;
            double sonuc1 = Math.Round(sonuc, 2);
            label3.Text = sonuc1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            double sonuc = sayi * 1000;
            double sonuc1 = Math.Round(sonuc, 2);
            label3.Text = sonuc1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            double sonuc = sayi * 0.3937;
            double sonuc1=Math.Round(sonuc,2);
            label3.Text = sonuc1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            double sonuc = sayi * 0.621371;
            double sonuc1 = Math.Round(sonuc, 2);
            label3.Text = sonuc1.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            double sonuc = sayi * 2.54;
            double sonuc1 = Math.Round(sonuc, 2);
            label3.Text = sonuc1.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox1.Text);
            double sonuc = sayi1 * 1.6;
            double sonuc1 = Math.Round(sonuc, 2);
            label3.Text = sonuc1.ToString();
        }
    }
}
