var helper=
{
    id:"SD-10",
    location:"SV",
    addr:"123 st",
    getSetGen:function()
    {
        var properties = Object.keys(this);
        var len = properties.length;
        for(var i=0;i<len;++i)
        {
            if(typeof(this[properties[i]])=="function")continue;
            this["get"+properties[i]]=(function(obj,i)
            {
                return function()
                {
                    return obj[properties[i]];
                }
            })(this,i);

            this["set"+properties[i]]=(function(obj,i)
            {
                return function(value)
                {
                     obj[properties[i]]=value;
                }
            })(this,i);
        }
    }
}

  
var user =
{
    name:"Ali",
    age:10
}