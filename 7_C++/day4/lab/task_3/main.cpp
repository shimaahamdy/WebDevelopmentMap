#include <iostream>

using namespace std;
class Mystack
{
private:
    int stacksize;
    int top;
    int *ptr;
public:
    Mystack(int sizestack=10)
    {
        //cout<<"constructor\n";
        stacksize=sizestack;
        top=0;
        ptr = new int [stacksize];
    }
    Mystack(const Mystack &copied)
    {
        //cout<<"copy constructor\n";
        stacksize = copied.stacksize;
        top = copied.top;
        ptr = new int [stacksize];
        for(int i=0;i<stacksize;++i)
        {
            ptr[i]=copied.ptr[i];
        }
    }

    bool isfull()
    {
        return top==stacksize;
    }
    bool isempty()
    {
        return top==0;
    }

    int peak()
    {
        if(!isempty())
           return ptr[top-1];
        cout<<"stack is empty the return -1 \n";
        return -1;
    }
    int pop()
    {
       if(!isempty())
          return ptr[--top];
       cout<<"stack is empty the return -1 \n";
       return -1;

    }
    void push(int value)
    {
        if(!isfull())
            ptr[top++]=value;
        else
            cout<<"stack is full\n";
    }

    Mystack reversed()
    {
        Mystack reversed_stack;
        for(int j=0,i=top-1;j<top;++j,--i)
        {
            reversed_stack.ptr[j]=ptr[i];
            reversed_stack.top++;
        }
        return reversed_stack;
    }

    /*
    c1 = c2 bitwise copy
    so we have to overload operator if we have pointer
    to be deep copy:

    create new memory same as c1
    free old of memory  of pointer in c1

    */
    const Mystack& operator = (const Mystack &c2)
    {
        top=c2.top;
        this->stacksize=c2.stacksize;

        delete []ptr;
        ptr = new int[stacksize];

        for(int i=0;i<top;++i)
        {
            ptr[i]=c2.ptr[i];
        }
        return c2; // is const in call have to return as const &
    }
    Mystack operator+ (const Mystack &s2)
    {
        Mystack result(this->stacksize+s2.stacksize);
        for(int i=0;i<top;++i)
        {
            result.push(ptr[i]);
        }
        for(int i=0;i<s2.top;++i)
        {
            result.push(s2.ptr[i]);
        }
        return result;
    }

    /*
     //read only return value int x = s[]
     // read and edit return reference int &  s[]=5
    */
    int & operator[] (int index)
    {
        if(index>=0 && index<stacksize)
            return ptr[index];
    }

    ~Mystack()
    {
        for(int i=0;i<stacksize;++i)
            ptr[i]=-1;

        delete [] ptr;
        ptr = NULL;
        //cout<<"destructor\n";
    }

};

int main()
{
    Mystack c1(5);

    c1.push(5);
    c1.push(6);
    c1.push(8);
    c1.push(10);

    Mystack c2;
    c2=c1;
    cout<<c1.pop()<<"\n";
    cout<<c2.pop()<<"\n";

    Mystack s1(3),s2(5),s3(2);
    s1.push(8);
    s1.push(10);
    s1.push(5);

    s2.push(15);
    s2.push(9);
    s2.push(3);

    s3 = s1+s2;
    cout<<s3.pop()<<endl;///3

    s3[4]=22;
    cout<<s3.pop()<<endl;

    cout<<s3[0];


    /*

    int fun(int x)
    {
      x++;
      return x; //return by value
    }

    a = fun(8);
    fun(a) = 9 // value = 9 not valid

    int *fun2 (int *x)
    {
      *(x)++;
      return x; // return address of x
    }
    *fun2()//access data
    *fun2() = 10 //valid
    int &fun3(int &x)
    {
      x++;
      return x; //return by reference
      fun3() = 10; //vaild access x=10
      int b = fun3() //copy of x and put in b


    }


    */



    return 0;
}
