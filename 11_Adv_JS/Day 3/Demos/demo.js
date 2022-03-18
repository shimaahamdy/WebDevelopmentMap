//Static Prop
//Person.prop



var Person = function (nm, age, yr, addr) {
    //Abstract Class
    //if(this.constructor==Person)
      //  throw "abstract class..creation not allowed";
    
    //this.prnName=nm;
    //var i=
    //data Descriptor
    Object.defineProperty(this, "prsnName", {
        value: nm
        , //writable:true,
        configurable: true
        , //enumerable:true
    });
    Object.defineProperty(this, "prsnAddr", {
        value: addr
        , writable: true
        , // configurable:true,
        enumerable: true
    });
    //Accessor Descriptor
    Object.defineProperty(this, "yearBornVal", {
        get: function () {
            return yr;
        },
        enumerable:true
    , })
    /*
    Object.defineProperties(this, {
        prsnName: {
            value: 
            , writable: 
        , }
        , prsnAddr: {}
        , {
            yearBornVal: {
                get: function () {}
                , set: function () {}
            }
        }
    })
    */
    this.prsnAge = age;
    //private
    var yearBorn = yr;
    //privilged method
    this.getYearBorn = function () {
        return yearBorn;
    }
    var that = this
        //private method
    function privateMethod() {
        console.log(that.prsnAge);
    }
    //privateMethod();
    //var bindFun=privateMethod.bind(this);//
    //bindFun()//hard binding
    this.excPrivMethod = function () {
        //bindFun();
        privateMethod();
    }
    
    
}
//var x= new Person()/////


//Static Prop //Class Property
Person.Location="Cairo"
Person.DisplayInfo=function(){
    console.log(this.Location);
    console.log(Person.Location);
}

//override toString()
Person.prototype.toString=function(){
    return "person name is "+this.prsnName+" lives in "+this.prsnAddr
}

Person.prototype.valueOf=function(){
    return this.prsnAge;
    
}
/*
Person.prototype={
    toString:function(){},  
}
*/

var Employee=function(nm,age,yr,addr,dept,sal){
    Person.call(this,nm,age,yr,addr)//
    this.empDept=dept
    this.empsal=sal
    
}

//Employee.prototype=Person.prototype;//REF
Employee.prototype=Object.create(Person.prototype)//Parasetic Inher.
Employee.prototype.constructor=Employee

Employee.prototype.toString=function(){
    return Person.prototype.toString.call(this)+" works in dept "+this.empDept;
}

Employee.prototype.displayData=function(){}

Person.prototype.newFun=function(){}

