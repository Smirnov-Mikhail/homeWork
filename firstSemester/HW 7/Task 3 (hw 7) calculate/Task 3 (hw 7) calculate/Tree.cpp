#include "stdafx.h"
#include <iostream>
#include "Tree.h"
#include <string>

using namespace std;

struct NodeOfTree
{
	ElementType value;
	Tree *leftChild;
	Tree *rightChild;
};

NodeOfTree *createTree()
{
	return nullptr;
}

NodeOfTree *createNode(ElementType element)
{
	NodeOfTree *root = new NodeOfTree;
	root->value = element;
	root->leftChild = nullptr;
	root->rightChild = nullptr;
	return root;
}

void insert(NodeOfTree *&root, ElementType element)
{
	if (root == nullptr)
		root = createNode(element);
	else if (root->value > element)
		insert(root->leftChild, element);
	else if (root->value < element)
		insert(root->rightChild, element);
}

bool findForElement(NodeOfTree *root, ElementType element)
{
	if (root == nullptr)
		return false;

	if (root->value == element)
		return true;
	else if (root->value > element)
		findForElement(root->leftChild, element);
	else if (root->value < element)
		findForElement(root->rightChild, element);
}

void deleteElement(NodeOfTree *&root, ElementType element) 
{
	if (root == nullptr)
		return;

	if (!findForElement(root, element))
		return;

	if (element < root->value)
		deleteElement(root->leftChild, element);
	else if (element > root->value)
		deleteElement(root->rightChild, element);
	else if (root->leftChild == nullptr && root->rightChild == nullptr) 
	{
		delete root;
		root = nullptr;
	} 
	else if (root->leftChild == nullptr) 
	{
		NodeOfTree *temp = root; 
		root = root->rightChild;
		delete temp;
	}
	else if (root->rightChild == nullptr) 
	{
		NodeOfTree *temp = root; 
		root = root->leftChild;
		delete temp;
	}
	else
	{
		NodeOfTree *temp = root->rightChild;

		if (temp->leftChild == nullptr)
		{
			root->value = temp->value;
			root->rightChild = nullptr;

			delete temp;
		}
		else
		{
			while (temp->leftChild->leftChild != nullptr)
				temp = temp->leftChild;
			root->value = temp->leftChild->value;
			temp->leftChild = nullptr;

			delete temp;
		}
	}
}

void printInAscending(NodeOfTree *root)
{
	if (root != nullptr)
	{
		printInAscending(root->leftChild);
		cout << root->value << " ";
		printInAscending(root->rightChild);
	}
}

void printInDecreasing(NodeOfTree *root)
{
	if (root != nullptr)
	{
		printInDecreasing(root->rightChild);
		cout << root->value << " ";
		printInDecreasing(root->leftChild);
	}
}

void printInArifmeticForm(NodeOfTree *root)
{
	cout << "vivat!" << endl;
	if (root->value == '+' || root->value == '*' || root->value == '/' || root->value == '-')
	{
		cout << '(' << root->value; 
		printInArifmeticForm(root->leftChild); 
		printInArifmeticForm(root->rightChild);
		cout << ')';
	}
	else if (root->value >= '0' && root->value <= '9')
		cout << root->value;
}

void deleteTree(NodeOfTree *root)
{
	if (root == nullptr)
	{
		delete root;
		return;
	}

	if (root->leftChild != nullptr)
	{
		deleteTree(root->leftChild);
	}

	if (root->rightChild != nullptr)
	{
		deleteTree(root->rightChild);
	}

	delete root;
}










bool isOperator(char a)
{
	return a == '+' || a == '-' || a == '*' || a == '/';
}

bool isBracketOrSpace(char a)
{
	return a == '(' || a == ')' || a == ' ';
}

void addNode(TreeNode *&tree, char a[], int &i)
{
	if (isBracketOrSpace(a[i]))
	{
		i++;
		addNode(tree, a, i);
	}

	else if (a[i] != '\n')
	{
		if (isOperator(a[i]))
		{
			tree = create(a[i]);
			i++;
			addNode(tree->left, a, i);
			addNode(tree->right, a, i);
		}

		else 
		{
			tree = create(a[i]);
			i++;
		}
	}

	else 
		return;
}

void calculateNode(NodeOfTree *&tree)
{
	double result = 0;

	switch (tree->value)
	{
		case '+':
		{
			result = tree->left->result + tree->right->result;
			break;
		}
		case '-':
		{
			result = tree->left->result - tree->right->result;
			break;
		}
		case '*':
		{
			result = tree->left->result * tree->right->result;
			break;
		}
		case '/':
		{
			result = tree->left->result / tree->right->result;
			break;
		}
	}

	delete tree->left;
	tree->left = nullptr;
	delete tree->right;
	tree->right = nullptr;
	tree->value = '0';
	tree->result = result;
}

void calculateTree(NodeOfTree *&tree)
{
	if (isOperator(tree->value))
	{
		if (!isOperator(tree->left->value) && !isOperator(tree->right->value))
			calculateNode(tree);
		else 
		{
			if (isOperator(tree->left->value))
                calculateTree(tree->left);
            if (isOperator(tree->right->value))
                calculateTree(tree->right);
            calculateTree(tree);
		}
	}
}