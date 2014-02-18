//Task 3(Найти наиболее часто встречающийся элемент в массиве быстрее, чем за O(n^2).)
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>
#include <time.h>

using namespace std;

void insert(int a[], int begin, int end)
{
	for (int i = begin + 1; i < end; i++)
	{
		for (int j = i; j > 0 && a[j - 1] > a[j]; j--)
		{
			int temp = a[j - 1];
			a[j - 1] = a[j];
			a[j] = temp;
		}
	}
}

void qSort(int a[], int begin, int end)
{
	if (end - begin > 10)
	{
		int i = begin;
		int j = end;

		int neutral = 0;
		bool temp1 = 1;
		while (temp1)
		{
			if (a[begin] > a[begin + 1])
			{
				neutral = a[begin];
				temp1 = 0;
			}
			else if (a[begin] < a[begin + 1])
			{
				neutral = a[begin + 1];
				temp1 = 0;
			}
			else
				begin++;
		}
 
		while (i <= j)
		{
			while (a[i] < neutral) 
				i++;
			while (a[j] > neutral) 
				j--;
 
			if(i <= j) 
			{
				int temp = a[i];
				a[i] = a[j];
				a[j] = temp;
				i++;
				j--;
			}
		}
 
		if (i < end)
			qSort(a, i, end);
		if (begin < j)
			qSort(a, begin,j);
	}
	else
		insert(a, begin, end + 1);
}

int main()
{
	srand(time(nullptr));

	int length = 0;
	cout << "Enter the length of the array:" << endl;
	cin >> length;

	int *a = new int[length];
	for (int i = 0; i < length; i++)
	{
		a[i] = rand() % 10 - 5;
		cout << a[i] << " ";
	}
	cout << endl;

	qSort(a, 0, length - 1);

	for (int i = 0; i < length; i++)
		cout << a[i] << " ";
	cout << endl;

	int maxAmount = 0;
	int maxNumber = 0;
	int temp = 0;
	for (int i = 0; i < length - 1; i++)
	{
		temp = 0;
		while (a[i] == a[i + 1])
		{
			temp++;
			i++;
		}
		if (temp > maxAmount)
		{
			maxAmount = temp;
			maxNumber = a[i];
		}
	}

	if (maxAmount == 0)
		cout<< a[0] << endl;
	else
		cout << maxNumber << endl;

	system("pause");
	return 0;
}
//для этих примеров работает:
//1 3 3 0 4 2 0 1 0 4
//1 3 3 0 4 2 0 1 4 4
//1 3 3 0 4 2 0 1 0 -1