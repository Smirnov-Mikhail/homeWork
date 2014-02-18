// Task 1 (hw 10)
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <locale.h>
#include <string>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	string str;
    char temp = '\0';
    ifstream in("input.txt");
    
    in.unsetf(ios::skipws);//считывание с пробелами
    while (in >> temp)
        str += temp;

	cout << str << endl;

	string p;
	cout << "Введите подстроку, которую хотите найти в тексте:" << endl;
	getline(cin, p);

	str = p + '#' + str;

	int *result = new int[str.length()];
	result[0] = 0;
	for (int k = 0, i = 1; i < str.length(); i++)
	{
		while (k > 0 && str[i] != str[k])
			k = result[k - 1];

		if (str[i] == str[k])
			k++;

		result[i] = k;

		if (result[i] == p.length())
		{
			cout << i - 2 * p.length() << endl;
			break;
		}
	}

	delete []result;
	return 0;
}

