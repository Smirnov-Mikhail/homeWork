#pragma once
#include <string>

typedef std::string ElementType;

struct ListElement;
struct List;

typedef ListElement *Position;
typedef List *HeadList;

List *create();

//возращаем значение эелемента по указателю
ElementType returnStr(List *list, ListElement *position);

//возращаем значение эелемента по указателю
int returnFrequency(List *list, ListElement *position);

//вставляем элемент в голову
void insertToHead(List *list, ElementType element);

//вставляем элемент в список
void insert(List *list, Position position, ElementType element);

//увеличиваем переменную, которая отвечает за частоту встречаемости
void increaseFrequency(List *list, Position position);

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

//возвращаем длину списка
int sizeOfList(List *list);

//возвращает указатель на следующий
ListElement *next(List *list, ListElement *position);

//возвращает указатель на средний
ListElement *middle(List *list);