const express = require("express");
const router  = new express.Router();
const PostsController = require("../Controllers/PostsController");

//getPosts
router.get("/",PostsController.GetAllPosts)

//Get user by id
router.get("/:id", PostsController.GetUserPosts)

//Create New User
router.post("/", PostsController.AddPost)

//Update USer
router.put("/:id", PostsController.UpdatePost)

//Delete USer
router.delete("/:id", PostsController.DeletePost)
//#endregion

module.exports = router;




