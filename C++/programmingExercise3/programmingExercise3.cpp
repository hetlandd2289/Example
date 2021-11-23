/*
    Auth: Drake Hetland
    Date: 11/19/21
    Desc: Indirect sorting via pointers
*/

#include <fstream>
#include "Person.cpp"
using namespace std;

int main()
{
    const int SIZE = 10;
    // create an array of Persons along with a perellel array of pointers
    Person people[SIZE];
    Person* pPerson[SIZE];

    // get data
    ifstream inFile("peopledata.txt");
    if (!inFile)
    {
        cout << "Enter data for ten people as prompted: " << endl;
        getPersonData(people);
    }
    else
    {
        getPersonData(people, inFile);
    }

    // Set the parallel array of pointers to point
    for (int i = 0; i < SIZE; i++)
    {
        pPerson[i] = &people[i];
    }
    //sort by pointers ascending
    sortByPointers(pPerson, people);
    //display array
    cout << "Here is the array: " << endl;
    displayPersonData(people);

    //display the array by pointers
    cout << "Here are the values indirectly via pointers: " << endl;
    displayPersonDataIndirect(pPerson);

    cout << "Press any key to end the program." << endl;
    cin.get();

    return 0;
}

