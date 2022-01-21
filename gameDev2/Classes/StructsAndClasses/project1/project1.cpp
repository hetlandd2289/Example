#include <iostream>

using namespace std;

struct CDAccount
{
    double balance;
    double interestRate;
    int term; //months until maturity
};

struct Person
{

};

void GetData(CDAccount& theAccount);

int main()
{
    CDAccount account;
    GetData(account);

    cout.setf(ios::fixed);
    cout.setf(ios::showpoint);
    cout.precision(2);

}

void GetData(CDAccount& theAccount)
{
    cout << "Enter the balance: $";
    cin >> theAccount.balance;
    cout << "Enter the interest rate: ";
    cin >> theAccount.interestRate;

}