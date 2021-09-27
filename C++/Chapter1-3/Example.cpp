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

void resturantSelector() {
    //create enumerated data type
    enum yn{y, n};

    // Delcare variables
    string ve = "", va = "", gf = "";
    yn vege = n, vega = n, glut = n;

    cout << "Is anyone in your party a vegetarian? [y/n]: ";
    cin >> ve;
    cout << "Is anyone in your party a vegan? [y/n]: ";
    cin >> va;
    cout << "Is anyone in your party gluten-free [y/n]: ";
    cin >> gf;
}

int main()
{
    int choice = -1;

    while (choice != 0) {
        cout << "1 - Tell Joke\n"
             << "2 - Punchline\n"
             << "7 - Resturant Selector \n"
             << "0 - Quit";
        cin >> choice;

        switch (choice) {
            case 1:
                break;
            case 2:
                break;
            case 3: 
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                resturantSelector();
                break;
            case 0:
                cout << "Have a wonderful day!\n";
                break;
            default:
                cout << "Error 404: Please replace user and try again.";
        }
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
}
*/


