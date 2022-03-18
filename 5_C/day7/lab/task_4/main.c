#include <stdio.h>
#include <stdlib.h>
#include<conio.h>
#include <windows.h>
#define highlighted 6
#define normal 7

struct employee
{
    int code;
    char name[20];
    float net_slary;

};

COORD coord={0,0};                   // this is global variable
                                    //center of axis is set to the top left cornor of the screen
struct employee emps[5];
char menu[5][15]={"insert","display","edit","exit"};
int current_select=0;
int flag_exit=1;
int entered=1;
void gotoxy(int x,int y)
 {
   coord.X=x;
   coord.Y=y;
   SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
 }
void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);

}
void display_menu()
{
    for(int i=0;i<4;++i)
    {
        if(i==current_select)
            textattr(highlighted);
        else textattr(normal);
        gotoxy(10,10+i);
        printf("%s\n",menu[i]);
    }
}

struct employee new_employee()
{
    system("CLS");
    struct employee emp1;
    printf("enter employee data\n");
    gotoxy(4,4);
    printf("\n code: ");
    gotoxy(4,6);
    printf("\n name: ");
    gotoxy(4,8);
    printf("\n net salary: ");

    gotoxy(8,5);
    scanf("%i",&emp1.code);
    gotoxy(8,7);
    scanf("%s",&emp1.name);
    gotoxy(13,9);
    scanf("%f",&emp1.net_slary);
    return emp1;

}
void display_employee(struct employee emp,int i)
{
    system("CLS");
    printf("\nemployee number %i \n",i);
    printf("\n code: %i",emp.code);
    printf("\n name: %s",emp.name);
    printf("\n salary: %f",emp.net_slary);
}

void multi_employee()
{
     system("CLS");
    for(int i=0;i<5;++i)
    {

    printf("enter employee data %i\n",i+1);
    gotoxy(4,4);
    printf("\n code: ");
    gotoxy(4,6);
    printf("\n name: ");
    gotoxy(4,8);
    printf("\n net salary: ");

    gotoxy(8,5);
    scanf("%i",&emps[i].code);
    gotoxy(8,7);
    scanf("%s",&emps[i].name);
    gotoxy(13,9);
    scanf("%f",&emps[i].net_slary);
    system("CLS");

    }

}

void edit(int i)
{
    system("CLS");
    printf("enter employee data\n");
    gotoxy(4,4);
    printf("\n code: ");
    gotoxy(4,6);
    printf("\n name: ");
    gotoxy(4,8);
    printf("\n net salary: ");

    gotoxy(8,5);
    scanf("%i",&emps[i-1].code);
    gotoxy(8,7);
    scanf("%s",&emps[i-1].name);
    gotoxy(13,9);
    scanf("%f",&emps[i-1].net_slary);
}

void enter_exit()
{
    system("CLS");
    flag_exit=0;
}
void enter_pressed()
{
    entered=0;
    if(current_select==0)
    {
        struct employee emp = new_employee();
        display_employee(emp,1);
    }
    else if(current_select==1)
        {
            multi_employee();
             system("CLS");
           for(int i=0;i<5;++i)
            {

                    printf("\nemployee number %i \n",i);
                    printf("\n code: %i",emps[i].code);
                    printf("\n name: %s",emps[i].name);
                    printf("\n salary: %f",emps[i].net_slary);

            }
        }
    else if(current_select==2)
    {
        system("CLS");
        int num;
        printf("enter employee number: ");
        scanf("%i",&num);
        if(num>5 || num<1)
        {
            printf("not exist");
        }
        else display_employee(emps[num-1],num);

    }
    else if(current_select==3)
    {
        system("CLS");
        int num;
        printf("enter employee number: ");
        scanf("%i",&num);
        if(num>5 || num<1)
        {
            printf("not exist");
        }
        else
        {
            edit(num);
            display_employee(emps[num],num);
        }
    }
    else enter_exit();
}
int main()
{

    do
    {
        if(entered)display_menu();
        char ch=getch();
        switch (ch)
        {
            case 0:
            case -32:
                ch = getch();
                switch (ch)
                {
                    case 80:

                        current_select++;
                        if(current_select>4)
                            current_select=0;
                    break;
                    case 72:

                        current_select--;
                        if(current_select<0)
                            current_select=4;
                    break;
                    case 79:
                        current_select=4;
                    break;
                    case 71:
                        current_select=0;
                    break;
                }

            break;
            case 13:

                        enter_pressed();
            break;
              case 27:
                  enter_exit();
                  break;
              case 'b':
                  system("CLS");
                entered=1;
                break;



        }
    }
    while(flag_exit);








    return 0;
}
