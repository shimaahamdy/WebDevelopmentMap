#ifndef STACKLINKEDLIST_H
#define STACKLINKEDLIST_H

#include "LinkedList.h"

class StackLinkedList
{
    LinkedList mylist;
    int top;

    public:
        StackLinkedList()
        {
           top=-1;
        }

        void Push(int item)
        {

            mylist.Add(item);
            ++top;
        }

        int Pop(int &item)
        {
            if(IsEmpty())
            {
                item=-9825;
                return 0;
            }
            mylist.RemoveLast(item);
            top--;
            return 1;
        }

        int peek(int &item)
        {
            if(IsEmpty())
            {
                item=-9825;
                return 0;
            }

            mylist.GetDataByIndex(top,item);
            return 1;
        }

    protected:

    private:

        int IsEmpty()
        {
            return top == -1;
        }
};

#endif // STACK_H
