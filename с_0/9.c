//Автор: Варанкин Владимир

// 9. Даны целые положительные числа N и K. Используя только операции сложения и вычитания, 
// найти частное от деления нацело N на K, а также остаток от этого деления.

#include <stdio.h>
#include <conio.h>


int main(int argc, char *argv[])
{
	int N, K;
	int count = 0;

	printf("Enter N: ");
	scanf("%d", &N);
	printf("Enter K: ");
	scanf("%d", &K);

	while (N >= K)
	{
		count++;
		N -= K;
	}
	
	printf("Chastnoe: %d\n", count);
	printf("Ostatok: %d", N);

	printf("\n\nPress Any Key to Continue");	
	getch();	
	return 0;
}
