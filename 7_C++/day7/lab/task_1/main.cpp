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
    void draw()
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
    void draw()
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
    void draw()
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
    Rect *pRect; //aggregtion realtion
    int Rnum;
    Cir *pCir;
    int Cirnum;
    Line *pLine;
    int Lnum;

public:
    Picture()
    {
        pCir=NULL;
        pRect=NULL;
        pLine=NULL;
        Cirnum=Lnum=Rnum=0;
    }
    Picture(Rect *ptr1,int R,Line *ptr2,int L,Cir *ptr3,int C)
    {
        setRect(ptr1,R);
        setLine(ptr2,L);
        setCir(ptr3,C);

    }
    void setRect(Rect *ptr1,int R)
    {
        pRect=ptr1;
        Rnum=R;
    }
    void setCir(Cir *ptr3,int C)
    {
        pCir=ptr3;
        Cirnum=C;
    }
    void setLine(Line *ptr2,int L)
    {
        pLine=ptr2;
        Lnum=L;
    }

    void paint()
    {
        for(int i=0;i<Rnum;++i)
            pRect[i].draw();
        for(int i=0;i<Cirnum;++i)
            pCir[i].draw();
        for(int i=0;i<Lnum;++i)
            pLine[i].draw();

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

      Rect RArr[1]={Rect(180,330,330,400,1111)};
      Cir CArr[1]={Cir(250,150,50,1111)};
      Line LArr[4]={Line(260,250,260,330,20),Line(225,150,199,250,40),Line(200,250,300,250,20),Line(245,250,245,330,100)};

      p.setRect(RArr,1);
      //p.paint();

      p.setRect(NULL,0);
      p.paint();








    return 0;
}
