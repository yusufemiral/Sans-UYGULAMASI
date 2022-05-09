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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Oyun o = new Oyun();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (double.Parse(textBox1.Text) > 5) 
            {
                o.cuzdan += double.Parse(textBox1.Text);
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen 5 TL'den Büyük Bir Değer Giriniz");
            }
            o.Cuzdan = o.cuzdan;
            label1.Text = "Cüzdan : " + o.Cuzdan + " TL";
            label6.Text = "Bakiye : " + o.Cuzdan + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (o.Cuzdan >= double.Parse(textBox1.Text))
            {
                o.Cuzdan -= double.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Hesabınızda Çekmek İstediğiniz Kadar Bakiye Bulunmamaktadır.","Uyarı");
            }
            label1.Text = "Cüzdan : " + o.cuzdan + " TL";
            label6.Text = "Bakiye : " + o.cuzdan + " TL";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (o.Cuzdan <= 0)
            {
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Random r1 = new Random();
                int sayi1 = r1.Next(0, 2);
                int sayi2 = r1.Next(0, 2);
                int sayi3 = r1.Next(0, 2);
                label3.Text = sayi1.ToString();
                label4.Text = sayi2.ToString();
                label5.Text = sayi3.ToString();

                if (sayi1 == sayi2 && sayi2 == sayi3)
                {
                    o.cuzdan += int.Parse(textBox2.Text)*10;
                    label6.Text = "Cüzdan : " + o.cuzdan + " TL";
                    MessageBox.Show("Kazandınız Ödülünüz Cüzdanınıza Eklenmiştir.", "Tebrikler");
                }

                else
                {
                    o.cuzdan -= int.Parse(textBox2.Text);
                    label6.Text = "Cüzdan : " + o.cuzdan + " TL";
                    label1.Text = "Cüzdan : " + o.cuzdan + " TL";
                    MessageBox.Show("Bir Dahaki Sefere......", "Eşleşme Yok");
                   
                }

                if (label3.Text == "7" && label4.Text == "7" && label5.Text == "7")
                {
                    o.Cuzdan += int.Parse(textBox2.Text)*40;
                }
            }
        }
    }
}
