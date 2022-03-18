var DumpTruck = function(_speed,_color,_size,_licPlate,_capcity=0,_wheels=0,_weight=0){

    //inhitrance (constructor chain) create object from vehicle
    MotorVehicle.call(this,_speed,_color,_size,_licPlate);
    var wheels;
    var capcity;
    var weight;

    
    var checkVaildInput = function(_capcity,_wheels,_weight)
    {
        if(typeof(_capcity)=='number' && typeof(_wheels)=='number' && typeof(_weight)=='number')
        {
            return true;
        }
        else return false;
    } 

    if(checkVaildInput(_capcity,_wheels,_weight))
    {
        wheels=_wheels;
        capcity=_capcity;
        weight=_weight;
    }
    else throw "not vaild input";

    Object.defineProperty(this,"lowerLoad",{
        value: function()
        {
            capcity-=10;
        }
    }); 
    Object.defineProperty(this,"rasieLoad",{
        value: function()
        {
            capcity+=10;
        }
    });
    

    
}
//take copy from car prototype 
DumpTruck.prototype=Object.create(MotorVehicle.prototype); //Parasetic Ihirtance
DumpTruck.prototype.constructor=DumpTruck;

DumpTruck.prototype.toString=function(){
    return "DumpTruck(color: "+this.getColor()+") sizeofengines: "+this.getSizeOfEngines()
    +"licplate: "+this.getLicPlate();
}
