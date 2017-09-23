// Exam.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#define LEN 5 
int pos;
char symb;
int digit;
double dbl;
int mas[LEN];
float masF[LEN];

void Input() {
	printf("Enter your values: \n");
	for (int i = 0; i < LEN; i++)
	{
		printf("mas[%d]=", i);
		scanf_s("%d", &mas[i]);
	}
}

void Print() {
	printf("\nYour mas values are: \n");
	for(int  i = 0; i < LEN; i++)
	{
		printf("mas[%d]=%d\n", i, mas[i]);
	}
}
int Search(int pos) {
	 pos = 0;

	for (int i = 0; i < LEN; i++)
	{
		if (mas[i] > mas[pos]) {
			pos = i;
		}
	}
	return pos;
}
void Change(int pos1 , int pos2) {
	    int tmp;
	
		tmp = mas[pos1];
		mas[pos1] = mas[pos2];
		mas[pos2] = tmp;

}
void Sorting() {
	
		for (int i = 0; i < LEN; ++i)
		{
			for (int j = i + 1; j < LEN; ++j)
			{
				if (mas[i] > mas[j])
				{
					int tmp;
					tmp = mas[i];
					mas[i] = mas[j];
					mas[j] = tmp;
				}
			}
		}
	}


int main()
{
	Input();

	Print();
	Sorting();
	Print();
	
    return 0;
}

