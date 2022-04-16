const PostValid = require("../Utils/PostValidate");
const PostModel = require("../Models/PostModel");



var AddPost = async (req,res)=>{
    try{
        var Post = new PostModel(
            {
                content:req.body.content,
                userID:req.body.userID
            }
        )
        var Valid = PostValid(Post);
        if(Valid)
        {
            await Post.save();
            res.status(201).send("Post addedd Successfully");
        }
        else res.status(400).send("Not vaild");
    }
    catch(err){
        console.log(err);
    }
}


var GetAllPosts = async(req,res)=>{
    
    let Posts = await PostModel.find().exec();
    res.send(Posts);
}

var GetUserPosts = async(req,res)=>{
    var ID = req.params.id;
    res.json( await PostModel.findOne({userID:ID}).exec());
}

var UpdatePost = async(req,res)=>{
    await PostModel.findByIdAndUpdate(req.params.id, req.body);
    res.json("Updated Successfully");
}


var DeletePost = async(req,res)=>{
    await PostModel.findByIdAndDelete(req.params.id);
    res.send("Deleted Successfully")
}



module.exports = {DeletePost, UpdatePost,GetUserPosts,GetAllPosts,AddPost};