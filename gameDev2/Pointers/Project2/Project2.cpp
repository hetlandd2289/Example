#include <iostream>
#include <cstdlib>
#include <algorithm>
#include <cstddef>

using namespace std;

typedef int* IntArrayPtr;

void FillArray(int a[], int size);
void Sort(int a[], int size);
void MemoryLeak();

int main()
{
    int arraySize;
    cout << "How many numbers\n";
    cin >> arraySize;

    int b[5];

    IntArrayPtr a;
    a = new int[arraySize];

    FillArray(a, arraySize);
    Sort(a, arraySize);

    cout << "Sorted array: " << " ";
    for (int i = 0; i < arraySize; i++)
    {
        cout << a[i] << " ";
        //same as
        cout << *(a + i);
    }

    delete a[];
}

void FillArray(int a[], int size)
{
    cout << "Enter " << size << "integers." << endl;
    for (int i = 0; i < size; i++)
    {
        cin >> a[i];
    }

    return;
}
void Sort(int a[], int size)
{
    sort(a, a + size);
    return;
}
void MemoryLeak()
{
    int* l = new int;
    *l = 12;
    delete l;
    return;
}
