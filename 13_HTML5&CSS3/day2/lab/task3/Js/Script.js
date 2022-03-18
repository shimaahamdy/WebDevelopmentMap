var canvas = document.getElementById('Canvas1');
//our pen
var ctx = canvas.getContext('2d');

var drawHalf2 = function()
{
      ctx.beginPath();
      var x=200,y=200,r=100,sAngel=0;
      ctx.arc(x, y, r, sAngel, sAngel+Math.PI,true);
      ctx.fillStyle = "yellow";
      ctx.fill();
      ctx.stroke();
      

      
}
var drawHalf1 = function()
{
      ctx.beginPath();
      var x=200,y=200,r=100,sAngel=0;
      ctx.arc(x, y, r, sAngel, sAngel+Math.PI);
      ctx.fillStyle = "yellow";
      ctx.fill();
      ctx.stroke();
}

var clear = function()
{
      ctx.clearRect(0, 0, canvas.width ,canvas.height);
}
var counter=0;
var upCircle = false;

var show = setInterval(function()
{
      if(counter<5)
      {
            if(upCircle)
            {
                  clear();
                  drawHalf2();
                  upCircle=false;
            }
            else
            {
                  clear();
                  drawHalf1();
                  upCircle=true;
            }
            counter++;
      }
      else
      {
            clear();
            clearInterval(show);
            drawHalf1();
            drawHalf2();
      }
},1000);





