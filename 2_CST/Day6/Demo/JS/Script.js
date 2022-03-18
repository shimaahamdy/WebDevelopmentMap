
// function ShowData(){
//     var sel = document.getElementById("SelectCoun");
//     var idx = sel.selectedIndex;
//     var ourDiv = document.getElementById("d1");
//     // ourDiv.innerHTML = idx;
//     // ourDiv.innerText = "<b>"+sel.options[idx].value+"</b>";
//     ourDiv.innerHTML = "<b>"+sel.options[idx].value+"</b>";
// }


function ShowData(){
    var sel = document.getElementById("SelectCoun");
    var ourDiv = document.getElementById("d1");

    ourDiv.innerHTML = "";

    for(var i = 0; i<sel.length; i++){
        if(sel.options[i].selected){
            ourDiv.innerHTML += "<br>"+sel.options[i].value;
        }
    }
}
