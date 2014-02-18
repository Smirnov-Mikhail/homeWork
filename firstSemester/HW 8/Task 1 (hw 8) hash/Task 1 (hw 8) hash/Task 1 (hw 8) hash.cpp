// Task 1 (hw 8) hash
//Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include "hash.h"
#include <fstream>
#include <string>

using namespace std;

int main()
{
	int sizeOfHash = 0;
	cout << "Enter the size of hash-table:" << endl;
	cin >> sizeOfHash;

	HeadList *hashTable = createHash(sizeOfHash);

	ifstream in("input.txt");
	string str;
	while (!in.eof())
	{
		in >> str;
		insertToHash(hashTable, str, sizeOfHash);
	}

	printHash(hashTable, sizeOfHash);
	
	deleteHash(hashTable, sizeOfHash);
	return 0;
}

