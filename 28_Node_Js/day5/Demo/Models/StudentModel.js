// var Students = [];

// var Students = require("../Data/Students.json");

var fs = require("fs");
var path = require("path");

var id = 0;


// var SaveStudent = (student)=>{
//     student.id = ++id;
//     Students.push(student);
//     return student;
// }

// var GetStudnets = ()=>{
//     return Students;
// }

// var GetStudentByID = (id)=>{
//     return Students[id-1]
// }

// var UpdateStudent = (StudentID,updatedStudnet)=>{
//     updatedStudnet.id = StudentID;
//     Students[StudentID-1] = updatedStudnet;
// }

// module.exports = {SaveStudent, GetStudnets, GetStudentByID, UpdateStudent}


class Student{
    constructor(name, dept){
        this.name = name;
        this.dept = dept;
    }
    saveStudent(){
        this.id = ++id;
        var Students = JSON.parse(fs.readFileSync(path.join(__dirname,"/../Data/Students.json")).toString());
        Students.push(this);
        fs.writeFileSync(path.join(__dirname,"/../Data/Students.json"),JSON.stringify(Students));
        return this;
    }
    static GetAllStudent(){
        var Students = JSON.parse(fs.readFileSync(path.join(__dirname,"/../Data/Students.json")).toString());
        return Students;
    }
}


// var s = new Student(req.body.name, req.body.dept);
// s.saveStudent();
// Student.GetAllStudent();

module.exports = Student;
