#include <iostream>

using namespace std;
class geoshape
{
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
    float virtual calc_area()
    {
        return 0;
    }
    virtual ~geoshape()
    {
       cout<<"geoshape destrucotr\n";
    }

    // if we want force the child to override the function
    // pure virtual method  (abstract function)
    //1 - virtual
    //2 - no implementation
    //float virtual absarea() = 0;

    // any class that has at least one pure virtual function is abstract class
    // cant create an instance from abstract class
    // but we can create pointer geoshape * p;



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
    ~rec()
    {
        cout<<"rec destrucotr\n";
    }
};
class square:public rec
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
    ~square()
    {
        cout<<"square destrucotr\n";
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
    ~tri()
    {
        cout<<"tri destrucotr\n";
    }
};
class circle:public geoshape
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
    ~circle()
    {
        cout<<"circle destructor\n";
    }

};
// without virtual concept
// will take 3 kind of shapes to handle every type
//can not add new datatype fiald in open for extension and closed for modification
//have to edit function code to handle new tyep
float sumofArea(rec *arr1,int r,square *arr2,int s,tri *arr3,int t)
{
    // handle every class on its own no generalization
    float sum=0;
    for(int i=0;i<r;++i)
        sum+=arr1[i].calc_area(); //object of rec

    for(int i=0;i<r;++i)
        sum+=arr2[i].calc_area(); //object of square

    for(int i=0;i<r;++i)
        sum+=arr3[i].calc_area(); //object of tri

    /* new type circle : another loop */

    return sum;
}

//gerneral
// closed for modifications
float generalSumOfArea(geoshape *arr[], int Size)
{
    float Sum=0;
    for(int i=0;i<Size;++i)
        Sum+=arr[i]->calc_area();
    return Sum;
}
int main()
{
   //rec R(10,20); //static allocated object
   //rec *prec = new rec(30,40); //dynamic allocated

   //statically allocated array
   //rec Rarr[3];  //parameterless constructor if there is no one will gernerate compile error

   // initalize objects with the constructors we want (default or parameter)
  // rec Rarr[3]={rec(15,20),rec(20,25),rec(30,25)};

   // dynamic allocated array
   //rec *pArr = new rec[3] //default construcotr
   //initialize constructor
   rec *Arr1 = new rec[3]{rec(15,20),rec(20,25),rec(30,25)};
   square Arr2[2] = {square(40),square(50)};
   tri Arr3[3]={tri(55,60),tri(65,70),tri(75,80)};
   circle *Arr4 = new circle[2]{circle(85),circle(90)};


   //cout<<sumofArea(Arr1,3,Arr2,2,Arr3,3);

//   geoshape *ptr = new rec(10,20);
//   cout <<ptr->calc_area(); //rec implementation
//
//   delete ptr; //free rec from memory
//   ptr = new tri(10,20);
//   cout <<ptr->calc_area(); //tri implementation
     geoshape* garr[10];
     garr[0]= Arr1;
     garr[1]= &Arr1[1];
     garr[2]= Arr1+2;
     garr[3]= Arr2;
     garr[4]= &Arr2[1];
     garr[5]= &Arr3[0];
     garr[6]= Arr3+1;
     garr[7]= Arr3+2;

     cout<<"\n"<<generalSumOfArea(garr,8);
    // add new type of circle
     garr[8]=Arr4;

     /* if destrucotr private the compiler will not allow to create
     object as it has to know that it will destroyed */




    return 0;
}
