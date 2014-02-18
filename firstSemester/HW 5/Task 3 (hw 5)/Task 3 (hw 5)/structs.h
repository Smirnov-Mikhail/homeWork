#pragma once
#include "stdafx.h"
#include "iostream"
#include "list.h"

struct ListElement
{
	int value;
	ListElement *next;
};

struct List
{
	ListElement *head;
};