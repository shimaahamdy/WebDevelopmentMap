#include <iostream>
using namespace std;


#include "LinkedList.h"



int main()
{
    LinkedList mylist;
    mylist.Add(35);
    mylist.Add(20);
    mylist.Add(10);
    mylist.Add(-35);
    mylist.Add(0);
    mylist.Add(40);
    mylist.Display();
    cout<<endl;

    mylist.BubbleSort();
    mylist.Display();
    cout<<endl;


    cout<<mylist.BinarySearch(20)<<endl;
    cout<<mylist.BinarySearch(-35)<<endl;
    cout<<mylist.BinarySearch(40)<<endl;
    cout<<mylist.BinarySearch(105)<<endl;
    return 0;
}
