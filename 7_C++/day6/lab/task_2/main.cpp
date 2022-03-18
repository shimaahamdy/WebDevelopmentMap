#include <iostream>

using namespace std;
class parent
{
    /* if we have the destructor in private section of parent
    the compiler will not allow to create object from parent
    in compile time so in first constructor of child will generate error
    */
    /*
        ~parent()
    {

    }
    */
    /* also for constructor if we move all the constructors to private section
    the compiler will not allow to create object from child in compile time

    in child constructor the compiler check if there is public constucotr can
    be called
    parent()
    {
        x=y=0;
    }
    parent(int a,int b)
    {
        x=a;
        y=b;
    }
    */
protected:
    int x;
    int y;

    /* if the constructor in protected section it will compile normal
    parent(int a,int b)
    {
        x=a;
        y=b;
    }
    */
public:

    parent(int a,int b)
    {
        x=a;
        y=b;
    }
    int get_x()
    {
        return x;
    }
    int get_y()
    {
        return y;
    }
    void set_x(int a)
    {
        x=a;
    }
    void set_y(int b)
    {
        y=b;
    }
    int sum()
    {
        return x+y;
    }

    ~parent()
    {

    }

};
class child:public parent
{
    int z;
public:
    /* parent has no default constructor
    so  it will generate compile error

    child()
    {
        z=0;
    }
    */

    child(int a,int b,int c):parent(a,b)
    {
        z=c;
    }
    int get_z()
    {
        return z;
    }
    void set_z(int c)
    {
        z=c;
    }
    int sum()
    {
        return x+y+z;
    }

};
int main()
{
    parent p1(5,10);
    child c1(10,20,30);
    //child c2(); //question here

    cout<<p1.sum()<<endl;
    cout<<c1.sum();

    return 0;
}
