// Task 2 (hw5)
//Смирнов Михаил Александрович
#include "stdafx.h"
#include <iostream>
#include <locale.h>

using namespace std;

#include "list.h"

int main()
{
	setlocale(LC_ALL, "Russian");
	List *list = create();
	
	int choice = 1;
	while (choice)
	{
		cout << "Введите 0(закончить работу), 1(внести в список),\n2(удалить из списка) или 3(вывести список): " << endl;
		cin >> choice;
		switch(choice)
		{
			case 1:
				{
					cout << "Введите элемент, который хотите внести в список:" << endl;
					int element = 0;
					cin >> element;
					insert(list, element);
				}
				break;
			case 2:
				{
					cout << "Введите элемент, который хотите удалить\n(если такого элемента в списке нет, то ничего удалено не будет): " << endl;
					int element = 0;
					cin >> element;
					Position number = head(list);

					//проверяем на пустоту
					if (number == nullptr)
						break;

					//отдельно работаем с "головой"
					if (returnValue(list, number) == element)
					{
						removeHead(list);
						break;
					}

					//ищем и удаляем нужный элемент
					remove(list, element);
				}
				break;
			case 3:
				{
					cout << "Наш список:" << endl;
					print(list);
					cout << endl;
				}
				break;
		}
	}
	
	deleteList(list);

	return 0;
}