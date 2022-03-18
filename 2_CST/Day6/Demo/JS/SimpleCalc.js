var ourText = document.getElementById("i1");
function addValueToText(ourbtn){
    ourText.value += ourbtn.value.trim();
}

function Cleartext(){
    ourText.value = "";
}