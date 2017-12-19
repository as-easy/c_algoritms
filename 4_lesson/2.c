//Автор: Варанкин Владимир

//2. Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.

#include <stdio.h>
#include <conio.h>

int main(int argc, char *argv[])
{
	char arr1[] = {'G','E','E','K','B','R','A','I','N','S'};
	char arr2[] = {'G','E','E','K','M','I','N','D','S'};
	int N = sizeof(arr1)/sizeof(char);
	int M = sizeof(arr2)/sizeof(char);
	int A[N+1][M+1];
	int i, j;
	int flag_i = 0;		
	int flag_j = 0;

	for(i = 0; i <= N; i++)
		for(j = 0; j <= M; j++)
			A[i][j] = 0;

	printf("\n\n");

	for(i = 1; i <= N; i++)
		{
			for(j = 1; j <= M; j++)
			{
				if ( arr2[j-1] == arr1[i-1])
				{
					 flag_j = flag_j + 1;					 
				}

				if (flag_j > flag_i)
				{
					A[i][j] = flag_i+1;
				}
				
				else
				{
					A[i][j] = A[i-1][j];
				}			
			}

			if (flag_j > flag_i)
				{					
					flag_i = flag_i + 1;
					flag_j = flag_i;
				}		
		}

	for(i = 0; i <= N; i++)
	{	

		for(j = 0; j <= M; j++)
		{
			printf("%4d", A[i][j]);
		}
		
			printf("\n");
	}	
	
	printf("\n\nPress Any Key to Continue");	
	getch();	
	return 0;
}




