#include <iostream>
#include <stdio.h>
#include <C:\Program Files\CodeBlocks\MinGW\include\graphics.h>
using namespace std;
class shape
{
protected:
    int color;

    public:
    shape(int col=15)
    {
        color=col;
    }
    void set_color(int col)
    {
        color=col;
    }
    int get_color()
    {
        return color;
    }
    void virtual draw()=0; //pure virtula method
    ~shape()
    {
        //cout<<"shape destructor\n";
    }
};
class Point
{
    int x,y;
public:

    Point(int send_x=0,int send_y=0)
    {
        x=send_x;
        y=send_y;
    }
    int get_x()
    {
        return x;
    }
    int get_y()
    {
        return y;
    }
    void set_x(int send_x)
    {
        x=send_x;
    }
    int set_y(int send_y)
    {
        y=send_y;
    }
    void show()
    {
        //cout<<"("<<x<<","<<y<<")\n";
    }
    ~Point()
    {
        //cout<<"point destructor\n";
    }
};

class Rect:public shape
{
    Point upper_left; //composition have to contain full dependant
    Point lower_right;


public:
    Rect()
    {

    }
    Rect(int x1,int y1,int x2,int y2,int col):upper_left(x1,y1),lower_right(x2,y2),shape(col)
    {


    }
    void draw() override
    {
        setcolor(shape::get_color());
        rectangle(upper_left.get_x(),upper_left.get_y(),lower_right.get_x(),lower_right.get_y());
    }
    ~Rect()
    {
        //cout<<"rectangle destructor\n";
    }


};
class Cir:public shape
{
    Point center;
    int radius;


public:
    Cir()
    {
        radius=0;
    }
    Cir(int x1,int y1,int r,int col):center(x1,y1),shape(col)
    {
        radius=r;

    }
    void draw() override
    {
        setcolor(shape::get_color());
        circle(center.get_x(),center.get_y(),radius);
    }
    ~Cir()
    {
        //cout<<"circle destructor\n";
    }


};
class Line:public shape
{
    Point point1;
    Point point2;


public:
    Line()
    {

    }
    Line(int x1,int y1,int x2,int y2,int col):point1(x1,y1),point2(x2,y2),shape(col)
    {

    }
    void draw() override
    {
        setcolor(shape::get_color());
        line(point1.get_x(),point1.get_y(),point2.get_x(),point2.get_y());
    }
    ~Line()
    {
        //cout<<"line destructor\n";
    }


};
class Picture
{
   shape **ptr;
   int total;

public:
    Picture()
    {
       ptr=NULL;
    }
    Picture(shape** ptr1,int len)
    {
        ptr = ptr1;
        total = len;

    }

    void setshape(shape** ptr1,int len)
    {
        ptr=ptr1;
        total=len;
    }

    void paint()
    {
        for(int i=0;i<total;++i)
            ptr[i]->draw(); // draw is virtual so it will draw child implementation


    }
    ~Picture()
    {
        //cout<<"picture destructor\n";
    }

};

int main()
{
initgraph();

      Picture p;

      shape *ptr[6];
      ptr[0]=new Rect(180,330,330,400,1111);
      ptr[1]=new Line(260,250,260,330,20);
      ptr[2]=new Line(225,150,199,250,40);
      ptr[3]=new Cir(250,150,50,1111);
      ptr[4]=new Line(200,250,300,250,20);
      ptr[5]=new Line(245,250,245,330,100);


      p.setshape(ptr,6);
      p.paint();







    return 0;
}
