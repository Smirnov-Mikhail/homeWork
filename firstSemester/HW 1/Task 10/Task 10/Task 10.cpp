// Task 10
//Смирнов Михаил Александрочич
#include "stdafx.h"
#include "stdlib.h"
#include "iostream"
#include "time.h"

using namespace std;
int main()
{
	srand(time(NULL));

	int n = 0;
	cout << "Enter the length of the array:" << endl;
	cin >> n;
	int *a = new int [n];

	int k = 0;
	cout << "This array:" << endl;
	for (int i = 0; i < n; i++)
	{
		a[i] = rand() % 10;
		cout << a[i] << " ";
		if (a[i] == 0)
		k++;
	}
	
	cout << endl << "Result: " << k << endl;

	delete []a;
	return 0;
}