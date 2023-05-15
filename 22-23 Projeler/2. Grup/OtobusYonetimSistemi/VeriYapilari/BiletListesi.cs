using VeriYapilari.Primitive;

namespace VeriYapilari;

public class BiletListesi : TekYonluBagliListe<BiletKonteyner>
{
    public new BiletKonteyner? Bas { get; set; }
    public BiletListesi()
    {
    }
}