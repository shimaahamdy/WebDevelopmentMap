#include <stdio.h>
#include <stdlib.h>

int main()
{
    int size,*ptr,sum=0;
    scanf("%d",&size);
    ptr = malloc(sizeof(int)*size);
    for(int i=0;i<size;++i)
    {
        scanf("%d",ptr+i);
        sum+=*(ptr+i);
    }
    printf("%d",sum);

    return 0;
}
