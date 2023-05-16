using VeriYapilari.Primitive;

namespace VeriYapilari;

public class BiletKonteyner : TekYonluDugum<Bilet>
{
    public Bilet? Bilet { get; set; }

    public new BiletKonteyner? Siradaki { get; set; }

    public BiletKonteyner(Bilet bilet) : base(bilet)
    {
        Bilet = bilet;
    }
}