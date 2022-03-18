#include <iostream>

using namespace std;

void Swap(int &first, int &second)
{
    int temp = first;
    first = second;
    second = temp;
}

void BubbleSort(int *arr, int size)
{
    int sorted = 0;

    for(int counter = 0; counter < size - 1 && sorted == 0; counter++)
    {
        sorted = 1;

        for(int index = 0; index < size - 1 - counter; index++)
        {
            if(arr[index] > arr[index + 1])
            {
                Swap(arr[index], arr[index + 1]);
                sorted = 0;
            }
        }
    }
}

void SelectionSort(int *arr, int size)
{
    for(int counter = 0; counter < size - 1; counter++)
    {
        int minIndex = counter;

        for(int index = minIndex + 1; index < size; index++)
        {
            if(arr[index] < arr[minIndex])
            {
                minIndex = index;
            }
        }

        Swap(arr[counter], arr[minIndex]);
    }
}

void InsertionSort(int *arr, int size)
{
    int key;

    for(int counter = 1; counter < size ; counter++)
    {
        key = arr[counter];
        int index = counter - 1;

        while(index >= 0 && arr[index] > key)
        {
            arr[index+1] = arr[index];
            index--;
        }

        arr[index + 1] = key;
    }
}

int BinarySearch(int data, int *arr, int size)
{
    int minIndex = 0, maxIndex = size - 1;

    while(minIndex <= maxIndex)
    {
        int midIdex = (minIndex + maxIndex) / 2;

        if(data == arr[midIndex])
            return midIndex;

        if(data > arr[midIndex])
        {
            minIndex = midIndex + 1;
        }
        else
        {
            maxIndex = midIdex - 1;
        }
    }

    return -1;
}

void Display(int *arr, int size)
{
    for(int index = 0; index < size; index++)
    {
        cout << arr[index] << "\t";
    }
}

//- BubbleSort using LinkedList
//- BinarySearch using LinkedList

int main()
{
    int arr[] = {5, 3, 4, 2, 6, 1};

    //BubbleSort(arr, 6);
    SelectionSort(arr, 6);
    Display(arr, 6);

    return 0;
}
