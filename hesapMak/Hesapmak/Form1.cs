using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesapmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = sayi1 + sayi2;
            textBox3.Text = sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = sayi1 - sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            float sayi1 = int.Parse(textBox1.Text);
            float sayi2 = int.Parse(textBox2.Text);
            float sonuc = sayi1 / sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int sayi= int.Parse(textBox1.Text);
            int sayi1= int.Parse(textBox2.Text);
            int faktoriyel = 1;
            int faktoriyel1 = 1;
            for (int i = 1; i < sayi+1; i++)
            {
                faktoriyel *= i;
            }
            for (int i=1; i <sayi1+1; i++)
            {
                faktoriyel1 *= i;
            }
            string ornek=textBox1.Text + "!=" + faktoriyel.ToString() + "   ";
            string ornek2 = textBox2.Text + "!=" + faktoriyel1.ToString();
            textBox3.Text = ornek+ "\r\n" + ornek2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int sayi1= int.Parse(textBox1.Text);
            int sayi2= int.Parse(textBox2.Text);
            int sonuc = sayi1 * sayi1;
            int sonuc1 = sayi2 * sayi2;
            string bir = sayi1 + " karesi " + sonuc.ToString()+" ";
            string iki = sayi2 + " karesi " + sonuc1.ToString();
            textBox3.Text= bir + "\r\n" + iki;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            double sayi1 = int.Parse(textBox1.Text);
            double sayi2 = int.Parse(textBox2.Text);
            double sonuc = 1;
            for (double i = 1; i < sayi2 + 1; i++)
            {
                sonuc*=sayi1;
            }
            textBox3.Text = sayi1 + " üzeri " + sayi2 + " = " + sonuc.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int sayi1=int.Parse(textBox1.Text);
            int sayi2=int.Parse(textBox2.Text);
            double sonuc = 1;
            double sonuc1= 1;
            sonuc = Math.Sqrt(sayi1);
            sonuc = Math.Round(sonuc, 2);
            sonuc1 = Math.Sqrt(sayi2);
            sonuc1= Math.Round(sonuc1, 2);
            string bir = sayi1 + " karekökü " + sonuc.ToString();
            string iki = sayi2 + " karekökü " + sonuc1.ToString();
            textBox3.Text = bir + "\r\n" + iki; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
