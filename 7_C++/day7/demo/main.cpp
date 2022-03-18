#include <iostream>

using namespace std;

class Base
{
protected:
    int X;
public:
    Base(int _X=0)
    {
        X = _X;
    }
    int GetX() { return X;}
    void SetX (int A) { X = A;}
    virtual ~Base () { cout<< "Base Destructor \n";}

    void Show ()
    {
        cout<<"I am Base \n";
    }
    //1.Public Virtual Method
    void virtual DynShow()
    {
        cout << "I am Base \n";
    }
};
//2. Public Inheritance
class Derived : public Base
{
protected :
    int Y;
public:
    Derived ( int _X =0 , int _Y = 0):Base(_X)
    { Y = _Y; }
    ~Derived() { cout<<"Derived Dest \n";}
    int GetY() { return Y;}
    void SetY(int B) { Y = B;}

    /* it is override also hide the old implementation but work on
    objects only */
    void Show()
    {
        cout <<"I am Derived \n";
    }
    //3.overriding with a Public method
    void DynShow() /*override*/
    {
        cout<< "I am Derived \n";
    }
};

class Derived2 : public Derived
{
public:
    /* it stays virtual method */
    void DynShow()
    {
        cout<<"I am Derived 02 \n";
    }
    ~Derived2()
    {
        cout<<"Derived2 Dest \n";
    }
};


/* abstract class useges:
1- inhit in concreate class
2- static methods
*/
class AbsClass
{
protected:
    int X , Y;
public:

    /* why constructor important here ?

        when we inhirt we need to initialize base
        section in child
        use in chaining
        so yes there is object created form abstract class
        but in child section only

    */
    AbsClass(int x , int y)
    {
         X = x; Y = y;
    }

    void Myfun () { cout <<"Abs Class \n" ;}

    void virtual Show () { cout <<"I am Base \n";}

    void virtual Fun01()=0; //make class abstract class
    virtual ~AbsClass()
    {
        cout<<"absclaa destrucot\n";
    }
};
//concrete
// provide implementation for abstract methods
class Derive01 : public AbsClass
{
    int Z ;
public:
    Derive01():AbsClass(-1,-1)
    {

        Z = -1;
    }

    void Fun01()
    {
        cout<<"Derived 01 Implementation \n";
    }
    void Show()
    {
        cout<<"i am derived 01\n";
    }
};
//abstract
class Derive02 : public AbsClass
{

public:
    void Fun02 ( int x ) { cout <<++X;}
};

int main()
{

    /* we declare object from base have all
    base methods and fields*/
//    Base B (1); //initialize object
//    B.Show(); //Base
//    B.DynShow(); //Base
//
//    /* here also an object from derived
//    so have it own copy of implementation
//    and filds */
//    Derived D(2,3);
//    D.Show(); //Derived
//    D.DynShow();//Derived

//    Base *BPtr ;//pointer to base object (dynamic allocation --> heap)
//    //Bptr = new Base() //default consturctor
//    BPtr = new Base(4);
//    //BPtr->Show(); //Base
//    BPtr->DynShow(); //Base
//
//    Derived *DPtr;
//    DPtr = new Derived(5,6);
//    //DPtr->Show(); //Derived
//    DPtr->DynShow(); //Derived
//
//    // free memory;
//    delete DPtr;
//    delete BPtr;
//    // DPtr->DynShow(); //not known as memory that pointer refer to was freeed
//    DPtr=NULL;
//    BPtr=NULL;

    /* every derived has part of is derived
       derived is a base
       so we can treat derived as a base
       and make pointer from kind base to refer to
       base section in derived

    */
//
 //   Base *BPtr;
   // Derived *DPtr;
    //BPtr = new Derived (7,8); //Valid (implicit casting from pointer to derive to pointer base)
//    //Every Derived is A Base , is Kind of Base
//    //Base Object inside each Derived Object
//    //Base * = Derived Object
//    //Base & = Derived Object
//
   // BPtr->Show();  //Base
//    // Statically Binded Methods , Early Binded Function
//    // Compiler Bind Function Call to function Code
//    // as Early as Compilation Time , Statically based on Pointer Type
//    // not Object Type


      /* to achieve dynamic binding and call derived methods
      in run time there are 4 steps:
      1- virtual public function( first time function created in the hirercy )
      2- public inheritance --> if there is virtual and inhirtance not public compilation error
      3- override function
      4- pointer to base refer to derived object
      Pointer(Ref) to Base = Derived Object*/
    //BPtr = new Derived (7,8); //Valid
    //BPtr = &D; //vaild
    //BPtr = DPtr; //vaild


    //BPtr->DynShow(); //I am Derived
    //Dynamic Binding , Late Binding
    //Binding will be carried out as late as Runtime by OS
    //based on Object Type not based on Pointer(ref) Type

     /* if function is virtual it stays virtual*/
//    /*
    // grand parent refer to child
     //Base * BPtr = new Derived2();
     //BPtr->DynShow(); //Derived02
//
//
    //parent refer to child
    //Derived *DPtr = new Derived2();
    //DPtr->DynShow(); // Derived02
//
//    //BPtr = new Derived();
//    //BPtr->DynShow(); //Derived

    //not Valid
    //derived refer to base
    //DPtr = new Base();
    //Dptr = (Derived*)new base() // valid but no sense
//
      //Base B(1) ; Derived D(2,3);
      //B = D;
      //B.DynShow(); //Base
      //D = (Derived)B; //invaild cast
      //D.DynShow(); //derived
 //   not a valid usage for Virtual (it is object not pointer)

     Base *BPtr;
    Derived *DPtr;
    BPtr = new Derived (7,8);
    DPtr = new Derived2();

    /* when we delete the BPtr it will
    will implement the base only*/
    /* Deleting a derived class object using a pointer of base class type that has a non-virtual
     destructor results in undefined behavior.
     Making base class destructor virtual guarantees that the object of derived class is destructed properly,
      i.e., both base class and derived class destructors are called */
    //delete BPtr;
    delete DPtr;

        //AbsClass O1(1,2); not valid to create an instance from Abstract class
//    AbsClass *Ptr; //vaild
//
 //   Derive01 O1; // object from dervied01
//    Ptr = new Derive01();
//    Ptr->Fun01(); //

     Derive01 a;//concrete
     a.AbsClass::Show(); //scope operator access base function (even if it virtual)
     //a.AbsClass::Fun01(); // error it is pure virtual has no implemenation




    return 0;
}
