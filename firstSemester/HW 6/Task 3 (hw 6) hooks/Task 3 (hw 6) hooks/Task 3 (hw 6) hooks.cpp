// Task 3 (hw 6) hooks.cpp
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include "stack.h"

using namespace std;

bool test(char str[], Stack *stack);

int main()
{
	Stack *stack = create();

	char str[1000];
	cout << "Enter the text:" << endl;
	gets(str);
	
	if (test(str, stack))
		cout << "right!" << endl;
	else
		cout << "error!" << endl;

	deleteStack(stack);

	system("pause");
	return 0;
}
/*
для строк:
hooks(({}[]){}) - right!
(M.{D.)House} - error!
({}) - right!
работает верно.
*/

inline bool oppositeClose(char a, char b)
{
	return (a == '(' && b == ')') || (a == '{' && b == '}') || (a == '[' && b == ']');
}

inline bool isBrace(char a)
{
	return a == '(' || a == '{' || a == '[' || a == ']' || a == '}' || a == ')';
}

bool test(char str[], Stack *stack)
{
	int temp = 0;
	while (!isBrace(str[temp]))
		temp++;

	push(stack, str[temp]);
	for (int i = temp + 1; i < strlen(str); i++)
	{
		if (!isBrace(str[i]))
			continue;

		if (oppositeClose(top(stack), str[i]) && !testForEmpty(stack))
			pop(stack);
		else
			push(stack, str[i]);
	}

	if (!testForEmpty(stack))
		return true;
	else
		return false;
}
