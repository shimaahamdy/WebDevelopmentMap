var linkedlist ={
    data:[],
    Enqueue:function(num)
    {
        if(this.data.length==0)
        this.data.push(num);
        else if(num>this.data[this.data.length-1])
        this.data.push(num);
        else throw "number out of sequence";
    },
    Insert:function(num)
    {
        if(this.data.includes(num)==false)
        {
            if(this.data.length==0)
            throw "array is empty"
            for(var i=0;i<this.data.length-1;++i)
            {
                if(num>this.data[i]&&num<this.data[i+1])
                {
                    this.data.splice(i+1,0,num);
                    break;
                }
            }
        }
        else throw "number is exist"
    },
    Pop:function()
    {
        return this.data.pop();
    },
    Remove:function(num)
    {
        index = this.data.indexOf(num);
        if (index > -1) 
        {
            this.data.splice(index, 1);
            return 1;
        }
        else return "data not found";
    },
    Dequeue:function()
    {
        return this.data.shift();
    },
    Display:function()
    {
        for (i=0;i<this.data.length;++i)
        document.writeln(this.data[i]+"<br>");
    },
    

}

// linkedlist.Enqueue(5);
// linkedlist.Enqueue(30);
// linkedlist.Insert(27);
// linkedlist.Display();
// linkedlist.Pop(); //30
// linkedlist.Dequeue(); //5

