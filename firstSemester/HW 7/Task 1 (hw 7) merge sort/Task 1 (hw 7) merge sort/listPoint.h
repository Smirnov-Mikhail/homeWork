#pragma once

typedef int ElementType;

struct ListElement;
struct ListPoint;

typedef ListElement *PositionPoint;

//�������� ������
//���������� choice �������� ��� �������� ����� ��������� ������ �� ���������� � ������ �� �������
ListPoint *create(ListElement *test);


//���������� ��������� �� ���������
ListElement *next(ListPoint *list, ListElement *position);
//�=���������� ��������� �� ��������� �������
ListElement *last(ListPoint *list);
//���������� ��������� �� ������
ListElement *head(ListPoint *list);
//��������� �������� ��������� �� ���������
ElementType returnValue(ListPoint *list, ListElement *position);
//���������� ������ �� ������� �������
ListElement *middle(ListPoint *list);


//��������� ������� � ��������������� ������, �������� �����������������
void insert(ListPoint *list, ElementType value, ListElement *position);
//��������� ������� � ������
void insertToHead(ListPoint *list, ElementType element);


//���� � ������ �������, ������� ����� �������, � �������
void remove(ListPoint *list, PositionPoint position);
//������� ��� �������� ������
void removeList(ListPoint *list);
//������� ��������� �� ������ �������
void removeHead(ListPoint *list);
//������� ������
void deleteList(ListPoint *list);


//������� ������
void printList(ListPoint *list);


//���������� ����������� ������
int sizeOfList(ListPoint *list);