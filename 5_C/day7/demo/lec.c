/* when we define the type like int , array
we book a much amount of memory (most of times will not be used)
*/
/* and that problem lead to dynamic alocation that means control of memory size*/
//alloc.h 
// heap area 
// need to be freed after book

/* heap is shared between other programs in os */
malloc(5); //search for 5 bytes insequence and return address of first byte
           //return pointer of void void*
           //return pointer to unknown datatype
           //address of first byte
           // if there is no space to prserve will return 0


// book an int form heap
int * px;
px = (int*)malloc(sizeof(int));

free(px); //pointer = null (not booked anymore)

//sizeof() return number of bytes of element in memory 

/*  allocate dynamic area for user datatype*/
struct Employee *pemp;
pemp = (struct Employee*)malloc(sizeof(struct Employee));
/* access stack inside */
pemp->code = 7;
free(pemp);

/* we should explicitly heap free it at the end of the program

/*how to allocate dynamic array */
// unknown type and size
int size;
char choice;
int *pint;
float *pf;

choice = getch(); //choose datatype of array int (i) or folat (f)
scanf("%d",&size); // enter size of array


switch (choice)
{
case 'I':
    pint = (int*)malloc(sizeof(int))*size;
    id(!pint) // if there no available memory
    {
        printf("no available memory");
        exit(1);
    }
    for(int i=0;i<size;++i)
    {
        //scanf("%d",&pint[i]);//ok
        //scanf("%d",pint+i);//ok
        scanf("%d",*pint);
        /*
        scanf("%d",*pint);
        pint++;
        doing pint++ will free the memory that we left 
        we have to keep pointer refer to first element in array
        
         */
        scanf("%d",*pcurrent);
        pcurrent++;

    }
    break;

case 'f':
    /* code */
    break;
default:
    break;
}

/* array of pointers */
int *parr[4]; // 4 spaces preserved in memory 
/* all pointers in array should be same type


//dynamic area allocation for pointers inside static array of pointers*/
parr[0]=(int*)malloc(sizeof(int)*5);
parr[1]=(int*)malloc(sizeof(int)*3);

//array of pointers --> stack
// what pointer refer to -->heap

/* students name with varable lenghts */
char cparr[4];
for(int i=0;i<4;++i)
{
    int size;
    scnaf("%d",&size); //enter your name size
    parr[i]=(int*)malloc(sizeof(int)*size);
}

/* pointers to pointers */
char **sptr; // pointer to char pointer
sptr = (char*)malloc(sizeof(char*)*3)

