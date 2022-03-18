var Bicycle = function(_speed,_color){

    //inhitrance (constructor chain) create object from vehicle
    Vehicle.call(this,_speed,_color);
    var sizeOfEngines;
    var licPlate;
    var ring=false;

    Object.defineProperty(this,"ringBell",{
        value: function()
        {
            ring=true;
        }
    }); 

}
//take copy from vehicle prototype 
Bicycle.prototype=Object.create(Vehicle.prototype); //Parasetic Ihirtance
Bicycle.prototype.constructor=Bicycle;

Bicycle.prototype.toString=function(){
    return "Bicycle(color: "+this.getColor();
}
