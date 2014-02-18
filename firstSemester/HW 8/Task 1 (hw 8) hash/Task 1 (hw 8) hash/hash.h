#pragma once

#include "listPoint.h"
#include <string>

HeadList *createHash(int sizeOfHash);

//��������� ������� � ���-�������
void insertToHash(HeadList *array, std::string str, int sizeOfHash);

//������� ���-�������
void printHash(HeadList *array, int sizeOfHash);

//������� ���-�������
void deleteHash(HeadList *array, int sizeOfHash);