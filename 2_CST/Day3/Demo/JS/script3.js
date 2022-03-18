// //UserDefined Functions

// console.log(add2());

// console.log(s);//undefined
// // console.log(r);//error

// var s = "Hello";
// r = "Hello";
// function showHello(){
//     console.log("Hello World!!");
// }

// // showHello();
// // console.log(showHello());


// function showHello2(){
//     return "Hello World!!";
// }

// //showHello2();
// // console.log(showHello2());
// //function statement
// // function add(){
// //     var x = 1;
// //     var y = 2;
// //     console.log(x + y);
// // }
// function add2(){
//     var x = 1;
//     y = 2;
//     return x + y;
// }



// // add();
// // console.log(add());

// // add2();//No Output
// // console.log(add2());


// var f = add2();
// console.log(f);

// console.log(y);//2



// function add(x=0, y=0){
function add(){
    // var sum = x+y;
    // return sum;
    // if(!x){x=0}
    // if(!y){y=0}
    // return x + y;

    if(arguments.length != 2){
        console.log("u must enter only 2 parameters");
        return 0;
    }
    else{
        return (isNaN(arguments[0])?0:arguments[0]) + (isNaN(arguments[1])?0:arguments[1]);
    }

}



