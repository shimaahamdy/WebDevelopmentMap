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
