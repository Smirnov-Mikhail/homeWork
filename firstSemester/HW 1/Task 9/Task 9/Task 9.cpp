//Task 9
//Смирнов Михаил Александрочич
#include "stdafx.h"
#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int n = 0;
	cout << "Enter number:" << endl;
	cin >> n;

	if (n >= 3)
		cout << "2 3 ";
	else if (n == 2)
		cout << "2";
	else
		cout << "No numbers!";

	bool simple = false;
	for (int i = 5; i <= n; i += 2)
	{
		//проверяем i на простоту
		simple = true;
		for (int j = 3; j <= sqrt(float(i)); j += 2)
		{
			if (i % j == 0)
			{
				simple = 0;//если i не простое, то simple - false
				break;
			}
		}
		if (simple)
			cout << i << " ";
	}

	return 0;
}