#include <iostream>
#include "LinkedList.h"
#include "Node.h"
using namespace std;

int main()
{
    LinkedList list;
    list.InsertNode(1);
    list.InsertNode(2);
    list.InsertNode(3);
    list.InsertNode(4);
    list.InsertNode(5);

    cout << "List elements: ";

    list.PrintList();
    cout << endl;

    list.DeleteNode(2);

    cout << "List is now: ";
    list.PrintList();

    cout << endl;
    return 0;
}