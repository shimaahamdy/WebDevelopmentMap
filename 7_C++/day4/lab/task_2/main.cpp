#include <iostream>

using namespace std;
class Intarray
{
    int* ptr;
    int arr_size;

public:
    Intarray(int arrsize=10)
    {
        arr_size=arrsize;
        ptr = new int [arrsize];

    }
    Intarray(const Intarray &copied)
    {
        //cout<<"copy constructor\n";
        arr_size = copied.arr_size;
        ptr = new int [arr_size];
        for(int i=0;i<arr_size;++i)
        {
            ptr[i]=copied.ptr[i];
        }
    }


    const Intarray & operator = (const Intarray &c2)
    {
        arr_size =c2.arr_size;

        delete []ptr;
        ptr = new int[arr_size];

        for(int i=0;i<arr_size;++i)
        {
            ptr[i]=c2.ptr[i];
        }
        return c2;
    }
    int & operator[] (int index)
    {
        if(index>=0 && index<arr_size)
           {
               int i=index;
               return ptr[i];

           }
    }
    void set_value(int index,int value)
    {
      if(index>=0 && index<arr_size)
        ptr[index]=value;
      else cout<<"wrong index\n";
    }
    int get_size()
    {
        return arr_size;
    }
    Intarray operator+ (const Intarray &s2)
    {
        Intarray result(this->arr_size+s2.arr_size);
        int i=0;
        for(;i<arr_size;++i)
        {
            result.ptr[i]=ptr[i];

        }
        for(int j=0;j<s2.arr_size;++j,++i)
        {
            result.ptr[i]=s2.ptr[j];

        }
        return result;
    }


    ~Intarray()
    {
        for(int i=0;i<arr_size;++i)
            ptr[i]=-1;

        delete [] ptr;
        ptr = NULL;
        //cout<<"destructor\n";
    }

};
int main()
{
    Intarray arr1(5),arr2(3),arr3(1);
    for(int i=0;i<arr1.get_size();++i)
    {
        arr1[i]=i*3;
        cout<<arr1[i]<<endl;
    }
    for(int i=0;i<arr2.get_size();++i)
    {
        arr2[i]=3+i;
        cout<<arr2[i]<<endl;
    }

    arr3 = arr1+arr2;
    cout<<arr3.get_size()<<endl;
    for(int i=0;i<arr3.get_size();++i)
    {
        cout<<arr3[i]<<endl;
    }


    return 0;
}
