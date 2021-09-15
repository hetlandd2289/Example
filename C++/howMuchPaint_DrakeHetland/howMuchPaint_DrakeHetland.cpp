// Auth: Drake Hetland
// Date: 9/12/2021
// Desc: Calculator for paint needed while taking inputs from the user.

#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    // Declaring variables to take input or be used later
    double height = 0.0;
    double length = 0.0;

    // Declare paint as a variable for possible future modularity
    double paint = 340.0;

    // Display prompts and take inputs from user
    cout << "Please enter the height of the fence you wish to paint in feet: ";
    cin >> height;

    cout << "Please enter the length of the fence you wish to paint in feet: ";
    cin >> length;

    // Give user info based on what needs to be calculated
    cout << "One gallon of the paint that you wish to use will cover " << paint << " square feet.\n";

    // Use math operators to avoid taking up unnecessary amounts of RAM and display values to user
    cout << "The area of the fence you wish to paint is: " << height * length << " square feet\n";

    cout << "Two coats of paint will double the area to: " << height * length * 2 << " square feet\n";

    // Do final math operations, set precision so there aren't an overwhelming number of decimal places, and display result
    cout << "You will need: " << setprecision(3) << (height * length * 2) / paint << " gallons of paint to put two coats on your fence.\n";
}
