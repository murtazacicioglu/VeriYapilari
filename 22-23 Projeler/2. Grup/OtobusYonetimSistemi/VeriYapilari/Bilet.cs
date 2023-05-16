namespace VeriYapilari;

public class Bilet
{
	public int ID { get; set; }
	public string KisiAdSoyad { get; set; }
	public string KimlikNo { get; set; }
	public bool Cinsiyet { get; set; }
	public string EpostaAdresi { get; set; }
	public Otobus Otobus { get; set; }
	public Sefer Sefer { get; set; }


	public Bilet(string kisiAdSoyadi, string kimlikNo, int biletID, bool cinsiyet, string epostaAdresi, Otobus otobus, Sefer sefer)
	{
		KisiAdSoyad = kisiAdSoyadi;
        KimlikNo = kimlikNo;
        ID = biletID;
        Cinsiyet = cinsiyet;
        EpostaAdresi = epostaAdresi;
        Otobus = otobus;
        Sefer = sefer;
	}
}
