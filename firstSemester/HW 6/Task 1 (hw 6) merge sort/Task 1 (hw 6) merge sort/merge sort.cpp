#include "stdafx.h"
#include <iostream>
#include "list.h"
#include "merge sort.h"

using namespace std;

List *mergeSort(List *list, bool choice)
{
	if (sizeOfList(list) == 1)
		return list;

	List *left = create();
	insertToHead(left, returnValue(list, head(list), true), returnValue(list, head(list), false));
	List *right = create();
	insertToHead(right, returnValue(list, next(list, middle(list)), true), returnValue(list, next(list, middle(list)), false));

	Position leftPos = head(left);
	Position rightPos = head(right);

	//разделим наш список на две половины
	Position temp = next(list, head(list));
	while (temp != next(list, middle(list)))
	{
		insert(left, leftPos, returnValue(list, temp, true), returnValue(list, temp, false));
		leftPos = next(left, leftPos);
		temp = next(list, temp);
	}
	temp = next(list, temp);
	while (temp != nullptr)
	{
		insert(right, rightPos, returnValue(list, temp, true), returnValue(list, temp, false));
		rightPos = next(right, rightPos);
		temp = next(list, temp);
	}

	//теперь применим сортировку для "половинок"
	left = mergeSort(left, choice);
	right = mergeSort(right, choice);

	List *sortList = create();
	Position sortListPos = head(sortList);
	
	//отдельно рассмотрим случай, когда в sortList ещё нет элементов
	if (returnValue(left, head(left), choice) <= returnValue(right, head(right), choice))
	{
		insertToHead(sortList, returnValue(left, head(left), true), returnValue(left, head(left), false));
		sortListPos = head(sortList);
		removeHead(left);
	}
	else
	{
		insertToHead(sortList, returnValue(right, head(right), true), returnValue(right, head(right), false));
		sortListPos = head(sortList);
		removeHead(right);
	}
	
	while (sizeOfList(left) != 0 && sizeOfList(right) != 0)
	{
		if (returnValue(left, head(left), choice) <= returnValue(right, head(right), choice))
		{
			insert(sortList, sortListPos, returnValue(left, head(left), true), returnValue(left, head(left), false));
			sortListPos = next(sortList, sortListPos);
			removeHead(left);
		}
		else
		{
			insert(sortList, sortListPos, returnValue(right, head(right), true), returnValue(right, head(right), false));
			sortListPos = next(sortList, sortListPos);
			removeHead(right);
		}
	}

	while (sizeOfList(left) != 0)
	{
		insert(sortList, sortListPos, returnValue(left, head(left), true), returnValue(left, head(left), false));
		removeHead(left);
		sortListPos = next(sortList, sortListPos);
	}
	while (sizeOfList(right) != 0)
	{
		insert(sortList, sortListPos, returnValue(right, head(right), true), returnValue(right, head(right), false));
		removeHead(right);
		sortListPos = next(sortList, sortListPos);
	}
	
	deleteList(left);
	deleteList(right);
	deleteList(list);

	return sortList;
}