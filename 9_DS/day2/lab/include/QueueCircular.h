#ifndef QUEUECIRCULAR_H
#define QUEUECIRCULAR_H


class QueueCircular
{
    private:
    int front;
    int rear;
    int *arr;
    int size;
    int items;

public:
    QueueCircular(int size)
    {
        front=0;
        rear=-1;
        items=0;
        this->size=size;
        arr = new int[size];

    }

    public:

        int EnQueue(int item)
        {
           if(!IsFull())
            {
            if(rear==size-1)rear=-1;
            arr[++rear]=item;
            ++items;
           }
           else return 0;
           return 1;
        }

        int DeQueue(int &item)
        {
            if(!IsEmpty())
            {
                item = arr[front++];
            if(front==size)front=0;
            --items;
            return 1;
            }
            else return 0;
        }

    protected:

    private:

    int IsFull()
    {
        return items==size;
    }
    int IsEmpty()
    {
        return items==0;
    }
};

/*


- Queue using LinkedList
- Circular Queue
*/

#endif // QUEUE_H
