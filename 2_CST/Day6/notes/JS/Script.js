// // function show_data()
// // {
// //       var selc=document.getElementsById("selectlist");
// //       var div1=document.getElementById("div1");
// //       console.log(selc.value);
// //       div1.innerText=selc.value;

// // }

// // var ourText=document.getElementById("il");
// // function add_value_to(elment)
// // {
// //       ourText.value+= +(elment.value);
// // }  
 
// // // if it was text and there was space use 
// // //element.value.trim(); // will delete spaces from string that added

// // /*
// // this -->return the elment that point to  
// // */

// // /* cookies */
// // function saveValues()
// // {
// //       var userNAme=document.getElementById("i1").value;

// //       document.cookie = "username"+"=";userNAme;
// // }
// var username = document.getElementById("i1");
// var userage = document.getElementById("i2");
// function saveValues()
// {
//       var dat = new Date();
//       dat.setMonth(dat.getMonth()+1);  // 0-->month 1
      
//       document.cookie = "username="+username.value+"; expires="+dat.toUTCString();
//       document.cookie = "userage="+userage.value;
// }

// function delteValues()
// {
//       var dat = new Date();
//       dat.setMonth(dat.getMonth()-1);
//       document.cookie = "username="+"; expires="+dat.toUTCString();
// }
/* cookie library */

function create_cookie(key,value,Expflage)
{
      
      if(arguments[2])
      {     var dat = new Date();
            dat.setMonth(dat.getMonth()+1);
            document.cookie = key+"="+value+"; expires="+dat.toUTCString();
      }
      else document.cookie = key+"="+value;
}

function delete_cookie(key)
{
      var dat = new Date();
      dat.setMonth(dat.getMonth()-1);
      document.cookie = key+"="+"; expires="+dat.toUTCString();
}

function get_cookies()
{
      var assArray =[];
      var allCookies = document.cookie.split(";").trim();
      for(var i=0;i<allCookies.length;++i)
      {
            var ourkey = allCookies[i].split("=")[0];
            var value = allCookies[i].split("=")[1];
            assArray[ourkey] = value;
      }
      return assArray;

}
function del_cookies()
{
      var cookies = get_cookies();
      for(var i in cookies)
      {
            delete_cookie(i);
      }
}
/* to access the key */
document.cookie.split("; ")[0].split("=")[0]; // key of first attribute








