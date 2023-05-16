namespace VeriYapilari.Primitive;

public class AgacDugumu
{
    public int Deger { get; set; }
    public AgacDugumu? Sol { get; set; }
    public AgacDugumu? Sag { get; set; }

    public AgacDugumu(int deger)
    {
        Deger = deger;
        Sol = null;
        Sag = null;
    }
}
