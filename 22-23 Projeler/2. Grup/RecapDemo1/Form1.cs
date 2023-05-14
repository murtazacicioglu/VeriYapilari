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
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // pencere boyutunu sabitledik
            this.MinimumSize = new Size(1100, 630); 
            this.MaximumSize = new Size(1100, 630);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            soyisim_uyari.Visible = true;
        }

        private void tcbos_uyari_VisibleChanged(object sender, EventArgs e)
        {
            if (tcbos_uyari.Visible)
            {
                tc_kimlik_textbox.Focus();
            }
        }

        private void giris_button_Click_1(object sender, EventArgs e)
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
            if (yas_numupdown.Text == "0")
                yas_uyari.Visible = true;
            else
                yas_uyari.Visible = false;
            if (tc_kimlik_textbox.Text.Length != 11 || tc_kimlik_textbox.Text == "")
            {
                tc11rakam_uyari.Visible = true;
            }
            else
            {
                tc11rakam_uyari.Visible = false;
                tcbos_uyari.Visible = false;
                tc11rakam_uyari.Visible = false;
                tc_uyari.Visible = false;
            }
            if (erkek_checkbox.Checked && kadin_checkbox.Checked)
            {
                cinsiyet_uyari.Visible = false;
                cinsiyet2_uyari.Visible = true;
            }
            else if (!erkek_checkbox.Checked && !kadin_checkbox.Checked)
            {
                cinsiyet_uyari.Visible = true;
                cinsiyet2_uyari.Visible = false;
            }
            else
            {
                cinsiyet_uyari.Visible = false;
                cinsiyet2_uyari.Visible = false;
            }
            if( tcbos_uyari.Visible == false && tc11rakam_uyari.Visible == false && tc_uyari.Visible == false && isim_uyari.Visible == false && soyisim_uyari.Visible == false && cinsiyet_uyari.Visible == false && cinsiyet2_uyari.Visible == false && yas_uyari.Visible == false)
                basariligiris_uyari.Visible = true;
        }


        private void bilet_olustur_button_Click(object sender, EventArgs e)
        {
            if (nereden_combobox.Text == "Seçiniz" || nereden_combobox.Text == "(Boş)")
                nereden_uyari.Visible = true;
            else
                nereden_uyari.Visible = false;
            if (nereye_combobox.Text == "Seçiniz" || nereye_combobox.Text == "(Boş)")
                nereye_uyari.Visible = true;
            else
                nereye_uyari.Visible = false;
            if (sefer_combobox.Text == "Seçiniz" )
                sefer_uyari.Visible = true;
            else
                sefer_uyari.Visible = false;
            if (koltuk_numarasi_numupdown.Text == "0")
                koltukno_uyari.Visible = true;
            else
                koltukno_uyari.Visible = false;
            if (nereden_combobox.Text == nereye_combobox.Text)
                aynisehir_uyari.Visible = true;
            else
                aynisehir_uyari.Visible = false;
            if (basariligiris_uyari.Visible != true)
                girisyaphata_uyari.Visible = true;
            if (girisyaphata_uyari.Visible == false && nereden_uyari.Visible == false && nereye_uyari.Visible == false && sefer_uyari.Visible == false && koltukno_uyari.Visible == false && aynisehir_uyari.Visible == false)
                basarilibilet_uyari.Visible = true;
           

        }


        private void bileti_sil_button_Click(object sender, EventArgs e)
        {
            if (bilet_sec_combobox.Text == "Seçiniz")
                biletsil_uyari.Visible = true;
            else
                biletsil_uyari.Visible = false;
            if(biletsil_uyari.Visible == false)
                basarilibiletsil_uyari.Visible=true;
        }

        private void zaman_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
                DateTime minDate = DateTime.Now.Date; // Sadece günü ve saati al
                zaman_dateTimePicker.MinDate = minDate; // DateTimePicker'ın MinDate özelliğine atama yap
        }

        private void basarilibilet_uyari_Click(object sender, EventArgs e)
        {

        }
    }
}
