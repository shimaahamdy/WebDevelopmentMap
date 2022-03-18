/*2) Proxy
create a dynamic object using Proxy such that it has only the 
following properties
 name property that accepts only string of 7 characters 
 address property that accepts only string value
 age property that accepts numerical value between 25 and 60*/

var obj ={
    set:function(obj,prop,val){
        if(prop==="name" && typeof(val)=='string' && val.length==7){
            obj[prop]=val;
        }
        else if(prop == "address" && typeof(val)=="string"){
            obj[prop]=val;
        }
        else if(prop == "age" && typeof(val)=="number" && val>=25 && val<=60){
            obj[prop]=val;
        }
    }
    

}
var myProxy = new Proxy({},obj);
