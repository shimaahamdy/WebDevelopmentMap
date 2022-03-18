var numericList = function (start, end, step) {
  
    //private members
    var start = start || 0;
    var end = end || 10;
    var step = step || 1;
    var arrlist=[];
    
    for(var i = start;i<=end;i+=step)
    {
        arrlist.push(i);
        
    }
  
    //getter
    this.getlist = function()
    {
        return arrlist;
    }
    this.getStep= function()
    {
        return step;
    }
    this.getStart = function()
    {
        return start;
    }
    
    //PRIVATE METHOD
    var push_item = (function (item) {
        last_item = this.getlist()[this.getlist().length-1]+this.getStep();
        //console.log(last_item+" "+item);
        if(item==last_item)
        this.getlist().push(item);
        else if(this.getlist().includes(item))
        throw "dublicate value";
        else throw "value is not in sequence";
    }).bind(this);
    //HARD BINDING
    this.push = function (item) {
        push_item(item); //this
    }


    //PRIVATE METHOD
    var pop_item = (function () {
        return this.getlist().pop();
    }).bind(this);
    //HARD BINDING
    this.pop = function () {
        return pop_item(); //this
    }

    //PRIVATE METHOD
    var shift_item = (function () {
        return this.getlist().shift();
    }).bind(this);
    //HARD BINDING
    this.dequeue = function () {
        return shift_item(); //this
    }
      
  //override
  numericList.prototype.toString =function()
  {
      return this.getlist().toString();
  }
   
}

/* test */
// var list5 = new numericList(5,20,5); //5 10 15 20
// list5.getlist(); //5 10 15 20
// list5.push(25); // 5 10 15 20 25
// //list5.push(20); //dublicate
// //list5.push(32); //out of sequence
// list5.pop(); //25
// list5.dequeue();//5
