/*2) Using rest parameter and spread operator return max value 
from any array 
note: array length is not fixed
Bonus: return min and max value and display each of them 
separately after function call*/

var MaxMin = function(...arr)  
{
    //console.log(arr);
    let maxValue= Math.max(...arr);
    let minValue = Math.min(...arr);
    return [maxValue,minValue];
}
var arr1 = [1,5,-6,0,8,8,10];
let[maxV,minV] = MaxMin(...arr1);  // arr1 --> NAN
console.log(`maxV= ${maxV} minV=${minV}`);