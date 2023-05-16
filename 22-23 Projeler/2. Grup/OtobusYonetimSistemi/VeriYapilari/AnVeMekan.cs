namespace VeriYapilari;

public class AnVeMekan
{
    public Mekan Mekan { get; }

    public DateTime An { get; }

    public AnVeMekan(Mekan mekan, DateTime an)
    {
        Mekan = mekan;
        An = an;
    }
}