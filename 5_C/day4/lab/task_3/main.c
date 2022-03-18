#include <stdio.h>
#include <stdlib.h>

int main()
{

        /* task 3*/
        char firstname[20],lastname[20],fullname[20];
        printf("enter your first name: ");
        scanf("%s",&firstname);
        printf("\nenter last name: ");
        scanf("%s",&lastname);

        strcat(fullname,firstname);
        strcat(fullname,lastname);
        printf("your fullname is:  %s",fullname);
    return 0;
}
