var MotorVehicle = function(_speed,_color,_size=0,_licPlate="nan"){

    //inhitrance (constructor chain) create object from vehicle
    Vehicle.call(this,_speed,_color);
    var sizeOfEngines;
    var licPlate;

    var checkVaildInput = function(_size,_licPlate)
    {
        if(typeof(_size)=='number' && typeof(_licPlate)=='string')
        return true;
        
        else return false;
    } 

    if(checkVaildInput(_size,_licPlate))
    {
        sizeOfEngines=_size;
        licPlate=_licPlate;
    }
    else throw "not vaild input";

    Object.defineProperty(this,"getSizeOfEngines",{
        value: function()
        {
            return sizeOfEngines;
        }
    }); 
    Object.defineProperty(this,"getLicPlate",{
        value: function()
        {
            return licPlate;
        }
    });
    
    
}
//take copy from vehicle prototype 
MotorVehicle.prototype=Object.create(Vehicle.prototype); //Parasetic Ihirtance
MotorVehicle.prototype.constructor=MotorVehicle;

MotorVehicle.prototype.toString=function(){
    return "MotorVehicle(color: "+this.getColor()+") sizeofengines: "+this.getSizeOfEngines()
    +"licplate: "+this.getLicPlate();
}
