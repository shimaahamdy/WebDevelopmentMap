#include <stdio.h>
#include <stdlib.h>
#include<windows.h>

COORD coord={0,0};                   // this is global variable
                                    //center of axis is set to the top left cornor of the screen
 void gotoxy(int x,int y)
 {
   coord.X=x;
   coord.Y=y;
   SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
 }


 void draw_static_magic_box()
 {
     int n=3;
     int r=1,c=(n+1)/2;
     gotoxy(c*3,r*3);
     printf("%i",1);
     for(int i=1;i<n*n;++i)
     {
         if(i%3==0)++r;
         else
         {
             --c;
             --r;
         }
         if(r>3)r=1;
         else if(r<1)r=3;

         if(c>3)c=1;
         else if(c<1)c=3;

         gotoxy(c*3,r*3);
         printf("%i",i+1);
         //printf("%i %i",r,c);
         //printf("\n");
     }
 }

  void draw_dynamic_magic_box(int n)
 {
     int r=1,c=(n+1)/2;
     gotoxy(c*5,r*5);
     printf("%i",1);
     for(int i=1;i<n*n;++i)
     {
         if(i%n==0)++r;
         else
         {
             --c;
             --r;
         }
         if(r>n)r=1;
         else if(r<1)r=n;

         if(c>n)c=1;
         else if(c<1)c=n;

         gotoxy(c*5,r*5);
         printf("%i",i+1);
         //printf("%i %i",r,c);
         //printf("\n");
     }
 }


int main()
{
   // draw_static_magic_box();


/*
    int n;
    printf("enter size of magic box (only odd number:");
    scanf("%i",&n);
    if(n%2==0)printf("try again :( enter odd number greater than 0 ");
    else draw_dynamic_magic_box(n);
*/

   /*
    int n,sum=0;
    while(sum<100)
    {
        printf("enter number to add to sum:");
        scanf("%i",&n);
        if(sum+n>100)break;
        sum+=n;
    }
    printf("%i",sum);

    */



  char c;int menu=1,presse=1;
   printf("new: n\ndisplay: d\nexist: e\n");
   printf("\n\npress b to back:");
    do{
            scanf("%c",&c);

            if(c=='n' && menu)
                {
                    system("CLS");
                    printf("you have enter new\n");
                    printf("\n\npress b to back:");
                    menu=0;
                }
            else if(c=='d' && menu)
                {
                    system("CLS");
                    printf("you have enter display\n");
                    printf("\n\n\n\npress b to back:");
                    menu=0;
                }
           else if(c=='b')
            {
           system("CLS");
           printf("new: n\ndisplay: d\nexist: e\n");
           printf("\n\npress b to back:");
           menu=1;

             }
             else if(c=='e')
             {
                 system("CLS");
                 printf("you have enter exist \n");
                 presse=0;
             }

    }
    while(presse);











    return 0;
}
