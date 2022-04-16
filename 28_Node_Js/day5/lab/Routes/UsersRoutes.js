const express = require("express");
const router  = new express.Router();
const UsersController = require("../Controllers/UsersController");

//getUSers
router.get("/",UsersController.GetUSers)

//Get user by id
router.get("/:id", UsersController.GetUser)

//Create New User
router.post("/", UsersController.AddUser)

//Update USer
router.put("/:id", UsersController.UpdateUser)

//Delete USer
router.delete("/:id", UsersController.DeleteUSer)
//#endregion

module.exports = router;




