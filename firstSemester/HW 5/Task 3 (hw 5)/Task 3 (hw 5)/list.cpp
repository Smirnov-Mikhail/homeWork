#include "stdafx.h"
#include "iostream"
#include "list.h"

using namespace std;

struct ListElement
{
	int value;
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

void addElement(List *list, int element)
{
	ListElement *newElement = new ListElement;
	
	if (list->head->next == nullptr)
	{
		newElement->value = element;
		newElement->next = list->head;
		list->head->next = newElement;
	}
	
	else
	{
		newElement->value = element;
		newElement->next = list->head->next;
		list->head->next = newElement;
	}
}

void insertToHead(List *list, int value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void removeElement(List *list, int index)
{
	ListElement *current = list->head->next;
	ListElement *previous = list->head;
	
	if (index == 0)
	{
		while (current != list->head)
		{
			previous = current;
			current = current->next;
		}
		list->head = current->next;
	}
	
	else
	{
		for (int i = 1; i < index; i++)
		{
			previous = current;
			current = current->next;
		}
	}

	previous->next = current->next;
	delete current;	
}

void printList(List *list)
{
	ListElement *current = list->head;
	
	do
	{
		cout << current->value << " ";
		current = current->next;
	} 
	while (current->value != list->head->value);
}