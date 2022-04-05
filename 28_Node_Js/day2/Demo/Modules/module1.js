// var x = 10;
// global.x = 10;
// console.log(x);

// console.log(module.exports);
// console.log(exports);

// exports.x = x;
// module.exports = {x:x};
// exports = {x:x};


// var y=20;
// module.exports = {x,y};


// function test1(){
//     return "Hello"
// }


// module.exports = {test1}


// var Items = [];
// function AddItem(item,price){
//     Items.push( {item, price} )
// }

// function getSum(){
//     // var sum=0;
//     // for(let i=0; i<Items.length; i++){
//     //     sum += parseInt(Items[i].price)
//     // }
//     // return sum;

//     return Items.reduce(function(sum,item){
//         return sum += parseInt(item.price);
//     },0)
// }

// module.exports = {
//     AddItem,
//     getSum
// }



//Class

class myClass{
    constructor(){
        this.Items = [];
    }
    AddItem(item,price){
        this.Items.push( {item, price} )
    }
    getSum(){
        return this.Items.reduce(function(sum,item){
            return sum += parseInt(item.price);
        },0)
    }
}

module.exports = myClass;
