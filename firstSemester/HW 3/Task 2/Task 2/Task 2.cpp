//Task 2
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

bool scan(int arr[], int begin, int end, int k)
{
	while (begin != end)
	{
		int q = 0;
		int x = arr[(begin + end) / 2];
		if (k > arr[(begin + end) / 2])
		{
			begin = ((begin + end) / 2) + 1;
			scan(arr, begin, end, k);
		}
		if (k < arr[(begin + end) / 2])
		{
			end = ((begin + end) / 2);
			scan(arr, begin, end, k);
		}

		if (k == arr[(begin + end) / 2])
			return true;
	}

	if (k == arr[begin])
	{
		return true;
	}
	return false;
}

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
 
		do 
		{
			while (a[i] < neutral) i++;
			while (a[j] > neutral) j--;
 
			if(i <= j) 
			{
				int temp = 0;
				temp = a[i];
				a[i] = a[j];
				a[j] = temp;
				i++;
				j--;
			}
		} while (i <= j);
 
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
	int n = 0;
	cout << "Enter length of the array: (from 1 to 5 000)" << endl;
	cin >> n;
	int k = 0;
	cout << "Enter the amount of numbers: (from 1 to 300 000)" << endl;
	cin >> k;
	int *a = new int[n];
	cout << "This array:" << endl;
	for (int i = 0; i < n; i++)
	{
		a[i] = (rand() * rand()) % 1000000000;
		cout << a[i] << " ";
	}
	cout << endl;

	qSort(a, 0, n - 1);

	for (int i = 0; i < k; i++)
	{
		int temp = (rand() * rand()) % 1000000000;
		if (scan(a, 0, n, temp))
			cout << temp << " - there is	" << endl;
		else
			cout << temp << " - no  " << endl;
	}
	cout << endl;
	
	delete[] a;
	return 0;
}

