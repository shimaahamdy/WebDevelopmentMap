#include <stdio.h>
#include <stdlib.h>


int main()
{

/*
    int X = 7 ;

    //if ( X = 5)   // x = 5 will be evaluated to :5 , 5 : true , Non Zero : True , Zero: False
        //if (5) // if (True)
    if ( X == 7)
        printf( "\n Equals");
    else
        printf("\n NEQ");

    printf("\n X = : %i" , X);
*/

    int M;

    printf("Enter Month : ");
    scanf("%i",&M);
    /*
    if ( M ==1)
        printf("\n Jan");
    else if (M==2)
        printf("\n Feb");
    else if (M==3)
        printf("\n Mar");
    else
        printf("Other");
      */

    switch(M)
    {
    case 1:
        printf("Jan");
        break;
    case 2:
        printf("Feb");
        break;
    case 3:
        printf("Mar");
        break;
    default:
        printf("Other");
        break;
    }


    printf("\n End of Program.");
/*
    printf("Enter New Value: ");
    scanf("%i", &X);


    if (X > 0)
        printf("\n Positive");
    else if ( X < 0)
        printf("\n -Ve");
    else
        printf ("Zero");


*/

}

int mainV1()
{
    /*
    int X = 7 ;
    int Y = 2;

    int Z = X / Y ;

    printf("%i \n",Z);

    float V = 7.0 / 2 ;

    printf("%f \n",V);


    int X = (7 + 3) * 5 ;

    X = 7 * 5 / 6 ;

    int Y = 8 , Z = 10;

    X = Y = Z;

    printf("%i",X);


    int X = 5 ;
    //++X;
    //X++;

    int Y = 6 ;

    //Y = X++;
    //Post Version
    //Compiler will Generate Two Statments
    //1. Y = X;
    //2. X = X +1;

    //Y = ++X ;

    //Generated Code
    //1. X = X +1
    //2. Y = X

    int Z = 7 , T = 8 , R ;


    //R = X * Z / (T - Y++) ;
    //1. R = X * Z / (T - Y);
    //2 Y = Y +1;

    R = X * (Y++);
    //1. R = X * (Y);
    //2. Y = Y+1;




    printf("R : %i \n",R);

    printf("Y : %i \n",Y);


    return 0;*/
}
