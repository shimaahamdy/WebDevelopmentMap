// var myWin;

// function OpenWin(){
//     myWin = open("Profile.html","","width=300; height=300");
// }

// function CloseWin(){
//     myWin.close();
// }

// function MoveToWin(){
//     if(!myWin){
//         console.log("Please Open Window Then Close it");
//     }
    
//     else if(!myWin.closed){
//         myWin.moveTo(50,50);
//         myWin.focus();
//     }
//     else{
//         console.log("No Window Ava.")
//     }
// }

// function MoveByWin(){
//     myWin.moveBy(50,50);
//     myWin.focus();
// }



// /** B) BOM Objects [Browser Object Model (Host)] 
//  *  1- Window Object [Parent - Container]
//  *      a- navigator Object [Name & Version of browser]
//  *      b- screen Object [Dimentions of Screen]
//  *      c- history Object  [history of visited pages (Arrows at each tab) ]
//  *      d- location Object [URL]
//  *      e- document Object  [content of document --> title, background color, links, forms]
// */

// /**Window === (Intervals - Timeout) */


// // setInterval("alert('hello')",2000);
// var s={mycounter:0};
// // ,i=0;
// var inter_1;
// function startInt(){
//     inter_1 = setInterval(myFun,2000,s);
// } 

// function myFun(s){
//     // alert("hello");
//     // i++;
//     s.mycounter++;
//     alert(s.mycounter);
//     // return ++i;

// }

// function stopInt(){
//     clearInterval(inter_1);
// }


// function koko(){
//     alert("Hello TimeOut");
// }

// var myTime;
// function startTimeOut(){
//     alert("Hello TimeOut");
//     myTime = setTimeout(startTimeOut, 2000);
// }

// function stopTimeOut(){
//     clearTimeout(myTime);   
// }



// /**Anonymous Function */
// // setInterval(function(){

// // },2000);

// var i =1 ;
// function plusNoti(){
//     setInterval(function(){
//         document.getElementById("s1").innerHTML = i++;
//     },2000)
// }



// /** B) BOM Objects [Browser Object Model (Host)] 
//  *  1- Window Object [Parent - Container]
//  *      a- navigator Object [Name & Version of browser]
//  *      b- screen Object [Dimentions of Screen]
//  *      c- history Object  [history of visited pages (Arrows at each tab) ]
//  *      d- location Object [URL]
//  *      e- document Object  [content of document --> title, background color, links, forms]
// */

// //====================================== Navigator =======================================

// if(navigator.userAgent.indexOf("Chrome/95.0.4638.69")>=0){
//     document.write("Welcome in Chroom Browser")
//     }
//     else if(navigator.userAgent.indexOf("Firefox/94.0")>=0){
//     document.write("Welcome in FireFox Browser")
//     }


// //====================================== Location =======================================


// // location.search.split("?")[1].split("&")[1].split("=")[1]


// //================================= e- document Object ===============================
// /** Properties [bgColor - fgColor - title - cookie - .....] */
// /** Methods [write() - writeln()]  XXXXXXXX  */ 
// /**You Can Change value of any attributes */
// /** Methods [getElementById("id")]  Only one Element*/
// /** Methods [getElementsByName("name")]  specified name="" Collection*/
// /** Methods [getElementsByTagName("tagname")]  <tagName> Collection*/
// /** Methods [getElementsByClassName("classname")]  class="" Collection*/

// // document.bgColor = "red";
// // var myWin = open("","","width=300;height=300");
// // setTimeout(()=>{
// //     myWin.document.bgColor = "blue";

// // },100)

// var userSalary = document.getElementById("i1").value;
// console.log(userSalary);

// document.getElementsByClassName("ii2")[1].style.backgroundColor = "red"


// document.getElementsByTagName("input")[2].type = "text"

// document.querySelector("#i1").style.backgroundColor = "black";
// // document.querySelector(".ii2").style.backgroundColor = "black";
// document.querySelectorAll(".ii2")[0].style.backgroundColor = "black";
// document.querySelectorAll(".ii2")[1].style.backgroundColor = "black";

// console.log(document.forms[0]);

function foc(){
    document.getElementById("d1").innerHTML = document.getElementById("i1").value;
}


function changeSrc(myImage){
    // document.getElementById("im1").src = "../Images/3.jpg";
    myImage.src = "../Images/3.jpg";
}

function changeOriginalSrc(myImage){
    // document.getElementById("im1").src = "../Images/1.jpg";
    myImage.src = "../Images/1.jpg";
}