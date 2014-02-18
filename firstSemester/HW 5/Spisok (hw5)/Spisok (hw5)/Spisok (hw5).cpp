// Task 2 (hw5)
//������� ������ �������������
#include "stdafx.h"
#include <iostream>
#include <locale.h>

using namespace std;

#include "list.h"

int main()
{
	setlocale(LC_ALL, "Russian");
	List *list = create();
	
	int choice = 1;
	while (choice)
	{
		cout << "������� 0(��������� ������), 1(������ � ������),\n2(������� �� ������) ��� 3(������� ������): " << endl;
		cin >> choice;
		switch(choice)
		{
			case 1:
				{
					cout << "������� �������, ������� ������ ������ � ������:" << endl;
					int element = 0;
					cin >> element;
					insert(list, element);
				}
				break;
			case 2:
				{
					cout << "������� �������, ������� ������ �������\n(���� ������ �������� � ������ ���, �� ������ ������� �� �����): " << endl;
					int element = 0;
					cin >> element;
					Position number = head(list);

					//��������� �� �������
					if (number == nullptr)
						break;

					//�������� �������� � "�������"
					if (returnValue(list, number) == element)
					{
						removeHead(list);
						break;
					}

					//���� � ������� ������ �������
					remove(list, element);
				}
				break;
			case 3:
				{
					cout << "��� ������:" << endl;
					print(list);
					cout << endl;
				}
				break;
		}
	}
	
	deleteList(list);

	return 0;
}