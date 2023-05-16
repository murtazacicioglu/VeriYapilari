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

using OnlineSatisPlatformu.Classes;
using OnlineSatisPlatformu.ProductClasses;

namespace OnlineSatisPlatformu.Forms
{
    public partial class frmSepet : Form
    {
        public SepetLinkedList Sepet;
        public SepetNode CurrentNode;


        public event EventHandler<KargoDugum> KargoyaEklendi;

        public event EventHandler<SepetNode> SepettenCikar;


        protected virtual void onKargoyaEklendi(KargoDugum k)
        {
            EventHandler<KargoDugum> handler = KargoyaEklendi;
            if (handler != null)
            {
                handler(this, k);
            }
        }

        protected virtual void onSepettenCikar(SepetNode k)
        {
            EventHandler<SepetNode> handler = SepettenCikar;
            if (handler != null)
            {
                handler(this, k);
            }
        }


        public frmSepet(SepetLinkedList s)
        {
            InitializeComponent();
            this.Sepet = s;
            CurrentNode = s.head;

        }

        private void frmSepet_Load(object sender, EventArgs e)
        {
            Display(CurrentNode);
        }


        public void Display(SepetNode node)
        {
            pnlSatis.Controls.Clear();
            if (node == null) return;

            lblKargoAd.Text = node.data.KargoAdi;
            lblKargoTipi.Text = GetKargoTipi(node.data.KargoTipi);
            
            clsProduct p = node.data.Urun;
            ucProduct up = new ucProduct(p);

            up.KargoyaEkle += KargoyaEkle;

            pnlSatis.Controls.Add(up);
        }

        private void KargoyaEkle(object? sender, clsProduct e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Alıcı adı boş olamaz!");
                return;
            }

            if (txtSurname.Text == "")
            {
                MessageBox.Show("Soyadı boş olamaz!");
                return;
            }

            if (txtAdres.Text == "")
            {
                MessageBox.Show("Adres boş olamaz!");
                return;
            }

            KargoDugum k = new KargoDugum(CurrentNode.data, CurrentNode.data.KargoTipi);
            k.Odeme = new clsOdeme(txtName.Text, txtSurname.Text, txtAdres.Text);
            onKargoyaEklendi(k);
            
            // KARGO LİSTESİNE GÖNDERİLEN SEPETNODE SEPETTEN ÇIKSIN
            Sepet.Remove(CurrentNode.data);
            CurrentNode = Sepet.head; // CurrentNode.next; 
            Display(CurrentNode);   
        }

        private string GetKargoTipi(int tip)
        {
            string ret = "NORMAL";

            switch(tip)
            {
                case 2: ret = "NORMAL"; break;
                case 1: ret = "ACİL"; break;
                case 0: ret = "ÇOK ACİL"; break;
            }

            return ret;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            CurrentNode = CurrentNode.next;
            Display(CurrentNode);   
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CurrentNode = CurrentNode.prev;
            Display(CurrentNode);
        }

          

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
                Sepet.Remove(CurrentNode.data);
                onSepettenCikar(CurrentNode);
                CurrentNode = Sepet.head; 
                Display(CurrentNode);
        }
    }
}
