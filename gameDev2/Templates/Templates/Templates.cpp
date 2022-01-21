#include <iostream>

using namespace std;

template<class T>
void SwapValues(T& v1, T& v2)
{
    T = temp;

    temp = v1;
    v1 = v2;
    v2 = temp;
}

int main()
{
    int i1 = 1;
    int i2 = 2;

    cout << "Origional values: i1: " << i1 << " i2: " << i2 << endl;
    SwapValues(i1, i2);
    cout << "Swapped values: i1: " << i1 << " i2: " << i2 << endl;

    char s1 = 'A';
    char s2 = 'B';

}

