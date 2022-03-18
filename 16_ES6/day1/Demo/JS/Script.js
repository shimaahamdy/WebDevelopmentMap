// /**Release Update Every June */
// /**
//  * ES2015 ---> ES6
//  * ES2016 ---> ES7
//  * .
//  * .
//  * .
//  * .
//  * ES2021 (June) ---> ES12
//  * 
//  * ====>ES2022 (June) ---> ES13<====
//  */

// // console.log(s);//undefiend
// // var s = "Hello";//Hoisting
// // console.log(s);//Hello

// // console.log(s1);//Reference Error =====>no s1
// // let s1 = "Hello";//No Hoisting
// // console.log(s1);//Hello


// // let x;
// // console.log(x);//undefined

// // let x;

// // console.log(y);//Reference Error
// // const y = 10;//No Hoisting
// // console.log(y);//10

// // const z;//Syntax Error
// // console.log(z);


// //let [No Hoist  -  Intialize/No Intialize  -  Declared Only one Time]
// //const [No Hoist  -  Intialized  -  Declared Only one Time]



// // function fun(){
// //     for(var i = 0; i<3; i++){
// //         // console.log(i);
// //     }
// //     console.log(i);//3
// // }

// // fun();


// // function fun2(){
// //     for(let i = 0; i<3; i++){
// //         console.log(i);
// //     }
// //     // console.log(i);//Refernce Error
// // }

// // fun2();

// // [fun(){0},fun(){1},fun(){2}]


// // function ClousureProblem(){
// //     var arr = [];

// //     for(let i = 0; i<3; i++){
// //         arr.push(function(){console.log(i)})
// //     }

// //     return arr;
// // }


// // console.log(ClousureProblem()[0]());
// // console.log(ClousureProblem()[1]());
// // console.log(ClousureProblem()[2]());





// //===================Object [this-that]======================
// //literal Creation


// // var obj = {
// //     fname:"ALY",
// //     lname:"Samy",
// //     disp:function(){
// //         return "Hello ya " + this.fname + " " + this.lname;
// //     },

// //     disp2:function(){
// //         var that = this;
// //        setTimeout(function(){console.log("Hello ya " + that.fname + " " + that.lname)},1000)
// //     },
// //     disp3:function(){
// //        setTimeout(()=>{console.log("Hello ya " + this.fname + " " + this.lname)},2000)
// //     },
// //     disp4(){//Note Name of Function
// //         setTimeout(()=>{console.log("Hello ya " + this.fname + " " + this.lname)},3000)
// //      }
// // }

// // console.log(obj.disp());


// // obj.disp2();
// // obj.disp3();
// // obj.disp4();



// //==============Arrow Function===============
// // var myVar = function myFun(x){return x+10;};
// // var myVar = function(x){return x+10};
// // var myVar = ()=>{};
// // var myVar = (x)=>{return x+10};
// // var myVar = x=>{return x+10};
// // var myVar = x=>x+10;

// // console.log(myVar(10));

// // w=s=>"Hello"+s;
// // console.log(w("Ahmed"))


// //================ rest parameter =================
// function sum(x,y){
//     return x+y;
// }

// function sum(){
//     return arguments[0]+arguments[1];
// }

// function sum(){
//     let s = 0;
//     for(let i=0;i<arguments.length;i++){
//         s+=arguments[i];
//     }
//     return s;
// }


// //rest Parameter
// function sum(...koko){
//     // console.log(koko);//array
//     let s = 0;
//     for(let i=0;i<koko.length;i++){
//         s+=koko[i];
//     }
//     return s;
// }


// function sum(a,b,...koko){
//     console.log(koko);//array
//     let s = 0;
//     for(let i=0;i<koko.length;i++){
//         s+=koko[i];
//     }
//     return "Hello ya "+a+" " + b + ", Sum = " + s;
// }



// // =============== Spreed Operator ================
// function conc(a,b){
//     return "Full Name: "+ a + " " + b;
// }


// // let info = ["Ahmed", "Aly", "Hossam"];

// // // console.log(conc(info[0], info[1]));
// // console.log(conc(...info));


// // //Destructuring

// // let arr = [1,2,3,4,5,6];
// // // let t = arr[0];
// // // let w = arr[2];
// // // let z = arr[5];
// // // console.log(t,w,z);

