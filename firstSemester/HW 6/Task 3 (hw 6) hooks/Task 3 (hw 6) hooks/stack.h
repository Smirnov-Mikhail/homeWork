#pragma once

struct StackElement;
struct Stack;

typedef char ElementType;
typedef StackElement *Position;

//������ ����
Stack *create();


//�������� �������
void push(Stack *stack, ElementType element);

//������� �������� ������
ElementType top(Stack *stack);

//������� ������
void pop(Stack *stack);

//��������� ���� �� �������
bool testForEmpty(Stack *stack);

//������� ����
void deleteStack(Stack *stack);