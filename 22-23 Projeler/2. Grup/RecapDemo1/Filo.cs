/*
 * Sabir Süleymanlı <suleymanli.sabir@anticverse.com>
 * 
 *  Helin Gül       <ihelin.gul@gmail.com>
 *  
 *  Filo.cs
 */
using System;

public class Class1
{
    /* şimdilik okey */
    public class Otobus
    {
        public int Numara { get; set; }           
        public string Hat { get; set; }
        public string Plaka { get; set; }
        public Otobus Sonraki { get; set; }
    }

    public class OtobusFilo
    {
        private Otobus Bas { get; set; }
        private Otobus Son { get; set; }

        /* Ekle Metodu */
        public void Ekle(Otobus otobus)
        {
            if (Bas == null)
            {
                Bas = otobus;
                Son = otobus;
            }
            else
            {
                Son.Sonraki = otobus;
                Son = otobus;
            }
        }

        /*Bulma Metodu*/
        public Otobus Bul(int otobusNumara)
        {
            Otobus current = Bas;
            while (current != null)
            {
                if (current.Numara == otobusNumara)
                    return current;
                current = current.Sonraki;
            }

            return null;
        }

        /* Listele Metodu */
        public void Listele()
        {
            Otobus current = Bas;
            while (current != null)
            {
                Console.WriteLine($"Otobüs Numarası: {current.Numara}, Hat: {current.Hat}, Plaka: {current.Plaka}");
                current = current.Sonraki;
            }
        }

        /* Filodan çıkarma Metodu */
        public void FilodanCikar(int otobusNumara)
        {
            if (Bas == null)
            {
                Console.WriteLine("Filo boş!");
                return;
            }

            if (Bas.Numara == otobusNumara)
            {
                Bas = Bas.Sonraki;
                if (Bas == null)
                    Son = null;
                Console.WriteLine($"Otobüs {otobusNumara} filodan çıkarıldı.");
                return;
            }

            Otobus current = Bas;
            Otobus onceki = null;
            while (current != null)
            {
                if (current.Numara == otobusNumara)
                {
                    onceki.Sonraki = current.Sonraki;
                    if (current == Son)
                        Son = onceki;
                    Console.WriteLine($"Otobüs {otobusNumara} filodan çıkarıldı.");
                    return;
                }
                onceki = current;
                current = current.Sonraki;
            }

            Console.WriteLine($"Otobüs {otobusNumara} filoda bulunamadı!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            OtobusFilo filo = new OtobusFilo();


            Otobus otobus1 = new Otobus { Numara = 1, Hat = "A", Plaka = "34 ABC 01" };
            Otobus otobus2 = new Otobus { Numara = 2, Hat = "B", Plaka = "34 DEF 02" };
            Otobus otobus3 = new Otobus { Numara = 3, Hat = "C", Plaka = "34 GHI 03" };

            filo.Ekle(otobus1);
            filo.Ekle(otobus2);
            filo.Ekle(otobus3);


            Console.WriteLine("Filodaki Otobüsler:");
            filo.Listele();


            int cikarilacakNumara = 2;
            filo.FilodanCikar;
    
}
