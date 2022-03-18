#include <iostream>
#include <stdio.h>
#include <C:\Program Files\CodeBlocks\MinGW\include\graphics.h>
using namespace std;
class shape
{
    int color;
public:

    shape()
    {
        color=15;
    }
    shape(int col)
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
};
class Point
{
    int x,y;
public:
    Point()
    {
        x=y=0;
    }
    Point(int send_x,int send_y)
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
    void show()
    {
        cout<<"("<<x<<","<<y<<")\n";
    }
    ~Point()
    {
        cout<<"point destructor";
    }
};

class Rect:public shape
{
    Point upper_left;
    Point lower_right;


public:
    Rect()
    {

    }
    Rect(int x1,int y1,int x2,int y2,int col):upper_left(x1,y1),lower_right(x2,y2),shape(col)
    {


    }
    void draw()
    {
        setcolor(shape::get_color());
        rectangle(upper_left.get_x(),upper_left.get_y(),lower_right.get_x(),lower_right.get_y());
    }
    ~Rect()
    {
        cout<<"rectangle destructor";
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
    void draw()
    {
        setcolor(shape::get_color());
        circle(center.get_x(),center.get_y(),radius);
    }
    ~Cir()
    {
        cout<<"circle destructor";
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
    void draw()
    {
        setcolor(shape::get_color());
        line(point1.get_x(),point1.get_y(),point2.get_x(),point2.get_y());
    }
    ~Line()
    {
        cout<<"line destructor";
    }


};

int main()
{
initgraph();
   // setcolor(1111);
  //  line(100,100,200,200);

    Cir c1(250,150,50,1111);
    c1.draw();

      Line L3(260,250,260,330,20);
      L3.draw();

      Line L1(225,150,199,250,40);
      L1.draw();

      Line L2(273,150,300,250,50);
      L2.draw();

      Line L4(200,250,300,250,20);
      L4.draw();

     Line L5(245,250,245,330,100);
     L5.draw();


    Rect R1(180,330,330,400,1111);
    R1.draw();;
    return 0;
}
