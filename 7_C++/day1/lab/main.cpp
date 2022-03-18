#include <iostream>

using namespace std;

void swap_nums(int &a, int &b)
{
    int temp = a;
    a=b;
    b=temp;
}
struct complex_num
{
private:
    float R;
    float I;


public:
    void set_R(float real)
    {
        R=real;
    }

    void set_I(float imaginary)
    {
        I=imaginary;
    }
    int get_R()
    {
        return R;
    }
    int get_I()
    {
        return I;
    }
    complex_num add(complex_num c2)
    {
        complex_num temp;
        temp.R = R+c2.R;
        temp.I = I+c2.I;
        return temp;
    }
    complex_num sub(complex_num c2)
    {
        complex_num temp;
        temp.R = R-c2.R;
        temp.I = I-c2.I;
        return temp;
    }
    void print_complex()
    {
        if(R!=0 && I!=0)
        {
            cout<<R;
            if(I>0)cout<<'+'<<I<<"i"<<endl;
            else cout<<I<<"i"<<endl;
        }
        else if(R!=0)
        {
            cout<<R<<endl;
        }
        else if(I!=0)
        {
            cout<<I<<"i"<<endl;
        }
        else cout<<0;

}

};

complex_num add(complex_num c1, complex_num c2)
{
        complex_num temp;
        float R = c1.get_R()+c2.get_R();
        float I = c1.get_I()+c2.get_I();
        temp.set_I(I);
        temp.set_R(R);
        return temp;
}
complex_num sub(complex_num c1, complex_num c2)
    {
        complex_num temp;
        float R = c1.get_R()-c2.get_R();
        float I = c1.get_I()-c2.get_I();
        temp.set_I(I);
        temp.set_R(R);
        return temp;
    }
complex_num multiply(complex_num c1, complex_num c2)
    {
        float R=0,I=0;complex_num temp;
        R += c1.get_R()*c2.get_R();
        I += c1.get_R()*c2.get_I();
        I += c1.get_I()*c2.get_R();
        R += -(c1.get_I()*c2.get_I());
        temp.set_I(I);
        temp.set_R(R);
        return temp;
    }

complex_num divison(complex_num c1, complex_num c2)
    {
        float R=0,I=0;complex_num temp;
        R += c1.get_R()*c2.get_R();
        R +=c1.get_I()*c2.get_I();
        R/= (c2.get_R()*c2.get_R()+ c2.get_I()*c2.get_I());

        I += c1.get_I()*c2.get_R();
        I -= (c1.get_R()*c2.get_I());
        I/= (c2.get_R()*c2.get_R()+ c2.get_I()*c2.get_I());
        temp.set_I(I);
        temp.set_R(R);
        return temp;
    }
int main()
{
//    int a=3,b=5;
//    cout<<"a: "<<a<<"  b:"<<b<<endl;
//    swap_nums(a,b);
//    cout<<"a: "<<a<<"  b:"<<b<<endl;


    float r,i;
    complex_num num,a,b,c;

//    cout<<"enter number to print\n";
//    cin>>r>>i;
//    num.set_I(i);
//    num.set_R(r);
//    num.print_complex();

    cout<<"enter num1\n";
    cin>>r>>i;
    a.set_R(r);
    a.set_I(i);

    cout<<"enter num2\n";
    cin>>r>>i;
    b.set_R(r);
    b.set_I(i);



    c = a.add(b);
    c.print_complex();

    c = a.sub(b);
    c.print_complex();

    c=add(a,b);
    c.print_complex();

    c=sub(a,b);
    c.print_complex();

    c=multiply(a,b);
    c.print_complex();


    c=divison(a,b);
    c.print_complex();






    return 0;
}
