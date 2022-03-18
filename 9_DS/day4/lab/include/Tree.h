#ifndef TREE_H
#define TREE_H
#include "Node.h"
//#include <stack>
#include<bits/stdc++.h>
#include <iostream>

using namespace std;

class Tree
{
    Node *root;
    public:
        Tree()
        {
            root = NULL;
        }

        void Add(int data)
        {
            Node *node = new Node(data);

            if(root == NULL)
            {
                root = node;
            }
            else
            {
                Node *current = root, *parent;

                while(current != NULL)
                {
                    parent = current;
                    if(data > current->Data)
                        current = current->Right;
                    else
                        current = current->Left;
                }

                if(data > parent->Data)
                    parent->Right = node;
                else
                    parent->Left = node;

            }
        }

        int Search(int data)
        {
            return GetNodeByData(data) != NULL;
        }

        void Delete(int data)
        {
            Node *node = GetNodeByData(data);

            if(node == NULL)
                return;

            if(node == root)
            {
                if(root->Left == NULL && root->Right == NULL)
                {
                    root = NULL;
                }
                else if(root->Right == NULL)
                {
                    root = root->Left;
                }
                else if(root->Left == NULL)
                {
                    root = root->Right;
                }
                else
                {
                    Node *newRoot = root->Left;
                    Node *maxRight = GetMaxRight(newRoot);
                    maxRight->Right = root->Right;
                    root = newRoot;
                }
            }
            else
            {
                Node *parent = GetParent(node);
                Node *newChild;

                if(node->Left == NULL && node->Right == NULL)
                {
                    newChild = NULL;
                }
                else if(node->Right == NULL)
                {
                    newChild = node->Left;
                }
                else if(node->Left == NULL)
                {
                    newChild = node->Right;
                }
                else
                {
                    Node *newParent = node->Left;
                    Node *maxRight = GetMaxRight(newParent);
                    maxRight->Right = node->Right;

                    newChild = newParent;
                }

                if(parent->Left == node)
                    parent->Left = newChild;
                else
                    parent->Right = newChild;
            }


            delete node;
        }

        void Traverse()
        {
            Display(root);
        }

        int GetMaxDepth()
        {

            Depth(root);
        }

        void TraverStack()
        {
            DisplayStack(root);
        }

    protected:

    private:

        int Depth(Node *current)
        {
            if(current==NULL)
                return 0;

            int n1 = Depth(current->Left);
            int n2 = Depth(current->Right);
            return max(n1,n2)+1;

        }

        Node* GetNodeByData(int data)
        {
            Node *current = root;

            while(current != NULL)
            {
                if(data == current->Data)
                    return current;

                if(data > current->Data)
                    current = current->Right;
                else
                    current = current->Left;
            }

            return NULL;
        }

        Node* GetParent(Node *node)
        {
            Node *parent = root;

            while(parent != NULL)
            {
                if(parent->Left == node || parent->Right == node)
                    return parent;

                if(node->Data > parent->Data)
                    parent = parent->Right;
                else
                    parent = parent->Left;
            }

            return NULL;
        }

        Node* GetMaxRight(Node *node)
        {
            while(node->Right != NULL)
            {
                node = node->Right;
            }

            return node;
        }

        void Display(Node *node)
        {
            if(node == NULL)
                return;

            Display(node->Left);
            cout << node->Data << "\t";
            Display(node->Right);
        }

        void DisplayStack(Node* root)
        {
            stack<Node*> s;
            //stack<int>s;
            Node *current = root;
           // Node *parent = current;
            while (current != NULL || !s.empty())
                {
                    while (current !=  NULL)
                    {
                        s.push(current);
                        current = current->Left;
                    }
                    current = s.top();
                    s.pop();

                   cout << current->Data <<"\t";
                   current = current->Right;

                }
          }
};

#endif // TREE_H
