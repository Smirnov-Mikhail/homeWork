// Task 1 (hw5)
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <locale.h>

using namespace std;

struct PhoneBook
{
	char name[50];
	char number[20];
};

//считывать данные из файла
int input(PhoneBook phB[], int size, int sizeOfFile); 

//искать номер по имени
void scanNumber(PhoneBook phB[], char str[], int size);

//искать имя по номеру
void scanName(PhoneBook phB[], char str[], int size);

//сохранять данные в файл
void out(PhoneBook phB[], int size, int sizeOfFile);

int main()
{
	setlocale(LC_ALL, "Russian");
	PhoneBook phoneBook[100];
	int size = 0;//количество абонентов в действительности
	int sizeOfFile = 0;//количестов абонентов сохранённых в файле

	//считываем данные из файла
	sizeOfFile = input(phoneBook, size, sizeOfFile);
	size = sizeOfFile;
	
	char temp[50];
	int choice = 1;
	while (choice)
	{
		cout << "Введите:\n"
			<< "0(закончить работу)\n"
			<< "1(добавить эелемент)\n"
			<< "2(узнать номер по имени)\n"
			<< "3(узнать имя по номеру)\n"
			<< "4(перенести данные в файл)" 
			<< endl;		
		cin >> choice;
		switch (choice)
		{
         case 1:
			cout << "Введите имя:" << endl;
			cin >> phoneBook[size].name;
			cout << "Введите номер телефона:" << endl;
			cin >> phoneBook[size].number;
			size++;
            break;
         case 2:
            cout << "Введите имя:" << endl;
			cin >> temp;
			scanNumber(phoneBook, temp, size);
            break;
         case 3:
            cout << "Введите номер телефона:" << endl;
			cin >> temp;
			scanName(phoneBook, temp, size);
		 case 4:
			out(phoneBook, size, sizeOfFile);
			cout << "Данные сохранены в файле!" << endl;
			sizeOfFile = size;
		}
		cout << endl;
	}//закрывается while

	return 0;
}

int input(PhoneBook phoneBook[], int size, int sizeOfFile)
{
	ifstream in ("file.txt");
	if (in != NULL)
	{
		while (!in.eof())
		{
			in.getline(phoneBook[size].name, 50);
			in.getline(phoneBook[size].number, 20);
			size++;
		}
	}
	sizeOfFile = size;
	in.close();
	return sizeOfFile;
}

void scanNumber(PhoneBook phoneBook[], char str[], int size)
{
	for (int i = 0; i < size; i++)
	{
		if (strcmp(phoneBook[i].name, str) == 0)
		{
			cout << "Искомый номер: " << phoneBook[i].number << endl;
			return ;
		}
		if (i == size - 1)
			cout << "Не найдено" << endl;
	}
}

void scanName(PhoneBook phoneBook[], char str[], int size)
{
	for (int i = 0; i < size; i++)
	{
		if (strcmp(phoneBook[i].number, str) == 0)
		{
			cout << "Искомое имя: " << phoneBook[i].name << endl;
			return ;
		}
		if (i == size - 1)
			cout << "Не найдено:" << endl;
	}
}

void out(PhoneBook phoneBook[], int size, int sizeOfFile)
{
	ofstream out;
	out.open("file.txt", ios::app);
	for (int i = sizeOfFile; i < size; i++)
	{
		out << phoneBook[i].name << endl;		
		out << phoneBook[i].number << endl;
	}
	out.close();
}