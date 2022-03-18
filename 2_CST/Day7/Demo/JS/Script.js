// console.log(document.documentElement);//html
// console.log(document.documentElement.firstChild);//head
// console.log(document.documentElement.lastChild);//body
// console.log(document.documentElement.lastChild.firstChild);//#text
// console.log(document.documentElement.lastChild.firstElementChild);//div
// console.log(document.documentElement.lastChild.firstElementChild.lastElementChild);//u
// console.log(document.documentElement.lastChild.firstElementChild.lastElementChild.previousElementSibling);//u
// console.log(document.documentElement.lastChild.firstElementChild.lastElementChild.previousElementSibling.firstElementChild);//text



// console.log(document.documentElement.lastChild.firstElementChild.id);//div
// document.documentElement.lastChild.firstElementChild.id = "KOKO";
// console.log(document.documentElement.lastChild.firstElementChild.firstElementChild.classList);//Class of <p>
// document.documentElement.lastChild.firstElementChild.firstElementChild.classList.add("c2");//Class of <p>
// console.log(document.documentElement.lastChild.firstElementChild.firstElementChild.classList);//Class of <p>
// document.documentElement.lastChild.firstElementChild.firstElementChild.classList.remove("c2");//Class of <p>
// console.log(document.documentElement.lastChild.firstElementChild.firstElementChild.classList);//Class of <p>
// document.documentElement.lastChild.firstElementChild.firstElementChild.classList.remove("c1");//Class of <p>
// console.log(document.documentElement.lastChild.firstElementChild.firstElementChild.classList);//Class of <p>
// setInterval(
//     function(){

//         document.documentElement.lastChild.firstElementChild.firstElementChild.classList.toggle("c1");
//     }
//     ,1000
// )


// console.log(getComputedStyle(document.documentElement.lastChild.firstElementChild.firstElementChild));//Class of <p>
// console.log(document.documentElement.lastChild.firstElementChild.firstElementChild.style);//Class of <p>



/**StyleSheets */
// console.log(document.styleSheets);
// document.styleSheets[1];
// console.log(document.styleSheets[0].cssRules);
// console.log(document.styleSheets[0].cssRules[0]);
// console.log(document.styleSheets[0].cssRules[1]);


// console.log(document.styleSheets[0].cssRules[0].cssText);
// console.log(document.styleSheets[0].cssRules[1].cssText);


//Create Elements (appendChild - insertBefore())


//========================= Ya (a) append child (b) gwaky ============================
//========================= Ya body Insert (a) before (b)  ============================


//1)append

var a = document.createElement("div");
var b = document.getElementById("d1");

var ourText = document.createTextNode("Hello From a");

a.appendChild(ourText);

a.style.height = "200px";
a.style.border = "1px solid red";
a.style.color = "blue";

b.appendChild(a);

//2)InsertBefore
var a2 = document.createElement("div");
var ourText2 = document.createTextNode("Hello From a");
a2.appendChild(ourText2);

a2.style.height = "200px";
a2.style.border = "1px solid red";
a2.style.color = "blue";
a2.id="lolo";

document.body.insertBefore(a2,b);

/**cloneNode(true  || false) true==>Including Content  */
// var a2Clone = a2.cloneNode(true);//Including Content
// var a2Clone = a2.cloneNode(false);// Without Content












