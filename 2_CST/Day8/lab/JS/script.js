/**
 * task1
 */
document.onkeypress = function(event)
{
      alert("key: "+event.key+"     "+"asci code: "+event.keyCode);
}
document.onkeydown = function(event)
{
      if(event.altKey)alert("key: "+event.key);
      else if(event.ctrlKey)alert("key: "+event.key);
      else if(event.shiftKey)alert("key: "+event.key);
}





