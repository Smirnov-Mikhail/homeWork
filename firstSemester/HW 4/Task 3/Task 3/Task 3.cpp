// Task 3
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream in("input.txt");
	char str[1000];

	int amountStr = 0;
	while (!in.eof())
	{
		in.getline(str, 12);
		cout << str << endl;
		for (int i = 0; str[i] != '\0'; i++)
		{
			if (str[i] != ' ')
			{
				amountStr++;
				break;
			}
		}
	}

	cout << amountStr << endl;
	in.close();
	system("pause");
	return 0;
}

