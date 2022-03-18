// objects

//built in objects
//BOM objects (browser as object that host website)
//DOM (document object model)

/* built in objects*/
//String

//1] literal creation
// faster and lighter
// value type 
var s = "hello";
console.log(s.length); //5 size
console.log(typeof s); //string

//2]constructio creation
// here we create the string as object type 
// alwayes use literal creation better
//reference type
var s2 = new String("hello");
console.log(s2.length); //5 size
console.log(typeof s2); //object

//methods for String both 2 types of creation(constructor/literal)

console.log(s.charAt(1));// e
console.log(s[0])//h

// return first index of char or word
//-1 if char not exist
console.log(s.indexOf("h"))//0
console.log(s.indexOf("X"))//-1

s[0]='I';  // nothing change here (not array) cannot edit every char can just access it 
console.log(s); //hello

console.log(s.lastIndexOf('l')) //hello -->3 last apper of char

var s3="hello at second day at javaSript wish good journey";
console.log(s3.substring(4,7));//return string form 4 to 6 -->o a
console.log(s3.substr(4,7));// retuen string start form 4 and count 7 char -->o at se


console.log(s3.split(" "));// array of string split of " "

console.log(s3.split("e",2));// return first 2 strings that e split it

console.log(s3.replace("h","1"));//return a string replace each h with 1 

//regix
console.log(s3.replace(/h/igm,"_"));// replace H or h with "_"

//falgs
/*
 igm:
     i--> ignore case senetive (A,a) replace first a (A,a) 
     g --> global (for whole string)
     M -->multiple lines 

*/

var regular = /h/ig;  // create regular expression and save in var
console.log(s3.replace(regular,"125"));

/* create regular expression*/
//1] literal 
var regular = /h/ig;  // create regular expression and save in var
//2] constructor
var regular2= new RegExp(/h/,"ig");
console.log(s3.replace(regular2,"constructor"));

console.log(typeof regular2); // object 

var phone_reg = /[0-9]{8}/  // any number fom 0 to 9 and length{8}==8

// test check if input string has 8 numbers inside it or not 
console.log(phone_reg.test("a12345679")) //true

var phone_reg2 = /^[0-9]{8}/  // start with any number fom 0 to 9 and length{8}==8

console.log(phone_reg2.test("12345678aa")) //true 
console.log(phone_reg2.test("aa12345678")) //false

var phone_reg3 = /^[0-9]{8}$/  // start with any number fom 0 to 9 and length{8}==8 and end
console.log(phone_reg3.test("12345678aa")) //false
console.log(phone_reg2.test("12435778")) //true

var phone_reg3 = /^[1-3]{8}[7-9]{2}$/  // 13212322 77 first8 numbers from 1 to 3 and then 2 numbers can be from 7 to 9

var phone_reg3 = /^[1-3]{0,8}$/  //length can be any number from 0 to 8
console.log(phone_reg3.test("")) //true

var phone_reg3 = /^[1-3]{2,}$/  //at least number size 2 
console.log(phone_reg3.test("13222223222222")) //true

var emailregx=/^[a-zA-Z]{0,}[0-9]{0,}\@{1}[a-z]{1,}$/
console.log(emailregx.test("Sh5@gmail")); //true

var charregx=/^[a-z A-Z 0-9]{0,}[@!]{1}/;
console.log(charregx.test("0A@"));//true
console.log(charregx.test("0A!"));//true
console.log(charregx.test("a@!!!!"));//true   ---> can not understand it

var charregx=/^[a-z A-Z 0-9]{0,} (@|!){1}/;
console.log(charregx.test("a@!!!!"));//true  can not understand it
/*
* --> 0 or more {0,}
+ --> 1 or more {1,}

*/

/* in conseole
document.write("hello".fontcolor("red"))
we can write from console to be applied in html page
*/

// every methods return new string not change value itself
var s4 = "hello";
var s4 = s4.toUpperCase();
console.log(s4);


// not refernced we just copy the value
var r="hi";
var f = "hello";
f=r;
console.log(f);
r="try if refernced";
console.log(f); //hi 

/////////////////////////////////////////////////

/* number object */

// 1] literal creation

var n = 13;
//2]constructor creation

var n2 = new Number(13);

console.log(typeof n);  //number
console.log(typeof n2); //object

/* still copy value from object to object */
var n2= new Number(14);
var n3 = new Number(18);

n3=n2;
console.log(n3);
n2=13;
console.log(n3);

/* */
console.log(n3.valueOf()); // return primitive value

console.log(n3.toLocaleString("ar-eg")); // change the style of value



/* array */
// array can have differnt types of parameters
//1] literal cration

var arr = [];
var arr2=[1,2,3];
var arr3=[1,true,"string"];
var arr=[[1,2],[4,5]];   //2D array
arr[0][1]; //2
var arr5=[1,,2]; //3 elements 
arr5[1]=10;  // can edit and access any index of array
console.log(arr5);
arr[0]=7;
console.log(arr);


//2] constructor array
var arr6 = new Array();
arr6[0]=6;
arr6[1]=8;
console.log(arr6);

//3] dense array
var arr7 = new Array("Apple","Banan",5);
console.log(arr7);

/* refernce change */
var arr10 = [1,2,3];
var arr11 = new Array("10",5,8);
arr11 = arr10;
console.log(arr11);
arr10[0]=115;
arr10[5]=6;
console.log(arr11);

/* 
note: if we change arr10 to arr10 = [10,15];
we create a new memory and make arr10 refrence to it
so no change in arr11
*/
arr10 = [152,85,30]; // new memory
console.log(arr11);
arr10[0]=3;
console.log(arr11);

/* if we want copy only values from one array to another*/
// only for loop
var a1 = [1,3];
var a2= [2,10,11];

for(var i=0;i<a2.length;++i)
{
    a1[i]=a2[i];
    
}

console.log(a1);


/* methods */
a1.join("*");  // no change in array value
console.log(a1);
console.log(a1[0]+5);

/* array have:
push          insert last
pop           delete last
unshift       insert first
shift         delete first

if array = [10,1,6,12]
sort     -->sort by uni code (1,10,12,6) 
1
10  
12
122
13
21
22
26
56
53
6
sort(function(a,b){return a-b;});
a-b -->return true  a > b so a come after b
a-b -->return false  a < b so b come after a
1,10   -->1-10=-9   1,10
10,6   -->10-6=4    6,10

*/

/*
Associative array*/
var arr = [1,2]; 
console.log(arr.length);   // dot notation

console.log(arr["length"]); // subscript




var arr = new Array();

arr["username"]="hello";
arr["age"]=20;
arr["phone"]=["010","011"];
arr["length"]=0;
arr[0]=15;

console.log(arr); // [username: 'hello', age: 20, phone: Array(2), ourlength: 0]
console.log(arr.length); //0  has no length as has no index

// associative array has no index
// to loop use for in
for(var i in arr)
{
      console.log(i); //key and if it was indexed will show inde not value
      arr["length"]++;
}

// mapping as key
console.log(arr["length"]); //3
console.log(arr["username"]); //retuen value = hello

for(var i in arr)
{
      console.log(i + arr[i]); //key and value
     
}

console.log(arr);

var date = new Date();
console.log(date);
console.log(date.getDay()); // 0-6

console.log(date.getFullYear()); //2021
date.setMonth(1);
console.log(date);

/* BOM */














