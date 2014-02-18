#pragma once
#include <string>

typedef std::string ElementType;

struct ListElement;
struct List;

typedef ListElement *Position;

List *create();

//��������� ������� � ��������������� ������, �������� �����������������
void insert(List *list, Position position, ElementType nameElement, ElementType numberElement);

//��������� ������� � ������
void insertToHead(List *list, ElementType nameElement, ElementType numberElement);

//���� � ������ �������, ������� ����� �������, � �������
void remove(List *list, Position position, ElementType element);

//������� ������
void deleteList(List *list);

//������� ������
void printList(List *list);

//������� ��������� �� ������ �������
void removeHead(List *list);

//���������� ��������� �� ������
ListElement *head(List *list);

//��������� �������� ��������� �� ���������
ElementType returnValue(List *list, ListElement *position, bool choice);

//���������� ����� ������
int sizeOfList(List *list);

//���������� ��������� �� ���������
ListElement *next(List *list, ListElement *position);

//���������� ��������� �� �������
ListElement *middle(List *list);