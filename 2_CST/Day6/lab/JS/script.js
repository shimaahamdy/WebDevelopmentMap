var inp = document.getElementById("txt1");
var sum;
var operation=0;   // 1 2 3 4 --->  + - * / --> 0 no operation
var new_num=true;

function writeVal(value_num)
{
      if(inp.value =="abc" || new_num)
      {
            inp.value="";
            new_num=false;
      }
      inp.value += value_num.trim();

}

function clear_input()
{
      inp.value="";
      sum=NaN;
      operation=0;
      new_num=true;
}

function del_num()
{
      inp.value = inp.value.substring(0,inp.value.length-1);
}

function calc(value)
{
      var num = parseInt(inp.value);
      console.log("num: "+num);
      if(operation==1)add_num(num);
      else if(operation==2)sup_num(num);
      else if(operation==3)multiply_num(num);
      else if(operation==4)divde_num(num);
      else if(operation==0)sum=num;

      if(value.trim()=="+")operation=1;
      else if(value.trim()=="-")operation=2;
      else if(value.trim()=="*")operation=3;
      else if(value.trim()=="/")operation=4;
      console.log("sum: "+sum);
      inp.value=sum;
      if(value.trim()=="=")result();
      new_num=true;

}

function add_num(num)
{
      sum+=num;
      
}
function sup_num(num)
{
      sum-=num;
}
function multiply_num(num)
{
      sum*=num;
}
function divde_num(num)
{
      if(num==0)
      {
            inp.value=NaN;
            sum=NaN;
      }
      else sum/=num;
     
}
function result()
{
      inp.value=sum.toString();
      sum=NaN;
      operation=0;
      new_num=true;
}



