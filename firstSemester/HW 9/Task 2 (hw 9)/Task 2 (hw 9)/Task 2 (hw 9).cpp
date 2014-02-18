// Task 2 (hw 9) - отображения
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include <locale.h>
#include "mapping.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int m = 0;
	int n = 0;
	cout << "Введите мощности двух множеств:" << endl;
	cin >> m >> n;

	cout << "Количество отображений из первого во второе: " <<  mapping(m, n) << endl;
	cout << "Количество биективных отображений из первого во второе: " << bijection(m, n) << endl;
	cout << "Количество инъективных отображений из первого во второе: " << injection(m, n) << endl;
	cout << "Количество сюръективных отображений из первого во второе: " << surjection(m, n) << endl; 

	return 0;
}

