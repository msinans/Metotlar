using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        void renklendir()
        {
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.LightGray;
            textBox3.BackColor = Color.Gray;
            textBox4.BackColor = Color.BlanchedAlmond;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
        void getir()
        {
            textBox5.Text = "Muhammed Sinan";
            textBox6.Text = "Ömercikoğlu";
            textBox7.Text = "Yazılım Uzmanı";
            textBox8.Text = " Yaş: 44";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            getir();
        }
        int Toplam(int sayi1, int sayi2)
        {
            int sayi3 = sayi1 + sayi2;
            return sayi3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(3, 5).ToString();
            label2.Text = Toplam(7, 9).ToString();
            label3.Text = Toplam(11, 13).ToString();

        }
        int Carpim(int s1, int s2, int s3)
        {
            int s4 = s1 * s2 * s3;
            return s4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = Carpim(2, 5, 7).ToString();
            label5.Text = Carpim(1, 3, 5).ToString();
            label6.Text = Carpim(1, 2, 3).ToString();
        }
        int Carpimlari(int c1, int c2, int c3)
        {
           int c4 = c1*c2*c3;
            return c4;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = Carpimlari(Convert.ToInt16(textBox9.Text),
                                     Convert.ToInt16(textBox10.Text),
                                     Convert.ToInt16(textBox11.Text)).ToString();
        }
    }
}
