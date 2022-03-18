#include <stdio.h>
#include <stdlib.h>

int main()
{
    int digit;
    scanf("%d",&digit);
    printf("%x",digit);

    /*

    char c;
    printf("enter any char\n");
    scanf("%c",&c);
    printf("the ASCII code is: %d",(int)(c));


    / task2/
    printf("hello world\n");



    //

    char hex[100];
    printf("enter a decimal number\n");
    int num,temp;
    scanf("%d",&num);
    temp=num;
    int i=0;
    while(temp)
    {
        int digit = temp%16;
        temp/=16;
        int shift_val1 = (int)('0');
        int shift_val2 = (int)('A');
        char digit_hex;
        if(digit<10)
        {
            digit_hex = (char)(digit+shift_val1);
            hex[i]=digit_hex;
            ++i;
        }
        else
        {
            digit_hex = (char)((digit-10)+shift_val2);
            hex[i]=digit_hex;
            ++i;
        }

    }
    --i;
    for(;i>=0;--i)
    {
        printf("%c",hex[i]);
    }
    */

    return 0;
}
