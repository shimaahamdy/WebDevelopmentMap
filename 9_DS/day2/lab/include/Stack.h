#ifndef STACK_H
#define STACK_H


class Stack
{
    int *arr;
    int size, top;

    public:
        Stack(int size)
        {
            this->size = size;
            arr = new int[size];
            top = -1;
        }

        int Push(int item)
        {
            if(IsFull())
                return 0;

            arr[++top] = item;
            return 1;
        }

        int Pop(int &item)
        {
            if(IsEmpty())
            {
                return 0;
            }

            item = arr[top--];

            return 1;
        }

    protected:

    private:

        int IsFull()
        {
            return top == size - 1;
        }

        int IsEmpty()
        {
            return top == -1;
        }
};

#endif // STACK_H
