//Task 2
//������� ������
#include "stdafx.h"
#include <iostream>
#include <locale.h>
#include <fstream>

using namespace std;

bool existenceMinus(int *array, int length);

int main()
{
	setlocale(LC_ALL, "Russian");

	ifstream in("input.txt");
	int n = 0;
	in >> n;

    int **array = new int *[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new int[n];
        for (int j = 0; j < n; j++)
			array[i][j] = -1;
    }
   
	int m = 0;
	in >> m;

	int a = 0;
	int b = 0;
	int len = 0;
	//��������� ������� ���������� ������
	for (int i = 0; i < m; i++)
	{
		in >> a >> b >> len;
		array[a][b] = len;
		array[b][a] = len;
	}

	//������ ������ �������, ������� ����� ������� �������������� ���� ��� ����� ������ �����������.
	int *cities = new int [n];
	for (int i = 0; i < n; i++)
		cities[i] = -1;

	int k = 0;
	in >> k;
	//������ ������ ������
	int *capitals = new int [k];
	for (int i = 0; i < k; i++)
	{
		in >> capitals[i];
		cities[capitals[i]] = capitals[i];//������� ����������� ������ ����������� �� ���������
	}
	
	in.close();

	int min = 100000;
	int indexMin = 0;
	//����� �� ������� ����������
	while (existenceMinus(cities, m))
	{
		//������������� ��� �����������
		for (int j = 0; j < k && existenceMinus(cities, m); j++)
		{
			//���� ������, ������������� ����� �����������
			for (int i = 0; i < n; i++)
			{
				if (cities[i] == capitals[j])
				{
					//���� ����� ���� ������� ����������
					for (int u = 0; u < n; u++)
					{
						if (array[i][u] < min && array[i][u] != -1 && cities[u] == -1)
						{
							min = array[i][u];
							indexMin = u;
						}
					}
				}
				
			}
			cities[indexMin] = capitals[j];
			min = 100000;
		}
	}
	
	for (int i = 0; i < n; i++)
		cout << cities[i] << " ";
	cout << endl;
	
    for (int i = 0; i < n; i++)
		delete[] array[i];
    delete[] array;

    return 0;
}

bool existenceMinus(int *array, int length)
{
	for (int i = 0; i < length; i++)
	{
		if (array[i] == -1)
			return true;
	}

	return false;
}