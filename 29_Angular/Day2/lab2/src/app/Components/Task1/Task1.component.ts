import { Component } from "@angular/core";

@Component({
  selector:"app-Task1",
  templateUrl:"./Task1.component.html",
  styleUrls:["./Task1.component.css"]
})
export class Task1Component{
  name="Mona";
  
  getFirstName(data:any){
    
    this.name = data.target.value
  }

  Reset()
  {
    this.name="";
  }

}
