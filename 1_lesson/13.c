//Автор: Варанкин Владимир

// 13. * Написать функцию, генерирующую случайное число от 1 до 100.
// с использованием стандартной функции rand()
// без использования стандартной функции rand()

#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <conio.h>

int SystemRandom();
int PGSCH(int x, int a, int b, int m);

int main(int argc, char *argv[])
{
	int x = 5;	

	srand(time(NULL));

	printf("System random: \n");
	for(int i = 0; i <= 100; i++)
		printf(" %d", SystemRandom());

	printf("\n\nPGSCH function: \n");
	for(int i = 0; i <= 100; i++)	
	{
		x = PGSCH(x, 4, 1, 100);
		printf("%d ", x);
	}

printf("\n\nPress Any Key to Continue");	
getch();	
return 0;
}

int SystemRandom()
	{
		return rand() % 100;
	}

int PGSCH(int x, int a, int b, int m)
	{
		return (a*x + b)%m;
	}
