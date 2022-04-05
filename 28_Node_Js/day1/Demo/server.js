const http = require("http");

http.createServer((req,res)=>{
    console.log(req.url.split("/"));//  /ali/ahmed/profile
    //Methods [Post- Get(default)  - Put - Patch - Delete ]
    // console.log(req.method);
    // console.log(req.statusCode);

    if(req.url.split("/")[1] != "favicon.ico"){
        console.log("Hamada")
    }
    
    res.writeHead(res.statusCode,{"content-type":"text/html"})
    res.write("<h1>Hello From Node JS</h1>");
    res.end();
}).listen(8000,function(){console.log("Listening On PORT: 8000")})



