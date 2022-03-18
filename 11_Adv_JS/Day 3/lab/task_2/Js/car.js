var Car = function(_speed,_color,_size,_licPlate,_wheels=0,_doors=0,_weight=0){

    //inhitrance (constructor chain) create object from vehicle
    MotorVehicle.call(this,_speed,_color,_size,_licPlate);
    var wheels;
    var doors;
    var weight;
    var aricon=false;

    var checkVaildInput = function(_wheels,_doors,_weight)
    {
        if(typeof(_wheels)=='number' && typeof(_doors)=='number' && typeof(_weight)=='number')
        {
            return true;
        }
        else return false;
    } 
    


    if(checkVaildInput(_wheels,_doors,_weight))
    {
        wheels=_wheels;
        doors=_doors;
        weight=_weight;
    }
    else throw "not vaild input";

    Object.defineProperty(this,"switchOnAircon",{
        value: function()
        {
            aricon=true;
        }
    }); 
    Object.defineProperty(this,"getDoors",{
        value: function()
        {
            return doors;
        }
    });
}   
//take copy from car prototype 
Car.prototype=Object.create(MotorVehicle.prototype); //Parasetic Ihirtance
Car.prototype.constructor=Car;

Car.prototype.toString=function(){
    return "car(color: "+this.getColor()+") sizeofengines: "+this.getSizeOfEngines()
    +"licplate: "+this.getLicPlate()+" doors: "+this.getDoors();
}
