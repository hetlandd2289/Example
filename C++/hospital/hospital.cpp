// Auth: Drake Hetland
// Date: 10/9/2021
// Desc: Program that validates and calculates the cost of a hospital stay based on user input.

#include <iostream>
#include <iomanip>
#include <string>
#include <cmath>
#include <cstdlib>
#include <ctime>
#include <fstream>
using namespace std;

//Function for calculating outpatient costs.
void oResult(float& service, float& medication)
{
    cout << "Total outpatient charges: $" << fixed << setprecision(2) << (service + medication) << endl;
}

//Function for calculating inpatient costs.
void iResult(int& days, float& rate, float& service, float& medication)
{
    cout << "Total inpatient charges: $" << fixed << setprecision(2) << ((days * rate) + service + medication) << endl;
}

//Validates first based on whether and values are negative, then by whether days and rate are 0.
void validation(int& days, float& rate, float& service, float& medication, int& patient)
{
    if (days >= 0 && rate >= 0 && service >= 0 && medication >= 0)
    {
        if (patient == 2)
        {
            oResult(service, medication);
        }
        else
        {
            iResult(days, rate, service, medication);
        }
    }
    else
    {
        cout << "Inputs cannot be negative.\n"
            << "Please try again.\n\n";
    }
}

int main()
{
    //Variable used for menu and switch statement
    int patient = -1;

    while (patient != 0)
    {
        //Variables initialized, as well as reset to 0 after every loop. Allows for validation to work properly
        int days = 0;
        float rate = 0.0;
        float service = 0.0;
        float medication = 0.0;

        cout << "1 - Inpatient\n"
            << "2 - Outpatient\n"
            << "0 - Quit\n";
        cin >> patient;

        switch (patient)
        {
        case 1:
        {
            cout << "Days spent in hospital: ";
            cin >> days;
            cout << "Daily rate: ";
            cin >> rate;
            cout << "Hospital services: $";
            cin >> service;
            cout << "Medication charges: $";
            cin >> medication;

            validation(days, rate, service, medication, patient);
            break;
        }
        case 2:
        {
            cout << "Hospital services: $";
            cin >> service;
            cout << "Medication charges: $";
            cin >> medication;

            validation(days, rate, service, medication, patient);
            break;
        }
        //Allows user to quit.
        case 0:
        {
            
            cout << "Goodbye.";
            break;
        }
        //Deals with erroneous input.
        default:
            cout << "Please only enter a 1 or 2 for patient type.\n\n";
            break;
        }
    }
}
