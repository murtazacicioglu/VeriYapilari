#include <stdio.h>
#include <stdlib.h>
struct dugum{
 int veri;
 struct dugum* ileri;	
};
typedef struct dugum Dugum;
typedef Dugum* Dugump;


int main()
{
	Dugum dugum1;	
	Dugump dugump;
	dugump=(Dugump)malloc(sizeof(Dugum));
	dugump->veri=10;
	dugump->ileri=(Dugump)malloc(sizeof(Dugum));
	dugump->ileri->veri=20;
	dugump->ileri->ileri=(Dugump)malloc(sizeof(Dugum));
	dugump->ileri->ileri->veri=30;
	dugump->ileri->ileri->ileri=NULL;
	Dugump temp=dugump;
	/*
	for(int i=0;i<3;i++)
	{
		printf("%d ", temp->veri);
		temp=temp->ileri;
	}*/
	while(temp->ileri!=NULL)
	{
		//printf("%d ", temp->veri);
		temp=temp->ileri;
	}
	for(int i=0;i<4;i++)
	{
		temp->ileri=(Dugump)malloc(sizeof(Dugum));
		temp=temp->ileri;
		temp->veri=i;
		temp->ileri=NULL;
	}
	while(dugump!=NULL)
	{
		printf("%d ", dugump->veri);
		dugump=dugump->ileri;
	}
	//printf("%d ", temp->veri);
	return 0;
}
