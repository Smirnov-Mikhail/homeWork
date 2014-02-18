#pragma once
#include <string>

typedef std::string ElementType;

struct ListElement;
struct List;

typedef ListElement *Position;
typedef List *HeadList;

List *create();

//��������� �������� ��������� �� ���������
ElementType returnStr(List *list, ListElement *position);

//��������� �������� ��������� �� ���������
int returnFrequency(List *list, ListElement *position);

//��������� ������� � ������
void insertToHead(List *list, ElementType element);

//��������� ������� � ������
void insert(List *list, Position position, ElementType element);

//����������� ����������, ������� �������� �� ������� �������������
void increaseFrequency(List *list, Position position);

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

//���������� ����� ������
int sizeOfList(List *list);

//���������� ��������� �� ���������
ListElement *next(List *list, ListElement *position);

//���������� ��������� �� �������
ListElement *middle(List *list);