var userName = document.getElementById("i1");
var userAge = document.getElementById("i2");
function SavaValues(){
    var dat = new Date();
    var dat2 = new Date();
    // dat.getMonth();
    dat.setMonth(dat.getMonth()+1);
    dat2.setMonth(dat2.getMonth()+3);
    // document.cookie = "Name=Value; expires=1-11-2022"
    document.cookie = "usrName="+userName.value+"; expires="+dat.toUTCString();
    document.cookie = "usrAge="+userAge.value+"; expires="+dat2.toUTCString();
}

function DeleteValues(){
    var dat = new Date();
    var dat2 = new Date();
    dat.setMonth(dat.getMonth()-1);
    dat2.setMonth(dat2.getMonth()-1);
    document.cookie = "usrName="+"; expires="+dat.toUTCString();
    document.cookie = "usrAge="+"; expires="+dat2.toUTCString();
}