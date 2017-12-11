//Автор: Варанкин Владимир

// 9. Даны целые положительные числа N и K. Используя только операции сложения и вычитания, 
// найти частное от деления нацело N на K, а также остаток от этого деления.

#include <stdio.h>
#include <conio.h>

int Recursia(int K_IN, int K_OUT);
int count = 0;
int main(int argc, char *argv[])
{
	int K_IN, K_OUT;	

	printf("Enter K_IN: ");
	scanf("%d", &K_IN);
	printf("Enter K_OUT: ");
	scanf("%d", &K_OUT);

	Recursia(K_IN,K_OUT);
	printf("count = %d", count);

	printf("\n\nPress Any Key to Continue");	
	getch();	
	return 0;
}

int Recursia(int K_IN, int K_OUT)
{
	if(K_IN <= (K_OUT/2))
	{		
		Recursia(K_IN*2, K_OUT);		
	}

	if(K_IN == K_OUT)
	{
		count++;
		return 0;
	}

	if(K_IN > K_OUT)
	{
		return 0;
	}	

	Recursia(++K_IN, K_OUT);
}


