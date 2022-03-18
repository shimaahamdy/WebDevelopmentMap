/* 1) Swap the values of x and y using destructuring */
var  x = 15;
var  y = 36;
console.log(`x: ${x} y:${y}`);
var[x,y] = [y,x];              //using let
console.log(`x: ${x} y:${y}`);