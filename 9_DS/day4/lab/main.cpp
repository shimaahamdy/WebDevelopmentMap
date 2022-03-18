#include <iostream>

#include "include/Tree.h"

using namespace std;

int main()
{
    Tree tree;

    tree.Add(50);
    tree.Add(40);
    tree.Add(45);
    tree.Add(60);
    tree.Add(70);
    tree.Add(30);
    tree.Add(80);

    tree.Traverse();
    cout<<endl;

    cout<<tree.GetMaxDepth()<<endl;

    tree.Add(105);
    cout<<tree.GetMaxDepth()<<endl;

    tree.Traverse();
    cout<<endl;
    tree.TraverStack();


    return 0;
}
