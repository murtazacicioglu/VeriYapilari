namespace VeriYapilari.Primitive;

public class TekYonluBagliListe<T>
{

    public TekYonluDugum<T>? Bas { get; set; }

    public void Ekle(T deger)
    {
        if (Bas == null)
            Bas = new TekYonluDugum<T>(deger);
        else
        {
            TekYonluDugum<T>? sonDugum = Bas;
            while (sonDugum.Siradaki != null)
            {
                sonDugum = sonDugum.Siradaki;
            }
            sonDugum.Siradaki = new TekYonluDugum<T>(deger);
        }
    }
    
    public void Sil(T deger)
    {
        if (Bas == null)
        {
            return;
        }
        else if (Bas.Deger.Equals(deger))
        {
            Bas = Bas.Siradaki;
        }
        else
        {
            TekYonluDugum<T>? sonDugum = Bas;
            while (sonDugum.Siradaki != null)
            {
                if (sonDugum.Siradaki.Deger.Equals(deger))
                {
                    sonDugum.Siradaki = sonDugum.Siradaki.Siradaki;
                    return;
                }
                sonDugum = sonDugum.Siradaki;
            }
        }
    }
    public void TersCevir()
    {
        TekYonluDugum<T>? onceki = null;
        TekYonluDugum<T>? simdiki = Bas;
        TekYonluDugum<T>? sonraki;
        while (simdiki != null)
        {
            sonraki = simdiki.Siradaki;
            simdiki.Siradaki = onceki;
            onceki = simdiki;
            simdiki = sonraki;
        }
        Bas = onceki;
    }
}