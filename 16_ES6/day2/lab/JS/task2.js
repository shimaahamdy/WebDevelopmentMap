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

var iter2 = fib2(6);
do
{
    var obj = iter2.next();
    console.log(obj);
}
while(!obj.done);