#pragma once

#include "listPoint.h"
#include <string>

HeadList *createHash(int sizeOfHash);

//вставляем элемент в хэш-таблицу
void insertToHash(HeadList *array, std::string str, int sizeOfHash);

//выводим хэш-таблицу
void printHash(HeadList *array, int sizeOfHash);

//удаляем хэш-таблицу
void deleteHash(HeadList *array, int sizeOfHash);