#include <iostream>

using namespace std;

class complex_num
{
private:
    float R;
    float I;


public:
    complex_num(float real,float imaginary)
    {
        R=real;
        I=imaginary;
        cout<<"constructor\n";
    }
    complex_num(float real)
    {
        R=real;
        I=0;
        cout<<"constructor\n";
    }
    complex_num()
    {

        cout<<"constructor\n";
    }

    /* will not compile without "const comp &c"
    must be passed by ref to not enter infinit loop
    if we implement it no bitwise anymore
        3 cases:
        -return object by value
        -pass object by value
        - initialize object from other object
          comp c3(c2);

    */
    complex_num(const complex_num &copied)
    {
        cout<<"copied constructor\n";
        R=copied.R;
        I=copied.I;
    }
    void set_R(float real)
    {
        R=real;
    }

    void set_I(float imaginary)
    {
        I=imaginary;
    }
    int get_R()
    {
        return R;
    }
    int get_I()
    {
        return I;
    }
    complex_num add(complex_num c2)
    {
        complex_num temp;
        temp.R = R+c2.R;
        temp.I = I+c2.I;
        return temp;
    }

    complex_num add_ref(const complex_num &c2)
    {
        complex_num temp;
        temp.R = R+c2.R;
        temp.I = I+c2.I;
        return temp;
    }
    complex_num sub(complex_num c2)
    {
        complex_num temp;
        temp.R = R-c2.R;
        temp.I = I-c2.I;
        return temp;
    }
    void print_complex()
    {
        if(R!=0 && I!=0)
        {
            cout<<R;
            if(I>0)cout<<'+'<<I<<"i"<<endl;
            else cout<<I<<"i"<<endl;
        }
        else if(R!=0)
        {
            cout<<R<<endl;
        }
        else if(I!=0)
        {
            cout<<I<<"i"<<endl;
        }
        else cout<<0;

}

    ~complex_num()
    {

        cout<<"distructor\n";
    }

};

int main()
{

    //pass by value
    complex_num a(5,6);
    complex_num b(8);
    complex_num c;
    c = a.add(b);
    c.print_complex();
/*
    a constructor
    b constructor
    c constructor
    -------------------------
    function call:
    ---------------
    copy constructor of b --> if we not have our own copy constructor we will not see it, it will be member wise(bitwise) copy
    temp constructor
    copy constructor of result to receive it in main  -->same as copy of b

    fun end:
    ---------
    result destructor
    copy of b destrucotr
    ----------------------------
    copy of result destructor
    c destructor
    b destructor
    a destructor
    ---------------------------------
    in debug mode:
    6 objects
    4 constructor 6 destructor as 2 copied bitwise
    6 constructors 6 destructor if we have our copy constructor
    --------------------------------------------------------------
    in resale mode: RVO (return value optimization)
    will extend the scope of result in main
    so copy of result will not be there
    5 objects
    4 constructors 5 destructors
    5 constructors 6 destructors

    */







    return 0;
}
