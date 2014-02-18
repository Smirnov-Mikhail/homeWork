//Task 3 (hw 7) arifmetic tree
// Смирнов Михаил
#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <locale.h>
#include "tree.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	ifstream in ("input.txt");

	char str[1000];
    in.getline(str, 1000);

    cout << "Входные данные:" << endl << str << endl;

    TreeNode *tree;
    int i = 0;

    addNode(tree, str, i);

    cout << endl << "Дерево:" << endl;
    printTree(tree);
    cout << endl << endl;

    cout << "Выражение, хранящееся в дереве:" << endl;
    printExpression(tree);
    cout << endl << endl;

    calculateTree(tree);
    cout << "Ответ: " << returnReuslt(tree);
    cout << endl << endl;
   
    in.close();
    deleteTree(tree);

    return 0;
}
