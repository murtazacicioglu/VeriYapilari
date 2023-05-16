using VeriYapilari.Primitive;

namespace VeriYapilari;


public class OtobusListesi : TekYonluBagliListe<OtobusKonteyner>
{
    public new OtobusKonteyner? Bas { get; set; }

    public OtobusListesi()
    {

    }
}