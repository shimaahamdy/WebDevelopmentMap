
importScripts("../worker/Adding.js");


onmessage = function(e){
    // console.log(e.data[0], e.data[1]);

    // var result = e.data[0]+ e.data[1];
    var result = Add(e.data[0],e.data[1]);
    postMessage([result]);
    // close();
}