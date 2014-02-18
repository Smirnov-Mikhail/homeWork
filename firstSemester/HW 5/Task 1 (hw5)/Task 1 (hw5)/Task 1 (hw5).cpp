// Task 1 (hw5)
//������� ������ �������������
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

//��������� ������ �� �����
int input(PhoneBook phB[], int size, int sizeOfFile); 

//������ ����� �� �����
void scanNumber(PhoneBook phB[], char str[], int size);

//������ ��� �� ������
void scanName(PhoneBook phB[], char str[], int size);

//��������� ������ � ����
void out(PhoneBook phB[], int size, int sizeOfFile);

int main()
{
	setlocale(LC_ALL, "Russian");
	PhoneBook phoneBook[100];
	int size = 0;//���������� ��������� � ����������������
	int sizeOfFile = 0;//���������� ��������� ���������� � �����

	//��������� ������ �� �����
	sizeOfFile = input(phoneBook, size, sizeOfFile);
	size = sizeOfFile;
	
	char temp[50];
	int choice = 1;
	while (choice)
	{
		cout << "�������:\n"
			<< "0(��������� ������)\n"
			<< "1(�������� ��������)\n"
			<< "2(������ ����� �� �����)\n"
			<< "3(������ ��� �� ������)\n"
			<< "4(��������� ������ � ����)" 
			<< endl;		
		cin >> choice;
		switch (choice)
		{
         case 1:
			cout << "������� ���:" << endl;
			cin >> phoneBook[size].name;
			cout << "������� ����� ��������:" << endl;
			cin >> phoneBook[size].number;
			size++;
            break;
         case 2:
            cout << "������� ���:" << endl;
			cin >> temp;
			scanNumber(phoneBook, temp, size);
            break;
         case 3:
            cout << "������� ����� ��������:" << endl;
			cin >> temp;
			scanName(phoneBook, temp, size);
		 case 4:
			out(phoneBook, size, sizeOfFile);
			cout << "������ ��������� � �����!" << endl;
			sizeOfFile = size;
		}
		cout << endl;
	}//����������� while

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
			cout << "������� �����: " << phoneBook[i].number << endl;
			return ;
		}
		if (i == size - 1)
			cout << "�� �������" << endl;
	}
}

void scanName(PhoneBook phoneBook[], char str[], int size)
{
	for (int i = 0; i < size; i++)
	{
		if (strcmp(phoneBook[i].number, str) == 0)
		{
			cout << "������� ���: " << phoneBook[i].name << endl;
			return ;
		}
		if (i == size - 1)
			cout << "�� �������:" << endl;
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