#include "stdafx.h"
#include <iostream>
#include "list.h"
#include <string>

using namespace std;

typedef string ElementType;

struct ListElement
{
	string name;
	string number;
	ListElement *next;
};

struct List
{
	ListElement *head;
};

List *create()
{
	List *result = new List;
	result -> head = NULL;
	return result;
}

ListElement *head(List *list)
{
	return list->head;
}

ElementType returnValue(List *list, ListElement *position, bool choice)
{
	if (choice)
		return position->name;
	else
		return position->number;
}

void insertToHead(List *list, ElementType nameElement, ElementType numberElement)
{
	ListElement *newElement = new ListElement;
	newElement->name = nameElement;
	newElement->number = numberElement;
	newElement->next = list->head;
	list->head = newElement;
}

void insert(List *list, Position position, ElementType nameElement, ElementType numberElement)
{
	ListElement *newElement = new ListElement;
	newElement->name = nameElement;
	newElement->number = numberElement;
	newElement->next = position->next;
	position->next = newElement;
}

void remove(List *list, Position position, ElementType element)
{
	Position temp = position->next;
	position->next = position->next->next;
	delete temp;
}

void removeHead(List *list)
{
	Position temp = list->head;
	list->head = list->head->next;
	delete temp;
}

void printList(List *list)
{
	Position temp = list->head;
	while (temp != nullptr)
	{
		cout << temp->name << " " << temp->number << endl;
		temp = temp->next;
	}
}

int sizeOfList(List *list)
{
	Position temp = list->head;
	int j = 0;
	while (temp != nullptr)
	{
		j++;
		temp = temp->next;
	}
	return j;
}

ListElement *next(List *list, ListElement *position)
{
	return position->next;
}

ListElement *middle(List *list)
{
	int middle =  sizeOfList(list) / 2 - 1;
	ListElement *temp = list->head;
	while(middle > 0)
	{
		middle--;
		temp = temp->next;
	}
	return temp;
}

void deleteList(List *list)
{
	ListElement *temp = head(list);
	while (temp != nullptr)
	{
		ListElement *tempNext = temp;
		temp = next(list, temp);
		delete tempNext;
	}
	delete list;
}