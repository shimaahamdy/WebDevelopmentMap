//AJV
const Ajv = require("ajv").default;
var ajv = new Ajv();
userSchema = {
    "type":"object",
    "properties":{
        "email":{"type":"string","pattern":"^[a-zA-Z0-9]+\@{1}[a-zA-Z0-9]+(.com){1}$"},
        "password":{"type":"string","minLength":5}
    },
    "required":["email","password"]
}


module.exports = ajv.compile(userSchema);

