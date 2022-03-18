/*              task2                                */
var curr_img = document.getElementById("imgs");
var curr_img_num=1;
var flag=true;
function next_pic()
{
      
      if(curr_img_num<6)
      {
            curr_img_num++;
            curr_img.src="../Images/SlideShow/"+curr_img_num+".jpg";
      }
}
function prvious_pic()
{
      if(curr_img_num>1)
      {
            --curr_img_num;
            curr_img.src="../Images/SlideShow/"+curr_img_num+".jpg";
      }
}
var stop;
function slide_show()
{
      stop = setInterval(slide,1000)
      
}
function slide()
{
      curr_img_num++;
      if(curr_img_num==7)curr_img_num=1;
      next_pic(); 
}
function stop_show()
{
      clearInterval(stop);
}