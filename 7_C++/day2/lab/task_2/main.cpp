#include <iostream>

using namespace std;

class complex_num
{
    //constructors can be public and private
    // Destructors must be public

private:
    float R;
    float I;


public:
    /* os create object
    constucotr
    initalize object
    function called automaicaly by os one time only at creation time
    */
    complex_num(float real,float imaginary)
    {
        R=real;
        I=imaginary;
        cout<<"constructor\n";
    }
    // constructor overloading
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

    // member function
    /* the function here have 3 objects:
    -the copy C2 that recive the call
    -temp
    -the copy of temp in return
    */
    complex_num add(complex_num c2)
    {
        complex_num temp;
        temp.R = R+c2.R;
        temp.I = I+c2.I;
        return temp;
    }

    /* pass by ref:
       complex_num &c --> can edit c
       const complex_num &c --> read only

       here there is only 2 cojects created
       -temp
       -copy temp
       c2 is actual object
    */
    complex_num add_ref(const complex_num &c2)
    {
        complex_num temp;
        temp.R = R+c2.R;
        temp.I = I+c2.I;
        //c2.R=20; // not vaild as it was send by const
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

    /* destrucotr function called automacialy
    by os when destory object
    -parmaterless
    -only one destucotr per class

    */
    ~complex_num()
    {

        cout<<"destructor\n";
    }

};

//stand alone function
complex_num add(complex_num c1, complex_num c2)
{
        complex_num temp;
        float R = c1.get_R()+c2.get_R();
        float I = c1.get_I()+c2.get_I();
        temp.set_I(I);
        temp.set_R(R);
        return temp;
}
complex_num sub(complex_num c1, complex_num c2)
    {
        complex_num temp;
        float R = c1.get_R()-c2.get_R();
        float I = c1.get_I()-c2.get_I();
        temp.set_I(I);
        temp.set_R(R);
        return temp;
    }
complex_num multiply(complex_num c1, complex_num c2)
    {
        float R=0,I=0;complex_num temp;
        R += c1.get_R()*c2.get_R();
        I += c1.get_R()*c2.get_I();
        I += c1.get_I()*c2.get_R();
        R += -(c1.get_I()*c2.get_I());
        temp.set_I(I);
        temp.set_R(R);
        return temp;
    }

complex_num divison(complex_num c1, complex_num c2)
    {
        float R=0,I=0;complex_num temp;
        R += c1.get_R()*c2.get_R();
        R +=c1.get_I()*c2.get_I();
        R/= (c2.get_R()*c2.get_R()+ c2.get_I()*c2.get_I());

        I += c1.get_I()*c2.get_R();
        I -= (c1.get_R()*c2.get_I());
        I/= (c2.get_R()*c2.get_R()+ c2.get_I()*c2.get_I());
        temp.set_I(I);
        temp.set_R(R);
        return temp;
    }
int main()
{

    /* here despite the casting but it can recognize
    int fun(int x){};
    int fun(char x){};
    */
    /*
    the compiler will error but in call
    ambgious
    not vaild
    int fun(int x){};
    int fun(int &x){};
    */



    complex_num a(5,6);
    complex_num b(8);
    complex_num c; // object by default constuctor

    // pass by value
    // copy the b
    c = a.add(b);




    cout<<"\n\n\npass by refernce\n";
    complex_num x(5,6);
    complex_num y(8);
    complex_num z;
    z = x.add_ref(y);







    return 0;
}
