// lecture notes
/* array that created in c should be in 
fixed sized even if compiler have others 
values 
*/

/* array of chars
we have noting called string in c, we have 
array of chars
*/


char str[10]; //char*
for(int i=0;i<10;++i)
scanf("%c",&str[i]);

/* problems: 
1-loop for 10 even the word less than that

sol: for size */
char c;
for(int i=0;i<10;++i)
{
    scanf("%c",&str[i]); // cause problem use getche
    if(c==0X0D) // if he click enter break
      break;
    str[i]=c;
}

/* 2-scanf --> will but enter in buffer as char  
getche -->print the char on scrren
getch -->no print char*/

// string size: the whole memory receved
// string length : the actual elements exsist

/* null character: special character in 1 byte determine the end of char arrays
/* getche()  ->not used delimiter to determine the end of input

*/

/* array of chars built in c */
char str[10];
scanf("%s",str); // take whole string as input no %str as it is address , s represent string
printf("%s",str); // print whole string

/* problems with scanf("%s",str);
1- loop we build better as limit size 
2- can not take space between string ex>ahme maoha

sol:
-gets(str); // take stop only with enter but also no size limit
-puts(str); //print whole string

puts as print but for char array but same performance no differnce
but printf better as it can include other strings and numbers 
pust take only one string to print
printf("hello %s",str);

puts("hello");
pust(str);

puts take newline default after print
*/

/* string functions:
-strcat(str1,str2) // str1+str2 "concatination"

Alphatic:

e<i
Hi>Hello

check char char if (x>y):
                          postive -->x>y
                          negative -->x<y
                          0       --> x==y

str2="Hi";
str1="Hello"
strcmp(str1,str2); // return -1 as Hi>hello

i>I captical less than small letters

strcmpi(str1,str2) //ignore case Hi == hI

/* some graphics */
/*
colors:
       0 to 15
       0000 black
       
       ....
       0111 light grey
       ....

       1111 white

flash: on/off 0/1
backcolor: 0-7 3bit
forecolor(): 0-15 4bit
normal: 0 000 0111 hex:0X07
highlited: 0 111 0000 hex:0X70 
textattr(0X70) to change color to highlited content
_cprintf()//print with colors
/***********************************/
/* aski for :
             upArrow
             DownArrow
             Home
             End
             Esc
             Enter
             pgUp
             pgDown

normal key-->char, numers,esc,enter work with normal getch or scanf 
             1byte

extendded keys:22key
(f1,...,f12, 4 arrows,home,end,pgup,pgdown,delete,insert);
2byte --> sign(1byte) code(2byte) 


