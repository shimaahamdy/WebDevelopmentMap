// /** (I) Objects */
// /** A) Built-in Objects [Properties - Methods]
//  *  1-String
//  *  2-Number
//  *  3-Boolean
//  *  4-RegExp
//  *  5-Array
//  *  6-Error
//  *  7-Date
//  *  8-Function
//  *  9-Math
//  *  10-Object
//  */


// /** B) BOM Objects [Browser Object Model (Host)] */
// /** C) DOM Objects [Document Object Model] */



// //=====================================================================
// /** String [Property(length) - Methods ...]*/

// //1)Literal Creation
// var s = "Hello";
// console.log(s.length);//5
// console.log(typeof s);//string

// //2)Constructor Creation
// var s2 = new String("Hello");
// console.log(s2.length);//5
// console.log(typeof s2);//Object

// console.log(s2.charAt(0));
// console.log(s2.charAt(4));
// console.log(s2.indexOf("o"));//4
// console.log(s2.indexOf("x"));//-1
// console.log(s2.indexOf("ll"));//2
// console.log(s2.indexOf("l"));//2
// console.log(s2.lastIndexOf("l"));//3
// console.log(s2[0]);//H

// s2[0]="T";
// console.log(s2[0]);//H

// //split
// //substr VS substring
// var g = "Hello at second h day h at JavaScript";
// console.log(g.substring(4,7));//o a   [start - end-1]
// console.log(g.substr(4,7));//o at se   [start - how many char]

// console.log(g.split(" "));//['Hello', 'at', 'second', 'day', 'at', 'JavaScript']
// console.log(g.split(""));//['H', 'e', 'l', 'l', 'o', ' ', 'a', 't', ' ', 's', 'e', 'c', 'o', 'n', 'd', ' ', 'd', 'a', 'y', ' ', 'a', 't', ' ', 'J', 'a', 'v', 'a', 'S', 'c', 'r', 'i', 'p', 't']
// console.log(g.split("e"));//['H', 'llo at s', 'cond day at JavaScript']
// console.log(g.split("e",2));// ['H', 'llo at s']
// console.log(g.split("h"));// ['Hello at second ', ' day at JavaScript']
// //RegExp  ===>   /reg/igm
// console.log(g.replace("h","_"));//Hello at second _ day at JavaScript
// console.log(g.replace(/h/i,"_"));//_ello at second h day at JavaScript
// console.log(g.replace(/h/igm,"_"));//_ello at second _ day at JavaScript

// var r = /h/ig;
// console.log(g.replace(r,"_"));//_ello at second _ day _ at JavaScript


// //1)literal Creation
// var r = /h/ig;
// console.log(typeof r);//object


// //2)Constructor Creation
// var r = new RegExp(/h/,"ig");
// console.log(g.replace(r,"_"));//_ello at second _ day _ at JavaScript
// console.log(typeof r);//object

// // var phoneReg = /[0-9]{8}/
// // console.log(phoneReg.test("12345678"));//true
// // console.log(phoneReg.test("123456789asdfg"));//true
// // console.log(phoneReg.test("adasdasd123456789asdfg"));//true


// // var phoneReg2 = /^[0-9]{8}$/
// // console.log(phoneReg2.test("12345678"));//true
// // console.log(phoneReg2.test("123456789"));//false
// // console.log(phoneReg2.test("123456789asdfg"));//false
// // console.log(phoneReg2.test("adasdasd123456789asdfg"));//false




// // var phoneReg3 = /^[1-5]{8}$/
// // console.log(phoneReg3.test("12345123"));//true
// // console.log(phoneReg3.test("123451230"));//false
// // console.log(phoneReg3.test("12345678"));//false
// // console.log(phoneReg3.test("123456789"));//false
// // console.log(phoneReg3.test("123456789asdfg"));//false
// // console.log(phoneReg3.test("adasdasd123456789asdfg"));//false




// // var phoneReg3 = /^[1-5]{8}[7-9]{2}$/
// // console.log(phoneReg3.test("1234512377"));//true
// // console.log(phoneReg3.test("1234512317"));//true
// // console.log(phoneReg3.test("17"));//false


// // var phoneReg3 = /^[1-5]{8}[7-9]{0,2}$/
// // console.log(phoneReg3.test("1234512377"));//true
// // console.log(phoneReg3.test("12345123"));//true
// // console.log(phoneReg3.test("123451237"));//true
// // console.log(phoneReg3.test("123451238"));//true
// // console.log(phoneReg3.test("123451239"));//true
// // console.log(phoneReg3.test("1234512377"));//true
// // console.log(phoneReg3.test("1234512378"));//true
// // console.log(phoneReg3.test("17"));//false

// // var phoneReg3 = /^[1-5]{8}[@!]{1}[7-9]{1,}$/
// // console.log(phoneReg3.test("12345123@77"));//true



// var phoneReg3 = /^[a-zA-Z]+$/
// console.log(phoneReg3.test("12345123@77"));//false
// console.log(phoneReg3.test("asdA"));//true
// console.log(phoneReg3.test(""));//false
// console.log(phoneReg3.test("a"));//true
// console.log(phoneReg3.test("A"));//true


