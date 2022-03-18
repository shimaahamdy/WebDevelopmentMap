/* 3) Promise
1 Create your function that takes url of required service to be 
consumed and return a promise.
2 Make ajax request using your function to consume the 
service of the following link 
“https://jsonplaceholder.typicode.com/users”
3 Display its output in a table style your website via 
bootstrap
*/
var getData = function(requistUrl)
{
    
    const xhttp = new XMLHttpRequest();
  
    xhttp.open("GET", requistUrl,false);
    xhttp.send();
    myPromise = new Promise(function(resolve, reject){
    
     if(xhttp.responseText){
        resolve(xhttp.responseText);//Fire Success======>.then(()=>{})
     }else{    
        reject("Error data is not available");//Fire Error===========>.catch(()=>{})
     }

    
 });
    return myPromise;
  
}
p1 = getData("https://jsonplaceholder.typicode.com/users");
 p1.then((data)=>{
    var table = document.getElementById("table");
    var obj = JSON.parse(data);
    var rowcount=1;
    
    for(i of obj)
    {
        //console.log(i);
        var row = table.insertRow(rowcount++);
        var cellcount=0;
        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.id;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.name;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.phone;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.username;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.website;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.company.name;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.company.catchPhrase;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.company.bs;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.address.zipcode;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.address.city;
            
        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.address.street;

        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.address.suite;



        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.address.geo.lat;

                
        cell = row.insertCell(cellcount++);
        cell.innerHTML = i.address.geo.lng;
           
        
    

    }
 })
           .catch((err)=>{console.log(err)})
