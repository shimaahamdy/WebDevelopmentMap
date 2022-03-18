
//Named Export

// import {Add} from "../Modules/module1.js";
// import {Add, Sub,Div,Mult} from "../Modules/module1.js";
// import * as KOKO from "../Modules/module1.js";

// console.log(KOKO.Add(1,2));
// console.log(KOKO.Div(1,2));
// console.log(KOKO.Mult(1,2));
// console.log(KOKO.Sub(1,2));



//Default Export
import dd from "../Modules/module1.js";
import {Sub as ss} from '../Modules/module1.js';
console.log(dd(1,2));

console.log(ss(1,2));