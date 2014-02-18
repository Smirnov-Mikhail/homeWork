#pragma once

#include <string>

struct NodeOfTree;

typedef char ElementType;
typedef NodeOfTree Tree;


//Создание дерева
NodeOfTree *createTree();


//Добавить элемент в дерево
void insert(NodeOfTree *&root, ElementType element);


//Выводим элементы дерева в порядке возрастания
void printInAscending(NodeOfTree *mainRoot);
//Выводим элементы дерева в порядке убывания
void printInDecreasing(NodeOfTree *mainRoot);
//Выводит дерево в виде арифметического выражения
void printInArifmeticForm(NodeOfTree *root);


//Удаление элемента из дерева
void deleteElement(NodeOfTree *&root, ElementType value);
//Удаляем дерево
void deleteTree(NodeOfTree *root);


//Функция проверяющее наличее элемента
bool findForElement(NodeOfTree *root, ElementType element);


//Заполнение дерева "арифметическим выражеинем"
void filling(NodeOfTree *&root, std::string str, int &position);


//Вычисление арифметического выражения
int calculate(NodeOfTree *&root);