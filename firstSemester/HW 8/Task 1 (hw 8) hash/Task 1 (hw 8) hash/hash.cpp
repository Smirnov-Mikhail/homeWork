#include "stdafx.h"
#include <iostream>
#include "listPoint.h"
#include "hash.h"
#include <string>

using namespace std;

HeadList *createHash(int sizeOfHash)
{
	HeadList *array = new HeadList [sizeOfHash];

	for (int i = 0; i < sizeOfHash; i++)
		array[i] = create();

	return array;
}

int hashFunction(string str, int sizeOfHash)
{
	int index = 0;
	for (int i = 1; i < str.length(); i++)
		index += pow(3.0, static_cast<double>(str.length() - i)) * (str[i] - '0');
	
	if (index < 0)
		index = -index;
	index %= sizeOfHash;

	return index;
}

void insertToHash(HeadList *array, string str, int sizeOfHash)
{
	const int n = hashFunction(str, sizeOfHash);

	if (sizeOfList(array[n]) == 0)
		insertToHead(array[n], str);
	else
	{
		Position position = head(array[n]);
		while (position != nullptr)
		{
			if (returnStr(array[n], position) == str)
			{
				increaseFrequency(array[n], position);
				break;
			}
			position = next(array[n], position);
		}

		if (position == nullptr)
			insertToHead(array[n], str);
	}
}

void printHash(HeadList *array, int sizeOfHash)
{
	for (int i = 0; i < sizeOfHash; i++)
	{
		Position position = head(array[i]);
		while (position != nullptr)
		{
			cout << returnStr(array[i], position) << ' ' << returnFrequency(array[i], position) << endl;
			position = next(array[i], position);
		}
	}
}

void deleteHash(HeadList *array, int sizeOfHash)
{
	for (int i = 0; i < sizeOfHash; i++)
		deleteList(array[i]);
	delete[] array;
}