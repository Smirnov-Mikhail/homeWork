#pragma once

struct NodeOfTree;

typedef int ElementType;
typedef NodeOfTree Tree;

// �������� ������
NodeOfTree *createTree();

// �������� ������� � ������
void insert(NodeOfTree *&root, ElementType element);

// ������� �������� ������ � ������� �����������
void printInAscending(NodeOfTree *mainRoot);

// ������� �������� ������ � ������� ��������
void printInDecreasing(NodeOfTree *mainRoot);

// �������� �������� �� ������
void deleteElement(NodeOfTree *&root, ElementType value);

// ������� ������
void deleteTree(NodeOfTree *root);

// ������� ����������� ������� ��������
bool findForElement(NodeOfTree *root, ElementType element);