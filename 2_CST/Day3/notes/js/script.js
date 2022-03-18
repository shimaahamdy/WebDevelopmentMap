document.write("heelo from external file js<br>")

console.log(" hi from console"); //console is consider object
// console as print most used in debug

/** primitive dataTypes 
 * 1-number[int-float-double-...]
 * 2-string
 * 3-boolean 
 * 4-undefined
 * 5-null[some peoble say its primitive and not primitive]
 
*/

// it detects from value the type
var x =5;
console.log(typeof x);
x="hello" ; //js is consider loosly data type
x=true;
console.log(x);
var z; // undefined varable as there is no value in declartion
console.log(typeof z);

var x;
console.log(typeof x); // last type initalize

var y = "vary";
x=y;  // change x to string 
console.log(typeof x);

x=5;
console.log(typeof y); //no effect on y

// operators
// ! not 
// unary
var z=10;
var w = ++z; // z=11 w=11
var w=z++; //w=11 z=12

// ternary
var r=true;
console.log(r);

var x=5
console.log(!!x);

var x="" // false values [0,"",null,undefined,false,nan()]
console.log(!!x);

// !! used to check unknown values (false (empty) or true)


//coersion & strict equalty (===)
// ===
var t = 5;
var y="5";
console.log(t==y); // true check 
/* change number to string and then compare*/

console.log(t===y) // false
/* does`t change type (no casting)*/

console.log(3<2<1); // true
/* 
3<2 false
false<1 -->  casting(false)=0<1 --> true
*/

console.log(5&&3); //3 
/* 
continue as it is true till he reach to final value
and print 3 (the last value in true serious)

continue till it face false and then print the value that make 
condition false
*/

console.log(5||0); //5
/*
if first value is false print value of first
if first value is true print value of first (5)
*/

console.log(!!(5||0));// print true of false use !! 

/////////////////////////////////////////////////////

//functions
var x="158";
console.log(x+2);
console.log(parseInt(x)+2);
console.log(parseInt("15.258hfkjla"));//15

console.log(parseInt("0110",2)); 
//change from binary to decimal (2)--> base

console.log(parseInt("Ab",16)); // 16 base of hexi
//////////////////////////////////////////////
console.log(parseInt(" "));

console.log(isFinite(123)); //true
console.log(isFinite("156")); //true
// is finite chek if it is number return true

console.log(isNaN("156fdjk")); // true
// return true if it is not a number




