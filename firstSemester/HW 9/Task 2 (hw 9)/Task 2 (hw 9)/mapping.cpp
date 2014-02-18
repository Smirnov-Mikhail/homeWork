#include "stdafx.h"
#include <iostream>

int fact(int n)
{
    if (n == 0)
        return 1;
    else
        return n * fact(n - 1);
}

int mapping(int m, int n)
{
	return pow(static_cast<double>(n), double(m));
}

int bijection(int m, int n)
{
	if (m != n)
		return 0;
	else
		return fact(n);
}

int injection(int m, int n)
{
	if (n >= m)
		return (fact(n) / (fact(m) * fact(n - m))) * fact(m);
	else
		return 0;
}

int surjection(int m, int n)
{
	if (m < n)
		return 0;

	int result = 0;
	for (int i = 0; i < n; i++)
		result += pow(double(-1), double(i)) * (fact(n) / (fact(i) * fact(n - i))) * pow(double(n - i), double(m));
	
	 return result;
}