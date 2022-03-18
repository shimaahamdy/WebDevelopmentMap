#ifndef QUEUELINKEDLIST_H
#define QUEUELINKEDLIST_H

#include "LinkedList.h"
class QueueLinkedList
{
    LinkedList mylist;
    int front, rear;

    public:

        QueueLinkedList()
        {
            front = rear = -1;
        }

        void EnQueue(int item)
        {

            if(IsEmpty())
                front++;

            rear++;
            mylist.Add(item);

        }

        int DeQueue(int &item)
        {
            if(IsEmpty())
                return 0;



            mylist.Removefirst(item);
            --rear;

            if(rear==-1)front=-1;

            return 1;
        }

    protected:

    private:

        int IsEmpty()
        {
            return front == -1;
        }


};

/*


- Queue using LinkedList
- Circular Queue
*/

#endif // QUEUE_H
