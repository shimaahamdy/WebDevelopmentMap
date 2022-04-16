const express = require("express");
const router = new express.Router();


//#region For Courses
var Courses = [];
var id = 0;

//Validators
var CoursesSchema = {
    "type":"object",
    "properties":{
        "courseName":{"type":"string","pattern":"^[a-zA-Z]+$"},
        "degree":{"type":"string","enum":["F","G","VG","EX"],"minLength":1,"maxLength":2}
    },
    "required":["courseName","degree"],
    // "minProperties":2,
    // "maxProperties":2
}

//Get All Courses
router.get("/",(req,res)=>{
    res.send(Courses);
})

//Get Courses By ID
router.get("/:id",(req,res)=>{//1==>0 || 2==>1
    var CourseID = req.params.id;
    res.json(Courses[CourseID-1]);
})


//Create New Courses
router.post("/",(req,res)=>{
    var newCourse = req.body;
    newCourse.id = ++id;
    Courses.push(newCourse);
    res.json(newCourse);
})

//Update Courses
router.put("/:id",(req,res)=>{
    var updatedCourse = req.body;
    var CourseID = req.params.id;
    updatedCourse.id = CourseID;
    Courses[CourseID-1] = updatedCourse;
    res.json(updatedCourse);
})

//Delete Courses
router.delete("/:id",(req,res)=>{
    var CourseID = req.params.id;
    Courses.splice(CourseID-1,1);
    res.send("Deleted Successfully")
})
//#endregion


module.exports = router;
