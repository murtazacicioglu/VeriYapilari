// AVL TREE YAPISI

/*

    2022-2023 ULUDAĞ ÜNİVERSİTESİ
    BİLGİSAYAR MÜHENDİSLİĞİ
    VERİ YAPILARI DERSİ
    PROJE ÖDEVİ

    031890011	SALİH ALBAYRAK
    031990047	ABDUSSAMET HADANOĞLU
    031990102	SAMİ CİHAN AKSU
    032090089	SAMİ NECCAR
    032090127	DURSUN EREN ÖZTÜRK
    032190140	ERDEM ZAFER
    032290090	HASAN BASRİ POLAT
    032290103	HASAN KALKAN
    032290104	ONUR POLAT
    032290105	TANER MÜFTÜOĞLU
    032290106	EMRE AYDEMİR
  
 */

namespace OnlineSatisPlatformu.ProductClasses
{

    public class clsProduct
    {
        public string Ad;
        public string Kategori;
        public float Fiyat;
        public string Marka;
        public int status = 0;

        public clsProduct(string Ad, float Fiyat, string Kategori, string Marka)
        {
            this.Ad = Ad;
            this.Fiyat = Fiyat; 
            this.Kategori = Kategori;  
            this.Marka = Marka;
            this.status = 0;
        }
    }

    public class clsProductNode
    {
        public clsProduct Veri;
        public int Height;
        public clsProductNode Left;
        public clsProductNode Right;

       


        public clsProductNode(clsProduct Veri)
        {
            this.Veri = Veri;
            Left = null;
            Right = null;
            this.Height = 1;
        }
    }

    public class ProductAVLTree
    {
        public clsProductNode root;
        public int count = 0;
        public int ind=0;

        public clsProduct[] serial;

        public ProductAVLTree(clsProductNode root)
        {
            this.root = root;
            count = 0;
        }   


        public ProductAVLTree Filter(string search)
        {
            clsProduct[] x;
            ProductAVLTree ret = new ProductAVLTree(null);

            x = InOrder();

            for(int i=0;i<count;i++)
            {
                bool ek = false;
                // FİLTRELEMEDE SIKINTI VAR KATEGORİ = BUZDOLABI İKEN

                ek = x[i].Ad.Contains(search);
                ek = ek || x[i].Marka.Contains(search);
                if (ek) { ret.Ekle(x[i]); }
            }
            return ret;
        }


        private int Yukseklik(clsProductNode node)
        {
            if (node == null)
                return 0;

            return node.Height;
        }

        private int Denge(clsProductNode node)
        {
            if (node == null)
                return 0;

            return Yukseklik(node.Left) - Yukseklik(node.Right);
        }

        private clsProductNode SagaDondur(clsProductNode y)
        {
            clsProductNode x = y.Left;
            clsProductNode T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Math.Max(Yukseklik(y.Left), Yukseklik(y.Right)) + 1;
            x.Height = Math.Max(Yukseklik(x.Left), Yukseklik(x.Right)) + 1;
            return x;
        }

        private clsProductNode SolaDondur(clsProductNode x)
        {
            clsProductNode y = x.Right;
            clsProductNode T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Math.Max(Yukseklik(x.Left), Yukseklik(x.Right)) + 1;
            y.Height = Math.Max(Yukseklik(y.Left), Yukseklik(y.Right)) + 1;

            return y;
        }

        private clsProductNode KucukNode(clsProductNode node)
        {
            clsProductNode current = node;

            while (current.Left != null)
                current = current.Left;

            return current;
        }

        public void Ekle(clsProduct veri)
        {
            if(root == null)
            {
                root = new clsProductNode(veri);
                count = 1;
                return;
            }

            this.root = Ekle(this.root, veri);
            count++;
        }

