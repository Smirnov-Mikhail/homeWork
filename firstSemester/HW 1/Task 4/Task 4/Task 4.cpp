//Task 4
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int dividend = 0;
	int divisor = 0;
	cout << "Enter the value dividend and divisor (separated by a space):" << endl;
	cin >> dividend >> divisor;

	bool sign = false;
	if (dividend * divisor < 0)
	sign = true;

	dividend = dividend < 0 ? -dividend : dividend;
	divisor = divisor < 0 ? -divisor : divisor;

	int quotient = 0;
	while (dividend - divisor >= 0)
	{
		dividend -= divisor;
		quotient++;
	}

	if (sign)
	quotient = - quotient;

	cout << "result: " << quotient << endl;

	return 0;
}