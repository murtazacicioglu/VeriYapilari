using VeriYapilari.Primitive;

namespace VeriYapilari;

public class Mekan : TekYonluDugum<string>
{
    public string Isim { get; set; }
    public new Mekan? Siradaki { get; set; }

    public Mekan(string deger) : base(deger)
    {
        Isim = deger;
    }
}