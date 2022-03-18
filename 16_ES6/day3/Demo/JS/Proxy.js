//Proxy ======> Contorll Properties in Object


// var target = {};

var handler = {
    set:function(obj,prop,val){
        if(prop == "x"){
            if(val>20 && val<30){
                obj[prop] = val;
            }else{
                throw "Value Must 20<Val<30"
            }
        }
        else if(prop == "y"){
            if(typeof val == "string"){
                if(val.length>=3){
                    obj[prop] = val
                }
                else{
                    throw "Length Of Y >= 3 "
                }
            }
            else{
                throw "Value Of Y Must be String"
            }
        }
        else{
            throw "Not X or Y !!!";
        }
    }
}


var myProxy = new Proxy({},handler);

myProxy.x = 21
console.log(myProxy);
// myProxy.z = undefined;
myProxy.y = "abc"

console.log(myProxy);


myProxy.y = "xyz"
console.log(myProxy)

// console.log(target);
// target.z = "Hamada";
// console.log(target);



