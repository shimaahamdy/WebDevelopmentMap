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

    ~Mystack_copy_const()
    {
        for(int i=0;i<stacksize;++i)
            ptr[i]=-1;

        delete [] ptr;
        ptr = NULL;
        cout<<"destructor\n";
    }
    friend void view_content2(Mystack_copy_const temp);
    friend void view_content_ref2(const Mystack_copy_const& temp);
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

    ~Mystack()
    {
        for(int i=0;i<stacksize;++i)
            ptr[i]=-1;
        cout<<"destructor\n";
        delete [] ptr;
        ptr = NULL;

    }

    /* friend unction can access private members of class
    without setter and getters
    --> no good use
    --> violate object orientated concept*/
    friend void view_content(Mystack temp);
    friend void view_content_ref(const Mystack &temp);
};


void view_content2(Mystack_copy_const temp)
{

    for(int i=0;i<temp.top;++i)
       cout<<temp.ptr[i]<<" ";
    cout<<"\n";
}
void view_content_ref2(const Mystack_copy_const& temp)
{

    for(int i=0;i<temp.top;++i)
       cout<<temp.ptr[i]<<" ";
    cout<<"\n";
}
void view_content(Mystack temp)
{

    for(int i=0;i<temp.top;++i)
       cout<<temp.ptr[i]<<" ";
    cout<<"\n";
}

/* const stack &c
const refrence can not edit
read only members
but we can edit in value that address refer to
c.ptr[0]=77; //valid
c.ptr = new int[7] //not valid

*/
void view_content_ref(const Mystack &temp)
{

    for(int i=0;i<temp.top;++i)
       cout<<temp.ptr[i]<<" ";
    cout<<"\n";
}

int main()
{
//    Mystack c1(5); ///without copy
//
//    c1.push(5);
//    c1.push(6);
//    c1.push(8);
//    c1.push(10);
    /*
       c1 is pass by value
       bitwise copy -->same pointer address
       when temp is destruct
       free pointer (memory of original object is freed)
    */
    //view_content(c1);

    /*
    sol: send object by ref
    but can edit content that
    ptr refer to
    */
    //view_content_ref(c1);



//    cout<<c1.pop()<<endl;  ///
//    cout<<c1.pop()<<endl;  ///
//    cout<<c1.pop()<<endl;  ///
//    cout<<c1.pop()<<endl;  ///

    /* sol : copy constuctor */

//    cout<<"with copy constructor\n";
//    Mystack_copy_const c2(5); ///with copy
//    c2.push(5);
//    c2.push(6);
//    c2.push(8);
//    c2.push(10);

    /* will have new ptr because of copy constructor */
//    view_content2(c2);
//    cout<<c2.pop()<<endl;  ///10
//    cout<<c2.pop()<<endl;  ///8


int *ptr = new int [5];
int *ptr2 = ptr;
delete []ptr;
ptr = NULL;
//
delete []ptr2;
    return 0;
}
