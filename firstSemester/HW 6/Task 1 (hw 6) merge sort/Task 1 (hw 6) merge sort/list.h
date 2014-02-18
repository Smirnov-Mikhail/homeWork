#pragma once
#include <string>

typedef std::string ElementType;

struct ListElement;
struct List;

typedef ListElement *Position;

List *create();

//вставляем элемент в отсортированный список, соблюдая отсортированность
void insert(List *list, Position position, ElementType nameElement, ElementType numberElement);

//вставляем элемент в голову
void insertToHead(List *list, ElementType nameElement, ElementType numberElement);

//ищем в списке элемент, который нужно удалить, и удаляем
void remove(List *list, Position position, ElementType element);

//удаляем список
void deleteList(List *list);

//выводим список
void printList(List *list);

//удаляем указатель на первый элемент
void removeHead(List *list);

//возвращаем указатель на голову
ListElement *head(List *list);

//возращаем значение эелемента по указателю
ElementType returnValue(List *list, ListElement *position, bool choice);

//возвращаем длину списка
int sizeOfList(List *list);

//возвращает указатель на следующий
ListElement *next(List *list, ListElement *position);

//возвращает указатель на средний
ListElement *middle(List *list);