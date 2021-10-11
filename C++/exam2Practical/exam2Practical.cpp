// Auth: Drake Hetland
// Date: 10/8/2021
// Desc: Exam 2, program with two functions, and reading from and writting to a file.

#include <iostream>
#include <iomanip>
#include <string>
#include <cmath>
#include <cstdlib>
#include <ctime>
#include <fstream>
#include <locale>
#include <cctype>
using namespace std;

//Global constant for spool price, one less thing that needs to be passed as an argument, and adds to modularity.
const float SPOOL = 100.0;

//Get info function uses refrences to get and change the values of the variables that will be used throughout the function.
void getInfo(int& ordered, int& stock, float& shipping)
{
    //Character variable used to querry the user if they need to edit the default shipping/handling price.
    char special = 'n';

    //cout cin statements to get and store inputs from user.
    cout << "Enter how many spools of copper wire was ordered: ";
    cin >> ordered;
    cout << "Enter the number of spools in stock: ";
    cin >> stock;
    cout << "Are there any special shipping and handling charges(y/n): ";
    cin >> special;

    //if statement to access shipping price, basically so user wouldn't have to re-enter the default that is already stored there.
    if (tolower(special) == 'y')
    {
        cout << "Enter the special shipping and handling charge: ";
        cin >> shipping;
    }
}

//Function called after all inputs are obtained, vomits info after math back at the user.
void compute(int& ordered, int& stock, float& shipping, string& salesInfo)
{
    //New variable to store the number of actually available spools.
    //Heavily debated adding this variable, ended up shrinking code by 23 lines, and prevented a lot of repitition.
    //Still probably more efficient ways of doing it, but this made most sense to me while being more efficient than I had.
    int available = 0;

    //If else if structure, tests if amount ordered is more than that of the stock, assigns available accordingly.
    if (stock >= ordered) 
    {
        available = ordered;
    }

    //Displays backorder line only when it would be relevant information.
    else if (ordered > stock)
    {
        available = stock;
        cout << "There is a backorder of " << (ordered - stock) << " spools of copper wire.\n";
    }
    cout << "Spools of copper wire ready to ship from the current stock: " << available << endl
         << "Price of spools ready to ship: $" << fixed << setprecision(2) << (available * SPOOL) << endl
         << "Price of shipping: $" << fixed << setprecision(2) << (available * shipping) << endl
         << "Grand total: $" << fixed << setprecision(2) << ((available * shipping) + (available * SPOOL)) << endl << endl;

    //Copies all information displayed to user down to a file.
    ofstream outFile(salesInfo);//open File
    if (outFile)
    {
        outFile << "Spools of copper wire ready to ship from the current stock: " << available << endl
                << "Price of spools ready to ship: $" << fixed << setprecision(2) << (available * SPOOL) << endl
                << "Price of shipping: $" << fixed << setprecision(2) << (available * shipping) << endl
                << "Grand total: $" << fixed << setprecision(2) << ((available * shipping) + (available * SPOOL)) << endl << endl;
        outFile.close();//close file
    }
    else
    {
        cout << "File could not be written to.\n";
    }
}

//Function that can be called from main menu to read from file that is written to earlier.
void readInfo(string& salesInfo)
{
    ifstream inFile(salesInfo);//open file

    //If else structure to make sure that the file exists before trying to read from it.
    if (inFile)
    {
        string fileInfo;

        getline(inFile, fileInfo, '\0');
        cout << endl << fileInfo;
        inFile.close();
    }
    else 
    {
        cout << "File has yet to be written to, or cannot be found.\n\n";
    }
}

int main()
{
    //Declare variables that will be altered later.
    int ordered = 0;
    int stock = 0;
    float shipping = 10.0;
    
    //Variable for menu.
    int choice = -1;

    //Allows user to set the file they are reading and writting, adds modularity,
    //and allows for multiple sales records to and be stored at a time.
    string salesInfo = "salesInfo";
    cout << "Please enter the file name you wish to write to or read from: ";
    cin >> salesInfo;
    
    //Elected to use while instead of do while to give the user the option to read from files of previous usages,
    //insetead of making them do a loop before being able to read.
    while (choice != 0) {
        cout << "1 - Run Program\n"
             << "2 - Read Results From File\n"
             << "0 - Quit\n";
        cin >> choice;

        //Switch to enter the "meat" of the function, read files, or quit.
        switch (choice)
        {
        case 1:
            getInfo(ordered, stock, shipping);
            compute(ordered, stock, shipping, salesInfo);
            break;
        case 2:
            readInfo(salesInfo);
            break;
        case 0:
            break;
        default:
            break;
        }
    }
}

