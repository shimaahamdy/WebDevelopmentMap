#include <stdio.h>
#include <stdlib.h>


int main()
{
/*
    int M;

    printf("Enter Month : ");
    scanf("%i",&M);
    */
/*
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
*/

/*
    switch(M)
    {
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        printf("31");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        printf("30");
        break;
    case 2:
        printf ("29");
        break;
    default:
        printf("NA");
        break;
    }

  */


    //int Value = 3000;

   /*
    switch(Value)
    {
    case 3000:
        printf("P");
        printf ("R");
        printf("B");
        break;
    case 2000:
        printf ("R");
        printf("B");
        break;
    case 1000:
        printf("B");
        break;

    }
    */

    /*
     switch(Value)
    {
    case 3000:
        printf("P \n");

    case 2000:
        printf ("R \n");

    case 1000:
        printf("B \n");
        break;
    }

    printf("\n End of Program.");

*/

    int x , sum , i;

    for ( i =0 , sum=0 ; i <3 ; sum+=x ,  i++)
    {
     printf("\n Enter Number %d:",i+1);
     scanf("%i",&x);
     //sum += x;
    }


    printf("Sum = %i",sum);

}
