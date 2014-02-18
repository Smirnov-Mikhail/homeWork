#pragma once

#include <string>

struct NodeOfTree;

typedef char ElementType;
typedef NodeOfTree Tree;


//�������� ������
NodeOfTree *createTree();


//�������� ������� � ������
void insert(NodeOfTree *&root, ElementType element);


//������� �������� ������ � ������� �����������
void printInAscending(NodeOfTree *mainRoot);
//������� �������� ������ � ������� ��������
void printInDecreasing(NodeOfTree *mainRoot);
//������� ������ � ���� ��������������� ���������
void printInArifmeticForm(NodeOfTree *root);


//�������� �������� �� ������
void deleteElement(NodeOfTree *&root, ElementType value);
//������� ������
void deleteTree(NodeOfTree *root);


//������� ����������� ������� ��������
bool findForElement(NodeOfTree *root, ElementType element);


//���������� ������ "�������������� ����������"
void filling(NodeOfTree *&root, std::string str, int &position);


//���������� ��������������� ���������
int calculate(NodeOfTree *&root);