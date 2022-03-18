var myWorker = new Worker("../Worker/worker.js")

function btn1(){
    setInterval(function(){
        document.getElementsByTagName("div")[0].innerHTML += "X";
    },100)
}

document.getElementsByTagName("input")[3].onclick = function(){
    var num1 = parseInt(document.getElementsByTagName("input")[1].value);
    var num2 = parseInt(document.getElementsByTagName("input")[2].value);

    myWorker.postMessage([num1,num2]);

    myWorker.onmessage= function(r){
        // console.log(r.data[0])
    document.getElementsByTagName("p")[0].innerHTML = r.data[0];
    // myWorker.terminate();
    }
    // document.getElementsByTagName("p")[0].innerHTML = num1+num2
}




function closeConnection(){
    myWorker.terminate();
}