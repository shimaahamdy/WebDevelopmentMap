//function (){}
//Imm invo. function expression IIFE pattern
(function (){
    //
    //
    var x=9;
    var fun=function(){}
    
     var obj={nm:"",age:""}
     
     window._obj=obj;
    
})()

window._obj.nm="sgdfhj"






(function (){}())


!function (){}()
void function (){}()

////////////////

var strJoin=[].join.bind(str,"___")
strJoin("^^");


///////////////////////////

function adding(x=10,y=5){
    arguments[0]=x||10//
    arguments[1]=x?://
    var sum=0;
    for(){}
    
    return sum;//x+y;
    
}
    

adding(1,2)//3
adding(1)//
adding()//
adding(1,2,3,4,5)//3
































/*

//console.log(x);//error
fun()
var x=10;


//function statement-->hoist
function fun(){
    
    var x=9;
    
}


console.log(myfun);//undefined

//function expression
//Named function expression NFE
//anonymous function
var myfun=function fun(){
    fun()
    
    var x=9;
    
}

myfun()


var newFun=myfun;
myfun=10
newfun()

console.log(myfun) 








var obj={};
obj.name="ali";
obj.age=10;

var obj2={color:"green", type:"fruit"}
obj2.count=20;
obj2["display"]=function(){
    console.log("obj2 function");
}
*/










