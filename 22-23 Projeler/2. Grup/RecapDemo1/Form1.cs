/*
 * Sabir SÜLEYMANLI <suleymanli.sabir@anticverse.com>
 * 
 * Form1.cs
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* Button button = new Button();
            button.Width = 50;
            button.Height = 50;
            button.Text= "My Button";
            this.Controls.Add(button);  */
        }

        /* 
          TextBox'a sadece sayı girişine izin verir ve giriş yapılan karakterlerin sayı olup olmadığını kontrol eder. 
        */
        private void tc_kimlik_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    tc_uyari.Visible = true;
                    e.Handled = true;
                }
                else
                    tc_uyari.Visible = false;
        }

        private void isim_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                isim_uyari.Visible = true;
                e.Handled = true;
            }
            else
                isim_uyari.Visible = false;
        }

        /*
          Textbox'ta girilen değerin bir sayısal değer olup olmadığını kontrol eder.
          Eğer textbox boş değilse ve girilen değer sayısal değilse, 'tc_uyari' isimli Label kontrolünü görünür yapar.
        */
        private void tc_kimlik_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(tc_kimlik_textbox.Text.Trim()) && !int.TryParse(tc_kimlik_textbox.Text.Trim(), out int tcNo))
                {
                    tc_uyari.Visible = true;
                }
                else if (tc_kimlik_textbox.Text.Trim().Length < 10)
                {
                    tc11rakam_uyari.Visible = true;
                }
                else
                {
                    tc_uyari.Visible = false;
                }
            }
        }

        /* 
            Eğer 'isim_textbox' boşsa (yalnızca boşluk karakterleri içeriyorsa değil) 'isim_uyari' etiketi görünür olur,
            aksi takdirde görünmez olur.
        */
        private void isim_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(isim_textbox.Text.Trim()))
                {
                    isim_uyari.Visible = true;
                }
                else
                {
                    isim_uyari.Visible = false;
                }
            }
        }

        /* 
         Kullanıcının 'soyisim_textbox' alanına bir değer girip girmediğini kontrol eder ve gerekli uyarıyı gösterir.
        */
        private void soyisim_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(soyisim_textbox.Text.Trim()))
                {
                    soyisim_uyari.Visible = true;
                }
                else
                {
                    soyisim_uyari.Visible = false;
                }
            }
        }

        /*
         Kullanıcı 'tc_kimlik_textbox' alanına bir şeyler yazdığında uyarı etiketinin görünmez olmasını sağlar. 
         */
        private void tc_kimlik_textbox_TextChanged(object sender, EventArgs e)
        {
            tc_uyari.Visible = false;
        }

        private void isim_textbox_TextChanged(object sender, EventArgs e)
        {
            isim_uyari.Visible = false;
        }

        private void soyisim_textbox_TextChanged(object sender, EventArgs e)
        {
            soyisim_uyari.Visible = false;
        }

        private void tcbos_uyari_VisibleChanged(object sender, EventArgs e)
        {
            if (tcbos_uyari.Visible)
            {
                tc_kimlik_textbox.Focus();
            }
        }

        private void tc_kimlik_textbox_Enter(object sender, EventArgs e)
        {
            tcbos_uyari.Visible = false;
        }


        private void giris_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_kimlik_textbox.Text))
                tcbos_uyari.Visible = true;
            else
                tcbos_uyari.Visible = false;
            if (string.IsNullOrEmpty(isim_textbox.Text))
                isim_uyari.Visible = true;
            else
                isim_uyari.Visible = false;
            if (string.IsNullOrEmpty(soyisim_textbox.Text))
                soyisim_uyari.Visible = true;
            else
                soyisim_uyari.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sefer_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void giris_button_Click_1(object sender, EventArgs e)
        {

        }

        private void nereden_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nereden_combobox.Text == null)
                nereden_uyari.Visible = true;
        }
    }
}
