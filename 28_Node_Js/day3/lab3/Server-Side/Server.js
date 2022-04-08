/* Task */
/**Server */

//congiguation
const fs = require("fs");
var express = require("express");
var app = express();
var PORT = process.env.PORT || 7000;
var path = require("path");
var bodyParser = require("body-parser");
app.use(bodyParser.urlencoded({extended:true}))

//start server
app.get("/main.html",(req,res)=>{
    res.setHeader("Access-Control-Allow-Origin",'*');
    res.sendFile(path.join(__dirname, "../ClientSide/main.html"));
})

app.get("/",(req,res)=>{
    res.setHeader("Access-Control-Allow-Origin",'*');
    res.sendFile(path.join(__dirname, "../ClientSide/main.html"));
})

app.get("/style.css",(req,res)=>{
    
    res.sendFile(path.join(__dirname, "../ClientSide/style.css"));
})

app.get("/script.js",(req,res)=>{
    
    res.sendFile(path.join(__dirname, "../ClientSide/script.js"));
})

app.get("/Profiles.json",(req,res)=>{
    
    res.sendFile(path.join(__dirname, "Profiles.json"));
})

app.get("*",(req,res)=>{
    res.send("Can`t Find This Page!!!")
})

app.post("/profile.html",(req,res)=>{

    //json file
    var obj = {
        table: []
        };
    fs.readFile('Profiles.json', 'utf8', function readFileCallback(err, data){
        if (err){
            console.log(err);
            } 
        else {
            //var assObj = Object.assign({}, assArray); 
            obj = JSON.parse(data); //now it an object
            obj.push(req.body); //add some data
            //json = JSON.stringify(obj); //convert it back to json
            fs.writeFile("Profiles.json", JSON.stringify(obj), function(err){
            if (err) throw err;
            console.log('The "data not append" was appended to file!');
            });
            }});  
            
           
            var infoHtml=fs.readFileSync("../ClientSide/profile.html").toString();
            infoHtml = infoHtml.replace("{clientName}",req.body.firstname+" "+req.body.lastname);
            infoHtml = infoHtml.replace("{MobileNumber}",req.body.Mobile);
            infoHtml = infoHtml.replace("{Email}",req.body.emal).replace("%40","@");
            infoHtml = infoHtml.replace("{add}",req.body.add);

            res.send(infoHtml);
    
        // res.sendFile(
        // path.join(__dirname, "../ClientSide/profile.html").replace("{clientName}",req.body.firstname+" "+req.body.lastname).
        // replace("{MobileNumber}",req.body.Mobile).replace("{add}",req.body.add).replace("{Email}",req.body.emal).
        // replace("%40","@")
        // );

        res.readFile
 
})
app.listen(PORT, ()=>{console.log("Listining on PORT "+PORT)});

// ********************************************************************************* */












