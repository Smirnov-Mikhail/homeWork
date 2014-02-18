#pragma once	

struct TreeNode;

// �������� ������
TreeNode* create(char value);

// �������� ������� � ������
void addNode(TreeNode *&tree, char a[], int &i);

// ������� �������� ����
void calculateNode(TreeNode *&tree);

// ������� �������� ����� ������
void calculateTree(TreeNode *&tree);

// ������� ������
void printTree(TreeNode *tree);

// ������� ������ � ���� ���������
void printExpression(TreeNode *tree);

// ������� ������
void deleteTree(TreeNode *root);

// ������� �������� ���������� result
int returnReuslt(TreeNode *&tree);