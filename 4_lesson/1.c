//Автор: Варанкин Владимир

//1. *Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и нахождение количество маршрутов.
//Фигура может ходить только вниз и вправо.

#include <stdio.h>
#include <conio.h>
#define N 4
#define M 4

void Print2(int n, int m, int a[N][M])
{
int i, j;
for(i = 0; i < n; i++)
	{
	for(j = 0; j < m; j++)
		printf("%4d", a[i][j]);
	printf("\n");
	}
}

int main(int argc, char *argv[])
{
	int A[N][M];
	int Map[N][M] = 	//карта препятствий
		{
			1, 1, 0, 1,
			0, 1, 1, 1,
			1, 0, 1, 1,
			1, 1, 1, 1
		};
	int i, j;
	int flag_j = 1;		
	int flag_i = 1;

	//Заполнение первой строки 1-чками, но если есть препятствие, то потом 0-ми
	for(j = 0; j < M; j++)	
	{
		if (Map[0][j] == 0)
		{
			flag_j = 0;	
		} 			
		A[0][j] = flag_j; 
	}

	
	for(i = 1; i < N; i++)
		{
			//Заполнение первого столбца 1-чками, но если есть препятствие, то потом 0-ми
			if (Map[i][0] == 0)
			{
				flag_i = 0;	
			} 			
			A[i][0] = flag_i;

			for(j = 1; j < M; j++)
				{
					if (Map[i][j] == 1) A[i][j] = A[i][j-1] + A[i-1][j];
					else A[i][j] = 0;
				}			
		}

	Print2(N, M, A);
	
	printf("\n\nPress Any Key to Continue");	
	getch();	
	return 0;
}


