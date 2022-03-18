/*1) Using ES6 new Syntax & features:
 Write a script to create different shapes (rectangle, square, 
circle, triangle) make all of them inherits from polygon.
 Display the area and each object parameter in your console 
by overriding toString()
 Draw your created shapes to a canvas element.*/
class polygon{

    constructor(dim1,dim2){
        if(this.constructor != polygon)
        {
            this.dim1 = dim1;
            this.dim2= dim2;
        }
        else throw "can not create object from polygon (abstract class)";

    }
    getArea(){
        return this.dim1 * this.dim2;
    } 
    getPerimeter(){
        return 2*(this.dim1+this.dim2);
    }  
      

    toString(){
        return `dim1: ${this.dim1}, dim1: ${this.dim2}, area= ${this.getArea()}, perimeter= ${this.getPerimeter()}`;
    }

    draw()
    {
        return "no implmentation";
    }
}

class rectangle extends polygon
{
    constructor(dim1,dim2)
    {
        super(dim1,dim2);
    }
    toString(){
       return super.toString();
    }
    draw(c)
    {
        var ctx = c.getContext("2d");
        ctx.beginPath();
        ctx.rect(10,10,this.dim1,this.dim2);
        ctx.stroke(); 
    }
    
}

class square extends polygon
{
    constructor(dim)
    {
        super(dim,dim);
    }
    toString(){
        return `dim: ${this.dim1}, area= ${this.getArea()}, perimeter= ${this.getPerimeter()}`;

     }
     draw(c)
     {
         var ctx = c.getContext("2d");
         ctx.beginPath();
         ctx.rect(80,10,this.dim1,this.dim2);
         ctx.stroke(); 
     }
}

class circle extends polygon
{
    #PI = Math.PI;
    constructor(R){
        super(R,R);
    }

    getArea(){
        return this.#PI *this.dim1*this.dim1;
    }
    getPerimeter(){
        return 2*this.#PI*this.dim1;
    }
    toString()
    {
        return `R: ${this.dim1}, area= ${this.getArea()}, perimeter= ${this.getPerimeter()}`;

    }
    draw(c)
    {
        var ctx = c.getContext("2d");
        ctx.beginPath();
        ctx.arc(100, 180, 50, 0, 2 * Math.PI);
        ctx.stroke();
    }

}
class triangle extends polygon
{
    constructor(dim1,dim2,dim3){
        super(dim1,dim2);
        this.dim3 = dim3;
    }


    getArea(){
        let a = this.dim1;
        let b = this.dim2;
        let c = this.dim3;
        let s = (a+b+c)/2;
        let area = Math.sqrt(s*(s-a)*(s-b)*(s-c));
      
        return area;
    }
    getPerimeter(){
        return this.dim1+this.dim2+this.dim3;
    }
    toString()
    {
        return `dim1: ${this.dim1}, dim2: ${this.dim2}, dim3: ${this.dim3},area= ${this.getArea()}, perimeter= ${this.getPerimeter()}`;

    }
    draw(c)
    {
        var ctx = c.getContext('2d');

        ctx.beginPath();
        ctx.moveTo(75, 300);
        ctx.lineTo(75+this.dim1, 300);
        let h = Math.sqrt(this.dim2*this.dim2-(this.dim1/2)*(this.dim1/2));
        ctx.lineTo(75+(this.dim1/2), 300+h);
        ctx.lineTo(75,300);
        ctx.stroke();
    }
}
var c = document.getElementById("myCanvas");

var rec = new rectangle(50,100);
console.log(rec.toString());
rec.draw(c);

var squ = new square(50);
console.log(squ.toString());
squ.draw(c);

var cir = new circle(100);
console.log(cir.toString());
cir.draw(c);

var tri = new triangle(80,90,30);
console.log(tri.toString());
tri.draw(c);

