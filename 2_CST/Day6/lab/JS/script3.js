var max=9;
var min=1;
var arr_img=[];
var clicked1=false;
var clicked2=false;
var img1,img2;
var imgs = document.getElementsByTagName("img");
function start()
{
    
    var arr=[0,0,0,0,0,0,0,0,0];
    for(var i=0;i<16;++i)
    {
        var rand_num = Math.floor(Math.random() * (max - min) ) + min;
        while(arr[rand_num]==2)
        {
            rand_num = Math.floor(Math.random() * (max - min) ) + min;
        }
        arr[rand_num]++;
        console.log(arr);
        imgs[i].src="../Images/memory_game/"+rand_num+".jpg";
        arr_img[i]=rand_num;
        console.log(arr_img);
    }
    setTimeout(hide,3000);
}

function hide()
{
    for(var i=0;i<16;++i)imgs[i].src="../Images/memory_game/9.jpg";
}

function catch_img(img_num)
{
    if(!clicked1)
    {
        clicked1=true;
        img1=img_num;
        
    }
    else
    {
        clicked2=true;
        img2=img_num;
        if(arr_img[img2]==arr_img[img1])
        {
            imgs[img2].src="../Images/memory_game/"+arr_img[img1]+".jpg";
            imgs[img1].src="../Images/memory_game/"+arr_img[img1]+".jpg";
            console.log(imgs[img1].src)
        }
        else 
        {
            imgs[img2].src="../Images/memory_game/"+arr_img[img1]+".jpg";
            imgs[img1].src="../Images/memory_game/"+arr_img[img1]+".jpg";
            imgs[img1].src="../Images/memory_game/9.jpg";
            imgs[img2].src="../Images/memory_game/9.jpg"
            
        }
        clicked1=false;
        clicked2=false;
        
    }
    console.log(img_num);
}
