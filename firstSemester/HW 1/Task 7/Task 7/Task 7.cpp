//Task 7
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int amountBrackets = 0;
	char str[1000];
	gets(str);
	
	for (int i = 0; i < strlen(str); i++)
	{
		if (str[i] == '(')
			amountBrackets++;
		else if (str[i] == ')')
			amountBrackets--;

		if (amountBrackets < 0)
		{
			cout << "error!" << endl;

			return 0;
		}
	}

	if (amountBrackets == 0)
	{
		cout << "correct!" << endl;
	}
	else
	{
		cout << "error!" << endl;
	}

	return 0;
}