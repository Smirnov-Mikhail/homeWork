//Task 1.1 (с помощью матриц)
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	const long int a[2][2] = {1, 1, 1, 0};
	
	int number = 0;
	cout << "Enter number of Fibonacci numeric:" << endl;
	cin >> number;

	int long fn[2][2] = {1, 1, 1, 0};
	int long temp[2][2] = {0};
	for (int i = 0; i < number; i++)
	{
		//перемножаем матрицы
		temp[0][0] = fn[0][0] * a[0][0] + fn[0][1] * a[1][0];
		temp[0][1] = fn[0][0] * a[0][1] + fn[0][1] * a[1][1];
		temp[1][0] = fn[1][0] * a[0][0] + fn[1][1] * a[1][0];
		temp[1][1] = fn[1][0] * a[0][1] + fn[1][1] * a[1][1];

		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
				fn[i][j] = temp[i][j];
		}
		cout << fn[0][0] << " " << fn[0][1] << endl;
		cout << fn[1][0] << " " << fn[1][1] << endl;
		cout << endl;
	}

	system("pause");
	return 0;
}