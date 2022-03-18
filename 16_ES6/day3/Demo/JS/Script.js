/**ES2021 v12 */
var msg = "Hello this is a message";

console.log(msg.replace("i","**"));
console.log(msg.replace(/i/g,"**"));
console.log(msg.replaceAll("i","**"));

/**Logical Operator */

//1)And & Equals [Assign Value when it`s true]
//Befor
// var a = 1;
// if(a){a=3;}
//After
var a = 1;
a &&= 3;//a = a&&3
console.log(a);


//2)Or || Equals [Assign value when it`s false]
//Before
// var a = 0;
// if(!a){a=3}
// console.log(a);
//After
var a = 0;
a ||= 3;//a=a||3
console.log(a);

//3)Nullish Coalescing & Equals [null || undefined]
var b;
b ??= 7
console.log(b);



//Numeric Separators ES2021
var num1 = 500;
console.log(num1);
var num2 = 1_500;
console.log(num2);
var num2 = 10500;
console.log(num2);

var num2 = 1_000_500;
console.log(num2);

//promise??



//class
class User{
    //private member
    #fullName = "";
    #Salary = 0;
    static counter = 0;
    constructor(fn="User First Name",ln="User Last Name",age=0,address="st",salary=1000){
        User.counter++;
        this.fname = fn;
        this.lname = ln;
        this.age = age;
        this.address = address;
        this.#fullName = this.fname + " " + this.lname;
        this.#Salary = salary
    }
    getUserName(){
        return this.#fullName;
    }
    setUserName(fn,ln){
        this.fname = fn;
        this.lname = ln;
        this.#fullName = fn + " " + ln;
    }
    get FullName(){
        return this.#fullName;
    }
    get #salary(){
        return this.#Salary;
    }

    static getCounter(){
        return User.counter;
    }
    static get MyCounter(){
        return User.counter;
    }
}


var u1 = new User("Ahmed","Aly",20,"123st",10_000);
console.log(u1);
// console.log(u1.#fullName);

console.log(u1.getUserName());
console.log(u1.FullName);
console.log(u1.salary)
var u2 = new User("Aly","Aly",20,"456st",5000)
console.log(User.counter);

console.log(User.getCounter());

console.log(User.MyCounter);




///Inheritance


class Person{
    static counter = 0;
    constructor(name,age,addr){
        this.name = name;
        this.age= age;
        this.addr = addr;
        if(this.constructor == Person)
            Person.counter++;
    }
    static myFun(){return "This is Person Class"}
    get Name(){return this.name;}    
    get Age(){return this.age;}
    get Address(){return this.addr;}
    DisplayInfo(){
        return `Hello ya ${this.name} of Age: ${this.age}`
    }
    toString(){
        return `Hello ya ${this.name} of Age: ${this.age}, Address: { ${this.addr} }`
    }
}



class Employee extends Person{
    static counter = 0;
    constructor(name,age,addr,dept,salary){
        super(name,age,addr);
        this.dept = dept;
        this.salary = salary;
        Employee.counter++;
    }
    toString(){
        // return `Hello ya ${this.name} of Age: ${this.age}, Address: { ${this.addr} }, Department: ${this.dept}, Salary=>${this.salary}`
        return `${super.toString()}, Department: ${this.dept}, Salary=>${this.salary}`
    }
}

var p1 = new Person("Ahmed",20,"456 st.");
console.log(p1.toString());//[object Object]

console.log(Person.counter);//1

var e1 = new Employee("KOKO",20,"123","SD",10000);
console.log(e1);
console.log(e1.DisplayInfo());
console.log(Employee.myFun());
console.log(Employee.counter);//1
console.log(e1.toString());




//ES7
console.log(Math.pow(6,2));//36
console.log(6**2);//6^2 = 36

//ES8
var obj = {name:"Ahmed",age:20};
console.log(Object.values(obj))
console.log(Object.keys(obj))

//Name: 
//Age:  
console.log("Name:".padStart(10,"_"))
console.log("Age:".padStart(10,"_"))

console.log("Name:".padEnd(10,"-"))
console.log("Age:".padEnd(10,"-"))

//ES10
var arr = [1,2,[30,40], [ [50,60],[70,80],[90,100] ] ];
console.log(arr.flat(0));
console.log(arr.flat(1));
console.log(arr.flat(2));

//Proxy ======> Contorll Properties in Object