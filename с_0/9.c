//Автор: Варанкин Владимир

// 3. Сделал только с рекурсией
//Исполнитель Калькулятор преобразует целое число, записанное на экране. У исполнителя две команды, каждой команде присвоен номер:

// 1)Прибавь 1 и 2)Умножь на 2 Первая команда увеличивает число на экране на 1, вторая увеличивает это число в 2 раза. 
// Сколько существует программ, которые число 3 преобразуют в число 20? а) с использованием массива;  б) с использованием рекурсии. 

#include <stdio.h>
#include <conio.h>

int Recursia(int K_IN, int K_OUT);
int count = 0;		//число шагов, ведущих от начального числа к конечному числу
int main(int argc, char *argv[])
{
	int K_IN; 	 	//начальное число - например 3
	int K_OUT;		//конечное число, к которому нужно прийти - например 20		

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


