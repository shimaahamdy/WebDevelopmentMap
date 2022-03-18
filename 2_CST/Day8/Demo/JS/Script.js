// console.log("Start");
// wait5sec();
// fun();
// console.log("end");
// setTimeout(function(){
//     console.log("timeOut After 1 sec.")
// },1000);


/**
 * Start
 * end
 * timeOut Immed.
 * timeOut After 1 sec.
 */



// function wait5sec(){}
// function fun(){
//     setTimeout(function(){
//         console.log("timeOut Immed.")
//     },0);
// }

// var x =1 ;

// setTimeout(function(){
//     console.log("timeOut After 5 sec.")
// },5000);


// setTimeout(function(){
//     console.log("timeOut After 1 sec.")
// },1000);


/** Bubbling VS Capturing Mood */
// function CLikeMe(ourDiv){
//     console.log(ourDiv.id);
//     this.event.stopPropagation();
//     // ourDiv.event.cancelBubble();
// }

// var ourElements = document.getElementsByTagName("div");
// var len = ourElements.length;

// for(var i = 0; i<len; i++){
//     ourElements[i].addEventListener("click",function(){
//         console.log(this.id);
//         console.log(event);
//         event.stopPropagation();
//     },true)//Default False(Bubble)  || true ==> capturing Mode
// }


// document.addEventListener("keypress",)\

// document.onkeypress = function(){
//     console.log(event.altKey);
//     console.log(event.key);
//     console.log(event.keyCode);
// }

// document.onkeydown = function(event){
//     console.log("Alt: "+event.altKey);
//     console.log("Ctrl: "+event.ctrlKey);
//     console.log("Shift: "+event.shiftKey);
//     console.log("Key: "+event.key);//a
//     console.log("KeyCode: "+event.keyCode);
// }

//1)Create Event
var ourEvent = new Event("seen");

//2)Add EventListner
document.getElementById("chat1").addEventListener("seen",function(){
    document.getElementById("chat1").innerHTML += "<sub><small><small>✔</small></small></sub>"
});
//3)Fire Event
// setTimeout(function(){
//     document.getElementById("chat1").dispatchEvent(ourEvent);
// },3000)

document.getElementById("chat1").addEventListener("click",function(){
    document.getElementById("chat1").dispatchEvent(ourEvent);
})

/**Error Object */
//1) Syntax Error
    // alert("Hello";
//2)Type Error
    // var num = 1 ;
    // num.toUpperCase();
//3)Range Error
    // var num = 1;
    // num.toFixed(101);//1.
    // console.log(num.toFixed(20));//1.
//4)Refrence Error
    // console.log(x);
//5)URI Error
    // decodeURI("%%%");

    // var c = encodeURIComponent("abc@gmail.com");
    // console.log(decodeURIComponent(c));


    /**Create Your Own Error */
    // var ourError = new Error("This is our Custom Error");
    // var ourError1 = new RangeError();
    // var ourError2 = new TypeError();
    // var ourError3 = new ReferenceError();

    // console.log(ourError);

    // throw ourError;

    // console.log(ourError.message);
    // console.log(ourError.name);
    // console.log(ourError1.name);
    // console.log(ourError3.name);

    // if(ourError1 instanceof TypeError){
    //     console.log("Yes, ourError1 of type RangeError");
    // }
    // else{
    //     console.log("No, ourError1 Not of type RangeError");
    // }
    
    // console.error("Amany");
    // console.error("hamada");

//Try Catch Finally


// var num = parseInt(prompt("Enter Number Between 10 & 15"));
// try{

//     if(num>=10 && num<=15){
//         console.log(num);
//     }
//     else{
//         // throw "Out of Range";
//         // console.logg();
//     }
// }
// catch(Mohamed){

//     // if(Mohamed == "Out of Range"){
//     //     console.log("7asal error !!");
//     // }else{
//     //     console.log("7asal error !!!!!");
//     // }
//     // console.log("7asal Error");
//     // console.log(Mohamed.name =="TypeError");
//     // console.log(Mohamed.name =="RangeError");
//     // console.logg(Mohamed.message);
// }
// finally{
//     // throw "Error in Finally";
//     console.log("End");
// }


// console.log("End !!!!!!!");



//onerror
onerror = fun;

throw "Error Test";

function fun(Hossam, Eng, l, c, err){
    console.log(Hossam);
    console.log(Eng);
    console.log(l);
    console.log(c);
    console.log(err);
    alert("7asal Error");
    return true;//true ==> Never Show Error at console.log
}
// onerror = function(){
//     return true;
// }


