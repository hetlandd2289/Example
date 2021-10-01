#include <iostream>
#include <cmath>
#include <cctype>

using namespace std;

void displayRaceMenu() {
    cout << "1 - Human\n"
        << "2 - Elf\n"
        << "3 - Dwarf\n"
        << "0 - Quit\n\n";
}

void displayJobMenu() {
    cout << "1 - Bard\n"
        << "2 - Cleric\n"
        << "3 - Monk\n"
        << "0 - Quit\n\n";
}

int main()
{
    enum race {human, elf, dwarf};
    enum job {bard, cleric, monk};
    
    int choice = -1;
    int raceChoice;
    int jobChoice;
    race pRace;
    job pJob;

    do{
        cout << "1- Select Race\n"
            << "2 - Select Class\n"
            << "3 - Quit\n\n";
        cin >> choice;

        switch (choice) {
        case 1:
            displayRaceMenu();
            cin >> raceChoice;

            switch (raceChoice) {
            case 1:
                pRace = human;
                break;
            case 2:
                pRace = elf;
                break;
            case 3:
                pRace = dwarf;
                break;
            default:
                break;

            }
        case 2:
            displayJobMenu();
            cin >> jobChoice;

            switch (jobChoice) {
            case 1:
                pJob = bard;
                break;
            case 2:
                pJob = cleric;
                break;
            case 3:
                pJob = monk;
                break;
            }
        case 0:
            cout << "invalid input";
            break;
        }
    } while (choice != 0);
    
}
