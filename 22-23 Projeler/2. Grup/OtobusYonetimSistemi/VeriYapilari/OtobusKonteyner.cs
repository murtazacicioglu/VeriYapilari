using VeriYapilari.Primitive;

namespace VeriYapilari;

public class OtobusKonteyner : TekYonluDugum<Otobus>
{
    public string? ID => Otobus?.ID;
    public Otobus? Otobus { get; set; }
    public new OtobusKonteyner? Siradaki { get; set; }

    public OtobusKonteyner(Otobus otobus) : base(otobus)
    {
        Otobus = otobus;
    }
}