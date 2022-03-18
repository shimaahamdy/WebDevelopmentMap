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