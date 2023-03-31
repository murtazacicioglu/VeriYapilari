#include<stdio.h>
#include<stdlib.h>

//kuyruktaki dugumlerin tasarimi
struct node{
	int data;
	struct node* ileri;
};
typedef struct node Node;
typedef Node* Nodeptr;

//Bir Dügüm olusturma
Nodeptr newNode(int veri){
	Nodeptr node = (Nodeptr)malloc(sizeof(Node));
	node->data=veri;
	node->ileri=NULL;
	return node;
}

//kuyruk tasarimi
struct kuyruk{
	Nodeptr bas;
	Nodeptr son;
};
typedef struct kuyruk Kuyruk;
typedef Kuyruk* Kuyrukptr;

//Bir kuyruk olusturma
Kuyrukptr newQueue(){
	Kuyrukptr k=(Kuyrukptr)malloc(sizeof(Kuyruk));
	k->bas=NULL;
	k->son=NULL;
	return k;
}

//kuyruk eleman ekleme
void enqueue(Kuyrukptr k, Nodeptr node){
	if(k->bas==NULL)
		k->bas=node;
	else
		k->son->ileri=node;
	k->son=node;
}

int isEmpty(Kuyrukptr k){
	return size(k);
}

//kuyruktan eleman silme
Nodeptr dequeue(Kuyrukptr k){
	Nodeptr temp=k->bas;
	if(isEmpty(k)){
		k->bas=k->bas->ileri;
		if(k->bas==NULL)
			k->son=NULL;
	}
	return temp;
}

//kuyruk eleman sayisini bulma
int size(Kuyrukptr k){
	Nodeptr temp=k->bas;
	int sayac=0;
	while(temp){
		sayac++;
		temp=temp->ileri;
	}
	return sayac;
}

//kuyruk yazdir
void show(Kuyrukptr k){
	Nodeptr temp = k->bas;
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
	Kuyrukptr kuyruk1;
	kuyruk1=newQueue();
	enqueue(kuyruk1, n1);
	enqueue(kuyruk1, n2);
	enqueue(kuyruk1, n3);
	dequeue(kuyruk1);
	enqueue(kuyruk1, n4);
	dequeue(kuyruk1);
	dequeue(kuyruk1);
	show(kuyruk1);
	return 0;
}
