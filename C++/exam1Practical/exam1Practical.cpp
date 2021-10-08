// Auth: Drake Hetland
// Date: 9/17/21
// Desc: Exam 1 testing random numbers, logic, and input/output proficiency

#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
    // Declare a string variable for the user to enter the item they want to set the value of
    string item = "";

    // Declare double variable to user's input for value of item
    double price = 0.0;

    // Create seed for random varibles
    unsigned seed;
    seed = time(0);
    srand(seed);

    // Random variable for quantity of items
    int quantity = 0;
    quantity = rand();

    // Random variable for number of buyers. Maximum range = quantity - 1
    int buyers = 0;
    buyers = rand() % (quantity - 1) + 1;

    // Prompts user for name of item and stores in string varible
    cout << "Please enter the name of the item you wish to adjust the price of: ";
    cin >> item;

    // Prompt user for the price of item and stores in double variable
    cout << "Enter the price you wish to apply to " << item << ": ";
    cin >> price;

    // Splits up inputs from outputs/makes easier to read
    cout << endl;

    // Displays amount of buyers interested in product
    cout << "There are " << buyers << " buyers interested in this product. \n";

    // Displays the amount of items required for the buyers
    cout << "The required number of items for " << buyers << " buyers is: " << quantity << endl;

    // Displays the income from the sales of the item times the price set by the user
    cout << "Gross income from " << quantity << " sales of " << item << "(s) will be: $" << showpoint << quantity * price << endl;
}

