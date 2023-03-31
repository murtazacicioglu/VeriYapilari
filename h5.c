#include<stdio.h>
#include<stdlib.h>
/*
//Tek yonlu bagli liste
struct node{
	int data;
	struct node* ileri;
};	
typedef struct node Node;
typedef Node* Nodeptr;

//Dügüm olusutrma
Nodeptr newNode(int veri){
	Nodeptr node = (Nodeptr)malloc(sizeof(Node));
	node->data=veri;
	node->ileri=NULL;
	return node;
}

//stack bagli liste tasarimi
struct stack{
	Nodeptr bas;
};
typedef struct stack Stack;
typedef Stack* Stackptr;

//stack olusturma
Stackptr newStack(){
	Stackptr stack=(Stackptr)malloc(sizeof(Stack));
	stack->bas=NULL;
	return stack;
}

//stack basina eleman ekleme O(1)
void push(Stackptr stack, Nodeptr dugum){
	dugum->ileri=stack->bas;
	stack->bas=dugum;
}

//stack basindan eleman silme O(1)
Nodeptr pop(Stackptr stack){
	Nodeptr temp=stack->bas;
	stack->bas=stack->bas->ileri;
	return temp;
}

//stack eleman sayisina bulma
int stackSize(Stackptr stack){
	Nodeptr temp=stack->bas;
	int sayac=0;
	while(temp){
		sayac++;
		temp=temp->ileri;
	}
	return sayac;
}
	
//stack yazdir
void show(Stackptr stack){
	Nodeptr temp = stack->bas;
	while(temp){
		printf("%d --> ", temp->data);
		temp=temp->ileri;
	}
}

Nodeptr peek(Stackptr stack){
	return stack->bas;
} 
*/

//Tek yonlu dizi liste
struct node{
	int data;
};	
typedef struct node Node;
typedef Node* Nodeptr;

//Dügüm olusutrma
Nodeptr newNode(int veri){
	Nodeptr node = (Nodeptr)malloc(sizeof(Node));
	node->data=veri;
	return node;
}

//stack dizi tasarimi
struct stack{
	int bas;
	int boyut;
	Nodeptr* dizi;
};
typedef struct stack Stack;
typedef Stack* Stackptr;

//stack olusturma
Stackptr newStack(int boyut){
	Stackptr stack=(Stackptr)malloc(sizeof(Stack));
	stack->bas=-1;
	stack->boyut=boyut;
	stack->dizi=(Nodeptr)malloc(boyut*sizeof(Node));
	return stack;
}

//stack basina eleman ekleme O(1)
void push(Stackptr stack, Nodeptr dugum){
	if(stack->bas<stack->boyut-1){
		stack->bas++;
		stack->dizi[stack->bas]=dugum;
	}	
}

//stack basindan eleman silme O(1)
Nodeptr pop(Stackptr stack){
	if(stack->bas!=-1){
		stack->bas--;
		return stack->dizi[stack->bas+1];
	}	
}

//stack eleman sayisina bulma
int stackSize(Stackptr stack){
	
}

//duplicate, swap, birden fazla stack üzerinde aritmetiksel islemler yapabiliriz
	
//stack yazdir
void show(Stackptr stack){
	for(int i=0; i<=stack->bas; i++)
		printf("%d --> ", stack->dizi[i]->data);
}

Nodeptr peek(Stackptr stack){
	return stack->bas;
} 

int main(){
	Nodeptr n1, n2, n3, n4, n5;
	n1=newNode(10);
	n2=newNode(20);
	n3=newNode(30);
	n4=newNode(40);
	n5=newNode(50);
	Stackptr stack1;
	stack1=newStack();
	push(stack1, n1);
	push(stack1, n2);
	push(stack1, n3);
	show(stack1);
	pop(stack1);
	printf("\n ");
	show(stack1);
	printf("\n ");	
	printf("liste basindaki eleman: %d ", peek(stack1)->data);
	int sayi=stackSize(stack1);
	printf("\nliste eleman sayisi: %d ", sayi);
	//show(liste1);
	return 0;
}
