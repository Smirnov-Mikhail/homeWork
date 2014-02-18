#include "stdafx.h"
#include <iostream>
#include "listArray.h"

using namespace std;

struct ListArray
{
	ElementType *array;
	int last;
	int sizeOfArray;
};

ListArray *create(int choice)
{
	ListArray *list = new ListArray;
	list->array = new ElementType[200];
	list->sizeOfArray = 200;
	list->last = -1;
	return list;
}


int head(ListArray *list)
{
	return 0;
}

int last(ListArray *list)
{
	return list->last + 1;
}

int next(ListArray *list, int position)
{
	return position + 1;
}

void insert(ListArray *list, ElementType element, int position)
{
	position += 1;
	if (list->last < list->sizeOfArray - 1)
	{
		for (int temp = last(list); temp != position; temp--)
			list->array[temp] = list->array[temp + 1];

		list->array[position] = element;
		list->last++;
	}
	else 
	{
		ElementType *newArray = new ElementType[list->sizeOfArray * 2];
		for (int temp = 0; temp != last(list); temp++)
			newArray[temp] = list->array[temp];

		ElementType *ptr = list->array;
		list->array = newArray;
		list->sizeOfArray = list->sizeOfArray * 2;
		for (int temp = last(list); temp != position; temp--)
			list->array[temp] = list->array[temp + 1];

		list->array[position] = element;
		list->last++;

		delete ptr;
	}
}

void insertToHead(ListArray *list, ElementType value)
{
	insert(list, value, -1);
}

void remove(ListArray *list, int position)
{
	for (int temp = position; temp != last(list); temp++)
	{
		list->array[temp] = list->array[temp + 1];
	}
	list->last--;
}

void removeHead(ListArray *list)
{
	remove(list, 0);
}

int middle(ListArray *list)
{
	return list->last / 2;
}

int sizeOfList(ListArray *list)
{
	return list->last + 1;
}

ElementType returnValue(ListArray *list, int position)
{
	return list->array[position];
}

void printList(ListArray *list)
{
	for (int temp = 0; temp != last(list); temp++)
	{
		cout << list->array[temp] << " ";
	}
}

void deleteList(ListArray *list)
{
	delete list->array;
	delete list;
}