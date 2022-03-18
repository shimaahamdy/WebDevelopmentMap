/*2) Create a generator that returns fibonacci series that takes only one 
parameter.*/
//a.the parameter passed determines the number of elements displayed from the series.
var fib = function* (len)
{
    let prev=0;
    let curr=1;
    if(len <2 )
    console.log("serious start with at least 2 numbers")
   
    else
    {
    yield prev; //0 
    yield curr; //1 
    for(let i=2;i<len;++i)
    {
        let next = prev+curr; 
        prev=curr; 
        curr=next;
        yield next;
    }
    }
}

console.log("fib(5)");
var iter = fib(5);
do
{
    var obj = iter.next();
    console.log(obj);
}
while(!obj.done);



/*b.the parameter passed determines the max number of the 
displayed series should not exceed its value.*/
var fib2 = function* (num)
{
    let prev=0;
    let curr=1;
    if(num <0 )
    console.log("serious start with at least 2 numbers")
   
    else
    {
    yield prev; //0 
    yield curr; //1 
    let next = prev+curr; 
    while(next<=num)
    {
        prev=curr; 
        curr=next;
        yield next;
        next = prev+curr
    }
    }
}

console.log("fib(6)");
var iter2 = fib2(6);
do
{
    var obj = iter2.next();
    console.log(obj);
}
while(!obj.done);
/* ***************************************************************************** */

/*3) Create your own object that has [Symbol.replace] method so that if 
any long string (e.g. its length exceed 15 characters )called replace 
and pass your object as replace method parameter it will display 
only 15 character of string with terminating “…”*/

var repObj = 
{
    [Symbol.replace]:function(str="")
    {
        if(str.length<=15)
        return str;
        else
        {
            return str.substring(0,16)+"...";
        }
    }
}


var mystr = "Hello from the other side";

console.log(mystr.replace(repObj));

/* **************************************************************************** */

/* 
4) create an iterable object by 2 methods one of them is by
implementing @@iterator method i.e. Symbol.iterator, so that you 
can use for..of and retrieve its properties.
Bonus: try retrieving the object properties and its values
*/
//@@iterator method (Symbol.iterator)
var iterableObj1 = 
{
    prop1:"value1",
    prop2:"value2",
    prop3:"value3",
    prop4:"value4",

    [Symbol.iterator]:function()
    {
        let counter = 0;
        var arr = Object.entries(iterableObj1); // ["key",value];
        return{
            
            next:function(){
                if(counter < arr.length)
                {
                    return {value:arr[counter++],done:false};
                }
                else 
                    return {value:undefined, done:true};
            }
                        
        }
    }
}
console.log("iterable obj 1");
for(i of iterableObj1)
{
    let[prop,value]=i;
    console.log(`${prop}:${value}`);
}

//generator method
var iterableObj2 = 
{
    prop1:"value1",
    prop2:"value2",
    prop3:"value3",
    prop4:"value4",

    [Symbol.iterator]:function*()
    {
        let counter = 0;
        var arr = Object.entries(iterableObj2); // ["key",value];
        for(i in arr)
        yield arr[i];
    }
}
console.log("iterable obj 2");
for(i of iterableObj2)
{
    let[prop,value]=i;
    console.log(`${prop}:${value}`);
}
