#include <iostream>
using namespace std;

#include "Queue.h"
#include "include\StackLinkedList.h"
#include "include\QueueLinkedList.h"
#include "include\QueueCircular.h"


int main()
{
    StackLinkedList Stack1;
    Stack1.Push(5);
    Stack1.Push(7);
    Stack1.Push(15);

    int item;
    int vaild;
    Stack1.Pop(item); //15
    cout<<item<<endl;
    Stack1.peek(item); //7
    Stack1.Pop(item);  //7
    cout<<item<<endl;
    Stack1.Pop(item); //5
    cout<<item<<endl;
    cout<<Stack1.Pop(item)<<endl; //0 not vaild
    Stack1.Push(35);
    Stack1.Pop(item);
    cout<<item<<endl;   //35



    Queue que(3);

    que.EnQueue(3);
    que.EnQueue(5);
    que.EnQueue(7);

    cout<<que.EnQueue(47)<<endl;

    que.DeQueue(item);
    cout<<item<<endl;  //3
    que.DeQueue(item);
    cout<<item<<endl;  //5
    que.DeQueue(item);
    cout<<item<<endl;  //7

    cout<<que.DeQueue(item)<<endl; //0 not vaild
    que.EnQueue(102);
    que.DeQueue(item);
    cout<<item<<endl;  //102


    QueueLinkedList que2;

    que2.EnQueue(3);
    que2.EnQueue(5);
    que2.EnQueue(7);


    que2.DeQueue(item);
    cout<<item<<endl;  //3
    que2.DeQueue(item);
    cout<<item<<endl;  //5
    que2.DeQueue(item);
    cout<<item<<endl;  //7

    cout<<que2.DeQueue(item)<<endl; //0 not vaild
    que2.EnQueue(102);
    que2.DeQueue(item);
    cout<<item<<endl;  //102

     QueueCircular que3(3);

    que3.EnQueue(3);
    que3.EnQueue(5);
    que3.EnQueue(7);


    que3.DeQueue(item);
    cout<<item<<endl;  //3
    que3.DeQueue(item);
    cout<<item<<endl;  //5
    que3.DeQueue(item);
    cout<<item<<endl;  //7

    cout<<que3.DeQueue(item)<<endl; //0 not vaild
    que3.EnQueue(102);
    que3.DeQueue(item);
    cout<<item<<endl;  //102



    return 0;
}
