var fun1 = function(a, b)
{
    var len = arguments.length;
    if(len==2)
    return true;
    throw "number of parameters either less than or exceeds 2 parameters";
};

var adding = function()
{
    var len = arguments.length, sum=0;
    if(len==0)
    throw "no parameter is passed";
    for(var i=0;i<len;++i)
    {
        if(typeof(arguments[i])=='number')
        sum+=arguments[i];
        else throw "numeric values only allowed";
    }
    return sum;

};
var reverse_num = function()
{
    var arr = [], len=arguments.length;
    arr = [].slice.apply(arguments,[0,len]);
    return arr.reverse();
}
var reverse_num2 = function()
{
    var arr = [], len=arguments.length;
    arr = [].slice.call(arguments,0,len);
    return arr.reverse();
}
