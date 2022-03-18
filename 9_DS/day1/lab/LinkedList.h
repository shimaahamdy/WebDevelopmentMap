#ifndef LINKEDLIST_H
#define LINKEDLIST_H

#include "Node.h"

#include <iostream>

using namespace std;

class LinkedList
{
    Node *head, *tail;
    int list_size, index;

    public:
        LinkedList()
        {
            head = tail = NULL;
            list_size=index=0;

        }
        
        //add on last of list
        void Add(int data)
        {
            Node *node = new Node(data);

            //check if list was empty
            if(head == NULL)
            {
                head = tail = node;

            }

            else
            {
                tail->Next = node;
                node->Prev = tail;
                tail = node;


            }
            list_size++;

        }

        void Display()
        {
            Node *current = head;

            while(current != NULL)
            {
                cout << current->Data << "\t";
                current = current->Next;
            }
        }

        int Search(int data)
        {
            Node *node = GetNodeByData(data);

            //return node != NULL;
            return index;
        }

        int Remove(int data)
        {
            Node *node = GetNodeByData(data);

            if(node == NULL)
                return -1;

            if(node == head)
            {
                if(node == tail)
                {

                    head = tail = NULL;
                }
                else
                {
                    head = head->Next;
                    head->Prev = NULL;
                }
            }
            else if(node == tail)
            {
                tail = tail->Prev;
                tail->Next = NULL;
            }
            else
            {
                node->Prev->Next = node->Next;
                node->Next->Prev = node->Prev;
            }

            delete node;
            --list_size;
            return index;
        }

        int InsertAfter(int data, int afterData)
        {
            Node *current=GetNodeByData(data);
            Node *node = new Node(afterData);

            if(current!=NULL)
            {
                if(current->Next!=NULL)
                {
                    node->Next = current->Next;
                    node->Prev = current;
                    current->Next->Prev = node;
                    current->Next = node;
                }
                else
                {
                    current->Next = node;
                    node->Prev = current;
                    tail = node;
                }
                return index+1;
                }
            return -1;

        }
        int InsertBefore(int data, int beforeData)
        {
            Node *current=GetNodeByData(data);
            Node *node = new Node(beforeData);

            //if node we want insert before exist
            if(current!=NULL)
            {
                //if current is not head
                if(current->Prev!=NULL)
                {
                    node->Prev=current->Prev;
                    node->Next = current;
                    current->Prev->Next = node;
                    current->Prev = node;

                }
                //if current is head
                else
                {
                    node->Next = current;
                    current->Prev = node;
                    head = node;
                }
               
                return index;

            }
             return -1;
        }
        int GetDataByIndex(int ind,int &value)
        {
            if(ind>list_size)
            {
                value = -5256;
                return -1; //not vaild operation
            }
            Node *node = head;
            for(int i=0;i<ind;++i)
            {
                node = node->Next;
            }
             value = node->Data;
             return 1; //vaild operation


        }

        //قثreverse list in new list
        LinkedList* Reverse1()
        {
            LinkedList *n = new LinkedList();
            Node *node = tail;
            while(node != NULL)
            {
                n->Add(node->Data);
                node = node->Prev;
            }
            return n;
        }
        void Reverse2()
        {
            Node *last=tail;
            Node *first=head;
            int i=list_size-1;
            int j=0;
            while(j<i)
            {
                int temp = last->Data;
                last->Data = first->Data;
                first->Data=temp;
                first=first->Next;
                last=last->Prev;
                ++j;
                --i;

            }
        }



    protected:

    private:

        Node* GetNodeByData(int data)
        {
            Node *current = head;
            index=0;

            while(current != NULL)
            {
                if(data == current->Data)
                    return current;

                current = current->Next;
                ++index;
            }
            index=-1;
            return NULL;
        }
};

#endif // LINKEDLIST_H
