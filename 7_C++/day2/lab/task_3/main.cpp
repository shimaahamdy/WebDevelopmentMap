#include <iostream>

using namespace std;

class Myqueue_shifting
{
private:
    int head;
    int tail;
    int *ptr;
    int queuesize;

public:
    Myqueue_shifting(int qsize=10)
    {
        head=0;
        tail=0;
        queuesize=qsize;
        ptr = new int[queuesize];

    }
    bool isfull()
    {
        return tail==queuesize;
    }
    bool isempty()
    {
        return tail==0;
    }

    void enqueue(int value)
    {
        if(!isfull())
            ptr[tail++]=value;
        else cout<<"queue is full the return -1 \n";

    }
    int peek()
    {
        if(!isempty())
            return ptr[head];
        cout<<"queue is empty the return -1 \n";
        return -1;
    }
    int dequeu()
    {
        if(!isempty())
        {

            int value = ptr[head];
            for(int i=1;i<tail;++i)
            {
                ptr[i-1]=ptr[i];

            }
            --tail;
            return value;

        }
        cout<<"queue is empty the return -1 \n";
        return -1;
    }
    ~Myqueue_shifting()
    {
        delete [] ptr;
    }


};

/// circular
class Myqueue_circular
{
private:
    int head;
    int tail;
    int *ptr;
    int queuesize;
    int items;

public:
    Myqueue_circular(int qsize=10)
    {
        head=0;
        tail=-1;
        items=0;
        queuesize=qsize;
        ptr = new int[queuesize];

    }
    bool isfull()
    {
        return items==queuesize;
    }
    bool isempty()
    {
        return items==0;
    }

    void enqueue(int value)
    {
        if(!isfull())
        {
            if(tail==queuesize-1)tail=-1;
            ptr[++tail]=value;
            ++items;
        }

        else cout<<"queue is full the return -1 \n";

    }
    int peek()
    {
        if(!isempty())
            return ptr[head];
        cout<<"queue is empty the return -1 \n";
        return -1;
    }
    int dequeu()
    {
        if(!isempty())
        {

            int value = ptr[head++];
            if(head==queuesize)head=0;
            --items;
            return value;

        }
        cout<<"queue is empty the return -1 \n";
        return -1;
    }
    ~Myqueue_circular()
    {
        delete [] ptr;
    }


};
int main()
{
/*
    Myqueue_shifting q1(4);

    q1.peek();
    q1.dequeu();

    q1.enqueue(5);
    q1.enqueue(6);
    q1.enqueue(8);

    cout<<q1.dequeu(); //5
    cout<<q1.dequeu();  //6

    q1.enqueue(15);

    cout<<q1.peek(); //8
    cout<<q1.dequeu(); //8

    cout<<q1.dequeu(); //15
    q1.dequeu();

*/
    Myqueue_circular q2(4);

    q2.peek();
    q2.dequeu();

    q2.enqueue(5);
    q2.enqueue(6);
    q2.enqueue(8);

    cout<<q2.dequeu(); //5
    cout<<q2.dequeu();  //6

    q2.enqueue(15);

    cout<<q2.peek(); //8
    cout<<q2.dequeu(); //8

    cout<<q2.dequeu(); //15
    q2.dequeu();
    /* empty */
    q2.enqueue(2);
    q2.enqueue(3);
    cout<<q2.dequeu();
    q2.enqueue(4);
    cout<<q2.dequeu();
    cout<<q2.peek();




    return 0;
}
