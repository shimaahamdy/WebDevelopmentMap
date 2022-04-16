const UserValid = require("../Utils/UserValidate");
const UserModel = require("../Models/UserModel");
const bcrypt = require('bcrypt');


var AddUser = async (req,res)=>{
    
    try{
        
        //check if user already exist
        let userf = await UserModel.findOne({email:req.body.email}).exec();
        if(userf)
            return res.status(400).send("User Already Exist");

        let salt = await bcrypt.genSalt(10);
        let hashedPassword = await bcrypt.hash(req.body.password,salt);

        var user = new UserModel(
            {
                _id:req.body._id,
                name:req.body.name,
                email:req.body.email,
                password:hashedPassword
            }
        )
        var Valid = UserValid(user);
        if(Valid)
        {
            await user.save();
            res.status(201).send("User addedd Successfully");
        }
        else res.status(400).send("Not vaild");
    }
    catch(err){
        console.log(err);
    }
}


var GetUSers = async(req,res)=>{
    
    let Users = await UserModel.find({email:req.body.email}).exec();
    res.send(Users);
}

var GetUser = async(req,res)=>{
    var UserID = req.params.id;
    res.json( await UserModel.findOne({_id:UserID}).exec());
}

var UpdateUser = async(req,res)=>{
    await UserModel.findOneAndUpdate({_id:req.params.id}, req.body);
    res.json("Updated Successfully");
}


var DeleteUSer = async(req,res)=>{
    await UserModel.findByIdAndDelete(req.params.id);
    res.send("Deleted Successfully")
}



module.exports = {AddUser ,GetUSers, GetUser, UpdateUser, DeleteUSer};