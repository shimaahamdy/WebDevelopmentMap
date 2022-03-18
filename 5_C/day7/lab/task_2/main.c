#include <stdio.h>
#include <stdlib.h>

int main()
{
    int students_num;
    char **stud_ptr;
    scanf("%d",&students_num);
    stud_ptr = (char **)malloc(sizeof(char *)*students_num);
    for(int i=0;i<students_num;++i)
    {
        int name_size;
        scanf("%d",&name_size);
        name_size++;
        stud_ptr[i] = (char *)malloc(sizeof(char)*name_size);
        scanf("%s",stud_ptr[i]);
    }
    for(int i=0;i<students_num;++i)
        printf("%s \n",stud_ptr[i]);
    return 0;
}
