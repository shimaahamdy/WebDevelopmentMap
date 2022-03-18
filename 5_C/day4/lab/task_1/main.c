#include <stdio.h>
#include <stdlib.h>
#include<conio.h>
#include <windows.h>
#define highlighted 6
#define normal 7

COORD coord={0,0};                   // this is global variable
                                    //center of axis is set to the top left cornor of the screen
char menu[3][5]={"New","Save","Exit"};
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
    for(int i=0;i<3;++i)
    {
        if(i==current_select)
            textattr(highlighted);
        else textattr(normal);
        gotoxy(10,2+i*3);
        printf("%s",menu[i]);
    }
}

void display_new()
{
    system("CLS");
    printf("that is new page\n");
    printf("press b to back: ");
}
void display_save()
{
    system("CLS");
    printf("that is save page\n");
    printf("press b to back: ");
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
        display_new();
    else if(current_select==1)
        display_save();
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
                    case 84:
                        current_select++;
                        if(current_select>2)
                            current_select=0;
                    break;
                    case 72:
                    case 76:
                        current_select--;
                        if(current_select<0)
                            current_select=2;
                    break;
                    case 79:
                        current_select=2;
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
