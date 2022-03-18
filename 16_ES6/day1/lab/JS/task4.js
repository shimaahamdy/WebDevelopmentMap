/*4) Create your own function that accepts an object with multiple 
parameters to generate course information and display it. 
assume course information must contains courseName,
courseDuation, courseOwner only and fire exception when user 
pass properties other that those mentioned above.*/
var displayCourse = function (optCourse={}){
    var defCourse = {courseName:"name",courseDuation:"duration", courseOwner:"owner"};

    var coure = Object.assign({},defCourse,optCourse)

  for(i in coure)
  {
      if(i === 'courseName' || i=== 'courseDuation' || i=== 'courseOwner')
      continue;
      else throw "wrong peoperty";
  }
 
  console.log(`CrsName: ${coure.courseName}, CrsDur: ${coure.courseDuation}, CrsOwner: ${coure.courseOwner}`);
}

var obj = {
    courseName:"ES-6",
    courseDuation:"3 days",
     //courseOwner:"ITI",
     //time:"25/5"
    }

displayCourse(obj);