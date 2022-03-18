// var x = 0;

// var myPromise = new Promise(function(success, fail){
//     if(x==1){
//         success("Success");//Fire Success======>.then(()=>{})
//     }else{    
//         fail("Error");//Fire Error===========>.catch(()=>{})
//     }
// });

// var p1 = myPromise;
// p1.then((data)=>{console.log(data)});
// p1.catch((err)=>{console.log(err)});


// var p1 = myPromise.then((data)=>{console.log(data)})
//                   .catch((err)=>{console.log(err)});


// myPromise.then((data)=>{console.log(data)})
//          .catch((err)=>{console.log(err)})

// var x = 1;
// var myPromise1 = new Promise(function(resolve, reject){
//     if(x==1){
//         setTimeout(()=>{resolve("Success 1")},1000);//Fire Success======>.then(()=>{})
//     }else{    
//         setTimeout(()=>{reject("Error 1")},1000);//Fire Error===========>.catch(()=>{})
//     }
// });

// myPromise1.then((data)=>{console.log(data)})
//          .catch((err)=>{console.log(err)})



// var y = 1;
// var myPromise2 = new Promise(function(resolve, reject){
//     if(y==1){
//         setTimeout(()=>{resolve("Success 2")},3000);//Fire Success======>.then(()=>{})
//     }else{    
//         setTimeout(()=>{reject("Error 2")},3000);//Fire Error===========>.catch(()=>{})
//     }
// });

// myPromise2.then((data)=>{console.log(data)})
//          .catch((err)=>{console.log(err)})




// async function myFun(){
//     var y = 1;
//     var myPromise2 =  new Promise(function(resolve, reject){
//     if(y==1){
//         setTimeout(()=>{resolve("Success 2")},3000);//Fire Success======>.then(()=>{})
//     }else{    
//         setTimeout(()=>{reject("Error 2")},3000);//Fire Error===========>.catch(()=>{})
//     }
//     });
//     var x = 1;
//     var myPromise1 = new Promise(function(resolve, reject){
//     if(x==1){
//         setTimeout(()=>{resolve("Success 1")},1000);//Fire Success======>.then(()=>{})
//     }else{    
//         setTimeout(()=>{reject("Error 1")},1000);//Fire Error===========>.catch(()=>{})
//     }
//     });
    
//     // await myPromise2;

//     // myPromise1.then((data)=>{console.log(data)})
//     // .catch((err)=>{console.log(err)});

//     myPromise2.then((data)=>{console.log(data)})
//              .catch((err)=>{console.log(err)})
//              .then(()=>{myPromise1.then((data)=>{console.log(data)})
//              .catch((err)=>{console.log(err)});});
// }
// console.log("Before MyFun")
// myFun();
// console.log("After MyFun")




var x = 0;
var myPromise1 = new Promise(function(resolve, reject){
if(x==1){
    setTimeout(()=>{resolve("Success 1")},1000);//Fire Success======>.then(()=>{})
}else{    
    setTimeout(()=>{reject("Error 1")},1000);//Fire Error===========>.catch(()=>{})
}
});


var y = 0;
var myPromise2 =  new Promise(function(resolve, reject){
if(y==1){
    setTimeout(()=>{resolve("Success 2")},3000);//Fire Success======>.then(()=>{})
}else{    
    setTimeout(()=>{reject("Error 2")},3000);//Fire Error===========>.catch(()=>{})
}
});

Promise.all([myPromise1.then().catch(),myPromise2])
        .then(()=>{console.log("All Success")})
        .catch(()=>{console.log("One Of The Promises Failed")})

//ES2021 [Proposal] ===> new 
// Promise.any([myPromise1,myPromise2])
//         .then(()=>{console.log("One Of The Promsies Success")})
//         .catch(()=>{console.log("All Promises Faild")})





// var xhr = new XMLHttpRequest();
// xhr.open("GET","https://jsonplaceholder.typicode.com/users")
