const mongoose = require("mongoose");
var valid = require("validator");

var DB_URL = "mongodb://localhost:27017/Users"

mongoose.connect(DB_URL, {useNewUrlParser:true});

var userSchema = new mongoose.Schema({
    name:{type:String, required:true, minlength:3, maxlength:50},
    email:{
        type:String,
        required:true, 
        validate:{
            validator:(val)=>{return valid.isEmail(val)},
            message:"{Email} Not Valid"
        }
    },
    password:{type:String,minlength:5,required:true},
    isAdmin:{type:Boolean}
})


module.exports = mongoose.model("Users",userSchema);