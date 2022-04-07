/* Task2 */
/**Server */




// var ScriptFile = fs.readFileSync("../Client-Side/script.js").toString()
// var Icon = fs.readFileSync("../Client-Side/favicon.ico");
// var Image = fs.readFileSync("../Client-Side/2.jpg");
const http = require("http");
const fs = require("fs");
http.createServer((req,res)=>{
    //require file

//read files that we want to call
var mainHTML = fs.readFileSync("../ClientSide/main.html").toString()
var profileHTML = fs.readFileSync("../ClientSide/profile.html").toString()
var StyleFile = fs.readFileSync("../ClientSide/style.css").toString()
var ScriptFile = fs.readFileSync("../ClientSide/script.js").toString()
var jsonFile = fs.readFileSync("Profiles.json");
    var URL = req.url;//   /main.html

    if(req.method == "GET"){
        switch(URL){
            case "/main.html":
            case "/":
                res.setHeader("content-type","text/html");
                res.setHeader("Access-Control-Allow-Origin",'*');

                res.write(mainHTML);
            break;

            case "/style.css":
                res.writeHead(res.statusCode,{"content-type":'text/css'})//MIME Type
                res.write(StyleFile);
            break;
            case "/script.js":
                res.writeHead(res.statusCode,{"content-type":'application/javascript'})//MIME Type
                res.write(ScriptFile);
            break;
            case "/Profiles.json":
                res.writeHead(res.statusCode,{"content-type":'application/json'})//MIME Type
                res.write(jsonFile);
            break;
            // case "/Client-Side/2.jpg":
            // case "/2.jpg":
            //     res.writeHead(res.statusCode,{"content-type":'image/jpeg'})//MIME Type
            //     res.write(Image);
            // break;
            default:
                res.write("Can`t Find This Page!!!")    
                
            break;
        }
        res.end();
    
    }
    
    else if(req.method == "POST"){
        switch(URL){
            // case "/ClientSide/profile.html":
            case "/profile.html":
                var AllData="";
                var assArray = [];
                var AllArray = [];
                var JsonObj = {};
                req.on("data",function(data){
                    
                    AllData = data.toString();
                    assArray = [];
                    JsonObj = {};
                    AllArray = AllData.split("&");
                    
                })
                
                req.on("end",function(){
                    
                    for(let i=0;i<AllArray.length;i++){
                        var key = AllArray[i].split("=")[0];
                        var value = AllArray[i].split("=")[1];
                        assArray[key] = value;
                        JsonObj[key] = value.replace("%40","@");
                    }

                    //json file
                    var obj = {
                        table: []
                     };
                     fs.readFile('Profiles.json', 'utf8', function readFileCallback(err, data){
                        if (err){
                            console.log(err);
                        } else {
                        //var assObj = Object.assign({}, assArray); 
                        obj = JSON.parse(data); //now it an object
                        obj.push(JsonObj); //add some data
                        //json = JSON.stringify(obj); //convert it back to json
                        fs.writeFile("Profiles.json", JSON.stringify(obj), function(err){
                            if (err) throw err;
                            console.log('The "data not append" was appended to file!');
                          });
                    }});

                    res.writeHead(res.statusCode,{'content-type':'text/html'});
                    profileHTML = profileHTML.replace("{clientName}",assArray["firstname"]+" "+assArray["lastname"])
                    profileHTML = profileHTML.replace("{MobileNumber}",assArray["Mobile"])
                    profileHTML = profileHTML.replace("{add}",assArray["add"])
                    profileHTML = profileHTML.replace("{Email}",assArray["emal"])
                    profileHTML = profileHTML.replace("%40","@")
                    //render page
                    res.write(profileHTML);
                    res.end();
                })
               

            break;
        }
        // res.end();
    }
    
    else if(req.method == "PUT"){

    }
    
    else if(req.method == "DELETE"){

    }

    // var obj = {
    //     table: []
    //  };
    //  var filedate;
    // fs.readFile('Profiles.json', 'utf8', function readFileCallback(err, data){
    //     if (err){
    //         console.log(err);
    //     } else {

    //         //console.log("date"+data);
    //         obj = JSON.parse(data); //now it an object
    //         //console.log(filedate);
            
    //         obj.table = [];
    //         obj.table.push({id: 1, square:2}); //add some data
    //         json = JSON.stringify(obj); //convert it back to json
    //     fs.writeFile('myjsonfile.json', json, 'utf8'); // write it back 
    // }});

}).listen(7000,()=>{console.log("Listening on port 7000")})













