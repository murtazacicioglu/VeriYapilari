namespace VeriYapilari.Primitive;
    
public class TekYonluStringDugumu
{
    public string Deger { get; set; }

    public TekYonluStringDugumu? Siradaki { get; set; }

    public TekYonluStringDugumu(string deger)
    {
        Deger = deger;
    }
}