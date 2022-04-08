function validateEmail(email){

    if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email))
    {
      return (true)
    }
      
      return (false)
}

function validateForm() {
    let firstname = document.forms["profileForm"]["firstname"].value;
    let lastname = document.forms["profileForm"]["lastname"].value;
    let Mobile = document.forms["profileForm"]["Mobile"].value;
    let Email = document.forms["profileForm"]["emal"].value;
    
    if (firstname == "") 
    {
      document.getElementById("nameVal").textContent = "FirstName is required";
      return false;
    }

    
    if(lastname == "")
    {
      document.getElementById("lnameVal").textContent = "LastName is required";
      return false;
    }
  
    
    if(Mobile == "")
    {
    document.getElementById("mobVal").textContent = "Mobile is required";
    return false;
    }

    if(validateEmail(Email)==false)
    {
    document.getElementById("mailVal").textContent = "Not Vaild Email Format";
    return false;
    }
      
    return true;
    
  }

function loadDoc() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
        document.getElementById("demo").innerHTML = this.responseText.replace("%40","@");
      }
    };
    xhttp.open("GET", "Profiles.json", true);
    xhttp.send();
  }

  