#pragma once

struct ListElement;

struct List;

List *create();

//добавляет элемент
void addElement(List *list, int element);

//удаляет элемент
void removeElement(List *list, int element);

//выводит список
void printList(List *list);

//вставляет в голову элемент
void insertToHead(List *list, int value);

//возвращает указатель на голову
ListElement *head(List *list);