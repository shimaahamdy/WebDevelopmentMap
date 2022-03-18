#include <stdio.h>
#include <stdlib.h>
#include<conio.h>
#include <windows.h>
#define highlighted 6
#define normal 7
COORD coord={0,0};                   // this is global variable
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

void swap(int *x,int *y)
{
    int temp = *x;
    *x = *y;
    *y = temp;
}

int power(int n,int por)
{
    if(por==0)return 1;
    return n * power(n,por-1);
}
int main()
{
//    int a=5,b=6;
//    printf("a: %i\n",a);
//    printf("b: %i\n",b);
//    swap(&a,&b);
//    printf("a: %i\n",a);
//    printf("b: %i\n",b);


    /* task 2*/
//    char str[50];int size;
//    char *str_ptr = str;
//    printf("enter size of input: ");
//    scanf("%i",&size);
//    for(int i=0;i<size;++i)
//    {
//        *str_ptr = getche();
//        str_ptr++;
//    }
//    printf("\nyour string: ");
//    puts(str);


      /* task 3*/



      char input[15];int flag=1;
      int x=4, y=4;
      char *input_ptr = input;
      for(int i=0;i<10;++i)
      {
          gotoxy(x,y);
          x+=2;
          textattr(highlighted);
          input[i]='_';
          printf("%c",input[i]);
      }
      x=4;
      gotoxy(x,y);
      do
      {
          char c = getch();
          switch(c)
          {
              case -32:
              case 0:
                  c = getch();
                  switch(c)
                  {
                      case 77:
                          if(input_ptr!=&input[9])
                          {
                            ++input_ptr;
                            x+=2;
                            gotoxy(x,y);

                          }

                      break;
                      case 75:
                          if(input_ptr!=&input[0])
                          {


                          --input_ptr;
                          x-=2;
                          gotoxy(x,y);
                          }
                      break;

                  }

              break;
              case 13:
                  flag=0;
                  break;

              default:
                  if((c>='a' && c<='z')||(c>='A' && c<='Z'))
                  {

                      if(input_ptr==&input[9])
                      {
                        *input_ptr=c;
                        --input_ptr;
                         printf("%c",c);
                        x-=2;
                        gotoxy(x,y);



                      }
                      else if(input_ptr==input)
                      {
                        *input_ptr=c;
                        ++input_ptr;
                         printf("%c",c);
                        x+=2;
                        gotoxy(x,y);

                      }


                      else
                      {
                          *input_ptr=c;
                          ++input_ptr;
                          gotoxy(x,y);
                          printf("%c",c);
                          x+=2;
                          gotoxy(x,y);
                      }
                  }
              break;
          }
      }
      while(flag);
      gotoxy(0,8);
      printf("your string is: ");
        for(int i=0;i<10;++i)
        {
            if((input[i]>='a' && input[i]<='z')||(input[i]>='A' && input[i]<='Z'))
            {
                printf("%c",input[i]);
            }

        }


                    /* task 4*/


//
//      int res = power(3,4);
//      printf("%i",res);
    return 0;
}
