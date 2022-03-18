// // /* BOM browser object oriented */
// // /* DOM */
// // /* the document in window is part from DOM independet*/
// // /* ways to access elements in your project */
// // console.log(document.documentElement); //html
// // console.log(document.documentElement.firstChild); //head
// // console.log(document.documentElement.lastChild);//body


// // console.log(document.documentElement.lastChild.firstElementChild);//to get first elment == div

// // console.log(document.documentElement.lastChild.firstChild);//to get first chile that can be text or space if there were spaces between first element and its childrens

// // console.log(document.documentElement.lastChild.firstElementChild.lastChild);//comment
// // console.log(document.documentElement.lastChild.firstElementChild.lastElementChild);//last element <u>

// // console.log(document.documentElement.lastChild.firstElementChild.lastElementChild.previousElementSibling);// p before last child
// // console.log(document.documentElement.lastChild.firstElementChild.lastElementChild.previousElementSibling.firstChild);// text inside p
// // var elm = document.documentElement.lastChild.firstElementChild;

// // elm.id = "koko";   //change 
// // console.log(elm.id);

// // var elp = document.documentElement.lastChild.firstElementChild.lastElementChild.previousElementSibling;

// // console.log(elp.classList);
// // elp.classList.add("c2");

// // /* style by js is computed style during run time*/

// // console.log(document.styleSheets[0].cssRules[0].cssText);

// // // create elements 



// var div2 = document.createElement("div");
// // append
// var d = document.getElementsByClassName("c1");

// var ourtext= document.createTextNode("hello that is the new div created")
// div2.appendChild(ourtext);
// // d[0].appendChild(div2);
// d= document.getElementById("d1");


// div2.style.border = "1px solid black";
// div2.style.color = "blue";
// /**  insert  */

// // document.body.insertBefore(div2,d);

// /** clone */
// div2.id= "crted"
// var a2 = div2.cloneNode(true);

// /** */

function move()
{
    var myimg = document.getElementById("img1");
    
}