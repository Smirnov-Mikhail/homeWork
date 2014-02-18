#pragma once

struct NodeOfTree;

typedef int ElementType;
typedef NodeOfTree Tree;

// Создание дерева
NodeOfTree *createTree();

// Добавить элемент в дерево
void insert(NodeOfTree *&root, ElementType element);

// Выводим элементы дерева в порядке возрастания
void printInAscending(NodeOfTree *mainRoot);

// Выводим элементы дерева в порядке убывания
void printInDecreasing(NodeOfTree *mainRoot);

// Удаление элемента из дерева
void deleteElement(NodeOfTree *&root, ElementType value);

// Удаляем дерево
void deleteTree(NodeOfTree *root);

// Функция проверяющее наличее элемента
bool findForElement(NodeOfTree *root, ElementType element);