// // let [t,,w,,,z] = arr;
// // console.log(t,w,z);


// // let obj = {fname:"Sama",surname:"SSS",age:20};

// // // let firstName = obj.fname;

// // // let {f,s,a} = obj;
// // // console.log(f, s , a);

// // // let {surname:sn,fname} = obj;
// // let {surname,fname} = obj;
// // // obj.surname = "kkkkkkkkkkkkkkk";

// // console.log(surname,fname);

// // surname = "Abdelrahman";
// // console.log(surname);
// // console.log(obj.surname);//kkkkkkkkkkkkkkk


// //Creation of Objects

// //1-literal Creation
// //2-constructor Creation
// //3-Factory Function
// //4-constructor Function

// var Employee = function(name,age,salary){
//     return {
//         age,
//         salary,
//         name
//     }
// }

// let e1 = Employee("Sara",30,10000);
// // console.log(e1)

// //New Methods at string

// // let s = "Hello";
// // console.log(s.endsWith("o"));//true
// // console.log(s.endsWith("s"));//false

// // console.log(s.startsWith("H"));//true
// // console.log(s.startsWith("h"));//false

// // console.log(s.includes("l"));//true
// // console.log(s.includes("L"));//false

// // console.log(s.repeat(5));//HelloHelloHelloHelloHello

// // console.log((" "+s+" ").trim());

// //=================== Template String ====================

// // var s = 10000;
// // var obj = {fname:"Nader", lname:"Kareem",age:20};

// // console.log("Hello Ya "+obj.fname+" "+obj.lname+ ", Age: "+obj.age+", Salary: "+s );
// // console.log(`Hello Ya ${obj.fname} ${obj.fname} Age: ${obj.age}, Salary: ${s}`);


// // ================ Array ================
// var myArray = [1,20,3,4,5,6];


// //find return only one element that match first occurence
// console.log(
//     myArray.find((num)=>{return num === 20;})//20
// );

// console.log(
//     myArray.find(num=> num === 20)//20
// );


// console.log(
//     myArray.find(num=> num === 60)//undefined
// );


// // var myArray = [1,1,1,1,1]//arr[0] == 1 && arr[1] ==1 &&......

// //every =====> &&
// console.log(
//     myArray.every(num=> num === 1)//false
// );


// //some =====> ||
// console.log(
//     myArray.some(num=> num === 1)//true
// );


// //fiter =====> return new Array
// console.log(
//     myArray.filter(num=> num === 1)//[1]
// );
// console.log(
//     myArray.filter(num=> num%2 === 0)//[20,4,6]
// );


// //forEach() ===> for loop
// console.log(
//     myArray.forEach(num=>console.log(num))//1   20    3    4    5   6
// );


// //map==>for loop but return new Array
// console.log(
//     myArray.map(num=>"this is num "+num)//[1,20,3,4,5,6]
// );


// //Number 
// // console.log(isFinite(123));//true
// console.log(isFinite("123"));//true


// // console.log(Number.isFinite(123));//true
// console.log(Number.isFinite("123"));//false
// console.log(Number.isInteger(123));//true
// console.log(Number.isInteger(123.456));//true



//Default parameter
function sum(x=0,y=0){
    // x = x||0;
    // y = y||0;
    return x+y;
}


var obj = {}
Object.defineProperty(obj,"fname",{
    value:"ALY"
    // enumerable//false
    // configurable:false
    // writable:false
})


//Default Object [options]
// function displayInfo(msg="Hello Ya ",{title="eng",nm="Aly",age=20}){
//     return `${msg} ${title}.${nm} of Age: ${age}`
// }

// console.log(displayInfo())



// function displayInfo(msg="Hello Ya ",obj = {title:"eng",nm:"Aly",age:20}){
//     return `${msg} ${obj.title}.${obj.nm} of Age: ${obj.age}`
// }

// console.log(displayInfo("Hiiii ya ",{nm:"Samy"}))




function displayInfo(msg="Hello Ya ",options={}){
    var defaultObj = {title:"eng",nm:"Aly",age:20}

    var result = Object.assign({},defaultObj,options)//return New Object

    return `${msg} ${result.title}.${result.nm} of Age: ${result.age}`
}

console.log(displayInfo("Hiiii ya ",{nm:"Samy"}))
