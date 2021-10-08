// Auth: Drake Hetland
// Date: 8/27/2021
// Desc: Simple in class C++ Chapeter 2 Example

#include <iostream>
#include <iomanip>
#include <string>
#include <cmath>
#include <cstdlib>
#include <ctime>
using namespace std;

int main()
{
    cout << "Hello World!\n";
    cout << "How are you doing?" << endl << "Hopefully you are well! \r \\";
    cout << "\"Weather is poor here\" \a ";

    int b = 0;
    int a = 0;
    int c = 0;

    cin >> a;
    cin >> b;
    cin >> c;

    if (a == 0 and b == 0 and c == 0) {
        cout << "bruh";
    }
    else if (a < 0 or b < 0 or c < 0) {
        cout << "cringe";
    }
    else {
        cout << "nice";
    }
    
    
}
/*
int getCoverage() {
    float cov = 0;

    cout << "Enter the square feet that each gallon can cover: ";
    cin >> cov;

    if (cov > 0) {
        return cov;
    }

    else {
        return 340;
    }
}

void howMuchPaint() {
    float height = 0.0, length = 0.0;
    float coverage = getCoverage();

    cout << "Height of your fence in feet: ";
    cin >> height;
    cout << "Length of your fence in feet: ";
    cin >> length;

    cout << "You will need " << setprecision(3) << (length * height * 2 / coverage) << " gallons of paint for two coats of paint.\n";
}*/



