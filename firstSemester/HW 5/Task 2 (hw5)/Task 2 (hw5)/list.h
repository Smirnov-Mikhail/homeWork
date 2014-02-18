/*#pragma once

typedef int ElementType;

struct ListElement
{
	ElementType value;
	ListElement *next;
};

struct List
{
	ListElement *head;
};

typedef ListElement *Position;

List *create();

void insert(List *list, ElementType value, Position position);
void insertToHead(List *list, ElementType value);
void remove(List *list, Position position);
void print(List *list);
Position first(List *list);
Position end(List *list);
Position next(List *list, Position position);
void quickSort(List *list);
//написать вынкцию выводящую значение по позиции*/