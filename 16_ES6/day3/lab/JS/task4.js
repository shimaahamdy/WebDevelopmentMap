/* reflct API */
/*
built-in object that provides methods for interceptable JavaScript operations
cannot use it with a new operator or invoke the Reflect object as a function.
All properties and methods of Reflect are static.
*/

/*methods:
          - Reflect.apply() :claa functions with specified arguments
          - Reflect.construct(): create object from function equal to new
          -Reflect.defineProperty(): add property to object
          - Reflect.get(): get propert value from object
*/
const duck = {
    name: 'Maurice',
    color: 'white',
    greeting: function(val) {
        this.val = val;
      console.log(`Quaaaack! My name is ${this.name}`);
    }
  }


console.log(Reflect.apply(duck.greeting, undefined, [1.75]));


const object1 = new duck.greeting(5);
console.log(object1);

if (Reflect.defineProperty(duck, 'weight', { value: 50, writable:false })) {
    console.log('property created!')};