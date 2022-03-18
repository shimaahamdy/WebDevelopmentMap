var canvas=document.getElementById("can");

canvas.style.border = "1px solid red"
var ctx = canvas.getContext("2d");

ctx.beginPath();
// ctx.moveTo(10,10);
// ctx.lineTo(100,100);
// ctx.stroke();

// ctx.fillText("Hello",10,10)

// var width1 = ctx.measureText("Hello").width; 

// ctx.fillText("Hello",width1+10,10);


// ctx.drawImage

var myImage = new Image();
myImage.src = "../Images/2.jpg";

myImage.onload = function(){
    ctx.drawImage(myImage,0,0,100,50);
    ctx.drawImage(myImage,0,0,200,200,70,60,100,50);
}


// function draw(par1,par2,par3,par4,par5,par6,par7,par8){
//     if(par6 == undefined){

//     }else{

//     }
// }



var canvas2 = document.getElementsByTagName("canvas")[1];
canvas2.style.border = "1px solid red"
var ctx2 = canvas2.getContext("2d");

var grad1 = ctx2.createLinearGradient(70,70,100,100);//50===>200

grad1.addColorStop(0,"yellow");
grad1.addColorStop(0.2,"red");
grad1.addColorStop(0.7,"green");
grad1.addColorStop(1,"black");

ctx2.fillStyle = grad1;

ctx2.fillRect(0,0,canvas2.width,canvas2.height);


var canvas3 = document.getElementsByTagName("canvas")[2];
canvas3.style.border = "1px solid red"
var ctx3 = canvas3.getContext("2d");

var grad2 = ctx3.createRadialGradient(100,100,50,100,100,200);
grad2.addColorStop(0,"yellow");
grad2.addColorStop(0.2,"red");
grad2.addColorStop(0.7,"green");
grad2.addColorStop(1,"black");

ctx3.fillStyle = grad2;

ctx3.arc(20,20,100,0,2*Math.PI);
ctx3.fill();


//Translate && save && restore


myImage.onload = function(){
    ctx3.rotate(100)
    ctx3.drawImage(myImage,0,0,100,50);
    ctx3.save();
    ctx3.translate(70,100);//pen start point at (70,100) instead of (0,0)
    // ctx3.closePath();

    // ctx3.beginPath();
    ctx3.fillStyle = "black";
    ctx3.save();

    ctx3.restore();
    // ctx3.restore();
    ctx3.fillRect(0,0,100,100)


}