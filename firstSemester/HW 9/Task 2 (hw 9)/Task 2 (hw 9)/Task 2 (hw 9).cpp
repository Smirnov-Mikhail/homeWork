// Task 2 (hw 9) - �����������
//������� ������
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
	cout << "������� �������� ���� ��������:" << endl;
	cin >> m >> n;

	cout << "���������� ����������� �� ������� �� ������: " <<  mapping(m, n) << endl;
	cout << "���������� ���������� ����������� �� ������� �� ������: " << bijection(m, n) << endl;
	cout << "���������� ����������� ����������� �� ������� �� ������: " << injection(m, n) << endl;
	cout << "���������� ������������ ����������� �� ������� �� ������: " << surjection(m, n) << endl; 

	return 0;
}

