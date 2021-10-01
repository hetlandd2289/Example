// Auth: Drake Hetland
// Date: 8/27/2021
// Desc: Simple in class C++ Chapeter 2 Example

#include <iostream>
#include <iomanip>
#include <string>
#include <cmath>
#include <cstdlib>
#include <ctime>
#include <fstream>
using namespace std;

void resturantSelector() {
    
    // Delcare variables
    string ve = "", va = "", gf = "";

    cout << "Is anyone in your party a vegetarian? [y/n]: ";
    cin >> ve;
    cout << "Is anyone in your party a vegan? [y/n]: ";
    cin >> va;
    cout << "Is anyone in your party gluten-free [y/n]: ";
    cin >> gf;

    
    if (ve == "n" && va == "n" && gf == "n") {
        // Joe's Gorumet Burgers
        // Mama's Fine Italian
        // Main Street Pizza
        // The Chefs Kitchen
        // Corner Cafe
        cout << "Here are your resturant choices:\n-Joe's Gorumet Burgers\n-Mama's Fine Italian\n-Main Street Pizza\n-The Chefs Kitchen\n-Corner Cafe\n";
    }
    else if (ve == "y" && va == "n" && gf == "n") {
        // Mama's Fine Italian
        // Main Street Pizza
        // The Chefs Kitchen
        // Corner Cafe
        cout << "Here are your resturant choices:\n-Mama's Fine Italian\n-Main Street Pizza\n-The Chefs Kitchen\n-Corner Cafe\n";
    }
    else if (va == "n" && gf == "y") {
        // Main Street Pizza
        // The Chefs Kitchen
        // Corner Cafe
        cout << "Here are your resturant choices:\n-Main Street Pizza\n-The Chefs Kitchen\n-Corner Cafe\n";
    }
    else {
        // The Chefs Kitchen
        // Corner Cafe
        cout << "Here are your resturant choices:\n-The Chefs Kitchen\n-Corner Cafe\n";
    }
}

void outToFile(string name, string str) {
    ofstream outFile(name); //open
    if (outFile) {
        outFile << "We are writing to the file."; //manipulate
        outFile.close(); //close
    }
    else {
        cout << "Invalid File.\n"
    }
}

void inFromFile(string name) {
    ifstream inFile("example.txt"); //open

    if (inFile) {
        string fileInfo;

        getline(inFile, fileInfo) //display
            cout << fileInfo;

        inFile.close(); //close
    }
    else {
        cout << "Invalid File.\n"
    }
}

void fileStuffs() {
    
    outToFile("example.txt", "We are writting to the file");

    inFromFile("example.txt")
    
}

int main()
{
    int choice = -1;
    string str;

    while (choice != 0) {
        cout << "1 - Tell Joke\n"
             << "2 - Punchline\n"
             << "7 - Resturant Selector\n"
             << "0 - Quit\n";
        cin >> choice;

        switch (choice) {
        case 1: cout << "Haha just kidding no joke";
                break;
        case 2: cout << "Bruh I said there was no joke";
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
            case 8:
                fileStuffs();
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


