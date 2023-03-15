using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta4
{
    //Çift yönlü bağlı liste 
    public class node
    {
        public int veri;
        public node ileri;
        public node geri;
        public node(int veri)
        {
            this.veri = veri;
            ileri = null;
            geri = null;
        }
    }
    public class cbListe
    {
        public node bas;
        public node son;
        public cbListe()
        {
            bas = null;
            son=null;
        }
        public void basaEkle(node yeni)
        {
            if(son==null)
                son= yeni;
            else
                bas.geri = yeni;
            yeni.ileri = bas;
            yeni.geri = null;
            bas =yeni;
        }
        public void sonaEkle(node yeni)
        {
            if(bas==null)
                bas= yeni;
            else
                son.ileri= yeni;
            yeni.geri= son;
            son = yeni;
        }
        public void ortayaEkle(node yeni)
        {
            int sayac=say() / 2;
            node temp = bas;
            for (int i = 0; i < sayac; i++)
                temp = temp.ileri;
            yeni.ileri = temp.ileri;
            temp.ileri.geri = yeni;
            yeni.geri = temp;
            temp.ileri = yeni;
        }
        public void ortayaEkle2(node yeni, node once)
        {
            yeni.ileri = once.ileri;
            once.ileri.geri = yeni;
            yeni.geri = once;
            once.ileri = yeni;
        }

        public void bastanSil()
        {
            bas = bas.ileri;
            if (bas == null)
                son = null;
            else
                bas.geri = null;
        }
        public void sondanSil()
        {
            son = son.geri;
            if (son == null)
                bas = null;
            else
                son.ileri = null;
        }
        public void ortayaSil()
        {
            int sayac = say() / 2;
            node temp = bas;
            for (int i = 0; i < sayac; i++)
                temp = temp.ileri;
            temp.ileri.geri = temp.geri;
            temp.geri.ileri= temp.ileri;
        }

        public void ortadanSil2(node d)
        {
            d.ileri.geri = d.geri;
            d.geri.ileri = d.ileri;
        }

        public int say()
        {
            node temp = bas;
            int sayac = 0;
            while (temp != null)
            {
                sayac++;
                temp = temp.ileri;
            }
            return sayac;
        }
        public void yaz()
        {
            node temp = bas;
            while (temp != null)
            {
                Console.Write(temp.veri + " - ");
                temp = temp.ileri;
            }
        }
    }

    public class daireListe
    {
        node bas;
        public daireListe()
        {
            bas = null;
        }
        public void ekle(node yeni)
        {
            if (bas != null)
            {
                yeni.ileri = bas;
                yeni.geri = bas.geri;
                bas.geri.ileri = yeni;
                bas.geri = yeni;
                bas = yeni;
            }
            else
            {
                bas = yeni;
                yeni.ileri = yeni;
                yeni.geri = yeni;
            }
            
        }
        public void sil()
        {
            if(bas.ileri==bas) //1 eleman varsa
            {
                bas = null;
            }
            else
            {
                bas.geri.ileri = bas.ileri;
                bas.ileri.geri = bas.geri;
                bas = bas.ileri;
            }
            
        }
        public void yaz()
        {
            node temp = bas;
            while (temp != null)
            {
                Console.Write(temp.veri + " - ");
                temp = temp.ileri;
                if (temp == bas)
                    break;
            }
        }
        public int say()
        {
            node temp = bas;
            int sayac = 1;
            while (temp.ileri != bas)
            {
                sayac++;
                temp = temp.ileri;
            }
            return sayac;
        }
    }

    public class pnode
    {
        public int katsayi, us;
        public pnode ileri;
        public pnode(int katsayi, int us)
        {
            this.katsayi = katsayi;
            this.us = us;
            ileri = null;
        }
    }
    public class liste
    {
        pnode bas;
        pnode son;
        public liste() {
            bas = null;
            son = null;
        }
        public void basaEkle(pnode yeni)
        {
            if(son==null)
                son= yeni;
            yeni.ileri = bas;
            bas = yeni;
        }
        public void sonaEkle(pnode yeni)
        {
            if (bas == null)
                bas = yeni;
            else
                son.ileri = yeni;
            son = yeni;
        }
        public void listele()
        {
            pnode temp = bas;
            while (temp != null)
            {
                Console.Write(temp.katsayi + "*x^" + temp.us + " ");
                temp = temp.ileri;
            }
            Console.WriteLine("");
        }
        public liste topla(liste l1, liste l2)
        {
            pnode temp1 = l1.bas;
            pnode temp2 = l2.bas;
            pnode node;
            int katsayi, us;
            liste yeniListe=new liste();
            while (temp1 != null && temp2  != null) {
                if(temp1.us == temp2.us)
                {
                    katsayi = temp1.katsayi + temp2.katsayi;
                    us=temp1.us;
                    temp1 = temp1.ileri;
                    temp2= temp2.ileri;
                }
                else
                {
                    if (temp1.us > temp2.us)
                    {
                        katsayi = temp1.katsayi;
                        us=temp1.us;
                        temp1 = temp1.ileri;
                    }
                    else
                    {
                        katsayi = temp2.katsayi;
                        us = temp2.us;
                        temp2 = temp2.ileri;
                    } 
                }
                if (katsayi != 0)
                {
                    node = new pnode(katsayi, us);
                    yeniListe.sonaEkle(node);
                }
            }
            pnode temp3;
            if (temp1 == null)
                temp3 = temp2;
            else
                temp3 = temp1;
            while (temp3 != null)
            {
                node = new pnode(temp3.katsayi, temp3.us);
                yeniListe.sonaEkle(node);
                temp3 = temp3.ileri;
            }
            return yeniListe;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            pnode n1 = new pnode(5, 2);
            pnode n2 = new pnode(7, 1);
            pnode n3 = new pnode(3, 0);
            liste l1 =new liste();
            l1.sonaEkle(n1);
            l1.sonaEkle(n2);
            l1.sonaEkle(n3);
            liste l2=new liste();
            pnode n4 = new pnode(8, 2);
            pnode n5 = new pnode(5, 1);
            pnode n6 = new pnode(1, 0);
            l1.listele();
            l2.sonaEkle(n4);
            l2.sonaEkle(n5);
            //l2.sonaEkle(n6);
            l2.listele();
            liste l3=new liste();
            l3=l3.topla(l1, l2);
            l3.listele();

            /*
            node n1 = new node(10);
            node n2 = new node(20);
            node n3 = new node(30);
            node n4 = new node(40);
            //cbListe liste1= new cbListe();
            //liste1.basaEkle(n1);
            //liste1.basaEkle(n2);
            //liste1.sonaEkle(n1);
            //liste1.sonaEkle(n2);
            //liste1.sonaEkle(n3);
            //Console.WriteLine(liste1.say());
            //liste1.ortayaEkle(n4);
            //liste1.ortayaEkle2(n4, n2);
            //liste1.bastanSil();
            //liste1.sondanSil();
            //liste1.ortayaSil();
            //liste1.yaz();
            daireListe dliste1=new daireListe();
            dliste1.ekle(n1);
            dliste1.ekle(n2);
            dliste1.ekle(n3);
            //dliste1.sil();
            dliste1.yaz();
            Console.WriteLine("\n");
            Console.WriteLine(dliste1.say());*/
            Console.ReadKey();
        }
    }
}
