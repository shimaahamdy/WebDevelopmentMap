/*
//problem with scanf it is delimeter with enter or space
/ char inputs: a b c d 
char str[10];
for(int i=0;i<10;++i)
  scanf("%c",&str[i]) ;

so we want functions deal with chars char by char without delimeter like space or enter
/* read only charaters with no need to press enter or space:

//used only with chars 
//return the char was pressed
char ch=getch()  
char ch=getche() //e stands for echo (print) that means char was pressed print on console

how they work:
go to buffer
if buffer have data on -->read that data(single byte) and return it
if buffer have no data -->wait for user to enter data and read 1 byte from buffer

*/
/*
both geche() and scanf() with loop must enter full size, what if i want finish after 3 letter or 4:
for(int i=0;i<10;++i)
{
    char c =getche();
    if(ch == 13)  //check if he press enter
     break;
    str[i]=c;
}
// when we print we have also print 10 chars and maybe the name is smaller so maybe print grabage
for(int i=0;i<10;++i)
printf("%c",str[i]);

//so maybe we have counter but in a general solution
/* make array hold a delimeter that determine last cell in array of char --> '\o'
a l y \o I v * u v b 
\0 null terminator a termantior that determine end of string 
for(int i=0;i<10;++i)
{
    char c =getche();
    if(ch == 13) 
    { //check if he press enter
     str[i]='\0'; //end of string
     break;
     }
    str[i]=c;
}
// will print the lenght of array only ali 
while(str[i]!='\0')
printf("%c",str[i++]); 

/* treat string as single varable not array of char*/
scanf("%s",str); //press enter the os will put '/o' alone but will exceed size and not take spaces also "ahmed ali" will terminate after ahmed
printf("%s",str);

/*scanf sometimes not clear buffer:
ex ahmedalimohamed and str[8] mohamed maybe stay in buffer
sol: _flushall();
*/
//functions to use with strings as one varable:
gets(str); //accept spaces  but exceed size of varable
puts(str); //printstring  

//exceed size problem:
scanf("%s",str); //str[5], input:shimaahamdy 
/* os will continue writing and put also '/0' so it is not granted that '/o' will change as it is not varable memory*/
printf("%s",str);
//print continue printing till founc '\0' so if input was exceeding upper bound
//it will continue printing till error or found '/0' ;

/* string functions */
strlen(str0); //length of string

char str1[10]={'A','b','c','\o'}; //arr of chars
char str2[10]="hello"; //as string 

str1=str2 //not vaild 
char str3[10]=str2; //not vaild

strcpy(str1,str2); //str1 = str2 , assignment
//strcpy doesnt check size it continue copying and writing till find in str2 '/o'

strcat(str1,str2); //str1=str1+str2; == str1+=str2;

strcmp(str1,str2); 
/*
+ str1>str2
- str1<str2
0 str1==str2
*/
//compare alphatic
Ha < He   //e-a=
h > H     
strcmpi(str1,str2); //non case senetive
// HeLoo == hEloo

/* array of strings */
/*2d array of chars
/* [3][5];
   a b c \o
   d e f g \o
   r n b m \o
*/
/*single dimension array of string with size = 3
abc\0
defg\0
rnbm\0
*/
char menu[3][5]={"new","save","exit"};
scanf("%s",menu[0]); //new

/*
forecolor 
colors in c 16 color(0-15):
   0000  black  
   .
   0111 light grey
   .
   1111 white
backcolor:(8 colors)
flashing(on/off);

1byte hold informations about text
0 000 0000 flash backcolor forcolor

normal pen:00000111 7 hex:0x07
highlighted pen:0x70
textattr() //recive single byte
{

}
textattr(highligted);
_cprintf(); //print text with color

Extended keys (24) :delete,insert,arrows 4,functions key (12),pgup,pgdn,home,end
aski code for  extended keys
2 chars 
-32|0 then asci code
uparrow 72

normal key:
-enter 13
-esc 27
-letter
-numbers
*/













