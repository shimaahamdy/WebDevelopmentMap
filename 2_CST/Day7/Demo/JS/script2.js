// function MoveMan(){
//     var myImage = document.getElementById("im1");

//     // var lef = getComputedStyle(myImage).left;//'50px'
//     var lef = parseInt(getComputedStyle(myImage).left);//50
//     myImage.style.left = lef + 10 + "px";
// }

// function submitBtn(){
//     alert("Hello");
//     location.assign("./main.html");
// }

document.getElementById("btn1").onclick = function(){
    alert("Hello");
    location.assign("./main.html");
}
