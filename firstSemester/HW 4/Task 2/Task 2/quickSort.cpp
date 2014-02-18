#include "stdafx.h"
#include <iostream>

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