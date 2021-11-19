/*
    Auth: Drake Hetland
    Date: 11/19/21
    Desc: Indirect sorting via pointers
*/

#include <iostream>
#include <fstream>
#include "Person.h"
using namespace std;

void getPersonData(Person people[])
{
    for (int i = 0; i < sizeof(people); i++)
    {
        Person p;
        cout << "\nEnter the name: " << endl;
        getline(cin, p.name);
        cout << "\nEnter the age: " << endl;
        cin >> p.age;

        people[i] = p;
    }
}

void getPersonData(Person people[], ifstream& inFile)
{
    Person p;
    string n;
    int a;
    int i = 0;
    while (!inFile.eof())
    {
        inFile >> n;
        inFile >> a;

        p.name = n;
        p.age = a;

        people[i] = p;
        i++;
    }
}


int main()
{
    const int SIZE = 10;
    // create an array of Persons along with a perellel array of pointers
    Person people[SIZE];
    Person pPerson[SIZE];

    // get data
    ifstream infile("people.txt");
    if (!infile)
    {
        cout << "Enter data for ten people as prompted: " << endl;
        getPersonData(people);
    }
    else
    {
        getPersonData(people, infile);
    }

    // Set the parallel array of pointers to point
    for (int i = 0; i < SIZE; i++)
    {
        pPerson[i] = &people[i];
    }

    //sortByPointers(pPerson, people);
    //display array
    cout << "Here is the array: " << endl;
    //displayPersonData(people);

    //display the array as pointers
    cout << "Here are the values via pointers: " << endl;
    //displayIndirectly(pPerson);
    return 0;
}

