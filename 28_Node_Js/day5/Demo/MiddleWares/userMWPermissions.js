var jwt = require("jsonwebtoken");

module.exports = (req,res,next)=>{
    var Token = req.header("x-auth-token");
    if(!Token) return res.status(400).send("Access Denied...");
    try{
        var decodePayload = jwt.verify(Token,"thisistokensecret");
        // console.log(decodePayload)
        if(decodePayload.adminRole){
            next();//isAdmin
        }else{
            return res.status(400).send("Access Denied...")
        }
    }catch(err){
        res.status(400).send("Invalid Token")
    }
    //else res.send
}