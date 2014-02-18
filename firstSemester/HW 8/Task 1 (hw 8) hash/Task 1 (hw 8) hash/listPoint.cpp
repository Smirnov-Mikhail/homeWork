#include "stdafx.h"
#include <iostream>
#include "listPoint.h"
#include <string>

using namespace std;

typedef string ElementType;

struct ListElement
{
	string str;
	int frequency;
	ListElement *next;
};

struct List
{
	ListElement *head;
};

List *create()
{
	List *result = new List;
	result->head = nullptr;
	return result;
}

ListElement *head(List *list)
{
	return list->head;
}

ElementType returnStr(List *list, ListElement *position)
{
	return position->str;
}

int returnFrequency(List *list, ListElement *position)
{
	return position->frequency;
}

void insertToHead(List *list, ElementType element)
{
	ListElement *newElement = new ListElement;
	newElement->str = element;
	newElement->frequency = 1;
	newElement->next = list->head;
	list->head = newElement;
}

void increaseFrequency(List *list, Position position)
{
	position->frequency++;
}

void insert(List *list, Position position, ElementType element)
{
	ListElement *newElement = new ListElement;
	newElement->str = element;
	newElement->frequency = 1;
	newElement->next = position->next;
	position->next = newElement;
}

void headTo0(List *list)
{
	list->head = nullptr;
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
		cout << temp->str << " " << temp->frequency << endl;
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