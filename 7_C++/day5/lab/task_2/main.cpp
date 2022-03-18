#include <iostream>

using namespace std;
/*
define data type that is defined in runtime
if i send int T will replaced with int and so on
//type inference , compiler determine t in run time
compiler generate own copy of class or function that use
temp in memory
so according to the use there are different numbers of functions or class created

*/
template<class T>
void Swap(T &x,T &y)
{
    T temp = x;
    x=y;
    y=temp;
}
/*
end of scope t
if we have another class or function you have to write
template<class t>
class c{};
template<class c>
function {};
*/

// mixed types
template<class t1,class t2>
Swap(t1 x,t2 y)
{

}

template<class T>
class Mystack
{
private:
    int stacksize;
    int top;
    T *ptr;
    /*
       static : is shared value between all class objects
       it is class attribute not object attribute
       belong to class
       call by class name: comp::stacks_num;

       initialize: outside the class was private
       it initialize without create any object

       int comp::stacks_num=0;


    */

    static int stacks_num;
public:


    /*
      static function :
      -class behavior
      -function body doesn't depend on object members
      -deal with static attributes only
      -can not access non static members directly inside
      the funciton
      it dosent send this refernce

      but it can recive the object
      and access its attributes directly without setters and getters
    */
    //can not overload static method
    static int gets_num()
    {
        return stacks_num;
    }

    static Mystack sum(const Mystack &s1)
    {
        //this ->tos // not vaild
        int x = s1.gets_num();
    }
    Mystack(int sizestack=10)
    {
        //cout<<"constructor\n";
        stacksize=sizestack;
        top=0;
        ptr = new T [stacksize];
        stacks_num++;
    }
    Mystack(const Mystack &copied)
    {
        //cout<<"copy constructor\n";
        stacksize = copied.stacksize;
        top = copied.top;
        ptr = new T [stacksize];
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

    T peak()
    {
        if(!isempty())
           return ptr[top-1];
        cout<<"stack is empty the return -1 \n";
    }
    T pop()
    {
       if(!isempty())
          return ptr[--top];
       cout<<"stack is empty the return -1 \n";


    }
    void push(T value)
    {
        if(!isfull())
            ptr[top++]=value;
        else
            cout<<"stack is full\n";
    }


    const Mystack& operator = (const Mystack &c2)
    {
        top=c2.top;
        this->stacksize=c2.stacksize;

        delete []ptr;
        ptr = new T[stacksize];

        for(int i=0;i<top;++i)
        {
            ptr[i]=c2.ptr[i];
        }
        return c2;
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
template <class T>
// initialize static
/* here there is more than stacks_num
because there is differnt stacks
stack<int> has its own stacks_num
stack<char> has its own stacks_num
*/
int Mystack<T>::stacks_num=0;
int main()
{
    Mystack<int>s1;
    Mystack<float>f1;
    Mystack<char>c1;

    s1.push(5);
    s1.push(6);
    s1.push(8);
    s1.push(10);

    for(int i=0;i<4;++i)
        cout<<s1.pop()<<" ";
    cout<<endl;


    f1.push(10.3);
    f1.push(6.8);
    f1.push(81.888);
    f1.push(98.635);

    for(int i=0;i<4;++i)
        cout<<f1.pop()<<" ";
    cout<<endl;


    c1.push('a');
    c1.push('n');
    c1.push('a');
    c1.push('n');

    for(int i=0;i<4;++i)
        cout<<c1.pop()<<" ";
    cout<<endl;


    return 0;
}
