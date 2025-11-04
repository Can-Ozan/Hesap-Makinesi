using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_Uyg
{
    public partial class Form1 : Form
    {
        int secim= 0;
        double sayi1, sayi2, sonuc;
        public Form1()
        {
            InitializeComponent();
        }
        // Rakam butonları işlemi yapar
        private void Buttonlar(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += txtDisplay.Text = ((Button)sender).Text;
        }
        // Toplama butonu işlemi seçer
        private void toplamabtn_Click(object sender, EventArgs e)
        {
            sayi1= double.Parse(txtDisplay.Text);
            secim = 1;
            txtDisplay.Text = "0";
        }
        // Çıkarma butonu işlemi seçer
        private void cikarmabtn_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtDisplay.Text);
            secim = 2;
            txtDisplay.Text = "0";
        }
        // Çarpma butonu işlemi seçer
        private void carpmabtn_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtDisplay.Text);
            secim = 3;
            txtDisplay.Text = "0";
        }
        // Bölme butonu işlemi seçer
        private void bolmebtn_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtDisplay.Text);
            secim = 4;
            txtDisplay.Text = "0";
        }

        // Eşittir butonu işlemi yapar
        private void esittirbtn_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(txtDisplay.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            txtDisplay.Text = sonuc.ToString();
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            txtDisplay.Text = sonuc.ToString();
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
            }
            txtDisplay.Text = sonuc.ToString();
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
            }
            txtDisplay.Text = sonuc.ToString();
        }

        // Virgül butonu ekler
        private void virgulbtn_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.IndexOf(",") < 1)
            {
                txtDisplay.Text += ",";
            }
        }

        // Negatif yapma butonu eksi işaretini ekler veya çıkarır
        private void btnNegatif_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                if (txtDisplay.Text.StartsWith("-"))
                {
                    txtDisplay.Text= txtDisplay.Text.Replace("-", "");
                }
                else if (txtDisplay.Text.StartsWith("")) // eğer bu boş ise 
                {
                    txtDisplay.Text= "-" + txtDisplay.Text; //Önceki değerin başına - ekle
                }
            }
        }

        // C tuşuna Basınca ekranı sıfırlar
        private void sifirlamabtn_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        // Backspace butonu son karakteri siler
        private void Backspacebtn_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }
    }
}
