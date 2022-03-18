var Obj1 = {
    var v1;
  
    this.getv1 = function()
    {
        return v1;
    }
  };
  
var o1  = Object.create(Obj1);
  
  me.name = 'Matthew'; // "name" is a property set on "me", but not on "person"
  me.isHuman = true; // inherited properties can be overwritten
  
  me.printIntroduction();
  // expected output: "My name is Matthew. Am I human? true"