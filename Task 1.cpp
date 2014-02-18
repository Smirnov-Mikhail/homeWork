//Task 1
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int x = 0;
	cout << "Enter the value x:" << endl;
	cin >> x;
	int y;
	y = x * x;
	cout <<"Result: " << (y + 1) * (y + x) << endl;

	cout << "Enter any key to continue:" << endl;
	cin >> x ;
	return 0;
}

