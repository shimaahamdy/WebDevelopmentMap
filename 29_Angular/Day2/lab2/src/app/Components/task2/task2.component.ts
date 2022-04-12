import { Component, OnInit } from '@angular/core';



@Component({
  selector: 'app-task2',
  templateUrl: './task2.component.html',
  styleUrls: ['./task2.component.css']
})


export class Task2Component  {
  Src = "assets/Images/1.jpg";
  private counter = 0;
  private myTimeout:any;

  Next()
  {
    if(this.counter<4)
    {
      console.log(this.counter)
      this.counter=this.counter+1;
      this.Src = "assets/Images/"+this.counter+".jpg";
      
    }
  }
  Prev()
  {
    if(this.counter>1)
    {
      this.counter--;
      this.Src = "assets/Images/"+this.counter+".jpg";
    }
  }
  SlideShow()
  {
    
    this.myTimeout = setInterval(()=>{
      if(this.counter==4)
      this.counter=0;
      this.Next()
    } , 500);
   

      
    
  }


  Pause()
  {
    clearInterval(this.myTimeout);
  }

}