        private clsProductNode Ekle(clsProductNode node, clsProduct veri)
        {
            if (node == null)
                return new clsProductNode(veri);

            if (veri.Fiyat < node.Veri.Fiyat)
                node.Left = Ekle(node.Left, veri);
            else if (veri.Fiyat > node.Veri.Fiyat)
                node.Right = Ekle(node.Right, veri);
            else
                return node;

            node.Height = 1 + Math.Max(Yukseklik(node.Left), Yukseklik(node.Right));

            int deng = Denge(node);

            if (deng > 1 && veri.Fiyat < node.Left.Veri.Fiyat)
                return SagaDondur(node);

            if (deng < -1 && veri.Fiyat > node.Right.Veri.Fiyat)
                return SolaDondur(node);

            if (deng > 1 && veri.Fiyat > node.Left.Veri.Fiyat)
            {
                node.Left = SolaDondur(node.Left);
                return SagaDondur(node);
            }

            if (deng < -1 && veri.Fiyat < node.Right.Veri.Fiyat)
            {
                node.Right = SagaDondur(node.Right);
                return SolaDondur(node);
            }

            return node;
        }

        public void Sil(clsProduct veri)
        {
            this.root = Sil(this.root, veri);
            count--;
            if (root == null) count = 0;

        }

        private clsProductNode Sil(clsProductNode node, clsProduct veri)
        {
            if (node == null)
                return node;

            if (veri.Fiyat < node.Veri.Fiyat)
            {
                node.Left = Sil(node.Left, veri);
            }
            else if (veri.Fiyat > node.Veri.Fiyat)
            {
                node.Right = Sil(node.Right, veri);
            }
            else
            {
                if ((node.Left == null) || (node.Right == null))
                {
                    clsProductNode temp = null;

                    if (temp == node.Left)
                        temp = node.Right;
                    else
                        temp = node.Left;

                    if (temp == null)
                    {
                        temp = node;
                        node = null;
                    }
                    else
                    {
                        node = temp;
                    }
                }
                else
                {
                    clsProductNode temp = KucukNode(node.Right);
                    node.Veri = temp.Veri;
                    node.Right = Sil(node.Right, temp.Veri);
                }
            }

            if (node == null)
                return node;

            node.Height = 1 + Math.Max(Yukseklik(node.Left), Yukseklik(node.Right));

            int balance = Denge(node);

            if (balance > 1 && Denge(node.Left) >= 0)
                return SagaDondur(node);


            if (balance > 1 && Denge(node.Left) < 0)
            {
                node.Left = SolaDondur(node.Left);
                return SagaDondur(node);
            }

            if (balance < -1 && Denge(node.Right) <= 0)
            {
                return SolaDondur(node);
            }

            if (balance < -1 && Denge(node.Right) > 0)
            {
                node.Right = SagaDondur(node.Right);
                return SolaDondur(node);
            }

            return node;
        }

        public clsProduct[] InOrder()
        {
            serial = new clsProduct[count];
            ind = 0;
            //Console.Write("*" + root.Veri.Ad + "* ");
            InOrder(this.root);
            return serial;
        }

        private void InOrder(clsProductNode node) // ARTAN SIRALAMA
        {
            if (node != null)
            {
                InOrder(node.Left);
                serial[ind++] = node.Veri;
                Console.Write(node.Veri.Ad + " - ");
                InOrder(node.Right);
            }
        }

        public clsProduct[] Azalan()    // AZALAN SIRALAMA
        {
            serial = new clsProduct[count];
            ind = 0;
            Console.Write("*" + root.Veri.Ad + "* ");
            Azalan(this.root);
            return serial;
        }

        private void Azalan(clsProductNode node)
        {
            if (node != null)
            {
                Azalan(node.Right);
                serial[ind++] = node.Veri;
                Console.Write(node.Veri.Ad + " - ");
                Azalan(node.Left);

            }
        }
    
        public clsProduct Min()
        {
            clsProductNode current = root;
            while (current.Left != null)
                current = current.Left;
            return current.Veri;
        }

        public clsProduct Max()
        {
            clsProductNode current = root;
            while (current.Right!= null)
                current = current.Right;
            return current.Veri;
        }

    }
}
