var page_x=1;
var page_y=1;
function movewin()
{
      var page = window.open("","","width=200,height=200");
      var x=8;
     while(x--)
     { page_x=1;
      page_y=1
           console.log(page_x,page_y);      
      move_down(page);
            console.log(page_x,page_y);
            move_up(page,page_x,page_y);
            console.log(page_x,page_y);
     }
      
}

function move_down(page)
{
      var flag_stop=true;
      var width_screen=screen.width;
      var height_screen=screen.height;
      while(flag_stop)
      {
            if((page_x)<width_screen || (page_y)<=height_screen)
                 {page.moveBy(2,1);
                  page_x++;
                  page_y++;
                  page.focus();
                  console.log(page_x+" "+page_y+"width:"+width_screen+" height"+height_screen);
                  
                 }
                 else flag_stop=false;
            
                  
      }
}
function move_up(page,page_x,page_y)
{
      var flag_stop=true;
      while(flag_stop)
      {
            if((page_x)>=0 || (page_y)>=0)
                 {page.moveBy(-2,-1);
                  page_x--;
                  page_y--;
                  page.focus();
                  console.log(page_x+" "+page_y);
                  
                 }
                 else flag_stop=false;
            
                  
      }  
}

function scrollwin()
{
      var content="test test test test test test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test tv test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test test test test test test test testtest test test test";
      var content2="test test test test test test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test tv test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test ttest test test test  test test test test test test test test test test test testtest test test test";

      var page = window.open("scrollpage.html","","width=200,height=100");
      page.document.write(content);
      page.document.write(content2);
      setInterval(scroll_page,100,page);

     
}

function scroll_page(page)
{
      page.scrollBy(5,5);
}
var index=0;
var stop;
function write_window()
{
      var content="hello";
      var page = window.open("","","width=300,height=200");
      stop = setInterval(write,400,page,content);
      
}
function write(page,content)
{
      page.document.write(content[index++]);
      if(index>=content.length)clearInterval(stop);

}

function submitform()
{
       var name = document.getElementById("form1")[0].value;
       var last_name = document.getElementById("form1")[1].value;
      document.writeln("your name:"+name+"<br>");
      document.writeln("your last name"+last_name);

}
