namespace tictactoe
{
    public partial class Form1 : Form
    {
        int siraKimde = 1;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Sýra 1.Oyuncuda";
        }

        public void dugmekapat()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public void kazananKontrolu()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label1.Text = "1. OYUNCU KAZANDI";
                dugmekapat();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label1.Text = "2. OYUNCU KAZANDI";
                dugmekapat();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (siraKimde == 1)
            {
                button1.Text = "X";
                label1.Text = "Sýra 2.Oyuncuda";
                siraKimde = 2;

            }
            else
            {
                button1.Text = "O";
                label1.Text = "Sýra 1.Oyuncuda";
                siraKimde = 1;
            }
            kazananKontrolu();
            button1.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button2.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button2.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }

            }
            kazananKontrolu();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button3.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button3.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }

            }
            kazananKontrolu();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button4.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button4.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }

            }
            kazananKontrolu();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button5.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button5.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }

            }
            kazananKontrolu();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button6.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button6.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }
            }
            kazananKontrolu();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button7.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button7.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }
            }
            kazananKontrolu();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button8.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button8.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }
            }
            kazananKontrolu();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (siraKimde == 1)
                {
                    button9.Text = "X";
                    label1.Text = "Sýra 2.Oyuncuda";
                    siraKimde = 2;
                }
                else
                {
                    button9.Text = "O";
                    label1.Text = "Sýra 1.Oyuncuda";
                    siraKimde = 1;
                }
            }
            kazananKontrolu();
            button9.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1 || siraKimde == 2)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                label1.Text = "Sýra 1.Oyuncuda";
                siraKimde = 1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}