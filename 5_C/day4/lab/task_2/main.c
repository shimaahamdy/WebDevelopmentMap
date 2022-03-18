#include <stdio.h>
#include <stdlib.h>

int main()
{
       /* task 2*/
    char name[10];

    char letter;
    for(int i=0;i<9;++i)
        {
            letter=getche();
            if(letter==13) // if he click enter break
            break;
            name[i]=letter;

       }
       printf("your string: %s",name);
    return 0;
}
