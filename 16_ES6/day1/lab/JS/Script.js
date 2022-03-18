/* 1) Swap the values of x and y using destructuring */
var  x = 15;
var  y = 36;
console.log(`x: ${x} y:${y}`);
[x,y] = [y,x];              
console.log(`x: ${x} y:${y}`);




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

/* 3] Study new array api methods then use its new methods to do the following 
Hint: use the following array*/
var fruits = ["apple", "strawberry", "banana", "orange", "mango"];

//a. test that every element in the given array is a string

console.log(fruits.every(val => typeof val === 'string'));

//b.test that some of array elements starts with "a"
console.log(fruits.some(val => val.startsWith('a')));

/*c. generate new array filtered from the given array with only elements that
starts with "b" or "s"*/
var newFruits = fruits.filter(val => val.startsWith('a') || val.startsWith('s'));
console.log(newFruits);

/* d.generate new array, each element of the new array contains a 
string declaring that you like the give fruit element
*/
var LikeFruits = fruits.map(val => "i like "+val);
console.log(LikeFruits);

/* e.use forEach to display all elements of the new array from  previouse point*/
LikeFruits.forEach(val=>console.log(val));

/* e.use forEach to retrun new array */


/*4) Create your own function that accepts an object with multiple 
parameters to generate course information and display it. 
assume course information must contains courseName,
courseDuation, courseOwner only and fire exception when user 
pass properties other that those mentioned above.*/
var displayCourse = function (optCourse={}){
    var defCourse = {courseName:"name",courseDuation:"duration", courseOwner:"owner"};

    var coure = Object.assign({},defCourse,optCourse)

  for(i in coure)
  {
      if(i === 'courseName' || i=== 'courseDuation' || i=== 'courseOwner')
      continue;
      else throw "wrong peoperty";
  }
 
  console.log(`CrsName: ${coure.courseName}, CrsDur: ${coure.courseDuation}, CrsOwner: ${coure.courseOwner}`);
}

var obj = {
    courseName:"ES-6",
    courseDuation:"3 days",
     //courseOwner:"ITI",
     //time:"25/5"
    }

displayCourse(obj);