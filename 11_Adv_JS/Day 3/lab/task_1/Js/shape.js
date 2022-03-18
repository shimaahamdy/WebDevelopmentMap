var Shape = function(_w,_h)
{
    //abstract class
    if(this.constructor==Shape)
    throw "can not create object from Shape (abstract class)";
    
    //check vaild input
    if(typeof(_w)=='number' && typeof(_h)=='number')
    {
        this.width=_w;
        this.height=_h;
    }
    else throw "not vaild input";

    //data descriptor
    Object.defineProperty(this,"width",{
        value:_w
        
    });
    Object.defineProperty(this,"height",{
        value: _h
        
    });
    
    
    
    //fucntion can not be overrdie
    Object.defineProperty(this,"calcArea",{
        value: function()
        {
            return area();
        }
        
    });
    Object.defineProperty(this,"calcPerimeter",{
        value: function()
        {
            return perimeter();
        }
        
    });
    Object.defineProperty(this,"displayInfo",{
        value: function()
        {
            return "width: "+this.width+"height: "+this.height+"area: "+area()+"perimeter: "+perimeter();
        }
        
    });

    //private functions
    //hard bind
    var area = function()
    {
        return this.width*this.height;
    }.bind(this);

    var perimeter = function()
    {
        return 2*(this.width+this.height);
    }.bind(this);
    
    

}
 
Shape.prototype.toString=function(){
    return "width: "+this.width+" height: "+this.height;
}
Shape.prototype.valueOf=function(){
    return this.calcArea();
    
}