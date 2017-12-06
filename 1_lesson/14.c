//Автор: Варанкин Владимир

// 14. * Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата. 
// Например, 25 \ :sup: 2 = 625. Напишите программу, которая вводит натуральное число N и 
// выводит на экран все автоморфные числа, не превосходящие N.

#include <stdio.h>
#include <math.h> 
#include <conio.h>  //для getch() - ожидание нажатия клавиши

int main(int argc, char *argv[])
{
	int N = 0;		//Натуральное число N
	int number;		//Далее - число в счетчике от 2 до N
	int sum;		//Сумма чисел
	int number2;	//Число в квадрате
	int numbertemp;	//Последние цифры number2

	printf("Enter N symbols:");
	scanf("%u", &N);

	for(int i = 2; i <= N; i++)
	{
		number = i;
		sum = 1;
		number2 = number*number;
		numbertemp = 0;

		while (number>0)
		{
			number = number/10;
			sum *=10;
		}

		number = i;		
		
		numbertemp = number2 - floor(number2/sum)*sum; 

		if(numbertemp == number)
		{
			printf("%u \n", number);
		}
	}
printf("\nPress Any Key to Continue");	
getch();	
return 0;
}
