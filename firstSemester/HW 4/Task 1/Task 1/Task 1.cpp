//Task 1
//Смирнов Михаил Алескандрович
#include "stdafx.h"
#include <iostream>
#include <locale.h>
#include <math.h>

using namespace std;

void transformation10ToBinary(bool a[], int number)
{
	int mask = 1;
	for (int i = sizeof(int) * 8 - 1; i >= 0; i--)
	{
		a[i] = number & mask;
		mask = mask << 1;
	}
}

void transformationBinaryTo10(bool a[])
{
	int temp = 0;
	if (a[sizeof(int) * 8 - 1] == 1)//мы это рассматриваем отдельно, потому что pow(0., 0.) = 1, а нам нужно наоборот.
		temp++;
	for (int i = sizeof(int) * 8 - 2; i > 0; i--)
	{
		temp += pow(double(a[i] * 2), double(sizeof(int) * 8 - i - 1));
	}
	if (a[0] == 1)//если число отрицательно
		temp = temp - pow(2., 31.);
	cout << temp <<endl;
}

void output(bool a[])
{
	for (int i = 0; i < sizeof(int) * 8; i++)
		cout << a[i];
	cout << endl;
}

int main()
{
	setlocale(LC_ALL, "Russian");

	int number1 = 0;
	int number2 = 0;
	cout << "В представлении чисел будет использоваться дополнительный код." << endl;
	cout << "Введите два числа:" << endl;
	cin >> number1 >> number2;
	cout << "Двоичное представление первого и второго:" <<endl;
	bool *num1 = new bool[sizeof(int) * 8];
	bool *num2 = new bool[sizeof(int) * 8];
	
	transformation10ToBinary(num1, number1);
	transformation10ToBinary(num2, number2);
	
	output(num1);
	output(num2);

	bool *amount = new bool[sizeof(int) * 8];
	bool temp = 0;
	for (int i = sizeof(int) * 8 - 1; i >= 0; i--)
	{
		amount[i] = (temp + num1[i] + num2[i]) % 2;
		temp = (temp + num1[i] + num2[i]) / 2;
	}

	cout << endl << "Сумма в двоичной системе счисления:" << endl;
	output(amount);

	cout << endl << "Сумма в  десятичной системе счисления:" << endl;
	transformationBinaryTo10(amount);

	system("pause");
	return 0;
}

