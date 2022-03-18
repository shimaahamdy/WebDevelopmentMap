var forward_p1 = true;  
var forward_p2 = false;
var forward_p3 = true;
var stop;
var player1 = document.getElementById("player1");
var player2 = document.getElementById("player2");
var player3 = document.getElementById("player3");
function start()
{
    stop = setInterval(move,100);     
}

function reset()
{
    clearInterval(stop);
    player1.style.left="0px";
    player2.style.left="800px";
    player3.style.top="448px";

}

function move()
{
    var pos_1 = player_pos(player1);
    if(pos_1<=10)forward_p1=true;
    if(pos_1>=850) forward_p1=false;
    mov_player(player1,forward_p1);

    var pos_2 = player_pos(player2);
    if(pos_2<=-50)forward_p2=true;
    if(pos_2>=800) forward_p2=false;
    mov_player(player2,forward_p2); 

    var pos_3 = parseInt(getComputedStyle(player3).top);
    if(pos_3<=0)forward_p3=false;
    if(pos_3>=430)forward_p3=true;
    mov_player_top(player3,forward_p3);
}


function mov_player(player,dir)
{
    if(dir)move_left(player);
    else move_right(player);
}

function mov_player_top(player,dir)
{
    if(dir)move_up(player);
    else move_down(player);
}


function player_pos(player)
{
    var left = parseInt(getComputedStyle(player).left);
    return left;
}


function move_left(player)
{
    var left = parseInt(getComputedStyle(player).left);
    player.style.left = left + 10 + "px";
}
function move_right(player){
    var left = parseInt(getComputedStyle(player).left);
    player.style.left = left - 10 + "px";
}

function move_up(player)
{
    var up = parseInt(getComputedStyle(player).top);
    player.style.top = up - 10 + "px";
}
function move_down(player){
    var up = parseInt(getComputedStyle(player).top);
    player.style.top = up + 10 + "px";
}