// // // var x = 10;
// // // var y = 20;
// // // setTimeout(function(){console.log(x,y)},2000)
// // // console.log("Hiiii");
// // // global.console.log("Hiiii");

// // //Node [c++]
// // //Global Object[Module]
// // //Read - Write - Update -Delete
// // //Http Server


// // //Global Module ===> [global]
// // /**
// //  * 1- Global Modules without Require [process - global - console - require.....]
// //  * 2- Built-In Module [os - http - ...]
// //  * 3-third Party Module (need Install) [nodemon - express - ....]
// //  * 4-Custom Module [Create Ur Own Module]
// //  */

// // // process.stdout.write("Hello Ya NodeJS")
// // // process.stdout.write("Hello Ya NodeJS")

// // console.log("Hello Ya NodeJS");
// // console.log("Hello Ya NodeJS");

// // // console.log(process.argv[2])

// // //2-Built-In Modules [os - http]

// // // import {} from './asdad' ===> JS | ES
// // const os = require("os");//Import

// // console.log(os.hostname())
// // console.log("Hamada")

// // //3-Third Party Module [nodemon] (need Install) [npm i .... -g]
// // //4-Custom Module




// //Files
// //Built-In [ fs ]
// const fs = require("fs");
// fs.readFile("file.txt",function(err,info){
//     if(err){console.log(err)}
//     else{console.log(info)}
// })

// var data = fs.readFileSync("file.txt","utf-8");
// console.log("Sync Function: "+data);

// //2 Solutions

// fs.readFile("file.txt",function(err,info){
//     if(err){console.log(err)}
//     else{console.log(info.toString())}
// })


// fs.readFile("file.txt","utf-8",function(err,info){
//     if(err){console.log(err)}
//     else{console.log(info)}
// })

// console.log("After All Async Functions")

// const fs = require("fs");
// console.log("Hii111")
// fs.writeFileSync("file.txt","Write File Success");
// console.log("Hii222")
// fs.appendFileSync("file.txt"," Updated Success");

// fs.mkdir("new Folder",function(){});
// process.chdir("new Folder");
// fs.writeFileSync("file3.txt","Write File Success");

// process.chdir("../");
// fs.writeFileSync("file5.txt","Write File Success");
// fs.unlinkSync("file5.txt")

// const rimraf = require("rimraf");
// rimraf("./new Folder",function(){})

// fs.rmdirSync("new Folder")

//Read - Write - Delete - Update


// const fs = require("fs");

// fs.writeFileSync("file.txt","")
// for(let i=0; i<5000;i++){
//     fs.appendFileSync("file.txt","   Hello  ")
// }

// var readFile = fs.createReadStream("file.txt",{encoding:"utf-8",highWaterMark:16*1024});

// readFile.on("data",function(info){
//     // console.log(info.length)
//     var w = fs.createWriteStream("file2.txt")
//     w.write(info);
// });

