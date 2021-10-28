// classesPractice.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "goblin_class.h"
#include "dice.h"

using namespace std;

//prototypes
Goblin newGoblin();

int main()
{
    Goblin goblin = newGoblin();
    Goblin sraukk("Sraukk, Goblin Beast of the West", 7, 3, 2);
    Die d4(4), d6, d8(8);
    string uInput;

    cout << "Name: " << goblin.getName()
        << "\nHP: " << goblin.getHP()
        << "\nAttack: " << goblin.getAttack()
        << "\nDefence: " << goblin.getDef() << endl;

    cout << "\nEnter new name: ";
    getline(cin, uInput);
    sraukk.setName(uInput);
    //cout << "\nNew Name: " << goblin.getName();

    cout << "\nName: " << sraukk.getName()
        << "\nHP: " << sraukk.getHP()
        << "\nAttack: " << sraukk.getAttack()
        << "\nDefence: " << sraukk.getDef();

    
    cout << "\nRoll d4: " << d4.roll()
        << "\nRoll d6: " << d6.roll()
        << "\nRoll d8: " << d8.roll();
}

Goblin newGoblin()
{
    //declare variables
    
    string name;
    int HP;
    int attack;
    int def;

    cout << "\nEnter goblin's name: ";
    cin >> name;
    cout << "\nEnter " << name << "'s HP: ";
    cin >> HP;
    cout << "\nEnter " << name << "'s attack: ";
    cin >> attack;
    cout << "\nEnter " << name << "'s defence: ";
    cin >> def;

    //create the goblin
    Goblin g(name, HP, attack, def);

    return g;
    
    /* less efficient
    g.setName(name);
    g.setHP(HP);
    g.setAttack(attack);
    g.setDef(def);*/
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
