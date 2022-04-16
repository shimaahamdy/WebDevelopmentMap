const express = require("express");
const router = new express.Router();
const studentsControllers = require("../Controllers/StudentController");
const userPermissions = require("../MiddleWares/userMWPermissions");
//#region  For Students
//Get All Students
router.get("/", userPermissions,studentsControllers.GetAllStudents)
//Get Student By ID
router.get("/:id", userPermissions,studentsControllers.GetStudentByID)
//Create New Student
router.post("/", userPermissions,studentsControllers.AddNewStudent)
//Update Student
router.put("/:id", userPermissions,studentsControllers.UpdateStudent)
//Delete Student
router.delete("/:id", userPermissions,studentsControllers.DeleteStudentByID)
//#endregion

module.exports = router;
