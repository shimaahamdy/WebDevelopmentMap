
var canvas = document.getElementById("canvas1");
var ctx1 = canvas.getContext("2d");

//big circle
ctx1.beginPath();
var grad2 = ctx1.createLinearGradient(0,100,100,100);
grad2.addColorStop(0,"blue");
grad2.addColorStop(1,"rgb(155, 155, 243)");


ctx1.fillStyle = grad2;

ctx1.arc(200,200,200,0,2*Math.PI);
ctx1.fill();


//small circle
ctx1.beginPath();
var grad1 = ctx1.createLinearGradient(200,200,350,300);
grad1.addColorStop(0,"rgb(51, 51, 238)");
grad1.addColorStop(1,"white");


ctx1.fillStyle = grad1;

ctx1.arc(200,200,150,0,2*Math.PI);
ctx1.fill();


//text
ctx1.beginPath();
ctx1.font = "220px Arial";
ctx1.fillStyle="white";
ctx1.fillText("Sh", 60, 270);

