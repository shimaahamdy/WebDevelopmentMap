function create_cookie(key,value,Expflage)
{
      
      if(Expflage)
      {     var dat = new Date();
            dat.setMonth(dat.getMonth()+1);
            document.cookie = key+"="+value+"; expires="+dat.toUTCString();
      }
      else document.cookie = key+"="+value;
}

function delete_cookie(key)
{
      var dat = new Date();
      dat.setMonth(dat.getMonth()-3);
      document.cookie = key+"="+"; expires="+dat.toUTCString();
}

function get_all_cookies()
{
      var assArray =[];
      var allCookies = document.cookie.split("; ");
      for(var i=0;i<allCookies.length;++i)
      {
            var ourkey = allCookies[i].split("=")[0];
            var value = allCookies[i].split("=")[1];
            assArray[ourkey] = value;
      }
      return assArray;

}
function get_cookie(key)
{
    var all_cookies = get_all_cookies();
    console.log(all_cookies[key]);
    return all_cookies[key];
}
function del_cookies()
{
      var all_cookies = get_all_cookies();
      for(var i in all_cookies)
      {
            delete_cookie(i);
      }
}

/** */


function save_date()
{
    var value = document.getElementById("username").value;
    console.log(value);
    create_cookie("username",value,1);
    value = document.getElementById("age").value;
    create_cookie("userage",value);
    create_cookie("vis","0",1);
    if(document.getElementsByName("gender")[0].checked)
    {
        create_cookie("gender","1",1);
        
    }
    else if(document.getElementsByName("gender")[1].checked)
    {
        create_cookie("gender","2",1);
    }
    var col = document.getElementById("color").value;
     create_cookie("color",col);
    window.location.href="profile.html";
}
//del_cookies();



