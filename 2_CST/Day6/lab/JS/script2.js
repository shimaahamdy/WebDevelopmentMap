/*     task3              */

var img_num=0;
var img_coll=document.getElementsByTagName("img");
var stop = setInterval(change_pic,500);

function change_pic()
{
      img_num++;
      if(img_num==img_coll.length)img_num=0;
      if(img_num>0)img_coll[img_num-1].src="../Images/marbels/marble1.jpg";
      if(img_num==0)img_coll[img_coll.length-1].src="../Images/marbels/marble1.jpg";
      img_coll[img_num].src="../Images/marbels/marble3.jpg";
}

function fix_pic()
{
    clearInterval(stop);
}

function return_pic()
{
    stop = setInterval(change_pic,500);
}