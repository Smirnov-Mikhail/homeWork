// Task 2 (hw 6).cpp
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include "stack.h"

using namespace std;

int resultByPostfixForm(char str[]);

int main()
{
	char str[500];
	cout << "Enter the expression written in postfix form(no spaces):" << endl;
	cin >> str;
	
	cout << resultByPostfixForm(str) << endl;

	return 0;
}
//для 96+12-* выводит -15 - верно
//для 23+4*56*- выводит -10 - верно
//для 12+34++56+78+++ выводит 36 - верно

int operation(int a1, int a2, char value)
{
	switch(value)
	{
		case '+':
			return a1 += a2;
		case '-':
			return a1 -= a2;
		case '*':
			return a1 *= a2;
		case '/':
			return a1 /= a2;
	}
}

int resultByPostfixForm(char str[])
{
	Stack *stack = create();
	
	int temp = 0;
	for (int i = 0; i < strlen(str); i++)
	{
		if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
		{
			push(stack, str[i]);
		}
		else
		{
			temp = top(stack) - '0';
			pop(stack);
			temp = operation(top(stack) - '0', temp, str[i]);
			pop(stack);
			push(stack, char(temp + int('0')));
		}
	}

	temp = top(stack) - '0';

	deleteStack(stack);
	return temp;
}