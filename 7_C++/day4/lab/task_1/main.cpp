#include <iostream>
#include <math.h>
#include<cstring>
#include<string>
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
        //cout<<"constructor\n";
    }
    complex_num(float real)
    {
        R=real;
        I=0;
        //cout<<"constructor\n";
    }
    complex_num()
    {
        R=0;
        I=0;

        //cout<<"constructor\n";
    }

    complex_num(const complex_num &copied)
    {
        //cout<<"copied constructor\n";
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
         // not valid
        //return complex(5,6)
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
    /* what we can return from function as address:
    -this
    -memory in heap
    -address of parameter if it was send by value
    */

    /* operator overloading
       c1 - c2
       c1 is caller
       c2 is input parameter

       can be inside class and standalone
       can not be static function


       can not do operator overload for:
       . -> ! ::  * &
     */
    complex_num operator- (const complex_num &c2)
    {
        complex_num result(R - c2.R,I-c2.I);
        return result;
    }
    complex_num operator- (int value)
    {
        complex_num result(R - value,I-value);
        return result;
    }

    /* change the value of caller
    if we want allow that shape c = (c1+=c2)
        we have to return c1 so we return *this
        *this -->object
        return & --> return by refernce to minimize copy construcotrs
        return object itself c1

        the same concept in ++ --
        if we want to allow c3 = c4++; return *this -->c4

    */
    complex_num & operator-= (const complex_num &c2)
    {
        R-=c2.R;
        I-=c2.I;

        return *this;
    }
    complex_num & operator-= (int value)
    {
        R-=value;
        I-=value;
        return *this;
    }
    ///pre --x
    // return after edit so we return this itself
    complex_num & operator-- ()
    {
        --R;
        --I;
        return *this;
    }
    ///post x--
    /* return before edit so we have to save
    save old value in new object

    so complier to know that is pre
    we send (int)
    */
    complex_num  operator-- (int)
    {
        complex_num result(R,I);
        R--;
        I--;
        return result;
    }

    int operator == (const complex_num &c2)
    {
        return (R==c2.R) && (I==c2.I);
    }
    int operator != (const complex_num &c2)
    {
        return (R!=c2.R) || (I!=c2.I);
    }
    int operator > (const complex_num &c2)
    {
        float x1=R*R;
        float y1=I*I;
        float x2=c2.R*c2.R;
        float y2=c2.I*c2.I;

        float v1 = sqrt(x1+y1);
        float v2 = sqrt(x2+y2);
        return v1>v2;

    }
    int operator >= (const complex_num &c2)
    {
        float x1=R*R;
        float y1=I*I;
        float x2=c2.R*c2.R;
        float y2=c2.I*c2.I;

        float v1 = sqrt(x1+y1);
        float v2 = sqrt(x2+y2);
        return v1>=v2;

    }
        int operator < (const complex_num &c2)
    {
        float x1=R*R;
        float y1=I*I;
        float x2=c2.R*c2.R;
        float y2=c2.I*c2.I;

        float v1 = sqrt(x1+y1);
        float v2 = sqrt(x2+y2);
        return v1<v2;

    }
    int operator <= (const complex_num &c2)
    {
        float x1=R*R;
        float y1=I*I;
        float x2=c2.R*c2.R;
        float y2=c2.I*c2.I;

        float v1 = sqrt(x1+y1);
        float v2 = sqrt(x2+y2);
        return v1<=v2;

    }

    /* operator casting
    can not specify the return datatype
     */
    operator int()
    {
        return R;
    }
    operator char*()
    {
        int tempR=(int)R;
        int tempI=(int)I;
        char *str=new char[70];
        char s[50];
        int counter=0,scounter=0;
        if(tempR<0)
        {
            str[counter++]='-';
            tempR*=-1;
        }
        while(tempR)
        {
            char c = (char)('0'+ (tempR%10));
            tempR/=10;
            s[scounter++]=c;
        }

        for(int j=scounter-1;j>=0;--j)
        {
            str[counter++]=s[j];
        }
        if(I>0)str[counter++]='+';
        if(tempI<0)
        {
            str[counter++]='-';
            tempI*=-1;
        }
        scounter=0;
         while(tempI)
        {
            char c = (char)('0'+ (tempI%10));
            tempI/=10;
            s[scounter++]=c;
        }

        for(int j=scounter-1;j>=0;--j)
        {
            str[counter++]=s[j];
        }
        str[counter++]='i';

        return str;

    }




    ~complex_num()
    {

        //cout<<"distructor\n";
    }

};

/* operator overloading but caller is value so
it consider both value and object as parameter */
// send as reference not const compiler will not allow it
complex_num operator- (int value , complex_num &c2)
{
        complex_num result(value - c2.get_R(),value-c2.get_I());
        return result;
}


int main()
{

    /* for methods in class
       there is only one function for all objects
       when object call function the complier send the object address (this)
       void setr (comp *this, int r) // send object address
       this-> pointer to object
    */

    /* c1 = c2 normal assignment
      Comp c1 = c2 // copy constructor
    */

    complex_num a(8,13);
    complex_num b(4,6);
    complex_num c;

//    c=a-b;          //8-4=4  13-6=7
//    c.print_complex();
//
//    c=7-a;
//    c.print_complex(); //7-8=-1   7-13=6
//
//    c=a-7;             //8-7=1  13-7=6
//    c.print_complex();
//
//    a-=b;              //8-4=4  13-6=7
//    a.print_complex();
//
//    a-=2;             //4-2=2     7-2=5
//    a.print_complex();
//
//    --a;              //1     4
//    a.print_complex();
//
//    c = (b--);
//    c.print_complex();//4   6
//    b.print_complex();//3  5

    complex_num x(8,2);
    complex_num y(8,2);

//    if(x==y)cout<<"x==y\n";
//
    complex_num n(-5,-1);
//    complex_num m(0,12);
//    if(n!=m)cout<<"n != m\n";
//    if(n>m)cout<<"n is bigger\n";
//
//   cout<<(int)n<<endl; //5
   cout<<(char*)n<<endl; //-5-1i










    return 0;
}
