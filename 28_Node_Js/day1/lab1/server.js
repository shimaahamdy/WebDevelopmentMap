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
    var par1;
    var par2;
    const fs = require("fs");
    if(requst.url.split("/")[1] != "favicon.ico"){
        
        if(requestParameters.length==4)
        {
            operand = requestParameters[1];
            par1 = requestParameters[2];
            par2 = requestParameters[3];
          
            switch (operand)
            {
                case '+':
                    result = add(par1,par2);
                    break;
                case '-':
                    result = sub(par1,par2);
                    break;
                case '*':
                    result = mul(par1,par2);
                    break;
                    
            }
        }
        else
        {
            par1 = requestParameters[3];
            par2= requestParameters[4];
            operand='/';
            result = div(par1,par2);
        }
        respon.writeHead(respon.statusCode,{"content-type":"text/html"})
        respon.write("<h1>"+par1+" "+operand+" "+par2+" = "+result+"</h1>");
        //write on file
        fs.appendFileSync("operations.txt",par1+" "+operand+" "+par2+" = "+result+"\n");
        
    }
    
 
   
}).listen(8000,function(){console.log("Listening On PORT: 8000")})

var add = function(x, y)
{
    return parseFloat(x)+parseFloat(y);
}

var sub = function(x, y)
{
    return parseFloat(x)-parseFloat(y);
}

var mul = function(x,y)
{
    return parseFloat(x)*parseFloat(y);;
}
var div = function(x,y)
{
    if(y==0)return "can not div on 0";
    return parseFloat(x)/parseFloat(y);
}


