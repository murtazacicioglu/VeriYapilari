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
using OnlineSatisPlatformu.Forms;
using System.Collections;
using System.ComponentModel;
using OnlineSatisPlatformu.Classes;
using System.Xml.Linq;

namespace OnlineSatisPlatformu
{

    public partial class frmMain : Form
    {
        // AVL TREE
        public ProductAVLTree TV_AVL_TREE = new ProductAVLTree(null);
        public ProductAVLTree BD_AVL_TREE = new ProductAVLTree(null);
        public ProductAVLTree CM_AVL_TREE = new ProductAVLTree(null);
        public ProductAVLTree AL_AVL_TREE = new ProductAVLTree(null);
        public ProductAVLTree FLT_AVL_TREE = new ProductAVLTree(null);

        // SEPET CIRCULAR DOUBLE LINKED LIST
        public SepetLinkedList SEPET = new SepetLinkedList();

        // KARGO PRIORITY QUEUE
        public KargoListesi YRT_KARGO = new KargoListesi();  // Yurtiçi
        public KargoListesi MNG_KARGO = new KargoListesi();  // MNG
        public KargoListesi PTT_KARGO = new KargoListesi();  // PTT

        public string Adi = "Uludağ";
        public string SoyAdi = "Üniversitesi";
        public string Adresi = "Görükle Mh. İzmir Yolu Cd. No 1 NİLÜFER / BURSA";


        public string pFile = Directory.GetCurrentDirectory() + "\\products.txt";
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadProducts(pFile);
        }

        void LoadProducts(string path)
        {
            flpProducts.Controls.Clear();
            if (File.Exists(path))
            {
                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] fields = s.Split("\t");
                        if (fields.Length == 4)
                        {
                            string ad = fields[0].Trim();
                            string fiyat = fields[1].Trim();
                            string marka = fields[2].Trim();
                            string kat = fields[3].Trim();

                            float f=Convert.ToSingle(fiyat);

                            clsProduct x = new clsProduct(ad, f, kat, marka);
                            AL_AVL_TREE.Ekle(x);

                            switch (kat)
                            {
                                case "TV": TV_AVL_TREE.Ekle(x); break;
                                case "BUZDOLABI": BD_AVL_TREE.Ekle(x); break;
                                case "ÇAMAŞIR MAK.": CM_AVL_TREE.Ekle(x); break;
                            }

                            AddProdCard(x,flpProducts);

                        }
                        else
                        {
                            Console.WriteLine("Hatalı ürün tanımı : " + s);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine(path + " dosyası bulunamadı.");
            }
           
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            clsProduct x = new clsProduct("", 0.0f, "", "");

            frmAddProduct frmAddProduct = new frmAddProduct(ref x);
            DialogResult res = frmAddProduct.ShowDialog();
            
            if (res == DialogResult.OK) {
                switch(x.Kategori)
                {
                    case "TV": TV_AVL_TREE.Ekle(x); break;
                    case "BUZDOLABI": BD_AVL_TREE.Ekle(x); break;
                    case "ÇAMAŞIR MAK.": CM_AVL_TREE.Ekle(x); break;
                }

                AL_AVL_TREE.Ekle(x);
                AddProdCard(x, flpProducts);
                SaveProduct(x, pFile);
            }
        }

        public void AddProductBack()
        {

        }
        

        public void AddProdCard(clsProduct Product,  Control container)
        {
            ucProduct p = new ucProduct(Product);
            p.SepeteEkle += SepeteEkle;
            container.Controls.Add(p);
        }

        private void SepeteEkle(object? sender, clsProduct e)
        {
            frmKargoSor k = new frmKargoSor();
            DialogResult res = k.ShowDialog();

            if (res == DialogResult.OK) {

                int kargotipi = k.kt;
                string kargoadi = k.kad;
                clsSatis s = new clsSatis(e, kargotipi, kargoadi);
                SEPET.Add(s);

                AL_AVL_TREE.Sil(e);
                switch(e.Kategori)
                {
                    case "TV": TV_AVL_TREE.Sil(e); break;
                    case "BUZDOLABI": BD_AVL_TREE.Sil(e); break;
                    case "ÇAMAŞIR MAK.": CM_AVL_TREE.Sil(e); break;
                }
                Filtrele();
                e.status = 1;
            }
        }

