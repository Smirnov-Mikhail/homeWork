/*#include "stdafx.h"
#include <iostream>
#include "list.h"

using namespace std;

typedef int ElementType;

List *create()
{
	List *result = new List;
	result -> head = NULL;
	return result;
}

void insert(List *list, ElementType value, Position position)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = position->next;
	position->next = newElement;
}

void insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void remove(List *list, Position position)
{
	if (position->next)
	{
		return;
	}
	Position temp = position->next;
	position->next = position->next->next;
	delete temp;
}

void print(List *list)
{
	Position temp = list->head;
	while (temp != NULL)
	{
		cout << temp->value << " ";
		temp = temp->next;
	}
}

Position first(List *list)
{
	return list->head;
}

Position end(List *list)
{
	return NULL;
}

Position next(List *list, Position position)
{
	return position->next;
}

/*(void insertSorting(int a[], int begin, int end)
{
	for (int i = begin + 1; i < end; i++)
	{
		for (int j = i; j > 0 && a[j - 1] > a[j]; j--)
		{
			int temp = a[j - 1];
			a[j - 1] = a[j];
			a[j] = temp;
		}
	}
}*/