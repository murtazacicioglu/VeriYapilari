namespace VeriYapilari.Primitive;

public class TekYonluDugum<T>
{
    public T Deger { get; set; }

    public TekYonluDugum<T>? Siradaki { get; set; }

    public TekYonluDugum(T deger)
    {
        Deger = deger;
    }
}