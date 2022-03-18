class Complex
{
    public:
    int tos = 0; // not vailed as there is no mean (no object vreate or memory)
    Complex sub(Complex temp1,Complex temp2)
    {
        Complex result ;
        //code
        return result;

        /* temp1 , temp2 , result pass by value
        so there is a copy created in temp1 and temp2 to used in function
        and there is a copy created of result to pass back */ 
    }

    /* pass class/struct by refernce */
    Complex sub(Complex &temp1,Complex &temp2)
    {
        Complex result;
        //code
        return result;

        /* temp1 , temp2 here is the real strucutre that was pass to
        function and any change will affect the real classes/struct 
        */


    }

    /* pass as read only */
        Complex sub(const Complex &temp1,const Complex &temp2)
    {
        Complex result;
        //code
        return result;

        /* temp1 , temp2 here is the real classes\strucutre that was pass to
        function 
        but we can not chage any of its parameter
        temp1.real = 4 //not vaild
        */
       

    }
    /* constructor */
    /* that function is first function execute automatic when create the object*/
    /* we can not return thing as it is intialize function */
    /* same name as class name */
    Complex (int R,int I)
    {

    }
    Complex (int R)
    {
        
    }


    /* destructor: that a function that called automatic when destory object
       only one destructor per class
       os called it when removing object
       usually we remove memory we create as pointers
       but object itself delted by os
    */

   /* constructor and destructor optional 
   that mesans if there is no consturctor defined that the os called 
   defult one empty parameterless Complex(){}
   but if we define a parameter constructor
   we can not use the default one*/

   /* 

   /* not public constructor: the constructor can be private if there is no need to access outside class
   only want to be access from inside

    */
   private:
   Complex

   /* destructor can not be private*/


/* if i want default value fof r constarctor or function parameter*/
   // i can send size (5) or no parameters at all 
   mystack (int size=5)
   {
       
   }
}

main()
{
    Complex c1(1,2); // allocate 8 bytes using  constructor that take 2 varables
    Complex c2; //allocate 8 using parameterless insturcotr
    /* if you not define parameterlist consturcotr he will give erorr*/
    /* objects that we create in main created in stack */
}

/* asignment */
class stack: peak function: the value of last element but not removed

complex class 
with 3 ctors
     1 des
c3 = c1.sum(s2);
# of objects
# of ctors
# of destrucotr 

clss queue (first in first out)
{
    ctors 
    destructor 
    isfull, is empty
    enqueue
    deque
    peak
}
// one is shifiting 
// one is circular