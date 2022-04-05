// /**
//  * Events ==> Class
//  * Requests [Get-Post -delete - put - patch]
//  * Response
//  * Custom Module [ur Own Module]
//  */


// //Built-In Module [events]

// const myEvent = require("events");
// class myClass extends myEvent{

// }

//extend events
// var c = new myClass();

// c.on("abc",function(){console.log("Event Fired")})
//fire only one time
// c.once("abc",function(){console.log("Event Fired once !!!!!!!!!!")})


// c.emit("abc");
// c.emit("abc");
// c.emit("abc");
// c.emit("abc");

// /**
//  * var reading = createReadeStreem("")
//  * reading.on("data")
//  * 
//  */


/**Server */

const http = require("http");

//require file
const fs = require("fs");
//read files that we want to call
var mainHTML = fs.readFileSync("../Client-Side/main.html").toString()
var profileHTML = fs.readFileSync("../Client-Side/profile.html").toString()
var StyleFile = fs.readFileSync("../Client-Side/style.css").toString()
var ScriptFile = fs.readFileSync("../Client-Side/script.js").toString()
var Icon = fs.readFileSync("../Client-Side/favicon.ico");
var Image = fs.readFileSync("../Client-Side/2.jpg");

//read multiple images same name structure 1.jpg, 2.jpg
// var arr = [];
// for(let i=1;i<5; i++){
//     var Image = fs.readFileSync("../Client-Side/"+i+".jpg");
//     arr.push(Image);
// }

http.createServer((req,res)=>{
    var URL = req.url;//   /main.html

    //detect file name that is coming 
    // console.log(URL.split("/Client-Side/")[1].split(".")[0]); // file name ex main, js, style without extension
    if(req.method == "GET"){
        switch(URL){
            case "/main.html":
            case "/Client-Side/main.html":
            case "/":
                // res.writeHead(res.statusCode,{"content-type":'text/html'})//MIME Type
                //allow cors requests
                // res.writeHead(res.statusCode,{"Access-Control-Allow-Origin":'*'})//MIME Type
                // res.writeHead(res.statusCode,{"Set-Cookie":'userName=Aly'})//MIME Type
                res.setHeader("content-type","text/html");
                res.setHeader("Set-Cookie","userName=Hossam");

                res.write(mainHTML);
            break;
            // case "/profile.html":
            // case "/Client-Side/profile.html":
            // case "/Client-Side/profile.html?":
            //     res.setHeader("content-type","text/html");
            //     res.setHeader("Set-Cookie","userName=Hossam");

            //     res.write(profileHTML);
            // break;
            case "/Client-Side/style.css":
            case "/style.css":
                res.writeHead(res.statusCode,{"content-type":'text/css'})//MIME Type
                res.write(StyleFile);
            break;
            case "/Client-Side/script.js":
            case "/script.js":
                res.writeHead(res.statusCode,{"content-type":'application/javascript'})//MIME Type
                res.write(ScriptFile);
            break;
            case "/Client-Side/favicon.ico":
            case "/favicon.ico":
                res.writeHead(res.statusCode,{"content-type":'image/vnd.microsoft.icon'})//MIME Type
                res.write(Icon);
            break;
            case "/Client-Side/2.jpg":
            case "/2.jpg":
                res.writeHead(res.statusCode,{"content-type":'image/jpeg'})//MIME Type
                res.write(Image);
            break;
            default:
                //form with get
                if(URL.includes("profile.html")){
                    res.setHeader("content-type","text/html");
                    res.setHeader("Set-Cookie","userName=Hossam");
                    res.write(profileHTML);
                }else{
                    res.write("Can`t Find This Page!!!")    
                }
            break;
        }
        res.end();
    
    }
    
    else if(req.method == "POST"){
        switch(URL){
            case "/Client-Side/profile.html":
            case "/profile.html":
                var AllData="";
                var assArray = [];
                var AllArray = [];
                req.on("data",function(data){
                    // console.log(data.toString())
                    //Date --> User=""&Email=""
                    AllData = data.toString();
                    assArray = [];
                    AllArray = AllData.split("&");//['name=Aly', 'Age=22']
                })
                
                req.on("end",function(){
                    //split("&")[]==>values
                    for(let i=0;i<AllArray.length;i++){
                        var key = AllArray[i].split("=")[0];
                        var value = AllArray[i].split("=")[1];
                        assArray[key] = value;
                    }
                    res.writeHead(res.statusCode,{'content-type':'text/html'});
                    profileHTML = profileHTML.replace("{userName}",assArray["name"])
                    //render page
                    res.write(profileHTML);
                    res.end();
                })
                console.write("after end test");

            break;
        }
        // res.end();
    }
    
    else if(req.method == "PUT"){//UPDATE ===> PUT=>{} ==> PATCH=>{prop}

    }
    
    else if(req.method == "DELETE"){

    }

    // res.end();

}).listen(8002,()=>{console.log("Listening...")})













