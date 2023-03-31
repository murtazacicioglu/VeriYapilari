using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta5
{
    public class node
    {
        public int operand;
        public char islem;
        public int tip;
        public int oncelik;
        public node(int operand) {
            this.tip= 0;
            this. operand = operand;
        }
        public node(char islem)
        {
            this. islem = islem;
            this. tip = 1;
            switch (islem)
            {
                case'(':oncelik = 0; break;
                case'+':
                case '-':  oncelik = 1; break;
                case '*':
                case '/': oncelik = 2; break;
                case ')': oncelik = 3; break;
            }
        }
    }
    public class stack
    {
        public int bas;
        public int boyut;
        public node[] dizi;

        public stack(int boyut)
        {
            dizi=new node[boyut];
            this.boyut = boyut;
            bas = -1;
        }

        public void push(node yeni)
        {
            if(bas != boyut - 1)
            {
                bas++;
                dizi[bas] = yeni;
            }            
        }
        public node pop()
        {
            if (bas != -1)
            {
                bas--;
                return dizi[bas + 1];
            }
            return null;
        }
        public void show()
        {
            for (int i = 0; i < bas; i++)
                Console.WriteLine(" " + dizi[i].operand);
        }

        public int hesapla(node[] ifade)
        {
            node x, x1, x2, sonuc;
            stack temp = new stack(100);
            for (int i = 0; i < ifade.Length; i++)
            {
                x = ifade[i];
                if (x.tip == 0)
                    temp.push(x);
                else
                {
                    x1=temp.pop();
                    x2=temp.pop();
                    sonuc = islem(x.islem, x1.operand, x2.operand);
                    temp.push(sonuc);
                }
            }
            x=temp.pop();   
            return x.operand;
        } 
        public node islem(char islem, int x1, int x2)
        {
            int sonuc = 0;
            switch (islem)
            {
                case '+': sonuc = x1+ x2; break;
                case '-': sonuc = x1- x2; break;
                case '/': sonuc = x1/ x2; break;
                case '*': sonuc = x1* x2; break;
            }
            return new node(sonuc);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*node n1 = new node(10);
            node n2 = new node('+');
            stack s1 = new stack(10);
            s1.push(n1);
            s1.push(n2);*/
            // postfix 42/1-23*+2*  --> sonucu
            node[] d1=new node[5];
            d1[0]=new node(8);
            d1[1]=new node(4);
            d1[2] = new node(2);
            d1[3]=new node('+');
            d1[4]=new node('*');
            stack s1 = new stack(100);
            s1.push(d1[0]);
            s1.push(d1[1]);
            s1.push(d1[2]);
            //s1.show();
            Console.WriteLine("Sonuc: " + s1.hesapla(d1));
            Console.ReadKey();
        }
    }
}
