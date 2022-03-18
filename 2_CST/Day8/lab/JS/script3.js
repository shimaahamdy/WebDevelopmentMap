/**
 * task3
 */

function confirmation()
{
     var confirm_submit = confirm("you sure");
     var form1 = document.getElementById("form1");
     if(!confirm_submit)
     {
         rmove_date(form1);
         return false; 
     }

}

function rmove_date(form1)
{
    var elments_num = form1.length-1;
    for(var i=0;i<elments_num;++i)
    {
        form1[i].value = "";
    }
}

var data_Event = new Event("data");

document.addEventListener("data",function(){
    alert("pleaze fill the fields to submit");
});

setTimeout(check_data,30000);

function check_data()
{
    var form1 = document.getElementById("form1");
    var elments_num = form1.length-1;
    var counter = 0;
    for(var i=0;i<elments_num;++i)
    {
        if(form1[i].value=="")
        {
            counter++;
        }
    }
    if(counter==3)document.dispatchEvent(data_Event);
}



 