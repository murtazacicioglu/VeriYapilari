/*
 * Sabir SÜLEYMANLI <suleymanli.sabir@anticverse.com>
 * 
 * KoltukForm.cs
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
using RecapDemo1;
namespace RecapDemo1
{
    public partial class KoltukForm : Form
    {
        public KoltukForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // pencere boyutunu sabitledik
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600); 
        }


        private void Button_Click(object sender, EventArgs e)
        {
            // Tıklanan butonun adını alın
            Button clickedButton = (Button)sender;
            string buttonName = clickedButton.Name;
            
            // Koltuk bilgisini saklayın ve formu kapatın
            Properties.Settings.Default.KoltukBilgisi = buttonName;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void KoltukForm_Load(object sender, EventArgs e)
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.Click += Button_Click;
            } 
        }

        private void KoltukForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.KoltukBilgisi))
            {
                System.Windows.Forms.Label.koltukno_uyari.Visible = true;
            }
        }

        private void koltuk_onay_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
