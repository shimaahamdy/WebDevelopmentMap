import { Component } from "@angular/core";

@Component({
  selector:"app-first",
  templateUrl:"./first.component.html",
  styleUrls:["./first.component.css"]
})
export class FirstComponent{
  name="Ola";
  imgSrc = "assets/Images/2.jpg";

  firstName = "";
  lastName = "";

  chgName(){
    this.name = "Ahmed";
    this.firstName = "Ragab";
    this.imgSrc = "assets/Images/3.jpg";
  }

  getFirstName(data:any){
    // console.log(data.target.value);
    this.firstName = data.target.value
  }

}
