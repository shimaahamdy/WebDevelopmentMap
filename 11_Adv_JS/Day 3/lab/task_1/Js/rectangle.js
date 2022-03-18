var Rectangle = function(_width,_height){

    Rectangle.recObjectsCount++;
    if(Rectangle.recObjectsCount>=2)
    throw "can not create more than one object from rectangle";
    //inhitrance (constructor chain) create object from shape(parent)
    Shape.call(this,_width,_height);
    
}
//take copy from shape prototype to rectangle prototype
Rectangle.prototype=Object.create(Shape.prototype); //Parasetic Ihirtance
Rectangle.prototype.constructor=Rectangle;

Rectangle.recObjectsCount=0;