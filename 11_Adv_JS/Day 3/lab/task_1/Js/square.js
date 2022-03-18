var Square = function(_length){

    Square.squareObjectsCount++;
    if(Square.squareObjectsCount>=2)
    throw "can not create more than one object from square";
    //inhitrance (constructor chain) create object from shape(parent)
    Shape.call(this,_length,_length);





    //override rectangel functions
    Object.defineProperty(this,"setWidth",{
        value: function(_l)
        {
            Shape.prototype.setWidth.call(this,_l);
        }

    });
  


   
}
//take copy from shape prototype to rectangle prototype
Square.prototype=Object.create(Rectangle.prototype); //Parasetic Ihirtance
Square.prototype.constructor=Square;

Square.squareObjectsCount=0;


