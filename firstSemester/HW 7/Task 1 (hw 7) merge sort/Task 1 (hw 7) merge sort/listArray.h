#pragma once

struct ListArray;

typedef int ElementType;

//создание списка
//переменная choice помогает нам выбирать между созданием списка на указателях и списка на массиве
ListArray *create(int choice);


//Возвращаем позицию первого элемента
int head(ListArray *list);

//Возвращаем позицию последнего элемента
int last(ListArray *list);

//Возвращаем позицию последнего элемента
int next(ListArray *list, int position);
//Возвращаем позицию среднего элемента 
int middle(ListArray *list);
//Возвращаем значение элемента, стоящего на определённой позиции
ElementType returnValue(ListArray *list, int position);


//Вставляем элемент на позицию следующую после position
void insert(ListArray *list, ElementType value, int position);
//Вставляем элемент в начало
void insertToHead(ListArray *list, ElementType value);


//Удаление элемента, стоящего на определённой позиции
void remove(ListArray *list, int position);
//Удаление первого элемента
void removeHead(ListArray *list);
//Удаляем список
void deleteList(ListArray *list);


//Выводим список
void printList(ListArray *list);


//Возвращаем длину списка
int sizeOfList(ListArray *list);