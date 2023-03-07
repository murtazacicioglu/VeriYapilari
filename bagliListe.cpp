#include<stdio.h>
#include<stdlib.h>

//Tek yönlü baðlý liste
//ADT -->  
//dugum tasarýmý
struct node{
	int data;
	struct node* ileri;
};
typedef struct node Node;
typedef Node* Nodeptr;

//Düðüm oluþutrma
Nodeptr newNode(int veri){
	Nodeptr node = (Nodeptr)malloc(sizeof(Node));
	node->data=veri;
	node->ileri=NULL;
	return node;
}

//liste tasarýmý
struct liste{
	Nodeptr bas;
	Nodeptr son;
};
typedef struct liste Liste;
typedef Liste* Listeptr;

//tek yönlü boþ baglý liste oluþturma
Listeptr newList(){
	Listeptr liste=(Listeptr)malloc(sizeof(Liste));
	liste->bas=NULL;
	liste->son=NULL;
	return liste;
}

//listenin baþýna eleman ekleme O(1)
void addHead(Listeptr liste, Nodeptr dugum){
	if(liste->son==NULL)
		liste->son=dugum;
	dugum->ileri=liste->bas;
	liste->bas=dugum;
}

//listenin sonuna ekleme
void addTailer(Listeptr liste, Nodeptr node){
	if(liste->bas==NULL)
		liste->bas=node;
	else
		liste->son->ileri=node;
	liste->son=node;
}

//listede istenilden bir düðümden sonra eleman ekleme O(1)
void addMiddle(Nodeptr prevNode, Nodeptr newNode){
	newNode->ileri=prevNode->ileri;
	prevNode->ileri=newNode;
}

//listenin eleman sayýsýný bulma
int listSize(Listeptr liste){
	Nodeptr temp=liste->bas;
	int sayac=0;
	while(temp){
		sayac++;
		temp=temp->ileri;
	}
	return sayac;
}

//listenin ortasýna eleman ekleme
void addMiddle2(Listeptr liste, Nodeptr node){
	Nodeptr temp=liste->bas;
	int boyut=listSize(liste);
	int middle=boyut/2-1;
	for(int i=0;i<middle;i++){
		temp=temp->ileri;
	}
	node->ileri=temp->ileri;
	temp->ileri=node;	
	//printf("ortasi %d \n", temp->data);
}

//listede eleman arama
Nodeptr listSearch(Listeptr liste, int value){
	Nodeptr temp=liste->bas;
	while(temp){
		if(temp->data==value)
			return temp;
		temp=temp->ileri;
	}
	return NULL;
}

//listeden istenilen sýradaki elemaný getiren fonk
Nodeptr listSearch2(Listeptr liste, int value){
	Nodeptr temp=liste->bas;
	for(int i=0; i<value; i++)
		temp=temp->ileri;
	//printf("x. eleman %d \n", temp->data);
	return temp;
}

//listenin baþýndan eleman silme
void removeHead(Listeptr liste){
	if(liste->bas != NULL)
		liste->bas=liste->bas->ileri;
	if(liste->bas == NULL)
		liste->son==NULL;
}

//listenin son elemaný silme
void removeTailer(Listeptr liste){
	Nodeptr temp, once;
	temp=liste->bas;
	once=NULL;
	while(temp->ileri!=NULL){
		once=temp;
		temp=temp->ileri;
	}
	//printf("neredeyim %d ", temp->data);
	if(once==NULL)
		liste->bas=NULL;
	else
		once->ileri=NULL;
	liste->son=once;
}

//listenin tam ortasýndaki elemaný silme
void removeMiddle(Listeptr liste){
	Nodeptr temp, once;
	temp=liste->bas;
	once=NULL;
	int middle=listSize(liste)/2;
	for(int i=0;i<middle;i++){
		once=temp;
		temp=temp->ileri;
	}
	//printf("neredeyim %d ", temp->data);
	once->ileri=temp->ileri;
}	
	
//listeyi yazdýr
void show(Listeptr liste){
	Nodeptr temp = liste->bas;
	while(temp){
		printf("%d --> ", temp->data);
		temp=temp->ileri;
	}
}
int main(){
	Nodeptr n1, n2, n3, n4, n5;
	n1=newNode(10);
	n2=newNode(20);
	n3=newNode(30);
	n4=newNode(40);
	n5=newNode(50);
	Listeptr liste1, liste2;
	liste1=newList();
	liste2=newList();
	addHead(liste1, n1);
	addHead(liste1, n2);
	addHead(liste1, n3);
	addTailer(liste1, n4);
	//addTailer(liste1, n5);
	//addMiddle(n1, n5); O(1)
	addMiddle2(liste1, n5);
	/*
	int sayi=listSize(liste1);
	printf("liste eleman sayisi: %d ", sayi);
	*/
	/*
	if(listSearch(liste1, 300))
		printf("Aranan dugum bulundu\n");
	else 
		printf("Aranan dugum bulunamadi\n");
	*/
	//listSearch2(liste1, 3);
	//removeHead(liste1);
	//removeTailer(liste1);
	removeMiddle(liste1);
	show(liste1);
	return 0;
}
