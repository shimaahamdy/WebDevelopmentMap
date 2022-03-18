#include <stdio.h>
#include <stdlib.h>
#include<conio.h>
#define swap(a,b) int temp=a;a=b;b=temp;
#define PI 3.14
#define circle_area(x) (PI*x*x)
#include <string.h>
//#define X 3
#define Y 6
#define si 10

struct Student
{
    char Name[20];
    int Grades[5];
};
struct Student Fillstudent()
{
    struct Student std;
    int i;
    printf("enter student name: ");
    scanf("%s",std.Name);
    printf("enter student grads:\n");
    for(int i=0;i<5;++i)
    {
        scanf("%d",&std.Grades[i]);
    }
    return std;

}
void printStudent(struct Student std)
{
    int i;
    printf("student name: %s",std.Name);
    for(int i=0;i<5;++i)
    {
        printf("grade of sub %d : %d \n",i+1,std.Grades[i]);
    }

}
void e(int n)
{
    if(n>0)
    {
        e(--n);
        printf("%d",n);
        e(--n);
    }
}

long power(unsigned int x,unsigned int y)
{
    return x*power(x,--y);
    if(y==1)return 1;
}
void Draw(int y)
{
int i,n;
char x;
x=getche();
printf("\n");
printf("enter n\n");
scanf("%d",&n);

for(y=1;y<=(n-1);y++)
{
for(i=y;i>0;i--)
{
printf("%c",x);
}
printf("\n");
}


}

struct Employee
{
    char NAme[100];
    int age;
    int salary;
};
int fun()
{

}
struct Ex
{
    int i;
    float j;
    char *s;
};
int c;
int * reverse_ (int *x)
{
    int *ptr;
    ptr=x;
    *ptr = (-1*(*x));
    return ptr;
}
void removeVowels(char* arr,int size)
{
    int c=0;
    for(int i=0;i<size;++i)
    {
        if(arr[i]=='a' ||arr[i]=='e'|| arr[i]=='i' ||arr[i]=='o' ||arr[i]=='u' ||arr[i]=='y')
            continue;
        arr[c++]=arr[i];
    }
    if(c<size)arr[c]='\0';

    }
int factorial(int x);
struct simple
{
    int a;float c;
};
struct complex
{
    int a[20];
    float c;
    struct simple s;
    struct simple sa[4];

};
void return_val()
{
    return 5;
}
char* myFunc (char *ptr)
{
 ptr += 3;
 return (ptr);
}
void Func (int x)
{
   if (x > 0)
   Func(--x);
   printf("%d, ", x);
}

