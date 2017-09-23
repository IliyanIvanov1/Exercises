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
	for (int i = 0; i < LEN; i++)
	{
		printf("mas[%d]=%d\n", i, mas[i]);
	}
}
void Change(int pos1, int pos2) {
	int tmp;

	tmp = mas[pos1];
	mas[pos1] = mas[pos2];
	mas[pos2] = tmp;
}
int Search(int end_pos) {
	pos = end_pos;
	for (int i = 0; i < end_pos; i++) {


		if (mas[i] > mas[pos]) {
			pos = i;

		}

	}
	return pos;
}



void Sorting() {
	for (int i = 0; i < LEN; i++)
	{
		int max_pos = Search(LEN - 1 - i);
		Change(max_pos, LEN - 1 - i);
	}

}


int main()
{
	Input();
	Sorting();
	Print();

	return 0;
}