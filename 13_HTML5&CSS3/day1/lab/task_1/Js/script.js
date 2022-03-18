
var formatTime = function (time) {

    Math.floor(100*time)/100; //1.64
    //get Minutes
    var minutes = Math.floor(time / 60); //1
    //get seconds
    var seconds = Math.round(time - (minutes * 60));
  
    if (minutes < 10) { minutes = "0" + minutes }
    if (seconds < 10) { seconds = "0" + seconds }
  
    return minutes + ":" + seconds + "s"
    
 
};

var vid = document.getElementById("vid1"); 
var slider_vid = document.getElementById("slider-vid1");

var current = document.getElementById("current");
var duration = document.getElementById("duration");
var playPauseButton = document.getElementById("play-paused");
var slider_vid1_sound = document.getElementById("slider-vid1-sound");
var slider_vid1_speed = document.getElementById("slider-vid1-speed");

function playPause() 
{ 
    if (vid.paused)
    {
        vid.play();
        playPauseButton.innerText = "pause";
        
    } 
    else 
    {
        vid.pause();
        playPauseButton.innerText = "play";
    }
       
} 

function stop()
{
    vid.pause();
}

function start()
{
    vid.currentTime=0;
    vid.play();
}
function goForward()
{
    vid.currentTime-=3;
}
function goBackward()
{
    vid.currentTime+=3;
}
function end()
{
    vid.currentTime=vid.duration;
}
function changeSound()
{
    vid.volume=parseFloat(slider_vid1_sound.value); 
}
function mute()
{
    slider_vid1_sound.value=0;
    changeSound();
}
function changeSpeed()
{
    vid.playbackRate=slider_vid1_speed.value;
}

vid.onloadeddata = function()
{

    slider_vid.setAttribute("max",vid.duration);
    duration.innerText = formatTime(vid.duration);
    vid.volume=parseFloat(slider_vid1_sound.value);
        
}
vid.addEventListener("timeupdate",function(){
    slider_vid.value=vid.currentTime;
    current.innerText = formatTime(vid.currentTime);
})

function changeSliderPositon()
{
    vid.currentTime=slider_vid.value;
}






