#include <iostream>

using namespace std;

//abstract base class
class Polygon
{
protected:
    int width;
    int height;
public:
    Polygon(int a, int b) : width(a), height(b) //Shorthand
    {
        //width = a; longhand
        //height = b;
    }
    virtual int Area(void) = 0; //pure virtual function
    void printArea()
    {
        cout << this->Area() << '\n';
    }
};

class Rectangle : public Polygon
{
public:
    Rectangle(int a, int b) : Polygon(a, b)
    {

    }
    int Area()
    {
        return width * height;
    }
};

class Triangle : public Polygon
{
public: 
    Triangle(int a, int b) : Polygon(a, b) 
    {
    
    }
    int Area()
    {
        return width * height / 2;
    }
};

int main()
{
    Polygon* poly1 = new Rectangle(4, 5);
    Polygon* poly2 = new Triangle(4, 5);
    poly1->printArea();
    poly2->printArea();

    delete poly1;
    delete poly2;
}
