/* task1 */
function check_paindrome(word)
{
var wordlen=word.length;
var flag=true;
for(var i=0,j=(wordlen-1);i<j;++i,--j)
{
      if(word[i]!=word[j])
        flag=false;

      
}
if(flag) console.log("palindrome");
else console.log("not palindrome");
}
function run_fun_1()
{
      var confirm = prompt("do you want the word to be case sentive click confirm");
      var word = prompt("enter the word to check if it is palindrome");

      if(confirm != null)check_paindrome(word);
      else 
      {
            var templete=word.toLowerCase();
            check_paindrome(templete);
      }
}

/* task 2*/
function chek_name(name)
{
      var name_reg = /^[a-zA-Z]+$/;
      return(name_reg.test(name));
}
function chek_phone(phone)
{
      var phone_reg = /^[0-9]{8}$/;
      return(phone_reg.test(phone));
}
function chek_mobile(mobile)
{
      var mobile_reg = /^(010|011|012)[0-9]{8}$/;
      return(mobile_reg.test(mobile));
}
function chek_email(email)
{
      var email_reg = /^\w+@\w+\.com$/;
      return(email_reg.test(email));
}
function run_fun_2()
{
      var name = prompt("enter your name");
      while(!chek_name(name))
      {
            name = prompt("enter your name");
      }
      var phone = prompt("enter your phone");
      while(!chek_phone(phone))
      {
            phone = prompt("enter your phone");
      }
      var mobile = prompt("enter your mobile");
      while(!chek_mobile(mobile))
      {
            mobile = prompt("enter your moible");
      }
      var email = prompt("enter your email");
      while(!chek_email(email))
      {
            email = prompt("enter your eamil");
      }

      document.write("<div><span>welcome dear guest: </span>"+name+"</div>");
      document.write("<div><span>your telphone number is: </span>"+phone+"</div>");
      document.write("<div><span>your mobile number is: </span>"+mobile+"</div>");
      document.write("<div><span>welcome eamil address: </span>"+email+"</div>");
      document.write("<div class=c>"+Date()+"</div>");

      
}

/* task 3 */
function count_char(word,letter)
{
      var word_len=word.length;
      var counter=0;
      for(var i=0;i<word_len;++i)
      {
            if(word[i]==letter)counter++;
      }
      return counter;
}
function run_fun_3()
{
      var word = prompt("enter your string");
      var letter = prompt("enter letter do you want to count");
      console.log(count_char(word,letter));

}

function run_fun_4()
{
      var arr_elments=[];
      for(var i=0;i<5;++i)
      {
            var number = prompt("enter your number");
            arr_elments.push(number);
            
      }


      
      document.write("<div><span>your array of numbers: </span>"+arr_elments+"</div>");
      document.write("<div><span>your array of numbers sorted asc: </span>"+arr_elments.sort(function(a,b){return a-b;})+"</div>");
      document.write("<div><span>your array of numbers sorted desc: </span>"+arr_elments.sort(function(a,b){return b-a;})+"</div>");

}

/* task 5*/
function run_fun_5_1()
{
      var radius = prompt("enter radius of circle");
      var circleArea = Math.PI * radius * radius;
      alert("total area of circle"+circleArea);

}
function run_fun_5_2()
{
      var number = prompt("enter number");
      number = Math.sqrt(number);
      alert("the sqroot is: "+number);
}

function run_fun_5_3()
{
      var number = prompt("what the angle you want to calc its value");
      number = Math.cos(Math.PI*(number/180)).toFixed(4);
      document.write(number);
}


/* run */

//run_fun_1();
//run_fun_2();
//run_fun_3();
//run_fun_4();
//run_fun_5_1();
//run_fun_5_2();
run_fun_5_3();