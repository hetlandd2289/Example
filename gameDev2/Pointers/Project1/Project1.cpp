#include <iostream>

using namespace std;

void swap1(int n1, int n2);
void swap2(int* n1, int* n2);

int main()
{
    int *p1, *p2;

    p1 = new int;
    p2 = p1;

    *p1 = 42;

    cout << "p1: " << p1 << endl << "*p1: " << *p1 << endl;
    cout << "p2: " << p2 << endl << "*p2: " << *p2 << endl;

    *p2 = 53;

    cout << "p1: " << p1 << endl << "*p1: " << *p1 << endl;
    cout << "p2: " << p2 << endl << "*p2: " << *p2 << endl;

    int p3 = 99;
    cout << "&p3: " << p3 << endl << "&p3: " << &p3 << endl;

    p1 = new int;
    *p1 = 88;

    cout << "p1: " << p1 << endl << "*p1: " << *p1 << endl;
    cout << "p2: " << p2 << endl << "*p2: " << *p2 << endl;

    delete p1;
    delete p2;

    p1 = 0;
    p2 = 0;

    int n1 = 2;
    int n2 = 3;
    swap(n1, n2);
    cout << "n1: " << n1 << endl;
    cout << "n2: " << n2 << endl;

    swap2(&n1, &n2);
    cout << "n1: " << n1 << endl;
    cout << "n2: " << n2 << endl;
}

void swap1(int n1, int n2)
{
    int t;
    t = n1;
    n1 = n2;
    n2 = t;
}

void swap2(int* n1, int* n2)
{
    int t;
    t = *n1;
    *n1 = *n2;
    *n2 = t;
}