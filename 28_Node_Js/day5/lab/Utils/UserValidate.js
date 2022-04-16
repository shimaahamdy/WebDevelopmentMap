const Ajv = require("ajv").default;
var ajv = new Ajv();

userSchema = {
    "type": "object",
    "properties": {
        "_id": {"type":"number"},
        "name": {"type": "string"},
        "email": {"type": "string", "pattern":"^[a-zA-Z0-9]+\@{1}[a-zA-Z0-9]+(.com){1}$"},
        "password": {"type":"string"}
  },
  "required": ["_id","name","email","password"],
  
}

module.exports = ajv.compile(userSchema);
