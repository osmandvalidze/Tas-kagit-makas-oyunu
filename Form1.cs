using System;
using System.Drawing;
using System.Windows.Forms;

namespace taskagıtmakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        int kullanici = 0;
        int bot = 0;
        int tasKagitMakas;

        Random random = new Random();

        private void Fonksiyon()
        {

            tasKagitMakas = random.Next(0, 3);

            if (tasKagitMakas == 0)
            {
                textBox4.Text = "Taş";
            }
            if (tasKagitMakas == 1)
            {
                textBox4.Text = "Kağıt";
            }
            if (tasKagitMakas == 2)
            {
                textBox4.Text = "Makas";
            }
            // 0 taş
            // 1 kağıt
            // 2 makas
        }
        private void allClear()
        {
            textBox1.Clear();
            textBox4.Clear();

            label1.Text = "Bot : 0";
            label2.Text = "Kullanıcı : 0";

            kullanici = 0;
            bot = 0;
        }
        private void Skor()
        {
            if (kullanici == 3)
            {
                MessageBox.Show("Oyunu Kazandınız!");
                allClear();
            }
            if (bot == 3)
            {
                MessageBox.Show("Oyunu Kaybettiniz!");
                allClear();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Fonksiyon();
            if (tasKagitMakas == 0){textBox1.Text = "Berabere!";}
            else if (tasKagitMakas == 1)
            {
                textBox1.Text = "Kaybettiniz!";
                bot += 1;
                label1.Text = "Bot : " + bot.ToString();
            }
            else
            {
                textBox1.Text = "Kazandınız!";
                kullanici += 1;
                label2.Text = "Kullanıcı : " + kullanici.ToString();
            }
            Skor();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fonksiyon();
            if (tasKagitMakas == 0)
            {
                textBox1.Text = "Kazandınız!";
                kullanici += 1;
                label2.Text = "Kullanıcı : " + kullanici.ToString();
            }
            else if (tasKagitMakas == 1){textBox1.Text = "Berabere!";}
            else
            {
                textBox1.Text = "Kaybettiniz!";
                bot += 1;
                label1.Text = "Bot : " + bot.ToString();
            }
            Skor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fonksiyon();
            if (tasKagitMakas == 0)
            {
                textBox1.Text = "Kaybettiniz!";
                bot += 1;
                label1.Text = "Bot : " + bot.ToString();
            }
            else if (tasKagitMakas == 1)
            {
                textBox1.Text = "Kazandınız!";
                kullanici += 1;
                label2.Text = "Kullanıcı : " + kullanici.ToString();
            }
            else{textBox1.Text = "Berabere!";}
            Skor();
        }
    }
}
