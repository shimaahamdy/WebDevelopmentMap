/**
 * custom Module runs at Both [Server - Client] Side [UMD (Universal Module Defination)]
 * npm[node package Manager]
 * package.json ===> npm init
 * npm adduser ===> npm publish
 * express ===> npm i express
 * RestFull API  [GET - POST - DELETE - PUT] ===> express
 * body-parser [npm i body-parser]
 * MiddleWare
 */



//UMD

//IIFE [Immediatly Invoked Function Expresion]

// function Add(x,y){return x+y}
// Add(10,20);

// (function(x,y,plus){return x+y})(10,20,function(){})

(function(callingName,environment,definition){
    //if ==> env??? ===>
    // [Node (module.exports = defination) ] || [Client (env[callingName] = defination)]
    if(typeof module == 'undefined'){//Front-End
        environment[callingName] = definition();
    }else{
        module.exports = definition();
    }

})("MyModule",this, function(){
    return function(){
        console.log("Hii Everyone..")
        console.log("Hii Everyone2..")
    }
})













