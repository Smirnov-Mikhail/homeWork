#pragma once

struct ListArray;

typedef int ElementType;

//�������� ������
//���������� choice �������� ��� �������� ����� ��������� ������ �� ���������� � ������ �� �������
ListArray *create(int choice);


//���������� ������� ������� ��������
int head(ListArray *list);

//���������� ������� ���������� ��������
int last(ListArray *list);

//���������� ������� ���������� ��������
int next(ListArray *list, int position);
//���������� ������� �������� �������� 
int middle(ListArray *list);
//���������� �������� ��������, �������� �� ����������� �������
ElementType returnValue(ListArray *list, int position);


//��������� ������� �� ������� ��������� ����� position
void insert(ListArray *list, ElementType value, int position);
//��������� ������� � ������
void insertToHead(ListArray *list, ElementType value);


//�������� ��������, �������� �� ����������� �������
void remove(ListArray *list, int position);
//�������� ������� ��������
void removeHead(ListArray *list);
//������� ������
void deleteList(ListArray *list);


//������� ������
void printList(ListArray *list);


//���������� ����� ������
int sizeOfList(ListArray *list);