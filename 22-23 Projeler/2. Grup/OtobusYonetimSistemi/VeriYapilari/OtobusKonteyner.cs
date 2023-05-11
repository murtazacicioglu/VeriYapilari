namespace VeriYapilari;

public class OtobusKonteyner
{
    public string? ID => Otobus?.ID;
    public Otobus? Otobus { get; set; }
    public OtobusKonteyner? Siradaki { get; set; }
}