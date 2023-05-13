// ÖNCELİKLİ KUYRUK VERİ YAPISI

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

namespace OnlineSatisPlatformu.Classes
{
    public class clsOdeme
    {
        public DateTime OdemeTarihi;
        public string AliciAdi;
        public string AliciSoyadi;
        public string FaturaAdresi;

        public clsOdeme(string Ad, string Soyad, string Adres)
        {
            AliciAdi = Ad;
            AliciSoyadi = Soyad;
            FaturaAdresi = Adres;
            OdemeTarihi = DateTime.Now;
        }
    }

    public class KargoDugum
    {
        public clsSatis veri;
        public clsOdeme Odeme;

        public int oncelik;
        public KargoDugum ileri;

        public KargoDugum(clsSatis veri, int oncelik)
        {
            this.veri = veri;
            this.oncelik = oncelik;
            ileri = null;
        }
    }

    // Tek Yönlü Priority Queue Bağlı Listenin Oluşturulması
    public class KargoListesi
    {
        public KargoDugum bas;

        public KargoListesi()
        {
            bas = null;

        }
        public void Enqueue(KargoDugum yeni)
        {
            if (bas == null) //Bas bosşa başa ekle
            {
                bas = yeni;
            }
            else if (bas.oncelik > yeni.oncelik) //Eğer basdan daha az öncelikli ise basa ekle
            {
                yeni.ileri = bas;
                bas = yeni;
            }
            else
            {
                KargoDugum temp = bas;

                while (temp.oncelik <= yeni.oncelik) //yeni düğümün önceliğine sahip olan düğümü bul
                {

                    if (temp.ileri != null && temp.ileri.oncelik <= yeni.oncelik) //eşit seviyedeki düğümlerde son düğüme kadar ilerle yada sondaki düğümmü bak
                    {
                        temp = temp.ileri; //sondaki düğüm değilse ve öncelik aynı veya azsa ilerle
                    }
                    else
                    {
                        break;
                    }

                }
                yeni.ileri = temp.ileri;
                temp.ileri = yeni;
            }

        }
        public KargoDugum Dequeue()
        {
            KargoDugum temp;
            if (bas != null)
            {
                temp = bas;
                bas = bas.ileri;

                return temp;
            }
            return null;
        }

        public int say()
        {
            KargoDugum temp = bas;
            int sayac = 0;
            while (temp != null)
            {
                sayac++;
                temp = temp.ileri;
            }
            return sayac;
        }

    }
}
