/*

    2022-2023 ULUDAĞ ÜNİVERSİTESİ
    BİLGİSAYAR MÜHENDİSLİĞİ
    VERİ YAPILARI DERSİ
    PROJE ÖDEVİ

    031890011	SALİH ALBAYRAK
    031990047	ABDUSSAMET HADANOĞLU
    031990102	SAMİ CİHAN AKSU
    032090089	SAMİ NECCAR
    032090127	DURSUN EREN ÖZTÜRK
    032190140	ERDEM ZAFER
    032290090	HASAN BASRİ POLAT
    032290103	HASAN KALKAN
    032290104	ONUR POLAT
    032290105	TANER MÜFTÜOĞLU
    032290106	EMRE AYDEMİR
  
 */

using OnlineSatisPlatformu.ProductClasses;

namespace OnlineSatisPlatformu.Forms
{
    public partial class frmAddProduct : Form
    {
        public clsProduct Product;

        public frmAddProduct(ref clsProduct product)
        {
            InitializeComponent();
            Product = product;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cmbKat.Text=="")
            {
                MessageBox.Show("Kategori seçiniz.");
                return;
            }

            string a, k, m;
            float f;

            a = txtName.Text;
            k=cmbKat.Text;
            m=txtMarka.Text;

            f=Convert.ToSingle(txtFiyat.Text.Replace(".",","));

            Product.Ad = a;
            Product.Fiyat = f;
            Product.Kategori = k;
            Product.Marka= m;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
