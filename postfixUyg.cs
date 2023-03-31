namespace ConsoleApp7{
    //postfix gösterimi verilen bir ifadenin değerini hesapla
    
	public class dugum{
        public int tip;
        public int islenen;
        public char islem;
        public int oncelik;
        public dugum(int islenen){
            this.tip = 0;
            this.islenen = islenen;}
			
        public dugum(char islem){
            this.tip = 1;
            this.islem = islem;
            switch (islem){
                case '(': oncelik = 0;break;
                case '+':
                case '-': oncelik=1; break;
                case '*':
                case '/': oncelik = 2; break;
                case ')': oncelik = 3; break;
				}}}

    public class stack{
        public dugum[] dizi;
        public int ust;
        public int boyut;
		
        public stack(int boyut){
            dizi = new dugum[boyut];
            this.boyut = boyut;
            ust = -1;}
			
        public dugum peek(){
            return dizi[ust];}
			
        Boolean dolu(){
            if (ust == boyut - 1)
                return true;
            else
                return false;}
			
        Boolean bos(){
            if (ust == - 1)
                return true;
            else
                return false;}

        public void push(dugum yeni){
            if (!dolu()){
                ust++;
                dizi[ust] = yeni;}}
				
        public dugum pop(){
            if (!bos()){
                ust--;
                return dizi[ust+1];}
            return null;}
			
        public dugum top(){
            return dizi[ust];}
			
        public void listele(){
            int sayac = ust;
            while (sayac != -1){
                Console.WriteLine("listele: " + dizi[sayac].islenen);
                sayac--;}}
				
        public int hesapla(dugum[] ifade){
            dugum e, e1, e2, s;
            stack st=new stack(100);
            for (int i = 0; i < ifade.Length; i++){
                e = ifade[i];
                if (e.tip == 0)
                    st.push(e);
                else{
                    e2 = st.pop();
                    e1 = st.pop();
                    s=islem(e.islem, e1.islenen, e2.islenen);
                    st.push(s);}}
            e = st.pop();
            return e.islenen;}
			
        public dugum islem(char ch, int e1, int e2){
            int sonuc=0;
            switch (ch){
                case '+':sonuc=e1+e2; break;
                case '-':sonuc=e1-e2; break;
                case '*':sonuc=e1*e2; break;
                case '/':sonuc=e1/e2; break;}
            return new dugum(sonuc);}}
//***************************MAIN
    internal class Program{
        static void Main(string[] args){
            //    postfix ifade 42/1-23*+2*
            dugum[] d1 = new dugum[11];
            d1[0] = new dugum(4);
            d1[1] = new dugum(2);
            d1[2] = new dugum('/');
            d1[3] = new dugum(1);
            d1[4] = new dugum('-');
            d1[5] = new dugum(2);
            d1[6] = new dugum(3);
            d1[7] = new dugum('*');
            d1[8] = new dugum('+');
            d1[9] = new dugum(2);
            d1[10] = new dugum('*');
            stack s1 = new stack(100);
            s1.push(d1[0]);
            s1.push(d1[1]);
            s1.push(d1[2]);
            //s1.listele();
            //s1.hesapla(d1);
            Console.WriteLine(s1.hesapla(d1));
            Console.ReadKey(); }}}
