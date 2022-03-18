/* calc number of visited */
var vis_value=parseInt(get_cookie("vis"));
console.log("vis"+vis_value);
create_cookie("vis",(vis_value+1).toString(),1);

/* get gender */
var gen = get_cookie("gender");
var imeg = document.getElementById("gen");

if(gen=="2")imeg.src="../Images/gender/2.jpg";

/* get username and times */
var user = document.getElementById("username");
user.innerHTML = get_cookie("username");
var vis_times = document.getElementById("times");
vis_times.innerHTML = get_cookie("vis");

var color_val = get_cookie("color");
if(color_val=="0")
{
    user.style.color= "red";
    vis_times.style.color ="red";
}
else if(color_val=="1")
{
    user.style.color= "green";
    vis_times.style.color ="grenn";
}
else if(color_val=="2")
{
    user.style.color= "blue";
    vis_times.style.color="blue";
}