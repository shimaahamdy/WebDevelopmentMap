/* task1*/
/*
mess = prompt("enter your text");
for(var i=1;i<=6;++i)
{
document.write("<h"+i+">"+ mess +"<h"+i+">");
}
*/

/*task 2*/

var sum=0;
var iterate=true;
while(iterate)
{
    var mess = prompt("enter your text");
    var num=parseInt(mess);
    if(((sum+num)>100) || !(num))iterate=false;
    else sum+=num;    

}
document.write(sum);

