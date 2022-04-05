// var MyModule = require("../Modules/module1");
// // // x = 20;
// // console.log(MyModule.x);
// // console.log(MyModule.y);

// // console.log(MyModule);

// MyModule.AddItem("Labtop",12000);
// MyModule.AddItem("SmatWatch",4000);
// MyModule.AddItem("Headphone",1000);

// console.log(MyModule.getSum());

// var MyModule = require("../Modules/module1");

// MyModule.AddItem("Labtop",12000);
// MyModule.AddItem("SmatWatch",4000);
// MyModule.AddItem("Headphone",1000);

// console.log(MyModule.getSum());


var MyModule = require("../Modules/module1");

var user1 = new MyModule();

user1.AddItem("Labtop",12000);
user1.AddItem("SmatWatch",4000);
user1.AddItem("Headphone",1000);

console.log(user1.getSum());


var user2 = new MyModule();

user2.AddItem("Labtop",12000);
user2.AddItem("SmatWatch",4000);
user2.AddItem("Headphone",1000);

console.log(user2.getSum());


