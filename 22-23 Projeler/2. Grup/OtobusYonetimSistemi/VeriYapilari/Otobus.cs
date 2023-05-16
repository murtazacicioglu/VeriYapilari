using VeriYapilari.Primitive;

namespace VeriYapilari;

public class Otobus
{
    public string ID;
    public Sefer Sefer;
    public int KoltukSayisi { get; }
    public Agac bos_koltuklar;
    public Agac dolu_koltuklar;

    public Otobus(string plaka, Sefer guzergah, int koltukSayisi)
    {
        ID = plaka;
        KoltukSayisi = koltukSayisi;
        Sefer = guzergah;
        bos_koltuklar = new Agac();
        dolu_koltuklar = new Agac();

        for (int i = 1; i <= koltukSayisi; i++) // Boş koltuk ağacının dolduruyoruz.
            bos_koltuklar.Insert(i);
    }

    public void BiletAl(int koltukNo)
    {
        if (bos_koltuklar.Search(koltukNo))
        {
            bos_koltuklar.Delete(koltukNo);
            dolu_koltuklar.Insert(koltukNo);
        }
        else
            throw new ArgumentException("Almaya çalıştığınız bu koltuk zaten dolu!");
    }

    public void BiletSil(int koltukNo)
    {
        if (dolu_koltuklar.Search(koltukNo))
        {
            dolu_koltuklar.Delete(koltukNo);
            bos_koltuklar.Insert(koltukNo);
        }
        else
            throw new ArgumentException("Silmeye çalıştığınız bu koltuk zaten boş!");
    }
}