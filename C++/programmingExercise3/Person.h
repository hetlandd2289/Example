#pragma once
#include <string>
#include <iostream>

using namespace std;

struct Person
{
	string name;
	int age;
};

//Prototypes for this struct
void getPersonData(Person personData[]);
void getPersonData(Person personData[], istream& inFile);
void displayPersonData(Person pPerson[]);
void displayPersonDataIndirect(Person* pPerson[]);
void sortByPointers(Person* pPerson[], Person personData[]);
void reverse(Person* pPerson[]);