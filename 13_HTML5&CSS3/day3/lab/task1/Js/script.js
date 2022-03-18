
//width = 500 , height=300
var canvas = document.getElementById("canvas1");
canvas.style.border = "3px solid black"
var ctx1 = canvas.getContext("2d");

var grad1 = ctx1.createLinearGradient(50,50,50,175); //fixed x make gradient horiz only
grad1.addColorStop(0,"rgb(115, 234, 238)");
grad1.addColorStop(1,"white");

ctx1.fillStyle = grad1;
ctx1.fillRect(50,50,300,150);



var grad2 = ctx1.createLinearGradient(50,100,50,250); //fixed x make gradient horiz only
grad2.addColorStop(0,"rgb(8, 221, 8)");
grad2.addColorStop(1,"white");

ctx1.fillStyle = grad2;
ctx1.fillRect(50,150,300,100);

ctx1.beginPath();
ctx1.lineWidth = 2;
ctx1.moveTo(100, 200);
ctx1.lineTo(100, 100);
ctx1.stroke();

ctx1.lineTo(300, 100);
ctx1.stroke();

ctx1.lineTo(300, 200);
ctx1.stroke();


