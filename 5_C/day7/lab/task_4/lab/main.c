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

struct employee *emps;
int current_emp;
char menu[4][15]={"insert","display","edit","exit"};
int current_select=0;
int flag_exit=1;
int entered=1,size;
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
        gotoxy(10,2+i*3);
        printf("%s",menu[i]);
    }
}

void display_employee(struct employee *emp,int i)
{
    system("CLS");
    printf("\nemployee number %i \n",i);
    printf("\n code: %i",emp->code);
    printf("\n name: %s",emp->name);
    printf("\n salary: %f",emp->net_slary);
    printf("\n\npress b to back ");
}

void multi_employee(int num)
{
    system("CLS");
    for(int i=0;i<num;++i)
    {

    printf("enter employee data %i\n",i+1);
    gotoxy(4,4);
    printf("\n code: ");
    gotoxy(4,6);
    printf("\n name: ");
    gotoxy(4,8);
    printf("\n net salary: ");

    gotoxy(8,5);
    scanf("%d",&(emps+current_emp)->code);
    gotoxy(8,7);
    scanf("%s",(emps+current_emp)->name);
    gotoxy(13,9);
    scanf("%f",&(emps+current_emp)->net_slary);
    system("CLS");
    current_emp++;

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
    scanf("%d",&(emps+i-1)->code);
    gotoxy(8,7);
    scanf("%s",(emps+i-1)->name);
    gotoxy(13,9);
    scanf("%f",&(emps+i-1)->net_slary);
}

void enter_exit()
{
    system("CLS");
    flag_exit=0;
}
void enter_pressed()
{
    entered=0;
    int num=0;
    if(current_select==0)
        {
            system("CLS");
            printf("enter number of emp to insert: ");
            scanf("%d",&num);
            if(current_emp+num>size)
            {
                printf("the available space = %d student to insert\n\npress b to back",size-current_emp);
            }
            else
            {
                multi_employee(num);
                system("CLS");
            for(int i=current_emp-num;i<current_emp;++i)
                {

                    printf("\nemployee number %i \n",i+1);
                    printf("\n code: %i",(emps+i)->code);
                    printf("\n name: %s",(emps+i)->name);
                    printf("\n salary: %f",(emps+i)->net_slary);

                }
                printf("\n\npress b to back");
             }
            }

    else if(current_select==1)
    {
        system("CLS");
        int num;
        printf("enter employee number: ");
        scanf("%i",&num);
        if(num>size || num<1)
        {
            printf("not exist\n\npress b to back ");
        }
        else display_employee(emps+(num-1),num);

    }
    else if(current_select==2)
    {
        system("CLS");
        int num;
        printf("enter employee number: ");
        scanf("%i",&num);
        if(num>size || num<1)
        {
            printf("not exist\n\npress b to back");
        }
        else
        {
            edit(num);
            display_employee(emps+(num-1),num);
        }
    }
    else enter_exit();
}
int main()
{
    printf("enter number of students: ");
    scanf("%d",&size);
    emps = (struct Employee*)malloc(sizeof(struct employee)*size);
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
                        if(current_select>3)
                            current_select=0;
                    break;
                    case 72:

                        current_select--;
                        if(current_select<0)
                            current_select=3;
                    break;
                    case 79:
                        current_select=3;
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



//struct employee *emps;
//emps = (struct employee*)malloc(sizeof(struct employee)*5);
//scanf("%d",&(emps+1)->code);
//printf("%d",(emps+1)->code);






    return 0;
}
