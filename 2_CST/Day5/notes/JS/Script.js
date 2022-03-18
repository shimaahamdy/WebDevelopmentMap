// window object 
/* open and close window when button pressed*/
/* window object --> open
                     close
                     
*/
var page;
function butonpressed()
{
      page=open("profile.html","","width=300 height=500");
}

function closedbuton()
{
page.close();
}

function move()
{
      page.moveTo(5,5); // move but disappera 
      page.focus();        // make window alwayes appear 
     
} 
//page.moveBy(50,50); // the page move evey time we press by 50,50
function move_check_closed()
{
      if(!page)     //retrun if window is opened
     {
           butonpressed();
     }
      page.moveTo(5,5); // move but disappera 
      page.focus();        // make window alwayes appear 
     
} 
// intervals , timeout --> loop but with time
//setInterval("alert('this is interval')",2000); //every 2 loop for alert

// setInterval(fun(),2000);  //here we can not just call fucntion beacause of return type 
// function fun()
// {
//    alert("hello");
// }
// var i=0;
// setInterval(fun(),2000);  
// /* if we want set parameter to function we can not recall it with parameter as 
// we can not send parameter to the refrence that return from funcrion */  
// function fun()
// {

//    alert(1);
//    return fun;
//}


/* window object (parent) have other childrens (objects)
*/

// settime out work once after waiting the time specified
function timeout()
{
      setTimeout(test_time_out,2000);
}
function test_time_out()
{
      alert("hello time out");
}
//timeout();

/* time out behave like interval */
function timeout_loop()
{
      test_time_out();
      setTimeout(timeout,2000);   //recursion
}

//timeout_loop();


// // we can write whole body of function and give it a name or not 
// //
// setInterval(function fun_min()
// {
//       alert("hello");
// },2000);  // minimus function

/** can not understand it will  */
var i=0;
function notification()
{
      document.getElementById("s1").innerHTML = i++;
}

/* navigoter */
navigator.userAgent  // return whole data abour pocessor 

page.document.bgColor = "red"; // access another window document and control it 

document.write();
/* getelements by name -->return collection */
/*
Array inhirt from collection 

*/

document.getElementsByClassName("right").style.backgroundColor="red";

