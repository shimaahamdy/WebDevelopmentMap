#ifndef QUEUE_H
#define QUEUE_H


class Queue
{
    int *arr;
    int size, front, rear;

    public:

        Queue(int size)
        {
            this->size = size;
            arr = new int[size];
            front = rear = -1;
        }

        int EnQueue(int item)
        {
            if(IsFull())
                return 0;

            if(IsEmpty())
                front++;

            rear++;
            arr[rear] = item;

            return 1;
        }

        int DeQueue(int &item)
        {
            if(IsEmpty())
                return 0;



            item = arr[front];
            Shift();
            --rear;

            if(rear==-1)front=-1;

            return 1;
        }

    protected:

    private:

        int IsFull()
        {
            return rear == size - 1;
        }

        int IsEmpty()
        {
            return front == -1;
        }

        void Shift()
        {
            for(int i=front;i<rear;++i)
            {
                arr[i]=arr[i+1];
            }
        }
};



#endif // QUEUE_H
