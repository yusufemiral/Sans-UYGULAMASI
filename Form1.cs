using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi ="Emirhan", sifre = "1234";
            if (textBox1.Text == kullaniciadi && maskedTextBox1.Text == sifre)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı Kontrol Edip Tekrar Deneyiniz,", "Uyarı");
                textBox1.Clear();
                maskedTextBox1.Clear();
            }
        }
    }
}
