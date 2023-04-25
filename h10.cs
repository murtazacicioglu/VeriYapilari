  internal class Program
    {
        public class eleman {
            public int oncelik;
            public int ad;
            //attribute
            public eleman(int oncelik, int ad)
            {
                this.oncelik = oncelik;
                this.ad = ad;
            }
        }

        public class maxHeap {
            public eleman[] dizi;
            public int boyut;
            public int sayac;
            public maxHeap(int boyut) { 
                dizi= new eleman[boyut];
                this.sayac = 0;
            }

            public int findMax()
            {
                return dizi[0].ad;
            }

            public int size()
            {
                return sayac;
            }

            public void insert(eleman yeni)
            {
                sayac++;
                dizi[sayac-1]= yeni;
                nodeUp(sayac - 1);
            }

            public void nodeUp(int no)
            {
                int parent = (no - 1) / 2;
                while(parent>=0 && dizi[parent].oncelik < dizi[no].oncelik)
                {
                    int temp = dizi[parent].oncelik;
                    dizi[parent].oncelik = dizi[no].oncelik;
                    dizi[no].oncelik = temp;
                    no = parent;
                    parent = (no - 1) / 2;
                }
            }

            public int isEmpty()
            {
                if (sayac == 0)
                    return 1;
                else 
                    return 0;

            }
            public eleman delMax()
            {
                eleman temp = dizi[0];
                dizi[0] = dizi[sayac - 1];
                sayac--;
                nodeDown(0) ;
                return temp;
            }
            
            public void nodeDown(int no)
            {
                int sol = 2 * no + 1;
                int sag = 2 * no + 2;
                while ((sol<sayac && dizi[no].oncelik < dizi[sol].oncelik) || 
                    (sag < sayac && dizi[no].oncelik < dizi[sag].oncelik))
                {
                    if(dizi[no].oncelik < dizi[sol].oncelik)
                    {
                        int temp = dizi[no].oncelik;
                        dizi[no].oncelik = dizi[sol].oncelik;
                        dizi[sol].oncelik = temp;
                        no = sol;
                    }
                    else
                    {
                        int temp = dizi[no].oncelik;
                        dizi[no].oncelik = dizi[sag].oncelik;
                        dizi[sag].oncelik = temp;
                        no = sag;
                    }
                     sol = 2 * no + 1;
                     sag = 2 * no + 2;
                }

            }
            public void show()
            {
                for (int i = 0; i < sayac; i++)
                    Console.Write(dizi[i].oncelik + " ");
                Console.WriteLine("");
            }

            public int search(int key)
            {
                for (int i = 0; i < sayac; i++)
                {
                    if (dizi[i].ad==key)
                        return i;
                }
                return -1;
            }
        }


        static void Main(string[] args)
        {
            maxHeap h1 = new maxHeap(20);
            h1.insert(new eleman(10,10));
            h1.show();
            h1.insert(new eleman(15,15));
            h1.show();
            h1.insert(new eleman(8,8));
            h1.show();
            h1.insert(new eleman(1,1));
            h1.show();
            h1.insert(new eleman(30,30));
            h1.show();
            h1.delMax();
            h1.show();
            h1.delMax();
            h1.show();
            Console.ReadKey();
        }
    }
}
