/**
 * Number
 * String
 * Object
 * Boolean
 * undefined
 * null
 */
var __classPrivateFieldGet = (this && this.__classPrivateFieldGet) || function (receiver, state, kind, f) {
    if (kind === "a" && !f) throw new TypeError("Private accessor was defined without a getter");
    if (typeof state === "function" ? receiver !== state || !f : !state.has(receiver)) throw new TypeError("Cannot read private member from an object whose class did not declare it");
    return kind === "m" ? f : kind === "a" ? f.call(receiver) : f ? f.value : state.get(receiver);
};
var __classPrivateFieldSet = (this && this.__classPrivateFieldSet) || function (receiver, state, value, kind, f) {
    if (kind === "m") throw new TypeError("Private method is not writable");
    if (kind === "a" && !f) throw new TypeError("Private accessor was defined without a setter");
    if (typeof state === "function" ? receiver !== state || !f : !state.has(receiver)) throw new TypeError("Cannot write private member to an object whose class did not declare it");
    return (kind === "a" ? f.call(receiver, value) : f ? f.value = value : state.set(receiver, value)), value;
};
var _Person_phone;
let x;
x = 10;
// x = "";
let y = 10;
// y=true;
let z = 10; //Type Inference
// z="";
// z=true;
z = 20;
let a;
a = 10;
a = "";
a = true;
let a2;
a2 = 10;
a2 = "";
a2 = true;
let arr;
arr = [];
// arr = [10];
// arr = [""];
// arr = [true];
let arr2;
arr2 = [10];
// arr2 = [10,20];
arr2.push(20);
// arr2.push("20");
console.log(arr2);
let arr3;
arr3 = [];
arr3 = [1];
arr3 = [1, 5];
// arr3 = [1,5,10,""];
let arr4;
arr4 = [1, 2];
arr4 = ["sad", "fasfa"];
arr4 = [1, "asdas"];
arr4 = ["asdas", 224, "asda", "asdas", 22];
let obj;
obj = {};
obj = { name: "Ahmed" };
let obj1;
obj1 = { name: "Ahmed" };
let arrOfObj = [];
//Functions
// function test():boolean{
//     return true;
// }
class Person {
    constructor(name = "Person Name", age = 0, address = "123 st.") {
        this.name = name;
        this.age = age;
        this.address = address;
        // name = "";
        // age=0;
        // address = "";
        // constructor(name="Person Name", age=0, address="123 st"){
        //     this.name = name;
        //     this.age = age;
        //     this.address = address;
        // }
        _Person_phone.set(this, "");
        if (this.constructor == Person) {
            Person.counter++;
        }
    }
    get Phone() {
        return __classPrivateFieldGet(this, _Person_phone, "f");
    }
    set Phone(val) {
        __classPrivateFieldSet(this, _Person_phone, val, "f");
    }
    GetName() {
        return this.name;
    }
    static Counter() {
        return this.counter;
    }
}
_Person_phone = new WeakMap();
Person.counter = 0;
var p1 = new Person("Ahmed", 10, "");
var p2 = new Person();
console.log(p1, p2);
console.log(Person.counter);
console.log(Person.Counter());
class Employee extends Person {
    constructor(name = "Employee Name", age = 20, address = "456 st", salary = 10000) {
        super(name, age, address);
        this.salary = salary;
        if (this.constructor == Employee) {
            Employee.counter++;
        }
    }
}
Employee.counter = 0;
var e1 = new Employee();
console.log(e1);
class IPerson1 {
    constructor() {
        this.name = "";
        this.age = 20;
    }
    getName() {
    }
}
class Emp1 extends IPerson1 {
    getAge() {
        throw new Error("Method not implemented.");
    }
}
class Emp2 {
    getName() {
        throw new Error("Method not implemented.");
    }
    getAge() {
        throw new Error("Method not implemented.");
    }
}
class Emp3 {
    getName() {
        throw new Error("Method not implemented.");
    }
    getAge() {
        throw new Error("Method not implemented.");
    }
}
