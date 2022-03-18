#include <iostream>

using namespace std;
class Mystack
{
private:
    int stacksize;
    int top;
    int *ptr; //dynamic allocation for array
public:
    //default and parameter constructor
    Mystack(int sizestack=10)
    {
        stacksize=sizestack;
        top=0;
        ptr = new int [stacksize];
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

    /* here dest is a need to delete the memory
    we allocated in memory
    if we dont do that it will remain recived
    */
    ~Mystack()
    {
        delete [] ptr; //remove from heap
    }
};
int main()
{
    Mystack s(5);
    s.peak(); ///empty
    s.pop();   ///empty
    s.push(5);
    s.push(7);
    s.push(8);
    s.push(10);
    s.push(15);

    s.push(11); /// full

    cout<<s.pop()<<"\n";  ///15
    s.push(4);
    cout<<s.pop()<<"\n"; ///4


    /*
    int sum(int a=1,int b=2,int c=3)
    {return a+b+c;}

    sum(10,20,30) //a=10,b=20,c=30
    sum()//a=1,b=2,c=3
    sum(10)//a=10,b=2,c=3
    sum(10,20) a=10,b=20,c=3
    sum(,20,) // not vaild

    //vaild
    int sum2(int a,int b,int c=3)
    {return a+b+c;}

    //vaild
    int sum3(int a,int b=2,int c=3)
    {return a+b+c;}

    //not vaild
    //have to give c also
    int sum4(int a,int b=2,int c)
    {return a+b+c;}
    */


    return 0;
}
