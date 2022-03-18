document.write("Hello From External Script File<br>");

console.log("Hello From Console");

/**Primitive DataTypes at JS
 * 1-number[int-float -......]
 * 2-string
 * 3-boolean
 * 
 * 4-undefined
 * 5-null [primitive - not Primitive]
 * 
 */


var x;
// console.log(x);
// console.log(typeof x);
console.log("Value of X = "+x+" And Type = "+ typeof x)

var x=null;
// console.log(x);
// console.log(typeof x);
console.log("Value of X = "+x+" And Type = "+ typeof x)


var x = 5;
// console.log(x);
// console.log(typeof x);
console.log("Value of X = "+x+" And Type = "+ typeof x)

var x="Hello";
// console.log(x);
// console.log(typeof x);
console.log("Value of X = "+x+" And Type = "+ typeof x)

var x=true;
// console.log(x);
// console.log(typeof x);
console.log("Value of X = "+x+" And Type = "+ typeof x)


var y = "LOLO";//string

x=y;

console.log("Value of X = "+x+" And Type = "+ typeof x)
console.log("Value of Y = "+y+" And Type = "+ typeof y)

y = 10;
console.log("Value of X = "+x+" And Type = "+ typeof x)

console.log("Value of Y = "+y+" And Type = "+ typeof y)



//unary operator

var z = 10;
z++;//postfix
console.log(z);//11
++z;//prefix
console.log(z);//12
//z=12
var w = ++z;// z = z+1 ====> w = z
console.log(w);//13 
//z=13
var w = z++;// w = z ====>  z = z+1
console.log(w);//13 
console.log(z);//14 

var r = true;
console.log(typeof r);//boolean
console.log(!!r);//true

var s = 5;
console.log(!!s);

//Falsy Values [0, "", null, undefined, false, NaN]

console.log(!!0);
console.log(!!5);
console.log(!!50);
console.log(!!null);
console.log(!!undefined);
console.log(!!"");
console.log(!!" ");
console.log(!!false);

if(0){
    console.log("0 is true value")
}
else{
    console.log("0 is false value")
}

var d;//undefined
if(!!d){
    console.log("d has value")
}
else{
    console.log("d has No value")
}

//coersion & strict equality
var t = 5;
var u = "5";
console.log(t==u);//false ===> true  [(5 ==> "5") ==> "5"=="5"]
console.log(u==t);//false ===> true  [(5 ==> "5") ==> "5"=="5"]
console.log(t===u);//false

console.log(3<2<1);//true [3<2 ==> false ===> false < 1 ===> 0<1 ===> true]
console.log(3<(2<1));//true [3<2 ==> false ===> false < 1 ===> 0<1 ===> true]


console.log(5&&3);//3
console.log(5&&0&&3);//0
console.log(5||0||3);//5
console.log(0||0||3);//3
console.log(!!(0||0||3));//true
console.log(!!(5&&0&&3));//false


console.log(123);//number
console.log("123");//string
console.log(parseInt("123"));//123
console.log(parseInt("123.56"));//123
console.log(parseInt("123.56asdasd"));//123
console.log(parseInt("asdasd123.56asdasd"));//NaN (Not A Number)


console.log(parseFloat("123"));//123
console.log(parseFloat(" "));//NaN
console.log(parseFloat(null));//NaN
console.log(parseFloat("123.56"));//123.56
console.log(parseFloat("123.56asdasd"));//123.56
console.log(parseFloat("asdasd123.56asdasd"));//NaN (Not A Number)


console.log(parseInt("0110",2));//6
console.log(parseInt("A",16));//10


//isNaN VS isFinite
console.log(isFinite(123));//true
console.log(isFinite("123"));//true
console.log(isFinite("abc"));//false


console.log(isNaN("abc"));//true
console.log(isNaN("123"));//false




