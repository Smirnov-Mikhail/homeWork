// Task 4 (hw 6) output as postfix.cpp
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include "stack.h"
#include <string>

using namespace std;

void conversionToPostfix(string str, string &result);

int main()
{

	string str;
	cout << "Enter the text: (no spaces)" << endl;
	cin >> str;

	string result;
	conversionToPostfix(str, result);
	cout << "Result:" << endl;
	cout << result << endl;

	return 0;
}

/*
для:
1)9+6*7+1
Result: 967*+1+ - верно
2)(9+6)*(7+1)
 Result: 96+71+* - верно
*/

void conversionToPostfix(string str, string &result)
{
	Stack *stack = create();

	for (int i = 0; i < str.length(); i++)
	{
		if (str[i] >= '0' && str[i] <= '9')
			result += str[i];
		else if (str[i] == '+' || str[i] == '-')
		{
			//если стэк не пуст
			if (!testForEmpty(stack))
			{
				while (!testForEmpty(stack) && (top(stack) == '+' || top(stack) == '-' || top(stack) == '*' || top(stack) == '/'))
				{
					result += top(stack);
					pop(stack);
				}
			}
			push(stack, str[i]);
		}
		else if (str[i] == '*' || str[i] == '/')
		{
			//если стэк не пуст
			if (!testForEmpty(stack))
			{
				while (!testForEmpty(stack) && (top(stack) == '*' || top(stack) == '/'))
				{
					result += top(stack);
					pop(stack);
				}
			}
			push(stack, str[i]);
		}
		if (str[i] == '(')
			push(stack, str[i]);
		if (str[i] == ')')
		{
			while (top(stack) != '(')
			{
				result += top(stack);
				pop(stack);
			}
			pop(stack);
			if (!testForEmpty(stack))
			{
				if (top(stack) == '+' || top(stack) == '-' || top(stack) == '*' || top(stack) == '/')
				{
					result += top(stack);
					pop(stack);
				}
			}
		}
	}//закрыли for

	while (!testForEmpty(stack))
	{
		result += top(stack);
		pop(stack);
	}

	deleteStack(stack);
}