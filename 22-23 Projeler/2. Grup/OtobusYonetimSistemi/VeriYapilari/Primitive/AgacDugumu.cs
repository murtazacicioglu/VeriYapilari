namespace VeriYapilari.Primitive;

public class AgacDugumu
{
    public int value;
    public AgacDugumu? left;
    public AgacDugumu? right;

    public AgacDugumu(int value)
    {
        this.value = value;
        left = null;
        right = null;
    }
}