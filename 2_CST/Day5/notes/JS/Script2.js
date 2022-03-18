var i=0;

function plus_notify()
{
    var sup_notify = document.getElementById("notify_plus");
    setInterval(increase,1000,sup_notify)
}

function increase(sup_notify)
{
    sup_notify.innerHTML = i++; 
}

/*
<><> the tags have content have inner html and inner text like p
<> the tage have no conetnet have only value like input
*/
/** Navigator object */
/* some times document.write as it overwrite the document sometimes
*/
// var s = navigator.userAgent;
// if(s.indexOf("Chrome"))document.write("hello in chrome");
// if(s.indexOf("Chrome"))document.write("hello in chrome");

/** */

function test_location()
{
    var query = location.search;
    var username = query.split("?")[1].split("&")[0].split("=")[1]; //"username=koko"
    var userage = query.split("?")[1].split("&")[1].split("=")[1]; //"age=20"
    document.getElementById("write").innerHTML = username;
}

document.bgColor = "red";

/*
document.getElementByname()  return collection

*/

document.querySelector("#i").style.backgroundcolor= "black";

function change()
{
    
}

