namespace VeriYapilari;

public class Sefer
{
    public AnVeMekan Kalkis { get; set; }

    public AnVeMekan Varis { get; set; }

    public Sefer(AnVeMekan kalkis, AnVeMekan varis)
    {
        Kalkis = kalkis;
        Varis = varis;
    }
}