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