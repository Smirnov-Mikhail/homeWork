// „ееерновик.cpp : Defines the entry point for the console application.
#include "stdafx.h"
#include <iostream>
#include <locale.h>
#include <time.h>
#include "mergeSort.h"

using namespace std;

int main()
{
	srand(time(nullptr));

	setlocale(LC_ALL, "Russian");

	int length = 0;
	cout << "¬ведите длину списка:" << endl;
	cin >> length;
	
	Position test = NULL;
	List *list = create(test);
	
	insertToHead(list, rand() % 50);

	Position temp = head(list);
	for (int i = 0; i < length - 1; i++)
	{
		insert(list, rand() % 50, temp);
		temp = next(list, temp);
	}

	printList(list);
	cout << endl;

	list = mergeSort(list);

	printList(list);
	cout << endl;

	deleteList(list);

	scanf("%*s");
	// system("pause");
	return 0;
}

