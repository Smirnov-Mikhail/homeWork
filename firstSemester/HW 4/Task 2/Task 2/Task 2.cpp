//Task 2(����� �������� ����� ������������� ������� � ������� �������, ��� �� O(n^2). ������ ������� �� �����. + ������)
//������� ������ �������������
#include "stdafx.h"
#include <iostream>
#include <fstream>
#include "quickSort.h"

using namespace std;

int main()
{
	ifstream in("input.txt");

	int length = 0;
	in >> length;

	int *a = new int[length];
	for (int i = 0; i < length; i++)
	{
		in >> a[i];
		cout << a[i] << " ";
	}
	cout << endl;

	qSort(a, 0, length - 1);

	int maxAmount = 0;
	int maxNumber = 0;
	int temp = 0;
	for (int i = 0; i < length; i++)
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

	if (maxNumber == 0)
		cout<< a[0] << endl;
	else
		cout << maxNumber << endl;

	in.close();
	return 0;
}
//��� ���� �������� ��������:
//1 3 3 0 4 2 0 1 0 4
//1 3 3 0 4 2 0 1 4 4
