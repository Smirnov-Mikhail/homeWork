// Task 2 (hw 7) binary tree
//������� ������
#include "stdafx.h"
#include <iostream>
#include <locale.h>
#include "Tree.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	Tree *tree = createTree();
	
	cout << "������� 0, ����� ��������� ������ ���������." << endl;
	cout << "������� 1, ����� �������� ������� � ������." << endl;
	cout << "������� 2, ����� ������� ������� ������." << endl;
	cout << "������� 3, ����� ����� ��������� ����������� �� ������� ������." << endl;
	cout << "������� 4, ����� ������� �������� ������ � ������� �����������." << endl;
	cout << "������� 5, ����� ������� �������� ������ � ������� ��������." << endl;

	int choice = 1;
	int element = 0;
	while (choice)
	{
		cout << "�������:" << endl;
		cin >> choice;
		switch (choice)
		{
			case 1:
			{
				cout << "������� �������, ������� ������ ��������:" << endl;
				cin >> element;
				insert(tree, element);
				break;
			}
			case 2:
			{
				cout << "������� �������, ������� ������ �������:" << endl;
				cin >> element;
				deleteElement(tree, element);
				break;
			}
			case 3:
			{
				cout << "������� �������, � ������� �������� �� ������ ��������������:" << endl;
				cin >> element;
				if (findForElement(tree, element))
					cout << "������������!" << endl;
				else
					cout << "������ �������� �� ����������!" << endl;
				break;
			}
			case 4:
			{
				cout << "�������� ������ � ������� �����������:" << endl;
				printInAscending(tree);
				cout << endl;
				break;
			}
			case 5:
			{
				cout << "�������� ������ � ������� ��������:" << endl;
				printInDecreasing(tree);
				cout << endl;
				break;
			}
		}
	}

	deleteTree(tree);

	return 0;
}

