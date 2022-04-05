//request http module to turn to server
const http = require("http");

http.createServer((requst,respon)=>{
    // + 5 3
    // - 5 2
    // * 10 2
    //[ '', '+', '5', '3' ]
    // / 9 3  --> [ '', '', '', '5', '3' ]
    var requestParameters = requst.url.split("/");
    
    //if normal rquest
    var result;
    var operand;
    var startparm;
    const fs = require("fs");
    var show;
    if(requst.url.split("/")[1] != "favicon.ico"){
        
        if(requestParameters[1]!="")
        {
            operand = requestParameters[1];
            startparm=2;
          
            switch (operand)
            {
                case '+':
                    result = add(requestParameters);
                    break;
                case '-':
                    result = sub(requestParameters);
                    break;
                case '*':
                    result = mul(requestParameters);
                    break;
                    
            }
        }
        else
        {
            operand='/';
            startparm=3;
            result = div(requestParameters);
        }
        respon.writeHead(respon.statusCode,{"content-type":"text/html"});
        show=" ";
        for(let i=startparm;i<requestParameters.length;++i)
        {
            if(i==requestParameters.length-1)
            show+=requestParameters[i] + " = ";
            else show+=requestParameters[i]+" "+operand+" ";
        }
        respon.write("<h1>"+show+result+"</h1>");
        //write on file
        fs.appendFileSync("operations.txt",show+result+"\n");
        
    }
    
 
   
}).listen(7000,function(){console.log("Listening On PORT: 7000")})

var add = function(arr)
{
    var res=0;
    for(let i=2;i<arr.length;++i)
    {
        res+=parseFloat(arr[i]);
    }
    return res;

}

var sub = function(arr)
{
    var res=0;
    for(let i=2;i<arr.length;++i)
    {
        res-=parseFloat(arr[i]);
    }
    return res;
}

var mul = function(arr)
{
    var res=0;
    for(let i=2;i<arr.length;++i)
    {
        res*=parseFloat(arr[i]);
    }
    return res;
}
var div = function(arr)
{
    
    var res=0;
    for(let i=3;i<arr.length;++i)
    {
        if(parseFloat(arr[i])==0)return "can not div on 0";
        res/=parseFloat(arr[i]);
    }
    return res;
}


