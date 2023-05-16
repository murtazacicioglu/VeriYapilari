using VeriYapilari;
using VeriYapilari.Primitive;

var m1 = new Mekan("Ankara");
var m2 = new Mekan("İstanbul");
var m3 = new Mekan("İzmir");
var m4 = new Mekan("Antalya");
var m5 = new Mekan("Bursa");
var m6 = new Mekan("Konya");
var m7 = new Mekan("Samsun");

var d1 = new DateTime(2023, 6, 12, 12, 30, 00);
var d2 = new DateTime(2023, 6, 12, 13, 30, 00);


var o1 = new OtobusKonteyner(new Otobus("16 FYB 01", new Sefer(new AnVeMekan(m5, d1), new AnVeMekan(m2, d2)), 60));
o1.Otobus.BiletAl(1);
var b = new Bilet("ferit", "0321", 1, true, "", o1.Otobus, o1.Otobus.Sefer);

var otobusler = new OtobusListesi();


otobusler.Ekle(o1);
otobusler.Ekle(o1);
otobusler.Ekle(o1);