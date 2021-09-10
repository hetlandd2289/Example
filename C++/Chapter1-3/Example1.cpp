// Auth: Drake Hetland
// Date: 8/27/2021
// Desc: Simple in class C++ Chapeter 2 Example

#include <iostream>
using namespace std;


    

    //Chapter 3

void mathStuff() {
    int choice = -1;
    while (choice != 0)
    {
        cout << "1 - Promotion\n"
            << "2 - Dmotion\n"
            
            << "0 - Quit\n\n";

        cin >> choice;

        if (choice == 1)
        {
            int x = 3;
            float y = 5.0;

            cout << "Enter x: ";
            cin >> x;

            cout << "Enter y: ";
            cin >> y;

            cout << "X * Y = " << (x * y) << endl
                << "X:" << x << endl
                << "Y:" << y << endl;
        }

        if (choice == 2)
        {
            int x = 3;
            float y = 5.0;
            int result = 0;

            cout << "Enter x: ";
            cin >> x;

            cout << "Enter y: ";
            cin >> y;

            cout << "X * Y = " << (x * y) << endl
                << "X:" << x << endl
                << "Y:" << y << endl
                << "Result: " << result << endl;
        }
        cout << endl;
    }
}


    



    /*int main() {


                //Chapter 2
                //auto integer = 25;
                //auto pi = 3.14159;

        cout << "Your Choice: " << choice << endl;

        return 0;

        //Chapter 2
        cout << "Integer size: " << sizeof(integer) << endl;
        cout << "Float size: " << sizeof(pi) << endl;
        cout << "Double size: " << sizeof(double) << endl;

        //Chapter 1
        cout << "Hello World!\n";
        cout << "How are you doing?" << endl << "Hopefully you are well! \r \\";
        cout << "\"Weather is poor here\" \a ";

        return 0;
    }
    */


        