int Sum(int ar[], int size)
{
int j, s = 0;
for(j = 0 ; j < size ; j++)
{
s += ar[j];


}
return s;
}
int * getmin(int ar[5])
{
    int min=ar[0];
    for(int i=1;i<10;++i)
    {
        if(ar[i]<min)
        {
            min=ar[i];
        }
    }
    return &min;

}
int main()
{
    /*
    int *ptr;
    int x[5]={1,2,3,4,5};
    ptr = getmin(x);
    printf("&d",*ptr);
    */

  /*  int X[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int* ptr;
int Total;
ptr = X ;
ptr += 2;
Total = Sum(X, 4);
printf("%d", Total);
*/
    /*
    unsigned int val = 5;
    printf("%u %u",val,val-11);  /// run time error

*/
/*
    int i,j;
    for(i=1;i<=3;++i)
        for(j=1;j<3;j++)
    {
        if(i==j)
            continue;
        if((j%3)>1)
            break;
        printf("%d \t",i);
    }
    */

    /*
    int a=53,b=6;
    swap(a,b);
    printf("a=%d b=%d",a,b);
    */
/*
    float x;
    x=1;
    switch(x)  //have to be int or char
    {
        case 1:printf("1");
        break;
    }
    */

    /*
    int counter=0;
    for(int i=0;i<10;++i)
        for(int j=10;j>i;--j)
        counter++;
    printf("%d",counter);
    */
    /*
    char str[]="%d %d";
    int val=25;
    printf(str,val,val);//25 25
    */


    //int m=10,n=20;
    //10 20 200
    //printf("%d %d %d",m/* m-value*/,/* n-value */n,m* /*computer m*n*/n);


/*
   float area1;
   struct complex comp1;
   float *temp = &comp1.sa[2].c;
   comp1.s.a=2;
   comp1.sa[2].c=22.34;
   //printf("%d",2+comp1.s.a);
   area1=circle_area(2+comp1.s.a);
   printf("the value of the pointer is %f\n",*&*temp);
   printf("the area of the circle is %f",area1);

*/
/*
   int x = '2'=='2';
   printf("%d",x);
 */
 /*
   int num=-42;
   int x= (num<0)?0:num*num;
   printf("%d",x);
   */
   //const int m=10;



   /*
   int x=2,y=4,z=6;
   z+= x*x-2*x*y+y*y-10;
   printf("%d",z);
   */

/*
   printf("%d",factorial(5));
   */
/*
   char arr[]="hello aieouy hello";//hll hll
   removeVowels(arr,18);
   printf("%s",arr);
   */

   /*
  return_val();
   printf("%i",return_val());
   */
/*
   struct Employee *eptr = (struct Employee*)malloc(sizeof(struct Employee)*5);
   for(int i=0;i<5;++i)
   {
       scanf("%s",eptr[i].NAme);
       scanf("%i",&eptr[i].age);

   }
      for(int i=0;i<5;++i)
   {
       printf("%s",eptr[i].NAme);
      printf("%i",eptr[i].age);

   }
   */
   /*
   int z,x=5,y=-10,a=4,b=2;
   z = x++ - --y * b / a;
   printf("%i",z);
   */
   /*  check */
   /*
   void *ptr;
   struct Employee myArray[10];
   ptr = myArray;
   ptr->age=25;
   ptr+sizeof(struct Employee)->age=30;
   printf("%d",myArray[0].age);
   printf("%d",myArray[1].age);
   */

   /*
    char *x, *y;
 x = "HELLO";


 y = myFunc (x);
 printf ("y = %s \n", y);
 */
 /*
	printf("My salary was increased by 15%!\n");
	printf("\"My salary was increased by 15%%!\"\n");

*/

/*
int a=10,b;
b=a++ + ++a;
printf("%d,%d,%d,%d",b,a++,a,++a);
*/
/*
   Func(5);
*/
//int x = 11 ^ 5 ;

   //printf("%i",c);
/*
   int x = 3,y,*z;
   z=&x;
   y=++*z;
   printf("x: %d y: %d",x,y);
   */
/*
   struct Ex *p;
   p = (struct Ex*)malloc (sizeof(struct Ex));
   p->s = (char *)malloc(char[20]);

   strcpy(p->s,"ABS");
   printf("%s".p->s);
*/

/*
   int A = 5+15/5;
   A=*reverse_(&A);
   printf("%d",A);
   getch();
*/
   /*
   char x;
   printf("%d",x);

   */

   //fun();
/*
   int c=0,counter=0;
   do
   {
       c++;
       printf("hello\n");
       counter++;

   }
   while(10>=counter++);
   printf("%d",counter);
   */

   //struct Employee *E = (struct Employee*)malloc(sizeof(struct Employee)*5*2);

/*
   int b=2;
   float a=1.99;
   int x=10;

   switch((int)a)
   {
   case 0:
    x+=b;
   case 1:
    x+=b;
   case 2:
    x+=3;
   }
   printf("%d",x);
   */
   /*
   char strArr[][10]={"new","save","Exit"};
   printf("%c",strArr[1][2]);
   //scanf("%s",&strArr[0][1]);
   //printf("%c",strArr[0][1]);
   //scanf("%s",strArr[0]);
   //printf("%s",strArr[0]);

*/



/*
   char *arr[3]={"new","save","exit"};
    printf("%s",arr[0]);
    */

    /*
    char *ch;
    *ch='c';
    printf("%c",*ch);
    */
    /*
    int I=1;
    for(I < 5 ; I = 0 ; I++)
{
	printf(“%d”, I);
}
*/
/*
int numb;
do {
       scanf("%d", &numb);
}
 while (numb < 1 && numb > 10);

*/
/*
for(int i=1;i<=5;++i)
{
    for(int j=1;j<=i;++j)
        printf("%c",'*');
    printf("\n");
}
*/
/*
int row=1;

printf("enter the char u want to draw:\n ");

Draw(row);
*/
/*
int size=Y;
int i;
for(i=X;i<Y;i++)
    printf("%d",i);
    */
    /*
    long out = power(3,4);
    printf("%l",out);
    */
    //int t=4;
    //e(t);
/*
    int spread[10];
    spread[2]=10;
    *(spread+2)=20;
    scanf("%i",&spread[2]);
    printf("%i",spread[2]);

*/
/*
struct Student **std;
int numclasses;
int numstudentclass;
int cls,stcls;
printf("num of classes: ");
scanf("%d",&numclasses);
std = (struct Student **)malloc(numclasses*sizeof(struct Student *));
if(std)
{
    for(cls=0;cls<numclasses;cls++)
    {
        printf("num of student in class %d",cls+1);
        scanf("%d",&numstudentclass);
        std[cls]=(struct Student *)malloc(numstudentclass*sizeof(struct Student));
    }
}

std[4][2].Grades[3]=15;
printf("%d",std[4][2].Grades[3]);
(std[4]+2)->Grades[3]=80;
printf("%d",std[4][2].Grades[3]);
(*(std+4))[2].Grades[3]=90;
printf("%d",std[4][2].Grades[3]);
(*(*(std+4)+2)).Grades[3]=70;
printf("%d",std[4][2].Grades[3]);
(*(std+4)+2)->Grades[3]=60;
printf("%d",std[4][2].Grades[3]);
*/
/*
int a[5][5][5][5];
int i=2,j=3,k=2,l=4;
a[i][j][k][l]=5;

int x = *(*(*(*(a+i)+j)+k)+l);
printf("%d",x);
*/
/*
int a=5,b=8;
if(a==5 && (b=1))
    printf("gorilla = %d %d",a,b);
*/
/*
int a=0;
a = -9%4;
printf("%d",a);
*/
/*
int i;
for(i=0,printf("f");i<5,printf("y");printf("r"),++i)
{

}
*/
/*
	char *ch;
ch = 'c';
printf("%c", ch);
*/
int i=1;
	for(i < 5 ; i = 0 ; i++)
{
	printf("%d", i);
}
printf("%d", i);


    return 0;
}

int factorial(int x)
{
    if(x==1 || x==0)return 1;
    //main();
    return x*factorial(x-1);

}
