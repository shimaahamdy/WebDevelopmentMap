// call function in below section
 console.log(showhello2());


// make function
function showhello()
{
    console.log("hello");
}

showhello(); //hello
function showhello2()
{
    return "hello2";
}

var x = showhello2();
console.log(x);


