#pragma once	

struct TreeNode;

// Создание дерева
TreeNode* create(char value);

// Добавить элемент в дерево
void addNode(TreeNode *&tree, char a[], int &i);

// считаем значение узла
void calculateNode(TreeNode *&tree);

// считаем значение всего дерева
void calculateTree(TreeNode *&tree);

// вывести дерево
void printTree(TreeNode *tree);

// вывести дерево в виде выражения
void printExpression(TreeNode *tree);

// удалить дерево
void deleteTree(TreeNode *root);

// вернуть значение переменной result
int returnReuslt(TreeNode *&tree);