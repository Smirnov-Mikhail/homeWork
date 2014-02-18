// Task 2 (hw 7) binary tree
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include <locale.h>
#include "Tree.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	Tree *tree = createTree();
	
	cout << "Введите 0, чтобы закончить работу программы." << endl;
	cout << "Введите 1, чтобы добавить элемент в дерево." << endl;
	cout << "Введите 2, чтобы удалить элемент дерева." << endl;
	cout << "Введите 3, чтобы чтобы проверить принадлежит ли элемент дереву." << endl;
	cout << "Введите 4, чтобы вывести элементы дерева в порядке возрастания." << endl;
	cout << "Введите 5, чтобы вывести элементы дерева в порядке убывания." << endl;

	int choice = 1;
	int element = 0;
	while (choice)
	{
		cout << "Вводите:" << endl;
		cin >> choice;
		switch (choice)
		{
			case 1:
			{
				cout << "Введите элемент, который хотите добавить:" << endl;
				cin >> element;
				insert(tree, element);
				break;
			}
			case 2:
			{
				cout << "Введите элемент, который хотите удалить:" << endl;
				cin >> element;
				deleteElement(tree, element);
				break;
			}
			case 3:
			{
				cout << "Введите элемент, в наличии которого вы хотите удостовериться:" << endl;
				cin >> element;
				if (findForElement(tree, element))
					cout << "Присутствует!" << endl;
				else
					cout << "Такого элемента не обнаружено!" << endl;
				break;
			}
			case 4:
			{
				cout << "Элементы дерева в порядке возрастания:" << endl;
				printInAscending(tree);
				cout << endl;
				break;
			}
			case 5:
			{
				cout << "Элементы дерева в порядке убывания:" << endl;
				printInDecreasing(tree);
				cout << endl;
				break;
			}
		}
	}

	deleteTree(tree);

	return 0;
}

