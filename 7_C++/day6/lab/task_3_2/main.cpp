#include <iostream>

using namespace std;
class geoshape
{
    int test()
    {
        return 15;
    };
protected:
    int dim1;
    int dim2;
public:
    geoshape(int a=0,int b=0)
    {
        dim1=a;
        dim2=b;
    }
    int get_dim1()
    {
        return dim1;
    }
    int get_dim2()
    {
        return dim2;
    }
    void set_dim1(int a)
    {
        dim1=a;
    }
    void set_dim2(int b)
    {
        dim2=b;
    }
};
class rec:public geoshape
{
public:
    rec(int w,int h):geoshape(w,h)
    {

    }
    float calc_area()
    {
        return dim1*dim2;
    }
};

/*
here the square inhirt private from rec
so outside square they can not access rec public methods
*/
class square:private rec
{
public:
    square(int l):rec(l,l)
    {

    }
        void set_dim1(int l)
    {
        dim1=dim2=l;
    }
    void set_dim2(int l)
    {
        dim1=dim2=l;
    }
    void set_dim(int r)
    {
        dim1=dim2=r;

    }
    int get_length()
    {
        return dim1;
    }
    float calc_area()
    {
        return dim1*dim2;
    }



};
class tri:public geoshape
{
public:
    tri(int w,int h):geoshape(w,h)
    {

    }
    float calc_area()
    {
        return 0.5*dim1*dim2;
    }

    /// function to be override and it was private in parent
    int test()
    {
        return 50;
    }
};
class circle:private geoshape
{
public:
    circle(int r):geoshape(r,r)
    {

    }
        void set_dim1(int r)
    {
        dim1=dim2=r;
    }
    void set_dim2(int r)
    {
        dim1=dim2=r;
    }
    int get_radius()
    {
        return dim1;
    }
    float calc_area()
    {
        return 3.14*dim1*dim2;
    }
};
int main()
{
    rec r1(10,15);
    r1.set_dim1(10);
    r1.set_dim2(20);
    cout<<r1.calc_area()<<endl;

    square s1(20);
    cout<<s1.calc_area()<<endl;

    s1.set_dim1(20);
    s1.set_dim2(30);
    cout<<s1.calc_area()<<endl;

    circle c1(25);
    cout<<c1.calc_area()<<endl;

    c1.set_dim1(20);
    c1.set_dim2(30);
    cout<<c1.calc_area()<<endl;

    tri t1(10,20);
    cout<<t1.calc_area()<<endl;

    //s1.geoshape::set_dim1(5);  //error inaccessible
    //s1.geoshape::set_dim2(10);
    //cout<<s1.calc_area();


    cout<<t1.test();





    return 0;
}
