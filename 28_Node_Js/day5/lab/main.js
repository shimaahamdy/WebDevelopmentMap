//require express
const express = require("express");
const app = express();
const PORT = process.env.PORT||7400;
const bodyparser = require("body-parser");
app.use(bodyparser.urlencoded({extended:true}));
app.use(bodyparser.json());


//====================For Regestration===================
const UserRoutes = require("./Routes/UsersRoutes");
app.use("/api/users",UserRoutes)


//------------------------- Posts -----------------------------
const PostRoutes = require("./Routes/PostRoutes");
app.use("/api/Posts",PostRoutes)

app.use(express.json());
app.listen(PORT, ()=>{console.log("http://localhost:"+PORT)})


