//Task 6
//Смирнов Михаил Александрович
#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int amountTickets = 0;

	int a[28] = {0};
	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			for (int u = 0; u < 10; u++)
			{
				a[i + j + u]++;
			}
		}
	}

	for (int i = 0; i < 28; i++)
	{
		amountTickets += a[i] * a[i];
	}

	cout << "Result:" << amountTickets << endl;

	return 0;
}

