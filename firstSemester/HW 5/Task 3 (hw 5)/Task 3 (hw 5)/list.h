#pragma once

struct ListElement;

struct List;

List *create();

//��������� �������
void addElement(List *list, int element);

//������� �������
void removeElement(List *list, int element);

//������� ������
void printList(List *list);

//��������� � ������ �������
void insertToHead(List *list, int value);

//���������� ��������� �� ������
ListElement *head(List *list);