        public void SaveProduct(clsProduct p, string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                string strLine = p.Ad + "\t" +
                    p.Fiyat.ToString("0.00") + "\t" +
                    p.Marka + "\t" +
                    p.Kategori;

                sw.WriteLine(strLine);
            }

        }

  

        private void btnCargo_Click(object sender, EventArgs e)
        {
           


        }

        private void cmbKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        public void Filtrele()
        {

            flpProducts.Controls.Clear();

            clsProduct[] disp = AL_AVL_TREE.InOrder();

            FLT_AVL_TREE  = AL_AVL_TREE;

            //Kategori Filtreleme
            switch (cmbKat.Text)
            {
                case "TV":
                    FLT_AVL_TREE = TV_AVL_TREE;
                    break;
                case "BUZDOLABI":
                    FLT_AVL_TREE =  BD_AVL_TREE; break;
                case "ÇAMAŞIR MAK.":
                    FLT_AVL_TREE =  CM_AVL_TREE; break;
                case "HEPSİ":
                    FLT_AVL_TREE = AL_AVL_TREE; break;
                default: FLT_AVL_TREE = AL_AVL_TREE; break;
            }

            // Filtreleme

            string search = txtSearch.Text;
            FLT_AVL_TREE = FLT_AVL_TREE.Filter(search);
            
            // SIRALAMA

            int sort = cmbSort.SelectedIndex;
            
            switch (sort)
            {
                case 0: disp = FLT_AVL_TREE.InOrder(); break;
                case 1: disp = FLT_AVL_TREE.Azalan(); break;
                case 2: 
                    disp = new clsProduct[] { FLT_AVL_TREE.Min() }; 
                    break;
                case 3:
                    disp = new clsProduct[] { FLT_AVL_TREE.Max() };
                    break;
            }

            for (int i = 0; i < disp.Length; i++)
                AddProdCard(disp[i], flpProducts);

        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {

            Filtrele();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            frmSepet f = new frmSepet(SEPET);

            f.txtName.Text = Adi;
            f.txtSurname.Text = SoyAdi;
            f.txtAdres.Text = Adresi;

            f.KargoyaEklendi += KargoyaEkle;
            f.SepettenCikar += SepettenCikar;

            f.ShowDialog();

            Adi = f.txtName.Text;
            SoyAdi = f.txtSurname.Text;
            Adresi = f.txtAdres.Text;   

        }

        private void SepettenCikar(object? sender, SepetNode e)
        {
            clsProduct x = e.data.Urun;
            x.status = 0;
            switch (x.Kategori)
            {
                case "TV": TV_AVL_TREE.Ekle(x); break;
                case "BUZDOLABI": BD_AVL_TREE.Ekle(x); break;
                case "ÇAMAŞIR MAK.": CM_AVL_TREE.Ekle(x); break;
            }

            AL_AVL_TREE.Ekle(x);
            AddProdCard(x, flpProducts);
            Filtrele();

        }

        private void KargoyaEkle(object? sender, KargoDugum k)
        {
            k.veri.Urun.status = 2;
            switch (k.veri.KargoAdi)
            {
                case "YURTİÇİ": 
                    YRT_KARGO.Enqueue(k);
                    KargoGoster(YRT_KARGO, flpYurtici);
                    break;
                case "MNG": MNG_KARGO.Enqueue(k);
                    KargoGoster(MNG_KARGO, flpMNG);
                    break;
                case "PTT": PTT_KARGO.Enqueue(k);
                    KargoGoster(PTT_KARGO, flpPTT); 
                    break;
            }
        }

        private void KargoGoster(KargoListesi list, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            KargoDugum k = list.bas;   
            while(k!=null)
            {
                clsProduct p = k.veri.Urun;
                AddProdCard(p,flp);
                AddKargoCard(k, flp);
                k = k.ileri;   
            }
        }

        private void AddKargoCard(KargoDugum k, FlowLayoutPanel flp)
        {
            FlowLayoutPanel f = new FlowLayoutPanel();
            f.Width = 200;
            f.Height = flp.Height;
            f.BorderStyle= BorderStyle.Fixed3D;
            
            AddLabel("Öncelik:", OncelikToStr(k.oncelik), f);
            AddLabel("Alıcı:", k.Odeme.AliciAdi + " " + k.Odeme.AliciSoyadi  , f);
            AddLabel("Tarih:", k.Odeme.OdemeTarihi.ToString("dd.MM.yyyy HH:mm"), f);
            AddLabel("Adres:", k.Odeme.FaturaAdresi, f).Height = 80;
            flp.Controls.Add(f);
        }

        private Label AddLabel(string tag, string data, FlowLayoutPanel f)
        {
          
            Label l = new Label();
            l.Width = f.Width;
            l.Height = 30;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.AutoSize = false;
            l.BorderStyle = BorderStyle.Fixed3D;
            l.Text = tag + data;
            f.Controls.Add(l);
            return l;
        }

        private string OncelikToStr(int oncelik)
        {
            string ret = "";
            if (oncelik == 0) ret = "ÇOK ACİL";
            if (oncelik == 1) ret = "ACİL";
            if (oncelik == 2) ret = "NORMAL";
            return ret;
        }

        private void btnYrtTemizle_Click(object sender, EventArgs e)
        {
            YRT_KARGO.Dequeue();
            KargoGoster(YRT_KARGO, flpYurtici);

        }

        private void btnMngTemizle_Click(object sender, EventArgs e)
        {
            MNG_KARGO.Dequeue();
            KargoGoster(MNG_KARGO, flpMNG);
        }

        private void btnPttTemizle_Click(object sender, EventArgs e)
        {
            PTT_KARGO.Dequeue();
            KargoGoster(PTT_KARGO, flpPTT);
        }

        private void bthAbout_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
            frmSplash f = new frmSplash();
            f.ShowDialog();
            Opacity = 1.0;

        }
    }
}