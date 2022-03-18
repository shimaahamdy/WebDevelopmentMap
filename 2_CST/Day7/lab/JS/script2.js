setTimeout(change,2000);
function change()
{
    var div1 = document.documentElement.lastChild.firstElementChild.firstElementChild;
    var div2 = div1.cloneNode(true);

    var center_div = document.documentElement.lastChild.firstElementChild;
    center_div.appendChild(div2);
    div1.classList.add("div1");
    div2.classList.add("div2"); 
    var u_list = document.documentElement.lastChild.firstElementChild.lastElementChild.previousElementSibling.firstElementChild;
    u_list.classList.add("item_cir");
}