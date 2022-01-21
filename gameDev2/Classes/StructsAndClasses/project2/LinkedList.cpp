#include <iostream>
#include "LinkedList.h"

LinkedList::LinkedList()
{

}

void LinkedList::InsertNode(int data)
{
	//Create a new node
	Node* newNode = new Node(data);

	//Assign to head - base case
	if (head == NULL)
	{
		head = newNode;
		return;
	}

	//Traverse until the end of the list
	Node* temp = head;
	while (temp->next != NULL)
	{
		temp = temp->next;
	}

	temp->next = newNode;
}

void LinkedList::PrintList()
{
	Node* temp = head;

	if (head == nullptr)
	{
		std::cout << "List is empty\n";
		return;
	}

	while (temp != NULL)
	{
		//std::cout << (*temp).data << " "; LESS EFFICIENT
		std::cout << temp->data << " ";
		//temp - (*temp).next; LESS EFFICIENT
		temp = temp->next;
	}
}

void LinkedList::DeleteNode(int nodeOffset)
{
	Node* temp1 = head;
	Node* temp2 = NULL;

	int listLength = 0;

	if (head == NULL)
	{
		std::cout << "List is empty";
		return;
	}

	while (temp1 != NULL)
	{
		temp1 = temp1->next;
		listLength++;
	}

	if (listLength < nodeOffset)
	{
		std::cout << "Index out of range" << std::endl;
	}

	temp1 = head;

	if (nodeOffset == 1)
	{
		head = head->next;
		delete temp1;
		return;
	}
	
	while (nodeOffset-- > 1)
	{
		temp2 = temp1;
		temp1 = temp1->next;
	}

	temp2->next = temp1->next;
	delete temp1;
}
