// ������ �5.cpp : Defines the entry point for the console application.
#include "stdafx.h"
#include <iostream>
#include "list.h"
#include <locale.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	cout << "������� ���������� ������:" << endl;
	int n = 0;
	cin >> n;
	cout << "������� �����, �� �����, ������ �� ����� �������:" << endl;
	int k = 0; 
	cin >> k;

	List *list = create();

	insertToHead(list, 1);

	for (int i = n; i > 1; i--)
	{
		addElement(list, i);
	}

	int p = 0;
	int temp = n;
	for (int i = k - 1; i < n * k; i += k)
	{
		if ((i - p) / temp > 0)
		{
			i = (i - p) % temp;
			p = 0;
		}

		removeElement(list, i - p);
		p++;
		temp--;

		if (temp == 1)
			break;		
	}

	cout << "������� �������: " << endl;
	printList(list);
	cout << endl;

	delete head(list);
	delete list;
	return 0;
}
//��� ������ 8, 2 ������� 1, �.�. �������� ���������.