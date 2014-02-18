// Task 1 (hw 6) merge sort
//������� ������
#include "stdafx.h"
#include <iostream>
#include "list.h"
#include "mergeSort.h"
#include <string>
#include <fstream>

using namespace std;

/*
������� �������� ��� �������(� ���������� �� �����, � �� ������)
� 333
� 000
� 777
� 111
� 222
� 666
*/

int main()
{
	setlocale(LC_ALL, "Russian");

	ifstream in("input.txt");

	List *list = create();

	string tempName;
	string tempNumber;
	while (!in.eof())
	{
		in >> tempName;
		in >> tempNumber;
		insertToHead(list, tempName, tempNumber);
	}
	in.close();

	cout << "������ ������:" << endl;
	printList(list);
	cout << endl;

	bool choice = false;
	cout << "���� �� ������ ������������� �� �����, ������� 1, ���� �� ������, �� ������� 0" << endl;
	cin >> choice;
	list = mergeSort(list, choice);

	cout << endl;
	printList(list);

	deleteList(list);
	
	system("pause");
	return 0;
}

