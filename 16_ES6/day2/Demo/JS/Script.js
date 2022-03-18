// /** ========================= Set & Map ========================= */
// /**[Set] (Unique Values) */
// /**Properties [size] */
// /**Methods [add(val)- delete(val) - clear() - has(val)]*/
// /**Iterator Methods [entries() - values() - keys()] */

// var mySet = new Set([1,2,"Hello",9]);
// console.log(mySet);
// console.log(mySet.size);

// mySet.add("Ahmed");
// console.log(mySet);

// mySet.add("Ahmed");
// console.log(mySet);

// console.log(mySet.has("Ahmed"));//true

// mySet.delete("Ahmed")
// console.log(mySet);

// console.log(mySet.has("Ahmed"));//false

// //Iterators Methods
// console.log(mySet.entries());
// console.log(mySet.values());
// console.log(mySet.keys());

// mySet.clear();
// console.log(mySet);//{}


// //==========================================================
// /**[Map] (Duplicated Values) */
// /**Properties [size] */
// /**Methods [set(Key,val)- get(Key) - delete(Key) - clear() - has(Key)]*/
// /**Iterator Methods [entries() - values() - keys()] */

// var myMap = new Map([["name","Ahmed"],["age",25],[2,10000]]);
// console.log(myMap)

// console.log(typeof myMap)

// myMap.set("Address","123.st")
// console.log(myMap);
// console.log(myMap.size);

// //Itertor Methods
// console.log(myMap.entries())
// console.log(myMap.keys())
// console.log(myMap.values())

// //clear
// myMap.delete("name");
// console.log(myMap)


//Iterators ====> Iterable ====> for of

// var arr = ["Ahmed",20];

// for(let i in arr){//i =====> index
//     console.log(i+":"+arr[i]);
// }

// for(let i of arr){//i =====> value
//     console.log(i);
// }

var myMap = new Map([["name","Ahmed"],["age",25],[2,10000]]);
// for(let i in myMap){//i =====> index
//     // console.log(myMap[i]);
// }


// for(let i of myMap.keys()){//i =====> values
//     // console.log(i[0]);
//     console.log(i);
// }


for(let i of myMap){//i =====> values
    console.log(i);
}


for(let [k, v] of myMap){//i =====> values
    console.log(`Key: ${k}, Value: ${v}`);
}

var obj = {}
Object.defineProperty(obj,"fName",{value:"",enumerable:true})

//Enumerable[Properties of Object](for in) VS Iterable [iterable object]======> Iterator ======> [@@iterator] || [Symbole.iterator]

var myArray = ["Ahmed",20];

for(let i in myArray){//i =====> index
    console.log(i+":"+myArray[i]);
}

for(let i of myArray){//i =====> value
    console.log(i);
}

console.log(myArray.length);//2
console.log(myArray["length"]);//2

var l = "length";

console.log(myArray[l]);//2

console.log(myArray[Symbol.iterator]);

console.log(Symbol.iterator)

var iter = myArray[Symbol.iterator]();
console.log(iter.next());
console.log(iter.next());
console.log(iter.next());

//Iterable Object ===> Iterator [Symbol.iterator] ===> {next:f} ==next()==> {value:"" , done:true||false}

var myObj = {
    fname:"Ahmed",
    age:20,
    [Symbol.iterator]:function(){
        let counter = 0;
        var arr = Object.entries(myObj);//["",""] ==> ["",""]
        // var arr1 = Object.keys(myObj);//["","",""]
            return {next:function(){
                if(counter < arr.length){
                    return {value:arr[counter++][1], done:false}
                    // return {value:myObj[arr1[counter++]], done:false}
                }
                else
                    return {value:undefined, done:true}
            }
        }
    }
}


var iter2 = myObj[Symbol.iterator]();//counter intialized by 0
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());
console.log(iter2.next());

//============================ Genertor ========================
// for(let i = 0; i<3; i++){
//     console.log(i)

// }


//Generator
function * hamada(){
        console.log("Started");
    yield 1;
        console.log("Before KOKO Yield")
    yield "KOKO";
        console.log("Finished")
    yield 2;
    console.log("After Finished Yields")
}

var iter3 = hamada();

console.log(iter3.next())
console.log(iter3.next())
console.log(iter3.next())
console.log(iter3.next())
console.log(iter3.next())

//Another Way to add Iterator at object
var myObj2 = {
    fname:"Ahmed",
    age:20,
    [Symbol.iterator]:function*(){
        for(var i in this){
            // console.log(i);
            yield this[i];
        }
    }
}

var iter4 = myObj2[Symbol.iterator]();

console.log(iter4.next())
console.log(iter4.next())
console.log(iter4.next())
console.log(iter4.next())



// for(let i of myObj2){
//     console.log(i);
// }


function * EvenNumbers(arr){
    for(let i =0; i<arr.length;i++){
        if(arr[i]%2===0){
            yield arr[i];
        }
    }
}


for(let i of EvenNumbers([1,2,22,44,13,15,5,4,2,12])){
    console.log(i);//
}


///===================== GUID | UUID ====================

var x = Symbol();// Primitive Data Types[number - string - boolean - undefiend - ......................]
console.log(x);
console.log(typeof x);

var y = Symbol();

console.log(x==y);//false

var x = Symbol("abc");//description
var y = Symbol("abc");//description

console.log(x==y);//false

//ES9
console.log(x.description);//abc
console.log(y.description);//abc

//u can add Symbol to Register [Symbol.for("")]
var x = Symbol.for("abc")
var y = Symbol.for("abc")

console.log(x==y);//true



var obj = {
    nm:"Aly",
    age:20,
    id:Symbol(),//unique
    [Symbol("abc")]:"New Prop"
}
console.log(obj)
console.log(obj.id)
console.log(obj[Symbol("abc")])

//there are 2 ways to get symbol

//(1) variable
var ref = Symbol("abc");

var obj = {
    nm:"Aly",
    age:20,
    id:Symbol(),//unique
    [ref]:"New Prop"
}

console.log(obj[ref])

//(2) Symbol.for
var obj = {
    nm:"Aly",
    age:20,
    id:Symbol(),//unique====>Math.ra..
    [Symbol.for("abc")]:"New Prop"
}

console.log(obj[Symbol.for("abc")])


//Sybole.Iterator     Symbol.match     Symbole.replace

//Hello ======> H TEST llo

// console.log("Hello".replace("el"," TEST "));

var myObj = {
    [Symbol.replace]:function(str="",idx){
        return str.substring(0,idx)+" TEST "+str.substring(idx+1,str.length)
    }
}

var mystr = "Hello";

console.log(mystr.replace(myObj,2))



var myObj = {
    [Symbol.replace]:function(str="",[str2="",str3=""]){

        if(str.includes(str2)){
            var t = str.indexOf(str2);
            var L = str2.length;
            return str.substring(0,t) + str3 + str.substring(t+L,str.length)
        }

    }
}




console.log(mystr.replace(myObj,["el"," kk "]))
