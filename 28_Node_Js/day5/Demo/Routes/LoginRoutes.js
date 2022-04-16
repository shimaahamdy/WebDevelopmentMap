//Registration

const express = require("express");
const router = new express.Router();
const bcrypt = require("bcrypt");
const jwt = require("jsonwebtoken");

const userModel = require("../Models/usersModel");///Email, Pass [NameXXX]

const LoginValid = require("../Utils/loginValid");

var id = 0;

//Post ===> Body
router.post("/",async(req,res)=>{
    try{

        //Check Email
        var user = await userModel.findOne({email:req.body.email}).exec();
        if(!user) return res.status(400).send("Invalid email or Password")
   //Check Pass
   var checkpass = await bcrypt.compare(req.body.password, user.password);
   if(!checkpass) return res.status(400).send("Invalid email or Password")

   
   //Login==>res
   var Token = await jwt.sign({UserId:user._id, adminRole:user.isAdmin},"thisistokensecret");
   res.header("x-auth-token",Token)
    res.status(200).send("Logged-In Successfully")

}catch(err){
    res.status(400).send("Bad Request")
}
    
})


module.exports = router;

