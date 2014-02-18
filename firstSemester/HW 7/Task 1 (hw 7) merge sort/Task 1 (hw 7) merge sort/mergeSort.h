#pragma once

#include "listArray.h"
#include "listPoint.h"

//чтобы выбрать одну из двух реализаций нужно дописать /* перед одним и удалить перед вторым

typedef ListArray List;
typedef int Position;
//*/

/*
typedef ListPoint List;
typedef ListElement *Position;
//*/

List *mergeSort(List *list);