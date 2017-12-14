//Автор: Варанкин Владимир

// Сравнил производительность сортировки пузырьком и шейкерной сортировки. 
// 1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и не оптимизированной программы. Написать функции сортировки, которые возвращают количество операций.
// 2. *Реализовать шейкерную сортировку.

#include <stdio.h>
#include <conio.h>

void swap(int *a, int *b);
int Puzirik(int a[], int a_length);
int Sheiker(int a[], int a2_length);

int main(int argc, char *argv[])
{
	int a[]	 = {12, 1, 0, 32, 23, 4, 2, 9, 1, 4, 7, 1, 8};
	int a2[] = {12, 1, 0, 32, 23, 4, 2, 9, 1, 4, 7, 1, 8};
	//int a2[] = { 99, 88, 77, 66, 55, 44, 33, 22, 11, 8, 5, 3, 1 };
	int count = 0;
	int count2 = 0;
	int a_length = sizeof(a)/sizeof(int);
	int a2_length = sizeof(a2)/sizeof(int);

	puts("Array before sort");
	for(int i = 0; i < a_length; i++)
	{ printf("%3i", a[i]); }

	//int asort[] = Puzirik(a[]); - Почему нельзя массив вернуть через функцию?
	
	puts("\n\nArray after sort Bubble");
	count = Puzirik(a, a_length);
	for(int i = 0; i < a_length; i++)
	{ printf("%3i", a[i]);}

	puts("\n\nArray after sort Sheiker");
	count2 = Sheiker(a2, a2_length);
	for(int i = 0; i < a2_length; i++)
	{ printf("%3i", a2[i]);}

	printf("\n\nComparison operations Bubble: %d", count);
	printf("\n\nComparison operations Sheiker: %d", count2);

	printf("\n\nPress Any Key to Continue");	
	getch();	
	return 0;
}

int Puzirik(int a[], int a_length)
{
	int count = 0;	
	for(int i = 0; i < a_length; i++)
		for(int j = 0; j < a_length - 1; j++)
		if (a[j] > a[j + 1])
		{
		count++;
		swap(&a[j], &a[j + 1]);
		}
	return count;
}

int Sheiker(int a[], int a2_length)
{
	int left = 0;
	int right = a2_length - 1;
    int count = 0;

		while (left <= right)
		{
			for (int i = left; i < right; i++)
			{
				count++;
				if (a[i] > a[i + 1])
				{	
					swap(&a[i], &a[i + 1]);					
				}
			}
			right--;

			for (int i = right; i > left; i--)
			{
				count++;
				if (a[i - 1] > a[i])
				{
					swap(&a[i], &a[i - 1]);	
				}				
			}
			left++;
		}
	return count;
}

void swap(int *a, int *b)
 {
	int t = *a;
	*a = *b;
	*b = t;
}



