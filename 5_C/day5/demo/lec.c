/* 
fucntion prototype (signture)
PrintLine /// Pascal
printLine //Camel Casing
print_line //underscore

/*
/* defination: body */
/*
where function in program 
-befor main (function defination)
 int befor_name()
{
   code;
}

-after main  defination and befor name put function signture
void after_main();
int main
{
        // function call
       before_main(); 
       after_main();
} 
void after_main()
{
    code;
}

*/

/* data saved in memory:
code segment -->code
data segment --> stack,heap

stack:
fucntions

when we call function --> data will be in stack memory
stack size -->1MB fixed size
stack faster than heap (push / pop) is known how to work with fixed addresses O(1)
automaicaly manged
data -->not intalized

stack frame : function in stack as memory

stack trace --> which function run and execute



// delete "return type" from signture 
sum(int x,int y)
{
    return x;
}
int sum(int x,int y)
{
    //delter return statment
}
will work sometimes and return x but not garinted
// delete both return from signture and definiation
sum(int x,int y)
{
    
}
// it should return 0 as it suppose it return 0
//default if return type deleterus int

/* how to return more than one value:
array
pointer
struct 
global varable

for global varable:
-life time the whole program
-in the heap
-intailzed 
we can save functions values directly and return more than value


- int s=55;
int main()
{
    print s; //55
    int s=3; 
    print s //3
    complier choose the closet in scope
}

struct : datatype that have collection of different datatypes

befor main and any function used
--stack
define a new type datatype called "Book"
struct Book
{
    int ISBN;  //4 byte
    char title[20]; 20byte
    float price;  //4byte
};

typedef // define new type called book 
typedef struct 
{
    int ISBN;  //4 byte
    char title[20]; 20byte
    float price;  //4byte
}Book; // call book directly in main

// struct inside struct //search on for more
struct book
{
    struct c
    {

    }
}
int main()
{
    struct Book b; // declare a instance of b and in staack memory recive 28 byte

    // print attributes
    b.ISBN = 50;
    b.price = 250;
    strcpy(b.title,"C book");

    

}

/* assignment:
struct employee
{
    int id;
    int age;
    char gender;
    char name[20];
    char address[100];
    float slary;
    float overtime;
    float deduction;


};

//sizeof(struct employee) //return size

int main()
{
    struct employee[5];
    for(employee)
    {
        print data;
        netsalary();
    }
}

// show 
id:              name:
age:             address:
gender:          salary:
overtime:        deduction:

