// Auth: Drake Hetland
// Date: 11/5/2021
// Desc: Fishing game that incorperates a loop and simulated 6-sided die.

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

int main()
{
    //Introduction/Instructions
    cout << "Welcome to the fishing game. You may cast your rod as many times as you wish. \nAfter every cast, you will be given points"
         << " based on what you caught. \nWhen you decide to be finished, the game will tell you your total. Good luck, and have fun!" << endl << endl;

    //Variables to control the game loop and keep the running total, respectively
    unsigned int choice = -1;
    int total = 0;

    //Game loop
    do
    {
        //Rolls the die
        int fish = (rand() % (5 + 1));

        //Displays catch and assigns points accordingly
        switch (fish)
        {
            case 0:
                cout << "You caught a super rare fish!" << endl << endl;
                total += 7;
                break;
            case 1:
                cout << "You caught a small fish!" << endl << endl;
                total += 1;
                break;
            case 2:
                cout << "You caught a medium fish!" << endl << endl;
                total += 2;
                break;
            case 3:
                cout << "You caught a big fish!" << endl << endl;
                total += 3;
                break;
            case 4:
                cout << "You caught... an old tin can?" << endl << endl;
                total -= 1;
                break;
            case 5:
                cout << "You caught... nothing... " << endl << endl;
                break;
            default:
                cout << "Something went wrong. Please try again." << endl;
                break;
        }

        //Game loop choice
        cout << "Would you like to cast again?\n"
            << "1 - Yes\n"
            << "0 - No\n";

        cin >> choice;

        //Input validation
        while (choice > 1 || choice < 0)
        {
            cout << "Please only enter the numbers 1 or 0." << endl;
            cin >> choice;
        }

        //Switch breaks game loop or not base on user input, displays different closing messages based on user's points
        switch (choice)
        {
            case 1:
                choice = 1;
                break;
            case 0:
                choice = 0;
                
                if (total <= 0)
                    cout << "Your points from this round of fishing is " << total << endl << "You may want to find a new hobby..." << endl;
                else if (total > 0 && total < 20)
                    cout << "Good work! You scored " << total << " points this round of fishing!" << endl;
                else
                    cout << "Incredible! You scored " << total << " points! You are a master angler!" << endl;
                break;

            default:
                choice = 0;
                cout << "Something went wrong. Please try again." << endl;
                break;
        }
            
    } while (choice != 0);
}