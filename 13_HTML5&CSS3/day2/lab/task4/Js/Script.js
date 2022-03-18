var canvas = document.getElementById('Canvas1');
//our pen
var ctx = canvas.getContext('2d');
var x=0,y=0;
ctx.beginPath();
ctx.strokeStyle = "red";
ctx.moveTo(x, y);
var draw = setInterval(function()
{
      if(x==500)
      {
            alert("animation end :(");
            clearInterval(draw);
      }
      ctx.lineTo(x++, y++);
      ctx.lineWidth = 5;
      ctx.stroke();

},10);
  





