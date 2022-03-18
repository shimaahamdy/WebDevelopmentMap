var assArray;
function CreateCookie(CookieName,CookieValue,ExpFlage){
    
    if(arguments[2]){
        var dat = new Date();
        dat.setMonth(dat.getMonth()+1);
        document.cookie = CookieName+"="+CookieValue+";expires="+dat.toUTCString();      
    }
    else{
        document.cookie = CookieName+"="+CookieValue;
    }
}


function DeleteCookie(CookieName){
    var dat = new Date();
    dat.setMonth(dat.getMonth()-1);
    document.cookie = CookieName+"=; expires="+dat.toUTCString();
}

function GetAllCookies(){
    assArray=[];
    var allCookies = document.cookie.split(";");
    for(var i = 0; i<allCookies.length; i++){
        // var ourKey = allCookies[i].split("=")[0].trim();
        // var ourValue = allCookies[i].split("=")[1].trim();
        assArray[allCookies[i].split("=")[0].trim()] = allCookies[i].split("=")[1].trim();
    }
    return assArray;
}


function DeleteAllCookies(){
    var allCookies = GetAllCookies();
    for(var i in allCookies){
        // document.cookie = i +"=;expires="
        DeleteCookie(i);
    }
}

