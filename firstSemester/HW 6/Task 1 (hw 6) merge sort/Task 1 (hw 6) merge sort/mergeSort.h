#pragma once

#include "list.h"

// сортировка слиянием, которая может работать и для имен и для номеров, по выбору пользователя
List *mergeSort(List *list, bool choice);