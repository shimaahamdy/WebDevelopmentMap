#include <stdio.h>
#include <stdlib.h>

int main()
{
//   /* task 1: C Program to take an array elements from user, then print them out "using 2 for loops".  */
//
//   int arr[5000];
//   int arr_size=0;
//   printf("enter array size:");
//   scanf("%i",&arr_size);
//   printf("enter array elements\n");
//   for(int i=0;i<arr_size;++i)
//   {
//       scanf("%i",&arr[i]);
//   }
//   printf("the array:");
//   for(int i=0;i<arr_size;++i)
//   {
//       printf("%i ",arr[i]);
//   }



   /* task2:C Program to find the minimum & maximum value of array elements. (Min_Max Array)*/

//   int arr[12]={1,10,-3,2,0,15,20,2,20,25,25,-10};
//   int max_value=arr[0],min_value=arr[0];
//   for(int i=0;i<12;++i)
//   {
//       if(arr[i]>max_value)max_value=arr[i];
//       if(arr[i]<min_value)min_value=arr[i];
//   }
//   printf("max value is: %i\n",max_value);
//   printf("min value is: %i\n",min_value);

/* task3:  C Program to find Sum of each row in a 2D Array. (3 std, 4 subjects)*/

//int arr[3][4];
//int sum[3]={0};
//for(int i=0;i<3;++i)
//{
//    for(int j=0;j<4;++j)
//    {
//        scanf("%i",&arr[i][j]);
//        sum[i]+=arr[i][j];
//    }
//}
//for(int i=0;i<3;++i)
//    printf("sum of %i row is %i\n",i+1,sum[i]);

/* task4: Calculate average of each column in a 2D Array. */
//int arr[3][4];
//int avg[4]={0};
//for(int i=0;i<3;++i)
//{
//    for(int j=0;j<4;++j)
//    {
//        scanf("%i",&arr[i][j]);
//        avg[j]+=arr[i][j];
//    }
//}
//for(int i=0;i<4;++i)
//    printf("avg of %i col is %f\n",i+1,avg[i]/3.0);

/*task5:C Program to add two matrix and put the result in a third one, then print the result.*/

int matrix1[3][3],matrix2[3][3],sum[3][3]={0};
printf("enter first matrix\n");
for(int i=0;i<3;++i)
{
    for(int j=0;j<3;++j)
    {
        scanf("%i",&matrix1[i][j]);
        sum[i][j]+=matrix1[i][j];
    }


}
printf("enter first matrix\n");
for(int i=0;i<3;++i)
{
       for(int j=0;j<3;++j)
    {
        scanf("%i",&matrix2[i][j]);
        sum[i][j]+=matrix2[i][j];
    }

}
printf("sum of 2 matrix\n");
for(int i=0;i<3;++i)
{
    for(int j=0;j<3;++j)
       printf("%i ",matrix1[i][j]);
       printf(" + ");
    for(int j=0;j<3;++j)
        printf("%i ",matrix2[i][j]);
     printf(" = ");
       for(int j=0;j<3;++j)
        printf("%i ",sum[i][j]);
    printf("\n");


}


return 0;
}

