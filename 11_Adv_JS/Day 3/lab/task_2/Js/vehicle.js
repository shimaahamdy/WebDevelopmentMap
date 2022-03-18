var Vehicle = function(_speed=0,_color=0)
{
    //abstract class
    //f(this.constructor==Shape)
    //throw "can not create object from Shape (abstract class)";
    
    //private members
    var speed;
    var color;
    var wheel=0;

    //private function
    //have to be before code as it wont call later to create closure
    var checkVaildInput = function(_speed,_color)
    {
        if(typeof(_speed)=='number' && typeof(_color)=='number')
        return true;
        
        else return false;
    }; 

    if(checkVaildInput(_speed,_color))
    {
       speed=_speed;
       color=_color;
    }
    else throw "not vaild input";

    //define properties with data descriptor  
    Object.defineProperty(this,"getColor",{
        value: function()
        {
            return color;
        }
    });
    Object.defineProperty(this,"getSpeed",{
        value: function()
        {
            return speed;
        }
    });    
    Object.defineProperty(this,"turnLeft",{
        value: function()
        {
            wheel--;
        }
    });
    Object.defineProperty(this,"turnRight",{
        value: function()
        {
            wheel++;
        }
    });
    Object.defineProperty(this,"star",{
        value: function()
        {
            return speed!=0;
        }
    });
    Object.defineProperty(this,"stop",{
        value: function()
        {
            return speed==0;
        }
    });
    Object.defineProperty(this,"goForward",{
        value: function(_speed,_acc)
        {
            if(checkVaildInput(_speed,_acc))
            speed=_speed+_acc;
            else throw "not vaild input";
        }
    });       
    Object.defineProperty(this,"goBackward",{
        value: function(_speed,_acc)
        {
            if(checkVaildInput(_speed,_acc))
            speed=_speed-_acc;
            else throw "not vaild input";
        }

    });   

}

Vehicle.prototype.toString=function(){
    return "vehicle(color: "+this.getColor()+")";
}
Vehicle.prototype.valueOf=function(){
    return this.getSpeed();
}