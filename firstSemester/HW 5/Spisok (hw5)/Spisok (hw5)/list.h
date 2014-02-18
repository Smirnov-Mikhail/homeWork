#pragma once

typedef int ElementType;

struct ListElement;
struct List;

typedef ListElement *Position;

List *create();

//вставляем элемент в отсортированный список, соблюдая отсортированность
void insert(List *list, ElementType element);

//ищем в списке элемент, который нужно удалить, и удаляем
void remove(List *list, ElementType element);

//удаляем все элементы списка
//void removeList(List *list);

//выводим список
void print(List *list);

//удаляем указатель на первый элемент
void removeHead(List *list);

//возвращаем указатель на голову
ListElement *head(List *list);

//возращаем значение эелемента по указателю
ElementType returnValue(List *list, ListElement *position);

//удаляем список
void deleteList(List *list);