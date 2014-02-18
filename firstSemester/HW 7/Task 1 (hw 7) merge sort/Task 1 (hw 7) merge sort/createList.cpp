#include "stdafx.h"
#include <iostream>
#include "createList.h"
#include <stdio.h>
#include <time.h>

void createList(List *list, int sizeOfArray)
{
	Position temp = head(list);
	for (int i = sizeOfArray; i > 0; i--)
	{
		insert(list, rand() % 10, temp);
		temp = next(list, temp);
	}
}