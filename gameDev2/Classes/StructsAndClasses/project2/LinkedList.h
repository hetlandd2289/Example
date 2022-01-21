#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include "Node.h"

class LinkedList
{
public:
	LinkedList();

	//insert node at the end of the list
	void InsertNode(int);

	//print list
	void PrintList();

	//delete node at given position
	void DeleteNode(int);
protected:
private:
	Node* head;

};
#endif