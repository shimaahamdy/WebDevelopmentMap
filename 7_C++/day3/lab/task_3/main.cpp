#include <iostream>

using namespace std;
class Mystack_copy_const
{
private:
    int stacksize;
    int top;
    int *ptr;
public:
    Mystack_copy_const(int sizestack=10)
    {
        cout<<"constructor\n";
        stacksize=sizestack;
        top=0;
        ptr = new int [stacksize];
    }
    Mystack_copy_const(const Mystack_copy_const &copied)
    {
        cout<<"copy constructor\n";
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

    Mystack_copy_const revers()
    {
        Mystack_copy_const reversed_stack;
        for(int j=0,i=top-1;j<top;++j,--i)
        {
            reversed_stack.ptr[j]=ptr[i];
            reversed_stack.top++;
        }
        return reversed_stack;
    }

    ~Mystack_copy_const()
    {
        for(int i=0;i<stacksize;++i)
            ptr[i]=-1;

        delete [] ptr;
        ptr = NULL;
        cout<<"destructor\n";
    }

};

class Mystack
{
private:
    int stacksize;
    int top;
    int *ptr;
public:
    Mystack(int sizestack=10)
    {
        cout<<"constructor\n";
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

    Mystack revers()
    {
        Mystack reversed_stack;
        int i=top-1;
        for(int j=0;j<top;++j)
        {
            reversed_stack.ptr[j]=ptr[i];
            reversed_stack.top++;
        }
        return reversed_stack;
    }

    ~Mystack()
    {
        for(int i=0;i<stacksize;++i)
            ptr[i]=-1;
        cout<<"destructor\n";
        delete [] ptr;
        ptr = NULL;

    }

};


int main()
{
    Mystack c1(5); ///without copy

    c1.push(5);
    c1.push(6);
    c1.push(8);
    c1.push(10);
      /* return object by value
      bitwise copy
       free original data memory
       */
    cout<<c1.revers().pop()<<endl;

//    cout<<"with copy constructor\n";
//    Mystack_copy_const c2(5); ///with copy
//    c2.push(5);
//    c2.push(6);
//    c2.push(8);
//    c2.push(10);
//    cout<<c2.revers().pop()<<endl;




    return 0;
}
