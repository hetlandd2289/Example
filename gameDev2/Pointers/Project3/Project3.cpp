#include <iostream>

using namespace std;


int Addition(int a, int b)
{
    return (a + b);
}

int Subtraction(int a, int b)
{
    return (a - b);
}

int Operation(int x, int y, int(*functtocall)(int, int))
{
    int g;
    g = (*functtocall)(x, y);
    return g;
}

int main()
{
    int m, n;
    int(*Minus)(int, int) = Subtraction;

    m = Operation(7, 5, Addition);
    n = Operation(20, m, Minus);

    cout << n;
    return 0;
}
