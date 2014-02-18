// Task 1 (hw 6) merge sort
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include "list.h"
#include "mergeSort.h"
#include <string>
#include <fstream>

using namespace std;

/*
Успешно работает для примера(и сортировка по имени, и по номеру)
Д 333
Г 000
Б 777
В 111
А 222
Е 666
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

	cout << "Данный список:" << endl;
	printList(list);
	cout << endl;

	bool choice = false;
	cout << "Если вы хотите отсортировать по имени, введите 1, если по номеру, то введите 0" << endl;
	cin >> choice;
	list = mergeSort(list, choice);

	cout << endl;
	printList(list);

	deleteList(list);
	
	system("pause");
	return 0;
}