// /**
//      * a? (Zero or one) of a
//      * a* (Zero or more) of a
//      * a+ (one or more) of a
//      * Special Character   \$   or   \@   or \!
//      * \d   Any digit
//      * \D   Any Non-digit
//      * \w   Any Word Character
//      * \W   Any Non-Word Character
//      */
//     var f = "hello";
//     f.toUpperCase();
//     console.log(f);//hello

//     var r = f.toUpperCase();
//     f = f.toUpperCase();
//     // var r = "KOKO";
//     // f = r;
//     console.log(f);//HELLO


//     /** Number */
//     //1)Literal Creation
//     var n = 13;
//     console.log(typeof n)
//     //2)Constructor Creation
//     var n2 = new Number(13);
//     var n3 = new Number(45);
//     console.log(typeof n2)

//     n2 = n3;
//     n3 = 56;
//     console.log(n2);
//     console.log(n2.valueOf());//primitive number
//     console.log(n2.toLocaleString("ar-eg"));//٤٥
//     console.log(n2.toLocaleString("zh-Hans-CN-u-nu-hanidec"));//四五


// //Array Object
// //1)Literal Creation
// var arr1 = [];
// var arr2 = [1, true, "KOKO", function(){}, "SOSO", {x:"lll",y:10}];
// // var ob = {
// //     userName:"KOKO",
// //     userAge:20
// // }
// console.log(arr2);

// var arr3 = [[1,2],[4,5],[7,8]];//2D
// console.log(arr3[0]);//[1,2]
// console.log(arr3[0][0]);//1
// console.log(arr3[0][1]);//2

// var rrr = arr2[5];
// console.log(rrr);//{x: '', y: 10}
// console.log(rrr.x);
// console.log(rrr.y);

// console.log(arr2[5].x);
// console.log(arr2[5].y);

// var arr4 = [1,,2,,,5];
// console.log(arr4.length);//6
// console.log(arr4);//
// console.log(arr4[0]);//1
// console.log(arr4[1]);//
// arr4[1]=10;
// console.log(arr4);//


// //2)Constructor Creation
// var arr2_1 = new Array();
// arr2_1[0] = 10;
// arr2_1[1] = "LOLO";
// arr2_1[10] = true;
// console.log(arr2_1.length);//11


// //3)Dense Array
// var arr2_2 = new Array("Apple", "Banana", "Kiwi");
// arr2_2[3] = "Orange";
// console.log(arr2_2);


// arr2_1 = arr2_2;
// console.log(arr2_1);//['Apple', 'Banana', 'Kiwi', 'Orange']
// console.log(arr2_2);//['Apple', 'Banana', 'Kiwi', 'Orange']

// arr2_2[0] = "SOSO";

// console.log(arr2_2);//['SOSO', 'Banana', 'Kiwi', 'Orange']
// console.log(arr2_1);//['SOSO', 'Banana', 'Kiwi', 'Orange']

// var ar1 = [1,3,5,10];
// var ar2 = ["H", "e", "l", "l", "o"];
// // ar1 = ar2;
// // ar1 = [...ar2];
// for(var i =0; i<ar2.length; i++){
//     ar1[i] = ar2[i]; 
// }
// console.log(ar1);//['H', 'e', 'l', 'l', 'o']
// console.log(ar2);//['H', 'e', 'l', 'l', 'o']

// ar1[0]="T";
// console.log(ar1);//['T', 'e', 'l', 'l', 'o']
// console.log(ar2);//['H', 'e', 'l', 'l', 'o']



// //Methods
// var ar1 = [1,3,5,10];
// console.log(ar1.join("").split(""));

// ar1.push(11); //add at end 
// console.log(ar1);
// ar1.pop(); // delete from end
// console.log(ar1);

// ar1.unshift(0); //add at first
// console.log(ar1);
// ar1.shift(); //delete from first
// console.log(ar1);

// // ar1 = ["10","1","6","12"]; 
// ar1 = [10,1,6,12]; 
// console.log(ar1.sort());
// console.log(ar1.sort(   function(a,b){return a-b;}    ));
// console.log(ar1.sort(   function(a,b){return b-a;}    ));
/** ============================================================= */
//Associative Array

var arr = [5,10,11,2,20];
console.log(arr.length);//5 ===> Dot Notation
console.log(arr["length"]);//5  ===> Subscript Notation


var arr1 = new Array();
// var arr1 = [];
arr1["userName"] = "KOKO";
arr1["userAge"] = 20;
arr1["userPhone"] = ["011111111", "02222222222"];
arr1["userSalary"] = 10000;
// arr1["ourLength"] = 0;
// arr1[0] = "Mina";


console.log(arr1.length);//0
// arr1[0]=2000;
// console.log(arr1.length);//11

// for(var i = 0; i<arr1.length; i++){

// }

console.log(arr1);

for(var i in arr1){ //i == Key
    console.log(i + " : " + arr1[i]);
    arr1["length"]++;
    // arr1["ourLength"]++;
}
// arr1["HossamName"] = "Hossam";
console.log(arr1.length);//4

// console.log(arr1["ourLength"]);//5

// console.log(arr1["userName"]);