// Task 3 (hw 7) calculate
//������� ������
#include "stdafx.h"
#include <iostream>
#include "Tree.h"
#include <string>
#include <locale.h>
#include <fstream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	ifstream in("input.txt");

	string str;
	in >> str;
	
	Tree *tree = createTree();
	
	int position = 0;
	//filling(tree, str, position);

	cout << "������ �������������� ���������:" << endl;
	//printInArifmeticForm(tree);
	cout << endl;

	cout << "�������� ���������: " << calculate(tree) << endl;

	deleteTree(tree);

	return 0;
}

