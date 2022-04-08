// console.log(window);
// console.log(module.exports);
// console.log(this);
// console.log(global);
// console.log(typeof module);

// var s = require("../Modules/module1");
// console.log(s());
/**
* ~V1.0.0 ===> Accept Patches update
* ^V1.0.0 ===> Accept Minor,Patches update
* *V1.0.0 ===> Accept Major,Minor,Patches update
*/

//Third Party Module[nodemon - express]
var express = require("express");
var app = express();
var PORT = process.env.PORT || 8003;
var myPath = "C:/Users/MostafaMahmoudHelmy/Desktop/PD, SWA, Mobile/1-Node JS/Day3";
var path = require("path");
console.log(__dirname);

var bodyParser = require("body-parser");
app.use(bodyParser.urlencoded({extended:true}))
app.use(bodyParser.json());

// console.log(PORT);
app.all("/profile.html",(req,res,next)=>{
    console.log("Ana Allllll");
    next()
})

app.get("/*",(req,res,next)=>{
    console.log("Ana MidWare 3la '/'")
    next();
})
app.get("/",(req,res)=>{
    // res.send("Hellooooo");
    res.setHeader("content-type","text/html");
    // res.sendFile(myPath+"/Client-Side/main.html");
    res.sendFile(path.join(__dirname, "../Client-Side/main.html"));
})
app.get("/operator/:op/num1/:n1/num2/:n2",(req,res)=>{
    // console.log(req.params.op);
    // console.log(req.params.n1);
    // console.log(req.params.n2);
    var n1 = req.params.n1
    var n2 = req.params.n2
    var result = parseInt(n1)+parseInt(n2);
    res.send(result.toString());
})

app.param("op",(req,res,next)=>{
    console.log("Ana OP")
    next();
})

app.param("n1",(req,res,next)=>{
    console.log("Ana Num1")
    next();
})

app.get("/:op/:n1/:n2",(req,res,hamada)=>{
    console.log("MiddleWare: "+req.params.op);
    req.params.op = "*";
    hamada();
},(req,res,next)=>{
    console.log("MiddleWare: "+req.params.n1);
    req.params.n1 = 20;
    next()
},(req,res)=>{
    console.log("Final Method: "+req.params.op)
    console.log("Final Method: "+req.params.n1)
    var n1 = req.params.n1
    var n2 = req.params.n2
    var result = parseInt(n1)+parseInt(n2);
    res.send(result.toString());
})



app.get("/style.css",(req,res)=>{
    res.sendFile(path.join(__dirname , "../Client-Side/style.css"))
})

app.get("/script.js",(req,res)=>{
    res.sendFile(path.join(__dirname , "../Client-Side/script.js"))
})
// app.get("/main.html",(req,res)=>{})
// app.get("/profile.html",(req,res)=>{})

app.post("/profile.html",(req,res)=>{
    console.log(req.body);
    res.send("Done")
})

app.get("*",(req,res)=>{
    res.send("Invalid URL!!!!!!")
})

app.get("/",()=>{});
app.post("/",()=>{});

// app.router("/")
// .get(()=>{})
// .post(()=>{})
// .put(()=>{})


app.listen(PORT, ()=>{console.log("Listining on PORT "+PORT)});







