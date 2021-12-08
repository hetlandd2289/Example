#include "Person.h"
#include <algorithm> //for the swap

const int SIZE = 10;

void getPersonData(Person personData[])
{
	for (int i = 0; i < SIZE; i++)
	{
		cout << "\nEnter the person's name: " << endl;
		getline(cin, personData[i].name);

		cout << "\nEnter the person's age: " << endl;
		cin >> personData[i].age;
		cin.ignore();
	}
}


void getPersonData(Person personData[], istream& inFile)
{
	for (int i = 0; i < SIZE; i++)
	{
		getline(inFile, personData[i].name);
		inFile >> personData[i].age;
		inFile.ignore();
	}
}


void displayPersonData(Person personData[])
{
	for (int i = 0; i < SIZE; i++)
	{
		cout << "\nName: " << personData[i].name << "\nAge: " << personData[i].age << endl << endl;
	}
}


void displayPersonDataIndirect(Person* pPerson[])
{
	for (int i = 0; i < SIZE; i++)
	{
		cout << "\nName: " << pPerson[i]->name << "\nAge: " << pPerson[i]->age << endl << endl;
	}
}


void sortByPointers(Person* pPerson[], Person personData[])
{
	int minPos; //position of the pointer to the minimum value
	for (int i = 0; i < (SIZE - 1); i++)
	{
		minPos = i;
		for (int pos = i + 1; pos < (SIZE - 1); pos++)
		{
			if (pPerson[pos]->name < pPerson[minPos]->name)
				minPos = pos;
		}
		swap(pPerson[i], pPerson[minPos]);
	}
}

void reverse(Person* pPerson[])
{
	int lower = 0;
	int upper = SIZE - 1;

	while (lower < upper)
	{
		swap(pPerson[lower], pPerson[upper]);
		lower++;
		upper--;
	}
}