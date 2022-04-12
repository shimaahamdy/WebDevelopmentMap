/**
 * Number
 * String
 * Object
 * Boolean
 * undefined
 * null
 */

let x:number;
x = 10;
// x = "";

let y:number = 10;
// y=true;

let z = 10; //Type Inference
// z="";
// z=true;
z=20;

let a:any;
a=10;
a="";
a=true;

let a2;
a2=10;
a2="";
a2=true;

let arr:[];
arr = [];
// arr = [10];
// arr = [""];
// arr = [true];


let arr2:[number];
arr2 = [10];
// arr2 = [10,20];
arr2.push(20);
// arr2.push("20");
console.log(arr2);

let arr3:number[];
arr3 = [];
arr3 = [1];
arr3 = [1,5];
// arr3 = [1,5,10,""];

let arr4:(string|number)[];
arr4=[1,2];
arr4=["sad","fasfa"];
arr4=[1,"asdas"];
arr4=["asdas",224,"asda","asdas",22];

let obj:{};
obj = {};
obj = {name:"Ahmed"};

let obj1:{name:string};
obj1 = {name:"Ahmed"};

let arrOfObj:{name:string, age:number, address:string}[]=[];

//Functions
// function test():boolean{
//     return true;
// }

class Person{
    // name = "";
    // age=0;
    // address = "";
    // constructor(name="Person Name", age=0, address="123 st"){
    //     this.name = name;
    //     this.age = age;
    //     this.address = address;
    // }
    #phone="";
    static counter = 0;
    constructor(public name="Person Name", public age=0, public address="123 st."){
        if(this.constructor == Person){
            Person.counter++;
        }
    }
    get Phone(){
        return this.#phone;
    }
    set Phone(val:string){
        this.#phone = val;
    }

    GetName(){
        return this.name;
    }

    static Counter(){
        return this.counter;
    }
}


var p1 = new Person("Ahmed",10,"");
var p2 = new Person();
console.log(p1, p2);
console.log(Person.counter);
console.log(Person.Counter());



class Employee extends Person{
    static counter = 0;
    constructor(name="Employee Name", age=20, address="456 st",public salary=10000){
        super(name, age, address);
        if(this.constructor == Employee){
            Employee.counter++;
        }
    }
}

var e1 = new Employee();
console.log(e1);

abstract class IPerson1{
    name="";
    age=20;
    getName(){

    }
    abstract getAge();
}
class Emp1 extends IPerson1{
    getAge() {
        throw new Error("Method not implemented.");
    }

}

class Emp2 implements IPerson1{
    name: string;
    age: number;
    getName(): void {
        throw new Error("Method not implemented.");
    }
    getAge() {
        throw new Error("Method not implemented.");
    }

}


interface IPerson2{
    name:string;
    age:number;
    getName();
    getAge();
}

class Emp3 implements IPerson2{
    name: string;
    age: number;
    getName() {
        throw new Error("Method not implemented.");
    }
    getAge() {
        throw new Error("Method not implemented.");
    }
    
}