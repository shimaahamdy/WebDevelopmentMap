//iff function to executed once
var type="localStorage";
//check if there is no local or session storage
if (typeof window.localStorage == 'undefined' || typeof window.sessionStorage == 'undefined') 
(function ()
{
      var Storage = function(type)
      {
            
            //create localStorage or sessionStorage
          
            function createCookie(key,value,Expflage)
            {
                  if(Expflage)
                  {
                        var dat = new Date();
                        //expire date after 100 years from creation time
                        dat.setMonth(dat.getMonth()+1200);
                        document.cookie = key+"="+value+"; expires="+dat.toUTCString();
                  }
                  else document.cookie = key+"="+value;                 //+"; path=/";

                  
            }
            //return array with all cookies and there value
            function getAllCookies()
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
            //return value of localStorage or sessionStorage
            function getCookie(key)
            {
                  var cookies = getAllCookies();
                  if(cookies[key])
                  return cookies[key];
                  else return "{}";
            }
            //use in clear local or session storage
            function deleteCookie(key)
            {
                  var dat = new Date();
                  //set time to past
                  dat.setMonth(dat.getMonth()-3);
                  document.cookie = key+"="+"; expires="+dat.toUTCString();
            }

            function getData(key)
            {
                  var data = getCookie(type);
                  data = JSON.parse(data);
                  return data[key];
                  
            }
            //get key of specific member
            function getKey(indx)
            {
                  var data = getCookie(type);
                  data = JSON.parse(data);
                  var c=0;
                  for(i in data)
                  {
                        if(c==indx)
                        return i;
                        c++;
                  }
            }
            
            function addDataItem(key,value,storeData)
            {
                  var data = getCookie(type);
                  data = JSON.parse(data);
                  if(data[key]==undefined)
                  storeData.length++;
                  
                  data[key] = value;
                  data = JSON.stringify(data);
                  return data;
            }
            function removeDataItem(key)
            {
                  var data = getCookie(type);
                  data = JSON.parse(data);
                  delete data[key];
                  data = JSON.stringify(data);                 
                  return data;

            }
            /* properties */

            //set length in each new session
              var stor = getCookie(type);
              stor = JSON.parse(stor);
              var count=0;
              for(i in stor)
              {
                    count++;
              }
              this.length = count;
              Object.defineProperty(this,"clear",{
                  value:function()
                  {
                        this.length=0;
                        deleteCookie(type);
                  }
                  
              });
              Object.defineProperty(this,"getItem",{
                  value:function(key)
                  {
                        return getData(key);;
                  }
                  
              });
              Object.defineProperty(this,"key",{
                  value:function(indx)
                  {
                        return getKey(indx);
                  }
                  
              });
              Object.defineProperty(this,"removeItem",{
                  value:function(key)
                  {
                        this.length--;
                        data = removeDataItem(key);
                        if(type=="localStorage")
                        createCookie(type,data,true);
                        
                        else
                        createCookie(type,data,false);
                  }
                  
              });
              Object.defineProperty(this,"setItem",{
                  value:function(key, value)
                  {
                        data = addDataItem(key,value,this);
                        if(type=="localStorage")
                        createCookie(type,data,true);
                        
                        else
                        createCookie(type,data,false);
                        
                  }
                  
              });
            
      }
      if (typeof window.localStorage == 'undefined') window.localStorage = new Storage('localStorage');
      if (typeof window.sessionStorage == 'undefined') window.sessionStorage = new Storage('sessionStorage');      
      
      /* test */
     // window.localstore = new Storage('localStorage');
     // window.sessionstore = new Storage('sessionStorage');
      
})();
