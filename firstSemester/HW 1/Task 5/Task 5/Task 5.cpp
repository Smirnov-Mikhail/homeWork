//Task 5
//Смирнов Михаил Александрочич
#include "stdafx.h"
#include "stdlib.h"
#include <iostream>
#include "time.h"

using namespace std;

void reverse(int a[], int begin, int end)
{
	for (int i = begin; i < (begin + end) / 2; i++)
	{
		a[i] = a[end + begin - i - 1] + a[i];
		a[end + begin - i - 1] = a[i] - a[end + begin - i - 1];
		a[i] = a[i] - a[end + begin - i - 1];
	}
}
int main()
{
	srand(time(NULL));

	int length = 0;
	cout << "Enter the length of the array:" << endl;
	cin >> length;
	int *a = new int [length];

	cout << "This array:" << endl;
	for (int i = 0; i < length; i++)
	{
		a[i] = rand() % 20;
		cout << a[i] << " ";
	}

	int n = 0, m = 0;
	cout << endl << "Enter n and m(separated by a space):" << endl;
	cin >> n >> m;

	reverse(a, 0, m + n);//переворачиваем весь массив

	reverse(a, 0, m);//переворачиваем первые m элементов

	reverse(a, m, n + m);//переворачиваем элементы с m по n + m

	cout << "Result: " << endl;
	for (int i = 0; i < n + m; i++)
		cout << a[i] << " ";
	cout << endl;

	delete[] a;
	return 0;
}