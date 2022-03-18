/*
var Employee= function(nm,age){
    this.nm=nm;
    this.age=age;
    this.show=function(){
        console.log(this);
        
        
    }
    
}
var me= new Employee("ali",10)
me.show()




var obj={nm:"",}//litral creation

var person=function(nm,age,id){
    
    
    return {
        prsnNm:nm,
        prsnAge:age,
        psrnID:id
    }
    
}

var p1= person("ali",10,"sd-101");
*/



    //ctor function
    function Employee(dept="sd",sal=1000,addr="123st."){
        var addr=addr;//private
        this.empDept=dept;
        this.empSal=sal;
        this.getAddr= function(){//
            //return this.addr; //it will return the body to excute 
            //the caller is window
            return addr;
        }
        this.setAddr= function(val){//
             addr=val;
        }
        
    }


Employee.prototype.toString = function () {
    return "this employee works in"+this.empDept;
    
};
Employee.prototype.getempsal=function(){
            return this.empSal;
};
        
Employee.prototype.display=function(){
            return this.empDept+" salary:"+this.empSal;
}

    
  /*

for (prop in e2){
    e3[prop]=e2[prop]
}*/
    
    
    
    
    
    
    




























arr=[function(){}]
arr[0]()

var x= console.log;
x("dfghj")

function fun(){
    var arr=[];
    for(var i=0;i<3;i++){
        arr.push((function(j){
            
            return function(){
                console.log(j);
            }
        })(i))
    }
    i=500;
    
    
    return arr;
    
}


var res=fun()

/*

var x=10;
function f(a,b){//a=1;b=2;c=undefined;x=90
     x=90;
    var c=9;
    function f1(){
        var d=8;
        function f3(e){
            return x+c+d+e
            
        }
        f3(1);
    }
    
   f1();
    
}

f()
/*
console.log(x);//10
f(1,2);
console.log(x);//
*/



/*var innerfun;
function fun1(a,b){
    
    var x=10
     innerfun=function (){
        return a+b+x;
    }
    
   // return innerfun();
     return "dsgfgh";
    
}

fun1(1,2)

innerfun();
*/