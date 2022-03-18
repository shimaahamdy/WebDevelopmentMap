#include <iostream>
#include "LinkedList.h"
using namespace std;

int main()
{
    LinkedList myList;int index;

    myList.Add(3);
    myList.Add(5);
    myList.Add(7);
    myList.Add(9);
    myList.Add(11);
    myList.Add(20);
    myList.Add(45);

    myList.Display();
    cout<<endl;
    index = myList.Remove(3);
    cout<<index<<endl;
    myList.InsertAfter(7, 15);
    myList.InsertAfter(15,20);
    myList.Display();
    cout<<endl;


    index = myList.InsertAfter(20,22);
    cout<<index<<endl;
    index = myList.InsertBefore(11,33);
    cout<<index<<endl;
    index = myList.InsertBefore(5,105);
    cout<<index<<endl;
    index = myList.InsertBefore(205,101);
    cout<<index<<endl;
    myList.Display();
    cout<<endl;

    int num;
    int vaild = myList.GetDataByIndex(0,num);
    cout<<vaild<<" "<<num<<endl;
    vaild = myList.GetDataByIndex(4,num);
    cout<<vaild<<" "<<num<<endl;
    vaild = myList.GetDataByIndex(55,num);
    cout<<vaild<<" "<<num<<endl;


    LinkedList * new_list = myList.Reverse1();
    new_list->Display();
    cout<<endl;

    myList.Reverse2();
    myList.Display();



    return 0;
}
