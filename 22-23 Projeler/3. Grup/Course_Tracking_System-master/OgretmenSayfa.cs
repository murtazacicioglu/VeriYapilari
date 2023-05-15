using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_takip_sistemi
{
    public partial class OgretmenSayfa : Form
    {
        public OgretmenSayfa()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

     
       
        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa x= new AnaSayfa();
            x.Show();
            this.Hide();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            OgretmenDersler d = new OgretmenDersler();
            d.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            OgretmenDersler ogretmenDersler = new OgretmenDersler();
            ogretmenDersler.Show();
            this.Hide();
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

       

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgretmenDersler x = new OgretmenDersler();
            x.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
