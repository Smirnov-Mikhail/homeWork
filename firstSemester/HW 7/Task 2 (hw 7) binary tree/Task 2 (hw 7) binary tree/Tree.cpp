#include "stdafx.h"
#include <iostream>
#include "Tree.h"

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
			int element = temp->value;

			deleteElement(temp, temp->value);
			root->value = element;
		}
		else
		{
			while (temp->leftChild->leftChild != nullptr)
				temp = temp->leftChild;

			int element = temp->leftChild->value;

			deleteElement(temp, temp->leftChild->value);
			root->value = element;
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
		std::cout << root->value << " ";
		printInDecreasing(root->leftChild);
	}
}

void deleteTree(NodeOfTree *root)
{
	if (root == nullptr)
	{
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