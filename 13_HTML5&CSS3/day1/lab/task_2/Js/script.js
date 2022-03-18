var red = document.getElementById("red-range"); 
var green= document.getElementById("green-range");
var blue = document.getElementById("blue-range");
var text = document.getElementById("div-text");


function changeColor()
{
    var redValue = red.value; 
    var greenValue = green.value; 
    var blueValue = blue.value; 

    text.style.color = 'rgb('+redValue+','+greenValue+','+blueValue+')';
}








